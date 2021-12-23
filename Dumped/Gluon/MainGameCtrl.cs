using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.CharacterUniqueGimmick;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon
{
	public class MainGameCtrl : MonoBehaviour
	{
		public enum State
		{
			Loading,
			DungeonStart,
			PlayQuestStart,
			InGame,
			ToNextStage,
			Success,
			FailureInitialize,
			FailureWaitBlur,
			FailureWaitFinishMessage,
			FailureWaitCloseDialog,
			Failure,
			ObjectiveFailedInitialize,
			CheckObjectiveFailed,
			CheckTimeUp,
			TimeUp,
			TimeUpWaiting,
			BossAppear,
			FinishSlow,
			FinishSlowEnd,
			WaitDungeonRecord,
			WaitBossDrop,
			QuestEnd,
			WinInitialize,
			Win,
			WinFinalize,
			SimplicityWin,
			WaitStoryFade,
			SimplicityWinWait,
			WaitAutoAreaChange,
			PreAreaChange,
			AreaChange,
			CutScene,
			Story,
			StoryWaitOtherPlayers,
			Exit,
			WaitFailureFadeExit,
			WaitFadeResult,
			WaitTutorialUpdateStep,
			Retry,
			ContinueInit,
			ContinueWait,
			BRContinueInit,
			BRContinueWait,
			DmodeWaitingAutoAreaChange,
			DmodeWaitingNextFloorConfirm,
			DmodeSkipStart,
			DmodeWaitDungeonRecord
		}

		private enum IngameCuttStep
		{
			WaitRequest,
			Playing
		}

		private enum CheckResult
		{
			NotEnd,
			Clear,
			Failure
		}

		private delegate bool OpenFunc();

		private struct TutorialGuide
		{
			public int[] questId;

			public int areaIndex;

			public int[] guideWindowIds;

			public OpenFunc hasShownFunc;

			public Action finishAct;

			public TutorialGuide(int areaIndex, int guideWindowId_0, int guideWindowId_1, OpenFunc condition, Action finish, int[] qId)
			{
			}
		}

		public enum PartySwitchPhase
		{
			BeginPartySwitch = 0,
			JoinBeginPartySwitch = 5,
			Darken = 4,
			ShowDirection = 1,
			ChangeCharacter = 2,
			JoinChangeCharacter = 6,
			EndPartySwitch = 3
		}

		public const string kDungeonVariationTypePrefKey = "DungeonVariationType";

		public const string kDungeonQuestFromDebugMenu = "QuestFromDebugMenu";

		public const string kDebugQuestDebugMetching = "DebugMatching";

		private const string fastestQualitySettingName = "Fastest";

		private const string defaultQualitySettingName = "Simple";

		private const int noVsyncWaitSetting = -1;

		private const int lastAreaIndexOfThisQuestErrorCode = -1;

		public const int CommonTestQuestID = 999990101;

		public InGameUICtrl uiCtrl;

		[SerializeField]
		private GameParam _gameParam;

		public PlayerCommonData playerCommonData;

		protected GameObject playerCommonDataObject;

		[SerializeField]
		public GameObject loadingCanvas;

		[SerializeField]
		protected CameraController _cameraController;

		public Transform playerParent;

		public NotifyCharacter notifyCharacter;

		public NotifyDungeonObject notifyDungeonObject;

		public DragonTransformCtrl dragonTransform;

		public CtrlHolyLight holyLight;

		[SerializeField]
		protected GameObject cameraRootObject;

		protected GameObject cameraRootIns;

		public GameObject storyScene;

		private IngameCuttStep ingameCuttStep;

		private const int ingameCuttPlayRequestIdNone = -1;

		private int ingameCuttPlayRequestIdReq;

		private bool ingameCuttSkipRequestFlag;

		private bool _ingameCuttLoading;

		private List<State> _stateLog;

		protected State _state;

		public int fadeEffectTrigger;

		private EffectObject fadeEffect;

		private FadeImageUI fadeImageUI;

		protected FadeImageUI.Param fadeParam;

		private string[] dungeonAreaName;

		private string[] dungeonScenePath;

		private string[] areaSceneNameArray;

		private int previousAreaIndex;

		private int arrowTargetIndex;

		private StoryCanvas storyCanvas;

		private bool isCutScene;

		private bool inGameScript;

		private int storyReserveNextArea;

		private List<int> storyStartList;

		private int finishAreaEndStoryId;

		private bool storyPlayed;

		public static readonly string[] loadSoundGroup;

		private float questEndTimer;

		protected bool playedQuestStart;

		public TutorialCtrl tutorialCtrl;

		public BotMultiTutorialCtrl botMultiTutorialCtrl;

		public BotBRTutorialCtrl botBRTutorialCtrl;

		public TutorialAccessory tutorialAccessary;

		private QuestClearType questClearType;

		public bool isAutoAreaChangeReserved;

		public float autoAreaChangeWaitTimer;

		private bool isRetire;

		public bool isIgnoreDetectZombie;

		private BossAppearProduction bossAppearProcuction;

		private WinningProduction winningProduction;

		private QuestFailedType questFailedType;

		private float _questTimeElapsed;

		private bool isQuestFailureProcessing;

		private bool _isEnemyAIForceDisable;

		public Dictionary<int, RecodeMiniMapStatus> recodeAreaMiniMapStatus;

		private float _continueTimer;

		private ContinueDialog _continueDialog;

		private RetireConfirmDialogBase _retireConfirmDialog;

		private CommonDialog _continueLimitDialog;

		private CommonDialog.Param _continueLimitDialogParam;

		private DmodeContinueDialog dmodeContinueDialog;

		private const float CONTINUE_WAIT_TIME = 3f;

		public CuttDriverInGame cuttDriver;

		private AudioPlayback _areaBgmPlayback;

		public MainGameSkillFadeoutCtrl skillFadeoutCtrl;

		private bool needsBossBattleCharaTalk;

		private const float REBULT_BLUR_SIZE = 1.3f;

		private const float REBULT_BLUR_POWER = 1f;

		private WeaponTypePool weaponTypePool;

		private InGameTime gameTime;

		private bool pauseStateSuspend;

		private bool isOfficialAutoPlayMode;

		private bool isOfficialAutoPlayModePrev;

		public const string prefsKeyLastAutoPlayMode = "LastAutoPlayMode";

		private const string prefsKeyLastMultiAutoPlayMode = "LastMultiAutoPlayMode";

		private float disableAutoPlaySec;

		private const float AUTO_PLAY_INTERVAL_BY_INPUT = 0.5f;

		public const string prefsKeyLastAutoTransformMode = "LastAutoTransformMode";

		[SerializeField]
		public GameObject inputModuleParentNode;

		private MainGameLeaveAloneChecker leaveAloneChecker;

		private float _elasedWaitAutoFailTime;

		private bool isPlayingBossSpecialDead;

		private bool calledApiDungeonRecord;

		private List<DropItemUI.Parameter> bossDropParams;

		private List<DropItemUI.Parameter> bossItemBoxParams;

		private int poppedWaveCount;

		private int maxWaveCount;

		private int turnCount;

		private bool questEnded;

		private bool skipToGoQuest;

		private SleepTimeoutCtrl _sleepTimeoutCtrl;

		private FailQuestCtrl failQuestCtrl;

		private MainGamePartySwitchCtrl partySwitchCtrl;

		private bool isSimpleWinAfterCheckTimeUp;

		private int defenseProtectionDamage;

		private InGameSettings settings;

		public WalkingCtrl walkingCtrl;

		public DragonRelayCtrl dragonRelayCtrl;

		private PlayQuestStartProcTimerCtrl playQuestStartProcTimerCtrl;

		private const string failureJingleName = "BGM_JINGLE_0002_01";

		private float raidStageCollisionRadius;

		private bool isDmodeGameOver;

		private float failureWaitTime;

		private const float BLUR_START_TIMING = 3.2f;

		private const string closedAutoBtnWin = "AutoTutorialHasClosed";

		private TutorialGuide[] tutorialGuideTable;

		private bool _isPartySwitching;

		public bool CanProcessMultiPlayEvent => default(bool);

		public static MainGameCtrl instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DungeonManager dungeonManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CharacterManager charaManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public GameDataManager gameDataManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public GameUserData gameUserData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IngameApiController apiController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DamageCalculation damageCalc
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameParam gameParam => null;

		public AIScriptLoader aiScriptLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CameraController cameraController => null;

		public DungeonObjectShadow dungeonObjectShadow
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlayerCtrl player => null;

		public MainCameraCtrl mainCameraCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CharacterTalkCtrl charaTalkCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SupporterSkillCtrl supporterSkillCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AbilityCollisionManager abilityCollisionManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public State state
		{
			get
			{
				return default(State);
			}
			protected set
			{
			}
		}

		public bool fadeEnd
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestDataElement questData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuestRewardDataElement questRewardData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuestWallDetailElement wallDetail
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int areaNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int currentAreaIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isStoryPlaying
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPrologue
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPrologueTransformDragon
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isParamOverwrite
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool showTutorialGuide
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool goalQuest
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float QuestTimeElapsed => default(float);

		public AudioPlayback areaBgmPlayback
		{
			get
			{
				return default(AudioPlayback);
			}
			private set
			{
			}
		}

		public bool isStarted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isFinishedStartUI
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isFinishedQuestStartFTU
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int questId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WeaponTypePool WeaponTypePool => null;

		public InGameTime GameTime => null;

		public bool IsOfficialAutoPlayMode => default(bool);

		public bool isOfficialAutoTransformMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MainGameLeaveAloneChecker LeaveAloneChecker => null;

		public bool IsExecuteWarp
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int TurnCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsAllTurnCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MainGameRebornCtrl rebornCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InGameSettings Settings => null;

		public SameTimeHitChecker sameTimeHitChecker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BRCtrl brCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BRItemManager brItemManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BRPulse brPulse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeCtrl dmodeCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isQuestCleared
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPartySwitching => default(bool);

		public event Action _eventBeforeApiClearQuest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action _eventEndCutScene
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetDisableAutoPlaySec()
		{
		}

		public void SetDisableAutoPlaySecForEventMove()
		{
		}

		public bool IsDisableAutoPlay()
		{
			return default(bool);
		}

		public bool CanUseAutoTransformSkill()
		{
			return default(bool);
		}

		public void SetToggleAutoPlayMode(bool val)
		{
		}

		public void PushToggleAutoPlayMode()
		{
		}

		private void PopToggleAutoPlayMode(bool isMulti)
		{
		}

		public void SetToggleAutoTransformMode(bool val)
		{
		}

		public bool IsPlayingDragonRelayQuest()
		{
			return default(bool);
		}

		public bool IsPlayingDragonSoloOrRelayQuest()
		{
			return default(bool);
		}

		public static bool IsPlayingBR()
		{
			return default(bool);
		}

		public static bool IsPlayingBRTutorial()
		{
			return default(bool);
		}

		public static bool IsCheckCollisionOnDefenceSide()
		{
			return default(bool);
		}

		public static bool IsDmode()
		{
			return default(bool);
		}

		protected virtual void Awake()
		{
		}

		private void SetLoadDungeonData()
		{
		}

		public DungeonType GetDungeonType()
		{
			return default(DungeonType);
		}

		public bool IsDungeonType(DungeonType type)
		{
			return default(bool);
		}

		public void InitializeCamera()
		{
		}

		protected void InitializeUIPost()
		{
		}

		protected IEnumerator InitializeUIAfter()
		{
			return null;
		}

		protected virtual IEnumerator Start()
		{
			return null;
		}

		private void StartArea(bool isCutScene)
		{
		}

		private bool NeedsPlayStory()
		{
			return default(bool);
		}

		private bool NeedsBossAppear()
		{
			return default(bool);
		}

		private void DelaySetupPrologueDragonParam()
		{
		}

		protected void InitializeFade()
		{
		}

		private void SetFade()
		{
		}

		private void CallbackFade(FadeImageUI fade)
		{
		}

		public Color SetActiveFade()
		{
			return default(Color);
		}

		public void StartFade(bool fadeOut, bool colorChange = false)
		{
		}

		public void StartFadeWithParam(bool fadeOut, float time, Color color)
		{
		}

		private IEnumerator LoadEffectResourcesForDungeon()
		{
			return null;
		}

		protected IEnumerator LoadEffectResources()
		{
			return null;
		}

		protected void LoadSoundResources()
		{
		}

		public void SetInGameVisible(bool visible)
		{
		}

		private void StartBossAppear()
		{
		}

		public bool IsBossAppearWaiting()
		{
			return default(bool);
		}

		private IEnumerator RunStoryScript(string scriptName, Action onComplete)
		{
			return null;
		}

		public StoryCanvas GetStroyCanvas()
		{
			return null;
		}

		public static string GetScriptName(int scriptId)
		{
			return null;
		}

		public void InGameStartStory(string scriptPath)
		{
		}

		public void StartCutScene(string scriptPath)
		{
		}

		public void LoadIngameCutt(string cuttPath)
		{
		}

		public IEnumerator CoLoadIngameCutt(string cuttPath)
		{
			return null;
		}

		public void PlayIngameCutt(int id = 0)
		{
		}

		public bool IsIngameCuttBusy()
		{
			return default(bool);
		}

		public void SkipIngameCutt()
		{
		}

		private void StartIngameCutt()
		{
		}

		private void EndIngameCutt()
		{
		}

		private void SetActiveModelType(EnvironmentMap.ModelType type)
		{
		}

		private void StartStory(string scriptPath, bool inGameScript, bool isCutScene)
		{
		}

		public void InitializeCutt(string cuttName)
		{
		}

		public void ReleaseCutt()
		{
		}

		public void ResetPauseCutt()
		{
		}

		private void EndStory(StoryScriptFunctionManager.State state, StoryScriptFunctionManager.ScriptFunction index)
		{
		}

		private void ReleaseStory()
		{
		}

		public bool IsUsingPhotonQuest()
		{
			return default(bool);
		}

		public bool IsSingleQuest()
		{
			return default(bool);
		}

		public bool IsCoopQuest()
		{
			return default(bool);
		}

		public bool IsRaidQuest(bool includeSoloRaid)
		{
			return default(bool);
		}

		public bool IsDefenceQuestArea()
		{
			return default(bool);
		}

		public bool IsHeavyArea()
		{
			return default(bool);
		}

		public bool IsWallQuest()
		{
			return default(bool);
		}

		public bool IsScoringQuest()
		{
			return default(bool);
		}

		public bool IsCheckPopCountAtEnemyDeadEvent()
		{
			return default(bool);
		}

		public bool IsRandomMatchingQuest()
		{
			return default(bool);
		}

		public bool IsSumUpTotalDamageQuest()
		{
			return default(bool);
		}

		public void TryAddTotalDamage(int damage, CharacterBase from)
		{
		}

		public void TryAddTotalDamage(Dictionary<CharacterBase, int> damages)
		{
		}

		public float GetRaidStageCollisionRadius()
		{
			return default(float);
		}

		private bool IsMultiPlayType(MultiPlayManager.MultiType type)
		{
			return default(bool);
		}

		public bool IsTimeLimitQuest()
		{
			return default(bool);
		}

		public virtual bool IsInGame()
		{
			return default(bool);
		}

		public bool IsBeforeInGameState()
		{
			return default(bool);
		}

		public virtual bool IsInGameAndContinueTime()
		{
			return default(bool);
		}

		public bool IsBetweenInGameFadeIO()
		{
			return default(bool);
		}

		public bool IsWinningProduction()
		{
			return default(bool);
		}

		public virtual bool IsInGameAndContinueTimeWithoutStart()
		{
			return default(bool);
		}

		public virtual bool CanRetryVoteState()
		{
			return default(bool);
		}

		public bool IsQuestEnded()
		{
			return default(bool);
		}

		private void SetQuestClear()
		{
		}

		private CheckResult UpdateCheckQuest()
		{
			return default(CheckResult);
		}

		private CheckResult UpdateCheckPause()
		{
			return default(CheckResult);
		}

		protected void UpdateGamePlayTime()
		{
		}

		protected virtual void UpdateInGame()
		{
		}

		private void SetCameraAnimation(string cutSceneName)
		{
		}

		public void SetCutScene(string cutSceneName)
		{
		}

		private void ReleaseCutScene()
		{
		}

		private void SetWinInitialize()
		{
		}

		private void InitializeWin()
		{
		}

		private void UpdateWin()
		{
		}

		private void EndWin()
		{
		}

		protected virtual void Update()
		{
		}

		private IEnumerator DmodeAutoAreaChangeCoroutine()
		{
			return null;
		}

		private bool UpdateResultBlurPower(bool endSSCapture)
		{
			return default(bool);
		}

		private PlayFTU.Type GetQuestStartType()
		{
			return default(PlayFTU.Type);
		}

		private IEnumerator DisplayStartSystemMessage()
		{
			return null;
		}

		private IEnumerator PlayQuestStart()
		{
			return null;
		}

		public void SetGameTimeMode(InGameTime.Mode mode)
		{
		}

		public void StartGamePlayTime()
		{
		}

		public float GetGamePlayTime()
		{
			return default(float);
		}

		public float GetTimeLimitPlayTime()
		{
			return default(float);
		}

		public void ResetDmodeFloorPlayTime()
		{
		}

		public void PauseInGame(bool pause)
		{
		}

		public void PauseInGameActiveMotion(bool pause)
		{
		}

		public void ToPrologueDownload()
		{
		}

		public void ToGoQuestAsync(bool showLoading = true)
		{
		}

		public void ToRetry()
		{
		}

		public void ToContinueImpossible()
		{
		}

		public void ToResult(bool isSuccess)
		{
		}

		private void ToStoryPrologueBook()
		{
		}

		public void ToTitle(bool showLoading = true)
		{
		}

		public void ToLoginBonus(bool showLoading = true)
		{
		}

		public void ToMyPage(bool showLoading = true)
		{
		}

		public void ToDownload(bool showLoading = true)
		{
		}

		public void ToQuit(bool showLoading = true)
		{
		}

		private void ReleaseEffectAndSoundAssets()
		{
		}

		private void LoadNextScene(string sceneName, bool showLoading = true)
		{
		}

		private void OnUnloadInGame(Scene scene)
		{
		}

		private void DisableForceIdleMode()
		{
		}

		protected IEnumerator DelayedDisableForceIdleMode(float delay)
		{
			return null;
		}

		public void ReserveNextArea()
		{
		}

		private bool CheckItemsBeforeChangeSceneForDmode(bool organizeItems, Action onClickNextFloorButtonAction, Action onClickCancelButtonAction)
		{
			return default(bool);
		}

		public void ChangeNextScene(int nextIndex, int targetIndex, bool fadeCtrl, bool sendEvent = true, bool organizeItems = true)
		{
		}

		private IEnumerator LoadNewStage()
		{
			return null;
		}

		private IEnumerator LoadStory(int questStoryId)
		{
			return null;
		}

		public void PlayAreaBGM(bool isOnEndDragon = false)
		{
		}

		private void CallbackQuestFailure(PlayFTU playFTU)
		{
		}

		private void CallbackQuestTimeUp(PlayFTU playFTU)
		{
		}

		public void CallbackEndSkillCutIn(PlayFTU ftu)
		{
		}

		private bool CheckQuestClear()
		{
			return default(bool);
		}

		public void SetPlayerEventMode()
		{
		}

		public void SetPlayerEventMoveMode()
		{
		}

		public bool SetCharacterEventMode(bool eventMode)
		{
			return default(bool);
		}

		private bool CheckQuestFailure()
		{
			return default(bool);
		}

		private bool CheckQuestClearTimeElapsed()
		{
			return default(bool);
		}

		private bool CheckQuestFailureTimeElapsed(bool withWarning)
		{
			return default(bool);
		}

		private void Continue()
		{
		}

		private void OpenContinueImpossibleDialog()
		{
		}

		private void OpenDmodeContinueDialog()
		{
		}

		private bool OpenContinueDialog()
		{
			return default(bool);
		}

		private void OpenMultiQuestAutoFailDialog()
		{
		}

		private void OpenDmodeTimeUpDialog()
		{
		}

		private void OpenTimeupDialog()
		{
		}

		private void OpenTimeupRetireConfirmDialog()
		{
		}

		public bool IsMultiQuestAutoFail()
		{
			return default(bool);
		}

		public bool CheckLastVoteCondition()
		{
			return default(bool);
		}

		public void CloseAllDialog()
		{
		}

		private void OnRetryButtonPressedFromContinueDialog()
		{
		}

		private void OnRetireButtonPressedFromContinueDialog()
		{
		}

		private void OnContinueButtonPressedFromContinueDialog()
		{
		}

		private void OnNextButtonPressedFromBRContinueDialog()
		{
		}

		private void OnRetryButtonPressedFromContinueLimitDialog(CommonDialog sender)
		{
		}

		private void OnRetryButtonPressedFromContinueLimitDialog()
		{
		}

		private void OnRetireButtonPressedFromContinueLimitDialog(CommonDialog sender)
		{
		}

		private void OnRetireButtonPressedFromContinueLimitDialog()
		{
		}

		private void OnRetryButtonPressedFromRetireConfirmDialog()
		{
		}

		private void OnCancelButtonPressedFromRetireConfirmDialog()
		{
		}

		private void OnRetryButtonPressedFromMultiRetireConfirmDialog()
		{
		}

		private void OnCancelButtonPressedFromMultiRetireConfirmDialog()
		{
		}

		private void OnRetireButtonPressedFromTimeupDialog(CommonDialog sender)
		{
		}

		private void OnRetireButtonPressedFromTimeupDialog()
		{
		}

		private void OnRetryButtonPressedFromTimeupDialog(CommonDialog sender)
		{
		}

		private void OnRetryButtonPressedFromTimeupDialog()
		{
		}

		private void OnRetryButtonPressedFromTimeupRetireConfirmDialog()
		{
		}

		private void OnRetryTopButtonPressedFromDmodeTimeupRetireConfirmDialog()
		{
		}

		private void OnRetryFloorButtonPressedFromDmodeTimeupRetireConfirmDialog()
		{
		}

		private void OnCancelButtonPressedFromTimeupRetireConfirmDialog()
		{
		}

		public void OnContinueErrorPopup(string title, string message, Action onClosedCallback)
		{
		}

		private void OnContinueErrorToTitle()
		{
		}

		private void OnContinueErrorRetry(Action onClosedCallback)
		{
		}

		public void EnableMapCulling(bool enable)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void CallApiDungeonRecord(bool isFailure = false, bool isDmodeGameOver = false)
		{
		}

		private bool IsIngameApiFinished()
		{
			return default(bool);
		}

		private bool IsClearQuestApiSucceeded()
		{
			return default(bool);
		}

		private IEnumerator CallApiAreaChange()
		{
			return null;
		}

		private IEnumerator DisplayWaitingOtherPlayer()
		{
			return null;
		}

		public void SetRetire()
		{
		}

		private void StartSSCapture()
		{
		}

		private void EndSSCapture()
		{
		}

		protected void CopyGameGraphic(GameObject from)
		{
		}

		public void ContinueByOtherPlayer(int actorId)
		{
		}

		public void TransitionAreaBgm()
		{
		}

		private new Coroutine StartCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void RegisterCharaTarlk(CharacterTalkCtrl.Situation situation, float delaySec)
		{
		}

		public void ReadyToStartQuestForMulti()
		{
		}

		public void AddBossDrop(DropItemUI.Parameter param)
		{
		}

		public void AddBossItemBox(DropItemUI.Parameter param)
		{
		}

		private void CreateMasterDictionary()
		{
		}

		public void OnWaveStart(int popwaveIndex, int maxWaveIndex)
		{
		}

		public void StartRareEnemyRunAwayUI()
		{
		}

		private IEnumerator CoRareEnemyRunAwayUI(float duration)
		{
			return null;
		}

		private bool ExistsTutorialGuide()
		{
			return default(bool);
		}

		private bool CheckShowTutorialGuide(Action onEndAction)
		{
			return default(bool);
		}

		private static bool IsAutoButtonTutorialSeen()
		{
			return default(bool);
		}

		private static void SetAutoButtonTutorialSeen()
		{
		}

		public bool IsEnableContinue()
		{
			return default(bool);
		}

		public bool IsUnlimitContinue()
		{
			return default(bool);
		}

		public int GetContinueLimainCount()
		{
			return default(int);
		}

		public void StopDungeonEffectObjects()
		{
		}

		public bool IsFollowerTargetMirageEnemyQuest()
		{
			return default(bool);
		}

		private void ShowQuestRetireMessage()
		{
		}

		private void ShowLeaveAloneDialog()
		{
		}

		public bool HasUniqueTransform()
		{
			return default(bool);
		}

		public void RecoveryUtp(int point)
		{
		}

		public void RecoveryUtpRatio(float rate)
		{
		}

		public void RecoveryHpPotion(int value)
		{
		}

		public void RecoverySpPoint(int value, bool isPlayEffect, bool isShowRecoveryValue)
		{
		}

		public bool HasChainSkill(PlayerCharacter chara, int skillIdx)
		{
			return default(bool);
		}

		public static void SetQualitySettingToDefault()
		{
		}

		public void OnGoToTopForDmode()
		{
		}

		public void OnRetryForDmode()
		{
		}

		private void SetFailure(State nextState = State.Failure)
		{
		}

		private int LastAreaIndexOfThisQuest()
		{
			return default(int);
		}

		public bool IsPlayingDragonRelayQuestBeforeBossWave()
		{
			return default(bool);
		}

		private static bool IsMatchAreaId(string areaName, string masterAreaName)
		{
			return default(bool);
		}

		public void ForcedEndSupportSkill()
		{
		}

		public CharacterBase GetCameraFocusChara(bool original = true)
		{
			return null;
		}

		public bool IsDarkAgitoQuest()
		{
			return default(bool);
		}

		public bool IsPlayingMinHpOneQuest()
		{
			return default(bool);
		}

		public bool IsPlayingMenuActiveQuest()
		{
			return default(bool);
		}

		public bool ShouldBlockRunActionAfterQuestEnd()
		{
			return default(bool);
		}

		public bool RunPartySwitchPhase(PartySwitchPhase phase)
		{
			return default(bool);
		}

		public void StartJoinPartySwitchPhase(PartySwitchPhase phase, float minWaitSec, Action onFinishCallback)
		{
		}

		public void StopJoinPartySwitchPhase(PartySwitchPhase phase)
		{
		}

		public bool OnReceiveGameStep(GameStepEvent recvEvent)
		{
			return default(bool);
		}

		private void ActiveEnemyAI(bool sw)
		{
		}

		public bool IsAbilityDisableQuest()
		{
			return default(bool);
		}

		public static bool NeedsEnemyPopInvincible(EnemyCharacter enemy, out float sec)
		{
			return default(bool);
		}

		public string DebugReportIngameState()
		{
			return null;
		}

		public static bool NeedsToUseMyModelForOthersModels()
		{
			return default(bool);
		}

		private IEnumerator PlayDmodeFloorStartProduction(bool isCheckLife = false)
		{
			return null;
		}

		public bool IsDashSpeedUpArea()
		{
			return default(bool);
		}
	}
}
