/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using Gluon.CharacterUniqueGimmick;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainGameCtrl : MonoBehaviour
	{
		// Fields
		public const string kDungeonVariationTypePrefKey = "DungeonVariationType";
		public const string kDungeonQuestFromDebugMenu = "QuestFromDebugMenu";
		public const string kDebugQuestDebugMetching = "DebugMatching";
		private const string fastestQualitySettingName = "Fastest";
		private const string defaultQualitySettingName = "Simple";
		private const int noVsyncWaitSetting = -1;
		private const int lastAreaIndexOfThisQuestErrorCode = -1;
		public const int CommonTestQuestID = 999990101;
		[CompilerGenerated]
		private static MainGameCtrl _instance_k__BackingField;
		[CompilerGenerated]
		private DungeonManager _dungeonManager_k__BackingField;
		[CompilerGenerated]
		private CharacterManager _charaManager_k__BackingField;
		public InGameUICtrl uiCtrl;
		[CompilerGenerated]
		private GameDataManager _gameDataManager_k__BackingField;
		[CompilerGenerated]
		private GameUserData _gameUserData_k__BackingField;
		[CompilerGenerated]
		private IngameApiController _apiController_k__BackingField;
		[CompilerGenerated]
		private DamageCalculation _damageCalc_k__BackingField;
		[CompilerGenerated]
		private Action _eventBeforeApiClearQuest;
		[CompilerGenerated]
		private Action _eventEndCutScene;
		[SerializeField]
		private GameParam _gameParam;
		public PlayerCommonData playerCommonData;
		protected GameObject playerCommonDataObject;
		[CompilerGenerated]
		private AIScriptLoader _aiScriptLoader_k__BackingField;
		[SerializeField]
		public GameObject loadingCanvas;
		[SerializeField]
		protected CameraController _cameraController;
		[CompilerGenerated]
		private DungeonObjectShadow _dungeonObjectShadow_k__BackingField;
		public Transform playerParent;
		public NotifyCharacter notifyCharacter;
		public NotifyDungeonObject notifyDungeonObject;
		public DragonTransformCtrl dragonTransform;
		public CtrlHolyLight holyLight;
		[SerializeField]
		protected GameObject cameraRootObject;
		protected GameObject cameraRootIns;
		[CompilerGenerated]
		private MainCameraCtrl _mainCameraCtrl_k__BackingField;
		public GameObject storyScene;
		[CompilerGenerated]
		private CharacterTalkCtrl _charaTalkCtrl_k__BackingField;
		[CompilerGenerated]
		private SupporterSkillCtrl _supporterSkillCtrl_k__BackingField;
		[CompilerGenerated]
		private AbilityCollisionManager _abilityCollisionManager_k__BackingField;
		private IngameCuttStep ingameCuttStep;
		private bool ingameCuttPlayRequestFlag;
		protected State _state;
		public int fadeEffectTrigger;
		private EffectObject fadeEffect;
		private FadeImageUI fadeImageUI;
		protected FadeImageUI.Param fadeParam;
		[CompilerGenerated]
		private bool _fadeEnd_k__BackingField;
		[CompilerGenerated]
		private QuestDataElement _questData_k__BackingField;
		[CompilerGenerated]
		private QuestRewardDataElement _questRewardData_k__BackingField;
		[CompilerGenerated]
		private QuestWallDetailElement _wallDetail_k__BackingField;
		[CompilerGenerated]
		private int _areaNum_k__BackingField;
		private string[] dungeonAreaName;
		private string[] dungeonScenePath;
		private string[] areaSceneNameArray;
		private int previousAreaIndex;
		[CompilerGenerated]
		private int _currentAreaIndex_k__BackingField;
		private int arrowTargetIndex;
		private StoryCanvas storyCanvas;
		[CompilerGenerated]
		private bool _isStoryPlaying_k__BackingField;
		private bool isCutScene;
		private bool inGameScript;
		private int storyReserveNextArea;
		private List<int> storyStartList;
		private int finishAreaEndStoryId;
		private bool storyPlayed;
		public static readonly string[] loadSoundGroup;
		[CompilerGenerated]
		private bool _isPrologue_k__BackingField;
		[CompilerGenerated]
		private bool _isPrologueTransformDragon_k__BackingField;
		private float questEndTimer;
		protected bool playedQuestStart;
		[CompilerGenerated]
		private bool _isParamOverwrite_k__BackingField;
		public TutorialCtrl tutorialCtrl;
		public BotMultiTutorialCtrl botMultiTutorialCtrl;
		public BotBRTutorialCtrl botBRTutorialCtrl;
		[CompilerGenerated]
		private bool _showTutorialGuide_k__BackingField;
		public TutorialAccessory tutorialAccessary;
		private QuestClearType questClearType;
		[CompilerGenerated]
		private bool _goalQuest_k__BackingField;
		private bool isRetire;
		public bool isIgnoreDetectZombie;
		private BossAppearProduction bossAppearProcuction;
		private WinningProduction winningProduction;
		private QuestFailedType questFailedType;
		private float questFailureTimeElapsed;
		private bool isQuestFailureProcessing;
		private bool _isEnemyAIForceDisable;
		public Dictionary<int, RecodeMiniMapStatus> recodeAreaMiniMapStatus;
		private float _continueTimer;
		private ContinueDialog _continueDialog;
		private ContinueDialog.Param _continueDialogParam;
		private RetireConfirmDialog _retireConfirmDialog;
		private RetireConfirmDialog.Param _retireConfirmDialogParam;
		private CommonDialog _continueLimitDialog;
		private CommonDialog.Param _continueLimitDialogParam;
		private const float CONTINUE_WAIT_TIME = 3f;
		public CuttDriverInGame cuttDriver;
		private AudioPlayback _areaBgmPlayback;
		public MainGameSkillFadeoutCtrl skillFadeoutCtrl;
		[CompilerGenerated]
		private bool _isStarted_k__BackingField;
		[CompilerGenerated]
		private bool _isFinishedStartUI_k__BackingField;
		[CompilerGenerated]
		private bool _isFinishedQuestStartFTU_k__BackingField;
		private bool needsBossBattleCharaTalk;
		private const float REBULT_BLUR_SIZE = 1.3f;
		private const float REBULT_BLUR_POWER = 1f;
		[CompilerGenerated]
		private int _questId_k__BackingField;
		private WeaponTypePool weaponTypePool;
		private InGameTime gameTime;
		private bool pauseStateSuspend;
		private bool isOfficialAutoPlayMode;
		private bool isOfficialAutoPlayModePrev;
		public const string prefsKeyLastAutoPlayMode = "LastAutoPlayMode";
		private const string prefsKeyLastMultiAutoPlayMode = "LastMultiAutoPlayMode";
		private float disableAutoPlaySec;
		private const float AUTO_PLAY_INTERVAL_BY_INPUT = 0.5f;
		[CompilerGenerated]
		private bool _isOfficialAutoTransformMode_k__BackingField;
		public const string prefsKeyLastAutoTransformMode = "LastAutoTransformMode";
		[SerializeField]
		public GameObject inputModuleParentNode;
		private MainGameLeaveAloneChecker leaveAloneChecker;
		private float _elasedWaitAutoFailTime;
		[CompilerGenerated]
		private bool _IsExecuteWarp_k__BackingField;
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
		private float rebornTimer;
		private int consumeRebornCount;
		private bool isRebornCountDown;
		private InGameSettings settings;
		[CompilerGenerated]
		private SameTimeHitChecker _sameTimeHitChecker_k__BackingField;
		public WalkingCtrl walkingCtrl;
		public DragonRelayCtrl dragonRelayCtrl;
		[CompilerGenerated]
		private BRCtrl _brCtrl_k__BackingField;
		[CompilerGenerated]
		private BRItemManager _brItemManager_k__BackingField;
		[CompilerGenerated]
		private BRPulse _brPulse_k__BackingField;
		private PlayQuestStartProcTimerCtrl playQuestStartProcTimerCtrl;
		private const string failureJingleName = "BGM_JINGLE_0002_01";
		private float raidStageCollisionRadius;
		[CompilerGenerated]
		private bool _isQuestCleared_k__BackingField;
		private float failureWaitTime;
		private const float BLUR_START_TIMING = 3.2f;
		private const string closedAutoBtnWin = "AutoTutorialHasClosed";
		private TutorialGuide[] tutorialGuideTable;
		private bool _isPartySwitching;
	
		// Properties
		public bool CanProcessMultiPlayEvent { get; }
		public static MainGameCtrl instance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public DungeonManager dungeonManager { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CharacterManager charaManager { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public GameDataManager gameDataManager { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public GameUserData gameUserData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IngameApiController apiController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DamageCalculation damageCalc { [CompilerGenerated] get; [CompilerGenerated] set; }
		public GameParam gameParam { get; }
		public AIScriptLoader aiScriptLoader { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CameraController cameraController { get; }
		public DungeonObjectShadow dungeonObjectShadow { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PlayerCtrl player { get; }
		public MainCameraCtrl mainCameraCtrl { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CharacterTalkCtrl charaTalkCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SupporterSkillCtrl supporterSkillCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbilityCollisionManager abilityCollisionManager { [CompilerGenerated] get; [CompilerGenerated] set; }
		public State state { get; protected set; }
		public bool fadeEnd { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestDataElement questData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public QuestRewardDataElement questRewardData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public QuestWallDetailElement wallDetail { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int areaNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int currentAreaIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isStoryPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPrologue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPrologueTransformDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isParamOverwrite { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool showTutorialGuide { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool goalQuest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float QuestFailureTimeElapsed { get; }
		public AudioPlayback areaBgmPlayback { get; private set; }
		public bool isStarted { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isFinishedStartUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isFinishedQuestStartFTU { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int questId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public WeaponTypePool WeaponTypePool { get; }
		public InGameTime GameTime { get; }
		public bool IsOfficialAutoPlayMode { get; }
		public bool isOfficialAutoTransformMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MainGameLeaveAloneChecker LeaveAloneChecker { get; }
		public bool IsExecuteWarp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int TurnCount { get; set; }
		public InGameSettings Settings { get; }
		public SameTimeHitChecker sameTimeHitChecker { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BRCtrl brCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BRItemManager brItemManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BRPulse brPulse { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isQuestCleared { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Events
		public event Action _eventBeforeApiClearQuest {
			add;
			remove;
		}
		public event Action _eventEndCutScene {
			add;
			remove;
		}
	
		// Nested types
		public enum State
		{
			Loading = 0,
			DungeonStart = 1,
			PlayQuestStart = 2,
			InGame = 3,
			ToNextStage = 4,
			Success = 5,
			FailureInitialize = 6,
			FailureWaitBlur = 7,
			FailureWaitFinishMessage = 8,
			FailureWaitCloseDialog = 9,
			Failure = 10,
			ObjectiveFailedInitialize = 11,
			CheckObjectiveFailed = 12,
			CheckTimeUp = 13,
			TimeUp = 14,
			TimeUpWaiting = 15,
			BossAppear = 16,
			FinishSlow = 17,
			FinishSlowEnd = 18,
			WaitDungeonRecord = 19,
			WaitBossDrop = 20,
			QuestEnd = 21,
			WinInitialize = 22,
			Win = 23,
			WinFinalize = 24,
			SimplicityWin = 25,
			WaitStoryFade = 26,
			SimplicityWinWait = 27,
			AreaChange = 28,
			CutScene = 29,
			Story = 30,
			StoryWaitOtherPlayers = 31,
			Exit = 32,
			WaitFailureFadeExit = 33,
			WaitFadeResult = 34,
			WaitTutorialUpdateStep = 35,
			Retry = 36,
			ContinueInit = 37,
			ContinueWait = 38,
			BRContinueInit = 39,
			BRContinueWait = 40
		}
	
		private enum IngameCuttStep
		{
			WaitRequest = 0,
			Playing = 1
		}
	
		private enum CheckResult
		{
			NotEnd = 0,
			Clear = 1,
			Failure = 2
		}
	
		private delegate bool OpenFunc();
	
		private struct TutorialGuide
		{
			// Fields
			public int[] questId;
			public int areaIndex;
			public int[] guideWindowIds;
			public OpenFunc hasShownFunc;
			public Action finishAct;
	
			// Constructors
			public TutorialGuide(int areaIndex, int guideWindowId_0, int guideWindowId_1, OpenFunc condition, Action finish, params int[] qId);
		}
	
		public enum PartySwitchPhase
		{
			BeginPartySwitch = 0,
			ShowDirection = 1,
			ChangeCharacter = 2,
			EndPartySwitch = 3,
			Darken = 4,
			JoinBeginPartySwitch = 5,
			JoinChangeCharacter = 6
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass303_0
		{
			// Fields
			public bool isEndPreload;
	
			// Constructors
			public __c__DisplayClass303_0();
	
			// Methods
			internal void _InitializeUIAfter_b__0(PlayFTU playFTU);
		}
	
		[CompilerGenerated]
		private sealed class _InitializeUIAfter_d__303 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private __c__DisplayClass303_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitializeUIAfter_d__303(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass304_0
		{
			// Fields
			public bool isErrorPopupClosed;
	
			// Constructors
			public __c__DisplayClass304_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass304_1
		{
			// Fields
			public bool isCompleted;
			public bool isNeedErrorHandling;
	
			// Constructors
			public __c__DisplayClass304_1();
	
			// Methods
			internal void _Start_b__1();
			internal void _Start_b__2();
			internal void _Start_b__3();
			internal void _Start_b__4();
			internal void _Start_b__5();
			internal void _Start_b__6();
			internal void _Start_b__7();
			internal void _Start_b__8();
			internal void _Start_b__9();
			internal void _Start_b__10();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__304 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private __c__DisplayClass304_0 __8__1;
			private __c__DisplayClass304_1 __8__2;
			private int _savedFPS_5__2;
			private int _savedQualitySetting_5__3;
			private bool _isStory_5__4;
			private bool _playBGM_5__5;
			private bool _isCutScene_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__304(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadEffectResourcesForDungeon_d__315 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadEffectResourcesForDungeon_d__315(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadEffectResources_d__316 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadEffectResources_d__316(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__321_2;
			public static Action __9__377_1;
			public static Func<bool> __9__381_0;
			public static Func<bool> __9__381_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _RunStoryScript_b__321_2();
			internal void _Update_b__377_1();
			internal bool _PlayQuestStart_b__381_0();
			internal bool _PlayQuestStart_b__381_1();
		}
	
		[CompilerGenerated]
		private sealed class _RunStoryScript_d__321 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			public string scriptName;
			public Action onComplete;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RunStoryScript_d__321(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoLoadIngameCutt_d__327 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			public string cuttPath;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoLoadIngameCutt_d__327(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DisplayStartSystemMessage_d__380 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private NotifyCharacter.OpenPlaceNameParam _param_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisplayStartSystemMessage_d__380(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass381_0
		{
			// Fields
			public bool isEndPlayFTU;
			public MainGameCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass381_0();
	
			// Methods
			internal void _PlayQuestStart_b__2(PlayFTU playFTU);
			internal void _PlayQuestStart_b__3(PlayFTU playFTU);
			internal void _PlayQuestStart_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass381_1
		{
			// Fields
			public PlayFTU.Type uiType;
			public __c__DisplayClass381_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass381_1();
	
			// Methods
			internal void _PlayQuestStart_b__5(PlayFTU playFTU);
		}
	
		[CompilerGenerated]
		private sealed class _PlayQuestStart_d__381 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private __c__DisplayClass381_0 __8__1;
			private PlayQuestStartProcTimerCtrl _procTimer_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayQuestStart_d__381(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass388_0
		{
			// Fields
			public string nextSceneName;
			public MainGameCtrl __4__this;
			public bool showLoading;
	
			// Constructors
			public __c__DisplayClass388_0();
	
			// Methods
			internal void _ToGoQuestAsync_b__0(ErrorType type, int n);
		}
	
		[CompilerGenerated]
		private struct _ToGoQuestAsync_d__388 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MainGameCtrl __4__this;
			public bool showLoading;
			private __c__DisplayClass388_0 __8__1;
			private TaskAwaiter<GuildIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass399_0
		{
			// Fields
			public MainGameCtrl __4__this;
			public string sceneName;
	
			// Constructors
			public __c__DisplayClass399_0();
	
			// Methods
			internal void _LoadNextScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayedDisableForceIdleMode_d__402 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public MainGameCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayedDisableForceIdleMode_d__402(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass405_0
		{
			// Fields
			public bool isEnd;
	
			// Constructors
			public __c__DisplayClass405_0();
	
			// Methods
			internal void _LoadNewStage_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadNewStage_d__405 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private __c__DisplayClass405_0 __8__1;
			private bool _isCutScene_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadNewStage_d__405(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadStory_d__406 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			public int questStoryId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadStory_d__406(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass440_0
		{
			// Fields
			public CommonPopup errorPopup;
			public MainGameCtrl __4__this;
			public Action onClosedCallback;
	
			// Constructors
			public __c__DisplayClass440_0();
	
			// Methods
			internal void _OnContinueErrorPopup_b__0();
			internal void _OnContinueErrorPopup_b__1();
			internal void _OnContinueErrorPopup_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass441_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass441_0();
	
			// Methods
			internal void _OnContinueErrorToTitle_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass442_0
		{
			// Fields
			public CommonPopup errorPopup;
			public Action onClosedCallback;
			public MainGameCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass442_0();
	
			// Methods
			internal void _OnContinueErrorRetry_b__0();
			internal void _OnContinueErrorRetry_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CallApiAreaChange_d__448 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CallApiAreaChange_d__448(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DisplayWaitingOtherPlayer_d__449 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameCtrl __4__this;
			private bool _needsMessage_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisplayWaitingOtherPlayer_d__449(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoRareEnemyRunAwayUI_d__466 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float duration;
			public MainGameCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoRareEnemyRunAwayUI_d__466(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass472_0
		{
			// Fields
			public Action onEndAction;
			public Action<CommonDialog> __9__0;
	
			// Constructors
			public __c__DisplayClass472_0();
	
			// Methods
			internal void _CheckShowTutorialGuide_b__0(CommonDialog dialog);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass481_0
		{
			// Fields
			public MainGameCtrl __4__this;
			public CommonPopup pu;
	
			// Constructors
			public __c__DisplayClass481_0();
	
			// Methods
			internal void _ShowLeaveAloneDialog_b__0();
		}
	
		// Constructors
		public MainGameCtrl();
		static MainGameCtrl();
	
		// Methods
		public void SetDisableAutoPlaySec();
		public void SetDisableAutoPlaySecForEventMove();
		public bool IsDisableAutoPlay();
		public bool CanUseAutoTransformSkill();
		public void SetToggleAutoPlayMode(bool val);
		public void PushToggleAutoPlayMode();
		private void PopToggleAutoPlayMode(bool isMulti);
		public void SetToggleAutoTransformMode(bool val);
		public bool IsPlayingDragonRelayQuest();
		public bool IsPlayingDragonSoloOrRelayQuest();
		public static bool IsPlayingBR();
		public static bool IsPlayingBRTutorial();
		public static bool IsCheckCollisionOnDefenceSide();
		protected virtual void Awake();
		private void SetLoadDungeonData();
		public DungeonType GetDungeonType();
		public void InitializeCamera();
		protected void InitializeUIPost();
		[IteratorStateMachine]
		protected IEnumerator InitializeUIAfter();
		[IteratorStateMachine]
		protected virtual IEnumerator Start();
		private void StartArea(bool isCutScene);
		private bool NeedsPlayStory();
		private bool NeedsBossAppear();
		private void DelaySetupPrologueDragonParam();
		protected void InitializeFade();
		private void SetFade();
		private void CallbackFade(FadeImageUI fade);
		public Color SetActiveFade();
		public void StartFade(bool fadeOut, bool colorChange = false);
		public void StartFadeWithParam(bool fadeOut, float time, Color color);
		[IteratorStateMachine]
		private IEnumerator LoadEffectResourcesForDungeon();
		[IteratorStateMachine]
		protected IEnumerator LoadEffectResources();
		protected void LoadSoundResources();
		public void SetInGameVisible(bool visible);
		private void StartBossAppear();
		public bool IsBossAppearWaiting();
		[IteratorStateMachine]
		private IEnumerator RunStoryScript(string scriptName, Action onComplete);
		public StoryCanvas GetStroyCanvas();
		public static string GetScriptName(int scriptId);
		public void InGameStartStory(string scriptPath);
		public void StartCutScene(string scriptPath);
		public void LoadIngameCutt(string cuttPath);
		[IteratorStateMachine]
		public IEnumerator CoLoadIngameCutt(string cuttPath);
		public void PlayIngameCutt();
		public bool IsIngameCuttBusy();
		private void StartIngameCutt();
		private void EndIngameCutt();
		private void SetActiveModelType(EnvironmentMap.ModelType type);
		private void StartStory(string scriptPath, bool inGameScript, bool isCutScene);
		public void InitializeCutt(string cuttName);
		public void ReleaseCutt();
		public void ResetPauseCutt();
		private void EndStory(StoryScriptFunctionManager.State state, StoryScriptFunctionManager.ScriptFunction index);
		private void ReleaseStory();
		public bool IsUsingPhotonQuest();
		public bool IsSingleQuest();
		public bool IsCoopQuest();
		public bool IsRaidQuest(bool includeSoloRaid);
		public bool IsDefenceQuestArea();
		public bool IsHeavyArea();
		public bool IsWallQuest();
		public float GetRaidStageCollisionRadius();
		private bool IsMultiPlayType(MultiPlayManager.MultiType type);
		public bool IsTimeLimitQuest();
		public virtual bool IsInGame();
		public bool IsBeforeInGameState();
		public virtual bool IsInGameAndContinueTime();
		public bool IsBetweenInGameFadeIO();
		public bool IsWinningProduction();
		public virtual bool IsInGameAndContinueTimeWithoutStart();
		public virtual bool CanRetryVoteState();
		public bool IsQuestEnded();
		private void SetQuestClear();
		private CheckResult UpdateCheckQuest();
		private CheckResult UpdateCheckPause();
		protected void UpdateGamePlayTime();
		protected virtual void UpdateInGame();
		private void UpdateUI();
		private void SetCameraAnimation(string cutSceneName);
		public void SetCutScene(string cutSceneName);
		private void ReleaseCutScene();
		private void SetWinInitialize();
		private void InitializeWin();
		private void UpdateWin();
		private void EndWin();
		protected virtual void Update();
		private bool UpdateResultBlurPower(bool endSSCapture);
		private PlayFTU.Type GetQuestStartType();
		[IteratorStateMachine]
		private IEnumerator DisplayStartSystemMessage();
		[IteratorStateMachine]
		private IEnumerator PlayQuestStart();
		public void SetGameTimeMode(InGameTime.Mode mode);
		public void StartGamePlayTime();
		public float GetGamePlayTime();
		public void PauseInGame(bool pause);
		public void PauseInGameActiveMotion(bool pause);
		public void ToPrologueDownload();
		public async void ToGoQuestAsync(bool showLoading = true);
		public void ToRetry();
		public void ToContinueImpossible();
		public void ToResult(bool isSuccess);
		private void ToStoryPrologueBook();
		public void ToTitle(bool showLoading = true);
		public void ToLoginBonus(bool showLoading = true);
		public void ToMyPage(bool showLoading = true);
		public void ToDownload(bool showLoading = true);
		public void ToQuit(bool showLoading = true);
		private void ReleaseEffectAndSoundAssets();
		private void LoadNextScene(string sceneName, bool showLoading = true);
		private void OnUnloadInGame(Scene scene);
		private void DisableForceIdleMode();
		[IteratorStateMachine]
		protected IEnumerator DelayedDisableForceIdleMode(float delay);
		public void ReserveNextArea();
		public void ChangeNextScene(int nextIndex, int targetIndex, bool fadeCtrl, bool sendEvent = true);
		[IteratorStateMachine]
		private IEnumerator LoadNewStage();
		[IteratorStateMachine]
		private IEnumerator LoadStory(int questStoryId);
		public void PlayAreaBGM();
		private void CallbackQuestFailure(PlayFTU playFTU);
		private void CallbackQuestTimeUp(PlayFTU playFTU);
		public void CallbackEndSkillCutIn(PlayFTU ftu);
		private bool CheckQuestClear();
		public void SetPlayerEventMode();
		public void SetPlayerEventMoveMode();
		public bool SetCharacterEventMode(bool eventMode);
		private bool CheckQuestFailure();
		private bool CheckQuestFailureTimeElapsed(bool withWarning);
		private void Continue();
		private void OpenContinueImpossibleDialog();
		private bool CreateContinueDialog();
		private void OpenMultiQuestAutoFailDialog();
		private void OpenTimeupDialog();
		private void OpenTimeupRetireConfirmDialog();
		public bool IsMultiQuestAutoFail();
		public bool CheckLastVoteCondition();
		public void CloseAllDialog();
		private void OnRetryButtonPressedFromContinueDialog(ContinueDialog sender);
		private void OnRetireButtonPressedFromContinueDialog(ContinueDialog sender);
		private void OnContinueButtonPressedFromContinueDialog(ContinueDialog sender);
		private void OnNextButtonPressedFromBRContinueDialog(ContinueDialog sender);
		private void OnRetryButtonPressedFromContinueLimitDialog(CommonDialog sender);
		private void OnRetireButtonPressedFromContinueLimitDialog(CommonDialog sender);
		private void OnRetryButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnRetryButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnRetireButtonPressedFromTimeupDialog(CommonDialog sender);
		private void OnRetryButtonPressedFromTimeupDialog(CommonDialog sender);
		private void OnRetireButtonPressedFromTimeupRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromTimeupRetireConfirmDialog(RetireConfirmDialog sender);
		public void OnContinueErrorPopup(string title, string message, Action onClosedCallback);
		private void OnContinueErrorToTitle();
		private void OnContinueErrorRetry(Action onClosedCallback);
		public void EnableMapCulling(bool enable);
		protected virtual void OnDestroy();
		private void CallApiDungeonRecord(bool isFailure = false);
		private bool IsIngameApiFinished();
		private bool IsClearQuestApiSucceeded();
		[IteratorStateMachine]
		private IEnumerator CallApiAreaChange();
		[IteratorStateMachine]
		private IEnumerator DisplayWaitingOtherPlayer();
		public void SetRetire();
		private void StartSSCapture();
		private void EndSSCapture();
		protected void CopyGameGraphic(GameObject from);
		public void RebornByOtherPlayer(List<CharacterBase> targetCharas);
		public void ContinueByOtherPlayer(int actorId);
		public void TransitionAreaBgm();
		private new Coroutine StartCoroutine(IEnumerator coroutine);
		private void OnApplicationPause(bool pauseStatus);
		private void RegisterCharaTarlk(CharacterTalkCtrl.Situation situation, float delaySec);
		public void ReadyToStartQuestForMulti();
		public void AddBossDrop(DropItemUI.Parameter param);
		public void AddBossItemBox(DropItemUI.Parameter param);
		private void CreateMasterDictionary();
		public void OnWaveStart(int popwaveIndex, int maxWaveIndex);
		public void StartRareEnemyRunAwayUI();
		[IteratorStateMachine]
		private IEnumerator CoRareEnemyRunAwayUI(float duration);
		private bool ExistsTutorialGuide();
		private bool CheckShowTutorialGuide(Action onEndAction);
		private static bool IsAutoButtonTutorialSeen();
		private static void SetAutoButtonTutorialSeen();
		public bool IsEnableContinue();
		public bool IsUnlimitContinue();
		public int GetContinueLimainCount();
		public void StopDungeonEffectObjects();
		public bool IsFollowerTargetMirageEnemyQuest();
		private void ShowQuestRetireMessage();
		private void ShowLeaveAloneDialog();
		public bool HasUniqueTransform();
		public void RecoveryUtp(int point);
		public void RecoveryUtpRatio(float rate);
		public bool HasChainSkill();
		public bool HasChainSkill(PlayerCharacter chara, int skillIdx);
		public static void SetQualitySettingToDefault();
		private void SetFailure(State nextState = State.Failure);
		private int LastAreaIndexOfThisQuest();
		public bool IsPlayingDragonRelayQuestBeforeBossWave();
		private static bool IsMatchAreaId(string areaName, string masterAreaName);
		public void ForcedEndSupportSkill();
		public CharacterBase GetCameraFocusChara(bool original = true);
		public bool IsDarkAgitoQuest();
		public bool IsPlayingMinHpOneQuest();
		public bool IsPlayingMenuActiveQuest();
		public bool ShouldBlockRunActionAfterQuestEnd();
		public bool RunPartySwitchPhase(PartySwitchPhase phase);
		public void StartJoinPartySwitchPhase(PartySwitchPhase phase, float minWaitSec, Action onFinishCallback);
		public void StopJoinPartySwitchPhase(PartySwitchPhase phase);
		public bool OnReceiveGameStep(GameStepEvent recvEvent);
		private void ActiveEnemyAI(bool sw);
		public bool IsAbilityDisableQuest();
		public static bool NeedsEnemyPopInvincible(EnemyCharacter enemy);
		[CompilerGenerated]
		private float _Start_b__304_11();
		[CompilerGenerated]
		private bool _RunStoryScript_b__321_0();
		[CompilerGenerated]
		private bool _RunStoryScript_b__321_1();
		[CompilerGenerated]
		private void _EndStory_b__337_0();
		[CompilerGenerated]
		private void _Update_b__377_0();
		[CompilerGenerated]
		private bool _OpenContinueImpossibleDialog_b__418_0(CommonDialog d);
		[CompilerGenerated]
		private bool _OpenMultiQuestAutoFailDialog_b__420_0(CommonDialog d);
		[CompilerGenerated]
		private bool _OpenTimeupDialog_b__421_0(CommonDialog d);
	}
}
