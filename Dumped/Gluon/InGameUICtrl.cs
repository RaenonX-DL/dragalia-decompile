using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Dungeon;
using Gluon.Master;
using Gluon.PostEffectParams;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameUICtrl : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class InGameCanvasData
		{
			public InGameCanvas inGameCanvas;

			public RectTransform rootUI;

			public RectTransform buttonUI;
		}

		private MainGameCtrl mainGameCtrl;

		private MultiPlayManager.MultiType multiType;

		private CameraGroup _inGameUICameraGroup;

		private CameraGroup _mainCameraGroup;

		[SerializeField]
		private InGameCanvasData _noneRaycastCanvasData;

		[SerializeField]
		private InGameCanvasData _useRaycastCanvasData;

		[SerializeField]
		private InGameCanvasData _useRaycastCanvasTopData;

		[SerializeField]
		private InGameCanvasData _noneRaycastCanvasTopData;

		[SerializeField]
		private RectTransform charaUI;

		[SerializeField]
		private RectTransform touchUI;

		[SerializeField]
		private RectTransform markUI;

		[SerializeField]
		private RectTransform touchUITop;

		[SerializeField]
		private InGameGradationManager _gradationManager;

		[SerializeField]
		private InGameUIResourceManager _uiResourceManager;

		private GameObject enemyAttackReticle;

		private CharacterBase enemyAttackReticleTarget;

		private float enemyAttackReticleOffsetY;

		private bool enemyAttackReticleDisplayTimeFlg;

		private float enemyAttackReticleDisplayTime;

		private bool activeUI;

		private DamageUICtrl _damageUICtrl;

		private RectTransform dangerRect;

		private bool isDangerShow;

		private ComboUI comboUI;

		private GraphicRaycaster useRaycastCanvasRaycaster;

		[SerializeField]
		private RectTransform partyUI;

		private InGamePartyButtonUI[] _partyButtonUIArray;

		private InGamePartyCursorUI _partyCursorUI;

		private int _currentPartySlotIndex;

		private Dictionary<CharacterBase, int> _partySlotIndexDic;

		private Dictionary<InGameDef.SwitchPartyNoList, int> _partySlotNumDic;

		private Dictionary<int, int> _workPartyCharaRebornNumDic;

		private List<InGamePartyButtonUI> _workPartyButtonUIList;

		private RaidPlayerBase _otherRaidPartyInfoUI;

		private InGameSumUpTotalDamageInfoUI _sumUpTotalDamageInfoUI;

		private Dictionary<CharacterBase, CharacterMarkUI> _charaMarkDic;

		private List<ODCounterMarkUI> _odCounterMarkList;

		private Dictionary<CharacterBase, ODCounterMarkUI> _usedODCounterMarkDic;

		private Dictionary<GameObject, BarrelBombGaugeUI> barrelBombGaugeUIList;

		private CharaGimmickGaugeCtrl charaGimmickGaugeCtrl;

		private CharaGimmickInputCtrl charaGimmickInputCtrl;

		public ModeSelectButtonCtrl modeSelectButtonCtrl;

		private int[] partyOrder;

		[SerializeField]
		private float partyButtonMoveSec;

		private CharacterBase targetChara;

		public ShareSkillSelectButton shareSkillSelectButton;

		private DragonButton dragonButton;

		private DragonSelectButton dragonSelectButton;

		private UniqueTransButton uniqueTransButton;

		private SupportButton supportButton;

		private InventoryButton inventoryButton;

		private float statusInfoPageChangeTime;

		private const float statusInfoPageChangeDuration = 2f;

		private BootyInfoUIBase bootyUI;

		private CountDownUI countDownUI;

		private float countDownTime;

		private RebornCountDownUI rebornCountDownUI;

		private InGameSystemMsgUI systemMsgUI;

		private PlaceNameUI placeName;

		private PlaceNameRichUI placeNameRich;

		private GameObject menuButonObject;

		private Button menuButton;

		private RectTransform menuButtonRectTransform;

		private bool _isOpenMenuRequest;

		private bool isEnableBackKey;

		private bool activeMenu;

		private PlayerFootMark playerFootMark;

		private PlayFTU playFTU;

		private CharaDialogueCtrl charaDialogueCtrl;

		private StampUIInGame _stampUI;

		private EmotionIconCtrl emotionIconCtrl;

		private InGameFooterUI _footerUI;

		private CommonDialog _commonDialog;

		private CommonDialog.Param _commonDialogParam;

		private StrategyDialogBase _strategyDialog;

		private RetireConfirmDialogBase _retireConfirmDialog;

		private RetryVoteDialog _retryVoteDialog;

		private DmodeNextFloorConfirmDialog dmodeNextFloorConfirmDialog;

		private GameObject prefabHumanMark;

		private GameObject prefabDragonMark;

		private GameObject prefabEnemyMark;

		private GameObject prefabEnemyMarkSimple;

		private GameObject prefabBattlePortalUnitMark;

		private GameObject prefabDefenseUnitMark;

		public InGameBRInfoUI _brInfoUI;

		public InGameDmodeInfoUI dmodeInfoUI;

		public InGameScoringEventInfoUI scoringEventInfoUI;

		public InGameScoringEventCountDownUI scoringEventCountDownUI;

		private const bool changePartyButton = false;

		private const int maxBuffCaption = 15;

		private List<BuffCaption> activeBuffCaption;

		private List<BuffCaption> inactiveBuffCaption;

		private Tweener twBlinkAnim;

		private Tweener twChainSkillAnim;

		private Sequence seqHpGaugeShineAnim;

		public float moveValue;

		private Tweener moveTweener;

		private Tweener twSkillCutInComplete;

		public const float moveTime = 0.3f;

		public const float iPhoneXFooterMargin = 58f;

		public const float BRSystemMsgAdjustPosY = 70f;

		public FilterType beforeFilterType;

		private DmodeUsableItemsInGamePopup dmodeChooseDragonPU;

		private DmodeUsableItemsInGamePopup dmodeChooseSkillPU;

		public DmodeItemPopup dmodeItemPU;

		private TouchHandler touchHandler;

		private BossBreakUI bossGaugeUI;

		private PartBreakUI bossPartGaugeUI;

		private PartBreakUI.Param bossPartGaugeParam;

		private Dictionary<CharacterBase, string> enemyExtensionNameList;

		private CharacterBase[] partCharacter;

		private GameObject multiMarkPrefab;

		private Mesh[] multiMarkMeshArray;

		private List<PlayerFootMarkMulti> playerFootMarkMulti;

		private EnemySkillUI enemySkill;

		private EnemyAbilityUICtrl enemyAbilityUICtrl;

		private CharaCircleGaugeMiasmaUI bossMiasmaGaugeUI;

		public InGameBattleLogCtrl battleLogCtrl;

		private InGameBattleLogCtrl.LogData battleLogData;

		private bool isStartGame;

		private static readonly Dictionary<ElementalType, string> EnemySwitchElementFormatLabelDic;

		public CameraGroup inGameUICameraGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CameraGroup mainCameraGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InGameCanvas noneRaycastCanvas => null;

		public InGameCanvas useRaycastCanvas => null;

		public InGameCanvasData useRaycastCanvasData => null;

		public InGameCanvas useRaycastCanvasTop => null;

		public InGameCanvasData useRaycastCanvasTopData => null;

		public InGameCanvas noneRaycastCanvasTop => null;

		public bool IsShowSandTimerUI
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

		public bool IsShowCircleGaugeUI
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

		public bool IsVisibleCharaMarkUI
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

		public bool isVisibleBarrelBombGaugeUI
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

		public DefenseEventInfoCtrl defenseEventInfoCtrl
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

		public SkillInfo[] skillInfos
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

		public QuestSkillButtonBase questSkillButton
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

		public BootyInfoUIBase.ItemData bootyTotalItemData
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

		public BootyInfoUIBase.ItemData bootyItemData
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

		public bool IsOpenMenuRequest => default(bool);

		public bool IsOpendMenu
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

		public CharaFootMark charaFootMark
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

		public StampUIInGame stampUI => null;

		public InGameFooterUI FooterUI => null;

		public CommonDialog.Param CommonDialogParam => null;

		public MiniMapCtrl miniMapCtrl
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

		public AutoPlayUI autoPlayUI
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

		public WalkerQuestButton walkerQuestButton
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

		public bool IsLeftLayout => default(bool);

		public bool IsForceUIHiding
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

		public TouchHandler _TouchHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterBase bossCharacter
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

		public InGameEventExtendAtlasManager EventExtendAtlasManager
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

		public int GetCharaDialogueNumQueue()
		{
			return default(int);
		}

		public void Initialize()
		{
		}

		public void InitializeAfter()
		{
		}

		public void CharaDialogueInit()
		{
		}

		private void OnDestroy()
		{
		}

		public void PostInitialize()
		{
		}

		public void Release()
		{
		}

		public override void FastUpdate()
		{
		}

		private void LoadDamageSprites()
		{
		}

		private void LoadPrefabCharaMarks()
		{
		}

		private GameObject LoadPrefabPartyButton()
		{
			return null;
		}

		private GameObject LoadPrefabPartyCursor()
		{
			return null;
		}

		public void ShowDamageUI(CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount)
		{
		}

		private IEnumerator ShowDelayDamageUI(float delay, CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount)
		{
			return null;
		}

		public void ShowNoDamageUI(Vector3 position, DamageFigUI.NoDamageType noDamageType, Color color)
		{
		}

		public void ShowRecoverHP(int value, Vector3 position)
		{
		}

		public void ShowRecoverSP(int value, Vector3 position)
		{
		}

		public void ShowTotalDamage(CharacterBase character, int skillId)
		{
		}

		public void AddTotalDamage(CharacterBase character, int actionId, int skillId, int actionProductId, int damage, bool isHitCountDamage)
		{
		}

		public void ResetTotalDamage(CharacterBase character, int skillId)
		{
		}

		public void StopAllDamageUI()
		{
		}

		private void GenerateButton()
		{
		}

		public void LoadFooter(bool isLeft, bool isActive)
		{
		}

		private void InitializeFootMark()
		{
		}

		private void InitializeBooty()
		{
		}

		private void InitializeMenu()
		{
		}

		public void ActiveMenu(bool b)
		{
		}

		public void EnableMenu(bool b)
		{
		}

		public void OpenMenu()
		{
		}

		private void OpenMenuDialog()
		{
		}

		private bool IsEnableOpenDialog()
		{
			return default(bool);
		}

		private bool IsEnableOpenDialog(ref bool isOpenRequest)
		{
			return default(bool);
		}

		public void PreExecOpenDialog()
		{
		}

		public void PreExecCloseDialog()
		{
		}

		public void CloseDialog(bool isPlayCloseSE = false, bool ignoreRetryVoteDialog = false)
		{
		}

		private void OnRetryButtonPressedFromStrategyDialog()
		{
		}

		private void OnRetireButtonPressedFromStrategyDialog()
		{
		}

		private void OnCloseButtonPressedFromStrategyDialog()
		{
		}

		private void ExecCloseButtonPressedFromStrategyDialog()
		{
		}

		private void OnRetryButtonPressedFromConfirmDialog()
		{
		}

		private void OnRetryTopButtonPressedFromDmodeConfirmDialog()
		{
		}

		private void OnRetryFloorButtonPressedFromDmodeConfirmDialog()
		{
		}

		private void OnRetireButtonPressedFromConfirmDialog()
		{
		}

		private void OnCancelButtonPressedFromConfirmDialog()
		{
		}

		public bool IsEnableRetryButton(bool checkLastVote = false)
		{
			return default(bool);
		}

		public void OpenRetryVoteDialog(bool isOpenMyself = true)
		{
		}

		public void OpenDmodeNextFloorConfirmDialog(Action onClickNextFloorButton, Action onClickCancelButton)
		{
		}

		public void OnInventoryButtonPressedFromDmodeNextFloorConfirmDialog(Action onClose)
		{
		}

		public void OnSkillButtonPressedFromDmodeNextFloorConfirmDialog(Action onClose)
		{
		}

		public void OnNextFloorButtonPressedFromDmodeNextFloorConfirmDialog()
		{
		}

		public void OnCancelButtonPressedFromDmodeNextFloorConfirmDialog()
		{
		}

		private void ReleasePartyUI()
		{
		}

		private int EntryPartyUI(HumanCharacter human, DragonCharacter dragon, int entry, InGameDef.SwitchPartyNoList switchPartyNo, bool isMulti)
		{
			return default(int);
		}

		private int GetCharaMaxNumForPartyUI()
		{
			return default(int);
		}

		public int UpdatePartyUIGauge(CharacterBase chara, bool immediate = false)
		{
			return default(int);
		}

		public void UpdatePartyUIGauge(bool immediate = false)
		{
		}

		private void SetPartySlotIndex(int idx)
		{
		}

		public void UpdateFooterUIGauge(CharacterBase chara, bool isDamage, bool immediate = false)
		{
		}

		public int GetSlotPartyUI(CharacterBase chara)
		{
			return default(int);
		}

		public int GetCurrentPartySlotNum()
		{
			return default(int);
		}

		public void SetEnablePartyButton(bool isEnable)
		{
		}

		private void CreateChainSkillFrame()
		{
		}

		private void SetupChainSkillFrame()
		{
		}

		public void SetSkillInfoEnabled(bool b)
		{
		}

		private void InitializeMiniMap()
		{
		}

		private void InitializeAutoPlayUI(bool isEnable)
		{
		}

		private void InitializeWalkerQuestButton()
		{
		}

		private void SetEnableDof(bool enableDof)
		{
		}

		private void SetDofParameter(float dofValue)
		{
		}

		private void CreateBRInfUI()
		{
		}

		public void SetButtonAlignment()
		{
		}

		public void RealignmentPartyButton()
		{
		}

		private void OnMovePartyButtonInactive(MoveControlUI sender)
		{
		}

		public void RealignmentSkillButton()
		{
		}

		public void ApplyMembersInfo()
		{
		}

		public void ApplyMemberInfo(CharacterBase chara, bool isSelected = true)
		{
		}

		private void ApplyImagePartyButton(int index, CharacterBase chara)
		{
		}

		public void DisableSkillButton(int index, bool isDisable, bool isDisableGrayOut = true, bool isEnableReturnValue = true)
		{
		}

		private void ApplyImageSkillButton(PlayerCharacter player)
		{
		}

		public void ApplySkillButton(bool immediate = false)
		{
		}

		public void ApplyImageSupportButton()
		{
		}

		private void ApplyTransformButtonImage(bool immediate = true, bool withEffectAndSE = false)
		{
		}

		private void ApplyQuestSkillButton()
		{
		}

		public void ApplyBadgeIconForInventoryButton()
		{
		}

		public bool ApplyBadgeIconForInventoryButton(int itemId)
		{
			return default(bool);
		}

		public void VisibleBadgeIconForInventoryButton(bool b)
		{
		}

		private void ApplyFooterCharaIconButton()
		{
		}

		private void ApplyFooterChangeCharaIcon()
		{
		}

		private void ApplyRebornUI()
		{
		}

		public void ApplyDropItemPosition()
		{
		}

		private void AttachPlayerMark(CharacterBase chara, InGameDef.SwitchPartyNoList switchPartyNo, bool isSupportChara = false)
		{
		}

		public void AttachDragonMark(CharacterBase chara, InGameDef.SwitchPartyNoList switchPartyNo = InGameDef.SwitchPartyNoList.PartyNo1)
		{
		}

		public CharacterMarkUI AttachEnemyMark(CharacterBase chara)
		{
			return null;
		}

		private bool CanEntryEnemyMark(EnemyCharacter enemy, bool ignoreMultiWeak = false)
		{
			return default(bool);
		}

		public static bool IsNeedEnemyMark(EnemyCharacter enemy, bool ignoreMultiWeak = false)
		{
			return default(bool);
		}

		public void SetActiveEnemyMark(CharacterBase chara, bool isActive)
		{
		}

		private void EntryCharaMark(CharacterBase chara, CharacterMarkUI mark)
		{
		}

		public void RemoveCharaMark(CharacterBase chara)
		{
		}

		public CharacterMarkUI FindCharaMark(CharacterBase chara)
		{
			return null;
		}

		public void UpdateCharaMarkPosition(bool interpolation = true)
		{
		}

		public void VisibleCharaMark(bool visible)
		{
		}

		private void CreateODCounterMark()
		{
		}

		public void ShowODCounterMark(CharacterBase chara, Vector3 pos, Vector2 adjustPos2D)
		{
		}

		public void ShowODCounterMark(CharacterBase chara, Vector3 pos)
		{
		}

		public void HideODCounterMark(CharacterBase chara)
		{
		}

		public void CreateSandTimerUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void ShowSandTimerUI(int actorId)
		{
		}

		public void HideSandTimerUI()
		{
		}

		public void HideSandTimerUI(int actorId)
		{
		}

		public void SetSandTimerUICount(int actorId, int count)
		{
		}

		public void SetSandTimerUICountColor(int actorId, SandTimerUI.CountColorType type)
		{
		}

		public void CreateCircleGaugeElectrifiedUI()
		{
		}

		public void CreateCircleGaugeVirusUI()
		{
		}

		public void CreateCircleGaugeMultiWeakPointUI(CharacterBase owner)
		{
		}

		public void CreateCircleGaugeAbilityRebornUI(CharacterBase owner)
		{
		}

		public void CreateCircleGaugeDrasticForceUI(CharacterSelector selector)
		{
		}

		public void CreateCircleGaugeDrasticForceUI(CharacterBase owner)
		{
		}

		public void ShowCircleGaugeUI(CharacterSelector selector, CharaCircleGaugeUI.Type type)
		{
		}

		public void ShowCircleGaugeUI(CharacterBase chara, CharaCircleGaugeUI.Type type)
		{
		}

		public void HideCircleGaugeUI(CharacterSelector selector, CharaCircleGaugeUI.Type type)
		{
		}

		public void HideCircleGaugeUI(CharacterBase chara, CharaCircleGaugeUI.Type type)
		{
		}

		public void SetCircleGaugeUIGaugeTimer(CharacterSelector selector, CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public void SetCircleGaugeUIGaugeTimer(CharacterBase chara, CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public void SetCircleGaugeUICount(CharacterSelector selector, CharaCircleGaugeUI.Type type, int count)
		{
		}

		public void SetCircleGaugeUICount(CharacterBase chara, CharaCircleGaugeUI.Type type, int count)
		{
		}

		public void SetCircleGaugeUIAdjustPos(CharacterBase chara, CharaCircleGaugeUI.Type type, Vector3 pos)
		{
		}

		public void SetCircleGaugeUIAdjustScale(CharacterBase chara, CharaCircleGaugeUI.Type type, float scale)
		{
		}

		public BarrelBombGaugeUI CreateBarrelBombGaugeUI(GameObject owner)
		{
			return null;
		}

		private void EntryBarrelBombGaugeUI(GameObject owner, BarrelBombGaugeUI mark)
		{
		}

		public void RemoveBarrelBombGaugeUI(GameObject owner)
		{
		}

		public BarrelBombGaugeUI FindBarrelBombGaugeUI(GameObject owner)
		{
			return null;
		}

		public void VisibleBarrelBombGaugeUI(bool visible)
		{
		}

		public void CreateBossMiasmaGaugeUI()
		{
		}

		public void SetBossMiasmaGaugeUIGrayScale(bool b)
		{
		}

		public void SetBossMiasmaGaugeUIGaugeValue(float value, float maxValue, bool isForce = false)
		{
		}

		private void CreateDefenseQuestUI()
		{
		}

		public QuestSkillButtonBase CreateQuestSkillButtonUI(InGameUIConst.QuestSkillType type)
		{
			return null;
		}

		public void DeleteQuestSkillButton()
		{
		}

		public void ShowQuestSkillButton(bool isForce = false, bool isImmediate = false)
		{
		}

		public void HideQuestSkillButton(bool isForce = false, bool isImmediate = false)
		{
		}

		public void ChangeQuestSkillButton(int type, bool isImmediate = false)
		{
		}

		public void SetQuestSkillOnClick(Action onClick)
		{
		}

		public void SetQuestSkillOnClick(int type, Action onClick)
		{
		}

		public void SetDisplayingStampId(CharacterBase chara, int stampId)
		{
		}

		public int GetDisplayingStampId(CharacterBase chara)
		{
			return default(int);
		}

		public bool IsDisplayingStamp(CharacterBase chara)
		{
			return default(bool);
		}

		public void ValidateDragonButton(bool valid)
		{
		}

		public void ValidateSkillButton(bool valid)
		{
		}

		private void UpdateDisableByBuffState(PlayerCharacter player, int index)
		{
		}

		public void SetSkillValue(CharacterBase chara, bool immediate = false)
		{
		}

		public static bool GetOverChargeSkillData(CharacterBase chara, int skillIndex, out int phase, out int phaseSp, out int phaseConsumeSp)
		{
			return default(bool);
		}

		public void CheckCommonAnim()
		{
		}

		public void CheckCommonAnim(PlayerCharacter player)
		{
		}

		public void CreateBlinkAnim()
		{
		}

		public void OnUpdateBlinkAnim(float value)
		{
		}

		public void CreateChainSkillAnim()
		{
		}

		public void CreateHpGaugeShineAnim()
		{
		}

		public void OnUpdateBossHpGaugeShineBgFade(float value)
		{
		}

		public void OnUpdateBossHpGaugeShineGaugeFade(float value)
		{
		}

		public void OnUpdateBossHpGaugeShineLocalPosX(float value)
		{
		}

		public void OnUpdateHpGaugeShineGaugeFade(float value)
		{
		}

		public void OnUpdateHpGaugeShineLocalPosX(float value)
		{
		}

		public Vector2 GetSkillButtonPosition(int index)
		{
			return default(Vector2);
		}

		public Vector2 GetSkillButtonSize(int index)
		{
			return default(Vector2);
		}

		public Vector2 GetDragonButtonPosition()
		{
			return default(Vector2);
		}

		public Vector2 GetDragonButtonSize()
		{
			return default(Vector2);
		}

		public void DisplayCountDown(float countDownTime)
		{
		}

		public float GetRemainTime()
		{
			return default(float);
		}

		public void CreateRebornCountDown(bool isUnlimitReborn, int rebornNum)
		{
		}

		public void ShowRebornCountDown(int restRebornCount, int consumeRebornCount)
		{
		}

		public void SetRebornCountDownTime(float elapsed, float duration)
		{
		}

		public void HideRebornCountDown()
		{
		}

		public void PlayFooterRebornShowAnim()
		{
		}

		public void PlayFooterRebornConsumeAnim(int restRebornCount, [Optional] Action onComplete)
		{
		}

		public void SetPlayerRebornLifeCount(bool isUnlimitReborn, int count)
		{
		}

		protected bool GetPartyCharaRebornLifeCount(int playerNo, int rebornNum, ref Dictionary<int, int> rebornNumDic)
		{
			return default(bool);
		}

		public void SetPartyRebornLifeCountByOtherPlayer()
		{
		}

		public void SetPartyRebornTimeByOtherPlayer(CharacterBase owner, float elapsed, float duration)
		{
		}

		public void SetSumUpTotalDamage(long damage)
		{
		}

		public void OnEndDrop(DropItemElement.Type type, int value, bool isRare, bool isApplyBootyUI)
		{
		}

		private void UpdateTotalDrop()
		{
		}

		public bool IsEnablePlayerButton(bool checkState = false)
		{
			return default(bool);
		}

		private bool IsAlivePlayer()
		{
			return default(bool);
		}

		public void OnClickSkill(SkillInfo sender)
		{
		}

		public void OnClickSkill(int skillIndex, [Optional] Action onNextDisableAction, [Optional] DmodeDungeonItem dmodeItem)
		{
		}

		public void OnClickShareSkillSelect(ShareSkillSelectButton sender)
		{
		}

		public void OnClickSupportSkill(SupportButton sender)
		{
		}

		public void OnClickQuestSkill(QuestSkillButtonBase sender)
		{
		}

		public void OnClickQuestSkillEX(QuestSkillButtonBase sender)
		{
		}

		public void OnClickQuestSkillSelector(QuestSkillButtonBase sender)
		{
		}

		public void OnClickParty(CharacterBase chara, int index)
		{
		}

		private void OnClickChangePlayer()
		{
		}

		private bool CanChangePlayerCharacter()
		{
			return default(bool);
		}

		private void ChangePlayerCharacter(CharacterBase chara, int index)
		{
		}

		public void OnClickDragon(DragonButton sender)
		{
		}

		private void OnClickDragonForDmode(DmodeDungeonItem item)
		{
		}

		public void OnClickDragonSelect(DragonSelectButton sender)
		{
		}

		public void OnClickUniqueTrans(UniqueTransButton sender)
		{
		}

		public void OnClickMinimap()
		{
		}

		public void OnClickInventory(InventoryButton sender)
		{
		}

		private void OnRetryMenu()
		{
		}

		private void OnRetireMenu()
		{
		}

		public void SetBootyDPoint(int value, bool isShow)
		{
		}

		public void SetBootyDPointRare(int value, bool isShow)
		{
		}

		public void GetBootyPositionWeaponIcon(ref Vector3 _pos)
		{
		}

		public void GetBootyPositionSackIcon(ref Vector3 _pos)
		{
		}

		public void GetBootyPositionCoinIcon(ref Vector3 _pos)
		{
		}

		public void GetBootyPositionManaIcon(ref Vector3 _pos)
		{
		}

		public void GetBootyPositionAmuletIcon(ref Vector3 _pos)
		{
		}

		public void SetMoveIn(bool moveIn, float time = 0.3f)
		{
		}

		private void SetInputEnable(bool canvasRaycasterEnable, bool playerEnableInput)
		{
		}

		public void SetMoveInDirect(bool moveIn)
		{
		}

		public bool IsInsideUI()
		{
			return default(bool);
		}

		public bool IsOutsideUI()
		{
			return default(bool);
		}

		public void OnAreaChange()
		{
		}

		public void OnPostAreaChange()
		{
		}

		public float GetMovePosition(float outPosition)
		{
			return default(float);
		}

		public RectTransform GetCanvasRectTransform()
		{
			return null;
		}

		private void UpdatePartyUI()
		{
		}

		private void UpdateMenu()
		{
		}

		private void UpdateBuffCaption()
		{
		}

		private void StopAllBuffCaption()
		{
		}

		private void UpdateEnemyAttackReticle()
		{
		}

		private void UpdateDangerUI()
		{
		}

		private void UpdateDefenseQuestUI()
		{
		}

		private void UpdateRetryVoteDialog()
		{
		}

		private void UpdateBackKey()
		{
		}

		public bool IsShowUI(bool isIgnoreForceUIHide = false)
		{
			return default(bool);
		}

		public bool IsShowDangerUI()
		{
			return default(bool);
		}

		public void DispBuffCaption(CharacterBase chara, string text, BuffCaption.Param.DisplayIconType iconType = BuffCaption.Param.DisplayIconType.None, int iconElement = 0, string iconName = "", int conditionId = 0, float rate = 0f, bool isDisplayCheck = false, bool isSync = false, bool isDisplayCheckIncludeStack = false, AbilityConst.UnitType abilityOwnerUnit = AbilityConst.UnitType.None, int abilityOwnerId = 0)
		{
		}

		public void RemoveBuffCaption(CharacterBase chara, string text, AbilityConst.UnitType abilityOwnerUnit = AbilityConst.UnitType.None, int abilityOwnerId = 0)
		{
		}

		public BuffCaption GetBuffCaption(CharacterBase chara)
		{
			return null;
		}

		public bool IsDisplayBuffCaption(CharacterBase chara, string text = "", bool isIncludeStack = false, AbilityConst.UnitType abilityOwnerUnit = AbilityConst.UnitType.None, int abilityOwnerId = 0)
		{
			return default(bool);
		}

		public void SetBuffCaptionCharacter(CharacterBase chara, CharacterBase newChara)
		{
		}

		public void DispCancelDragonTransform(CharacterSelector selector)
		{
		}

		public void DispCancelUniqueTransform(CharacterBase chara)
		{
		}

		public void SetActiveMarkUI(bool active)
		{
		}

		public void InitialiseSystemMessage()
		{
		}

		public void SystemMessagePrologueAdjustPosY(float adjustPosY)
		{
		}

		public void DisplaySystemMessage(string text, float tm = 3f, bool isQueueing = true)
		{
		}

		public bool IsDisplayingSystemMessage(string msg = "")
		{
			return default(bool);
		}

		public InGameSystemMsgUI.MessageStatus GetSystemMessageCurrentStatus()
		{
			return default(InGameSystemMsgUI.MessageStatus);
		}

		public bool IsDisplayingSystemMessage_forGameSystemMsgUI(string msg = "")
		{
			return default(bool);
		}

		public void OpenSystemMessage(string text, bool se)
		{
		}

		public void CloseSystemMessage()
		{
		}

		public RectTransform GetStampButtonArrangementTransform()
		{
			return null;
		}

		public void SetEnableMenuBackkey(bool enabled)
		{
		}

		public void SetActiveUI(bool isActive)
		{
		}

		public void SetActiveFooterUI(bool isActive)
		{
		}

		public void SetForceUIHiding(bool isHide, bool isForce = false)
		{
		}

		public void OnUpdateCameraModeExtra()
		{
		}

		private void ChangeCharaGimmick(CharacterBase chara)
		{
		}

		public void ShowCharaGimmickGauge(CharacterBase chara)
		{
		}

		public void HideCharaGimmickGauge(CharacterBase chara, bool isOnlyOverflow = false)
		{
		}

		public void HideCharaGimmickGauge()
		{
		}

		private bool IsOverflowGauge(CharacterBase chara)
		{
			return default(bool);
		}

		public void ShowCharaGimmickInput(CharacterBase chara)
		{
		}

		public void HideCharaGimmickInput(CharacterBase chara, bool anim = true)
		{
		}

		public bool IsVisibleGimmickInput(CharacterBase chara)
		{
			return default(bool);
		}

		public void HideCharaGimmickInput(bool anim = true)
		{
		}

		public void AttachCharaGimmickGauge(CharacterBase chara, CharaGimmickGaugeCtrl.GaugeType type)
		{
		}

		public void AttachCharaGimmickGauge(CharacterBase chara)
		{
		}

		public void AttachCharaGimmickInput(CharacterBase chara)
		{
		}

		public void AttachCharaGimmickInputReserveDragon(CharacterSelector selector)
		{
		}

		public void AttachCharaGimmickInputDynamicSkill(CharacterBase chara, List<int> skillIdList)
		{
		}

		public void SetCharaGimmickGaugeValue(CharacterBase chara, int idx, int value, int consumeValue, int maxValue, float delay = 0f, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false)
		{
		}

		public void SetCharaGimmickModeGaugeMode(CharacterBase chara, int mode)
		{
		}

		public void SetCharaGimmickGaugeAnimCompleteCallback(CharacterBase chara, CharacterCustomPointController ctrl, int idx, Action<int> onComplete)
		{
		}

		public void SetCharaGimmickGaugeAnimCompleteCallback(CharacterBase chara, CharacterCustomPointController ctrl, int idx, Action<int, int, int> onComplete)
		{
		}

		public float GetCharaGimmickGaugeMoveTime(CharacterBase chara)
		{
			return default(float);
		}

		public void ChangeCharaGimmickAppearance(CharacterBase chara, int type)
		{
		}

		public void SetCharaGimmickGaugeAbilityData(CharacterBase chara, ref List<AbilityDataElement> list)
		{
		}

		public void SetCharaGimmickAdditionalInputCount(CharacterBase chara, int num, bool force = false, bool immediate = false)
		{
		}

		public static float GetIPhoneXFooterMargin()
		{
			return default(float);
		}

		public string RegistEnemyExtensionName(EnemyCharacter enemy)
		{
			return null;
		}

		public string GetEnemyExtensionName(EnemyCharacter enemy, bool isGaugeName = false)
		{
			return null;
		}

		public void RemoveEnemyExtensionName(EnemyCharacter enemy)
		{
		}

		public CharacterSelector GetOriginalPlayerSelector()
		{
			return null;
		}

		public PlayerCharacter GetOriginalPlayerChara()
		{
			return null;
		}

		public bool IsOriginalPlayerChara(CharacterBase chara)
		{
			return default(bool);
		}

		public void UpdatePartySwitch(List<HumanCharacter> currMemberList, List<HumanCharacter> nextMemberList)
		{
		}

		public static bool IsTutorialMidgardsormr(ref CharacterBase chara)
		{
			return default(bool);
		}

		public static bool GetQuestData(out QuestDataElement qde)
		{
			return default(bool);
		}

		public static bool GetQuestId(out int questId, out int questGroupId)
		{
			return default(bool);
		}

		public static bool GetQuestOverrideView(out QuestOverrideViewElement ove)
		{
			return default(bool);
		}

		public static bool CheckChangeDecorationSackIcon(QuestDataElement qde, out InGameUIConst.DecorationType decorationType)
		{
			return default(bool);
		}

		public static bool CheckChangeDecorationHpGauge(QuestDataElement qde, out InGameUIConst.DecorationType decorationType)
		{
			return default(bool);
		}

		public static bool CheckChangeDecorationFTU(QuestDataElement qde, out string dirName)
		{
			return default(bool);
		}

		public static bool CheckChangeDecorationQuestFailureSe(QuestDataElement qde, out string seName)
		{
			return default(bool);
		}

		public static bool GetDecorationTypeFromDefenseQuest(QuestDataElement qde, out InGameUIConst.DecorationType decorationType)
		{
			return default(bool);
		}

		public static int GetDecorationType(QuestDataElement qde)
		{
			return default(int);
		}

		public void CreateBattleLogUI(bool isLeft)
		{
		}

		public void StartBattleLogUI()
		{
		}

		public void AddBattleLogUIByEnemyDefeated(string winnerCharaName, string loserCharaName)
		{
		}

		public void AddBattleLogUIByEnemyDefeated(string winnerCharaName, EnemyCharacter enemy)
		{
		}

		public void AddBattleLogUIByWeaponEnhancement(string charaName, int level)
		{
		}

		public void AddBattleLogUIByRemainingNumber(int num)
		{
		}

		public void AddBattleLogUIByDmodeDropItem(DmodeDungeonDropItemParam param)
		{
		}

		private void UpdateStatusInfoUI()
		{
		}

		private void SetStatusInfoUIChangePage()
		{
		}

		public void CreateScoringEventInfoUI(bool isLeft)
		{
		}

		public void CreateScoringEventCountDownUI()
		{
		}

		public static string GetCharaName(CharacterBase chara)
		{
			return null;
		}

		public static string GetEnemyBaseName(EnemyCharacter enemy, bool isGaugeName = false)
		{
			return null;
		}

		public static int GetFloat2PercentInt(float value)
		{
			return default(int);
		}

		public static string GetFloat2PercentText(float value)
		{
			return null;
		}

		public static string GetFloat2PercentFormatText(string text, float v, bool abs = true)
		{
			return null;
		}

		public static string GetDurationNumText(string name, int count, bool isMax)
		{
			return null;
		}

		public static bool GetDurationNumText(int conditionId, int count, bool isMax, out string text)
		{
			return default(bool);
		}

		private void InitializeStick()
		{
		}

		public void DisplayTap()
		{
		}

		public void DisplaySwipe()
		{
		}

		public void DisplayCharge(bool value)
		{
		}

		public void DisplayChargeEnd()
		{
		}

		public void ForceInputBurst()
		{
		}

		public void ResetInput()
		{
		}

		public void DisplayEffectClickButton()
		{
		}

		public void ApplyFlickSensitivity()
		{
		}

		public void InitializeNotify()
		{
		}

		private void ReceiveNotificationPlayer(CharacterBase sender, NotifyCharacter.NoticeType notice, object param)
		{
		}

		private void ReceiveNotificationCharacter(CharacterBase sender, NotifyCharacter.NoticeType notice, object param)
		{
		}

		private void ReceiveNotificationOther(CharacterBase sender, NotifyCharacter.NoticeType notice, object param)
		{
		}

		private void ReceiveNotificationBoss(CharacterBase sender, NotifyCharacter.NoticeType notice, object param)
		{
		}

		private void ReceiveNotificationObject(DungeonObjectBase sender, NotifyDungeonObject.NoticeType notice, object param)
		{
		}

		public BossBreakUI GetBossGaugeUI()
		{
			return null;
		}

		public bool IsVisibleBossGaugeUI()
		{
			return default(bool);
		}

		public void ShowBossGaugeUI(EnemyCharacter enemy)
		{
		}

		public void CloseBossGaugeUI(CharacterBase sender)
		{
		}

		public void SetBossGaugeUIBreakGaugeValue(CharacterBase sender, float rate, bool immediate = false)
		{
		}

		public void SetBossPartGaugeUIForType(CharacterBase sender, int type, float rate, bool immediate = false)
		{
		}

		private void ApplyBossPartGaugeUI(CharacterBase part)
		{
		}

		private void ApplyTransformButtonValue(bool immediate = true, bool withEffectAndSE = true)
		{
		}

		public void SetActionDragonPointMax(Action onMaxDP)
		{
		}

		private void SetPlayerNo()
		{
		}

		public static int GetOwnPlayerNo()
		{
			return default(int);
		}

		private void PlayerFootMarkMultiVisible(CharacterBase chara, bool visible)
		{
		}

		public void SetCurrentPlayerMark(bool on)
		{
		}

		private void DisplayDragonTimer(DragonCharacter dragon)
		{
		}

		public void SetDragonTimeValue(DragonCharacter dragon, bool immediate)
		{
		}

		public bool IsDragonDamageAnimation(DragonCharacter dragon)
		{
			return default(bool);
		}

		public void DisplayDragonTimerForMulti(DragonCharacter dragon)
		{
		}

		public static Sequence GetPauseSequence()
		{
			return null;
		}

		public static void StopTweener(ref Tweener tweener, bool complete = false)
		{
		}

		public static void StopSequence(ref Sequence sequence, bool complete = false)
		{
		}

		public static void VisibleUIObj(RectTransform rt, bool value)
		{
		}

		public static void VisibleUIObj(Transform rt, bool value)
		{
		}

		public float GetScaleFactor()
		{
			return default(float);
		}

		public Vector2 GetCanvasSize()
		{
			return default(Vector2);
		}

		public Vector2 WorldToScreen(Vector3 pos)
		{
			return default(Vector2);
		}

		public static void SetSortingLayer(GameObject obj, string layer)
		{
		}

		public static void SetSortingLayerInCanvas(Canvas cv, string layer)
		{
		}

		public void OpenCommonDialog()
		{
		}

		public void EnableTouchUI(bool enable)
		{
		}

		public bool IsPlaceNameOpened()
		{
			return default(bool);
		}

		public void ClosePlaceName()
		{
		}

		public void GetBossGaugeUIGaugeEffectPos(ref Vector3 pos)
		{
		}

		public void GetBossGaugeUIRaidFishGradeEffectPos(ref Vector3 pos)
		{
		}

		public void GetSkillButtonPos(ref Vector3 pos)
		{
		}

		public void GetTutorialReactionPos(ref Vector3 pos)
		{
		}

		public void SetTutorialReactionFlip(ref Vector3 scale)
		{
		}

		public void GetDragonButtonPos(ref Vector3 pos, [Optional] Vector2? scale)
		{
		}

		public void DispEnemySkill(string param)
		{
		}

		public void EntryEnemyAbility(List<EnemyAbilityProcBase> abilities)
		{
		}

		public void OpenEnemyAbility(List<EnemyAbilityProcBase> abilities)
		{
		}

		public void CloseEnemyAbility()
		{
		}

		public void EnableEnemyAbility(int id)
		{
		}

		public void DisableEnemyAbility(int id)
		{
		}

		public EnemyAbilityUI GetEnemyAbility(int id)
		{
			return null;
		}

		public Material GetEnemyAbilityIcon(string iconId)
		{
			return null;
		}

		public void PlayQuestEffect(PlayFTU.Type type, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label, bool isRemove = true)
		{
		}

		public void PlayQuestEffectNumber(PlayFTU.Type type, int value, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label, bool isRemove = true)
		{
		}

		public bool PlayQuestEffectCharaSpecific(CharacterBase chara, PlayFTU.CharaSpecificFlashType csfType, bool isRemove, PlayFTU.CharaSpecificFlashAlignment csfAlign = PlayFTU.CharaSpecificFlashAlignment.Auto, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label)
		{
			return default(bool);
		}

		public bool PlayQuestEffectCharaSpecific(CharacterBase chara, string fileName, bool isRemove, PlayFTU.CharaSpecificFlashAlignment csfAlign = PlayFTU.CharaSpecificFlashAlignment.Auto, [Optional] Action<PlayFTU> endFunc, bool isKeeping = false, [Optional] string label)
		{
			return default(bool);
		}

		public void PlayQuestEffectMotionIndex(PlayFTU.Type type, string label, int playMotionIdx)
		{
		}

		public bool IsPlayingQuestEffect(PlayFTU.Type type)
		{
			return default(bool);
		}

		public void StopQuestEffect(PlayFTU.Type type)
		{
		}

		public void PreloadQuestEffect(PlayFTU.Type type, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void PreloadQuestEffectChangePlayer([Optional] Action<PlayFTU> endFunc)
		{
		}

		public void PreloadQuestEffectCharaSpecific(CharacterBase chara, string fileName, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void PreloadQuestEffectSkillCuttInReserveDragon(CharacterSelector selector)
		{
		}

		public void ReleaseQuestEffect(PlayFTU.Type type)
		{
		}

		public void PlayQuestEffectSkillCuttInCharacter(CharacterBase sender, NotifyCharacter.SkillCutInParam param)
		{
		}

		public void PlayQuestEffectSkillCuttInDragon(CharacterBase sender, NotifyCharacter.SkillCutInParam param)
		{
		}

		public void PlayQuestEffectBreak(CharacterBase sender, float param)
		{
		}

		public void StopQuestEffectBreak(CharacterBase sender)
		{
		}

		public void PlayQuestEffectOverdrive(CharacterBase sender)
		{
		}

		public void StopQuestEffectOverdrive(CharacterBase sender)
		{
		}

		public void PlayQuestEffectBerserk(CharacterBase sender)
		{
		}

		public void StopQuestEffectBerserk(CharacterBase sender)
		{
		}

		public void PlayQuestEffectWaveStart(int waveCount, int maxWaveCount)
		{
		}

		public void PlayQuestEffectBooty(PlayFTU.Type type, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void PlayQuestInstanceEffect(PlayFTU.FlashInstanceType type, Vector2 pos, [Optional] Transform parent, bool isForcePlay = false)
		{
		}

		public void PlayQuestInstanceEffectNumber(PlayFTU.FlashInstanceType type, int value, Vector2 pos, [Optional] Transform parent, [Optional] Transform trackingTransform, float trackingTransformOffsetY = 0f, bool isForcePlay = false)
		{
		}

		public void PlayQuestEffectRaidFishGrade(int grade, [Optional] Action<PlayFTU> endFunc)
		{
		}

		public void PlayQuestEffectDefenseEventInfo(string desc, DefenseEventIconType type, Action<DefenseEventIconType, int> endFunc)
		{
		}

		public void PlayQuestEffectDefenseEventInfo(string desc, int nextAreaMessage, List<PlayFTU.MaterialInfo> materialInfoList, Action<DefenseEventIconType, int> endFunc)
		{
		}

		public void PlayQuestEffectPartySwitch(List<HumanCharacter> currMemberList, List<HumanCharacter> nextMemberList, Action endFunc)
		{
		}

		public void OpenPlaceName(NotifyCharacter.OpenPlaceNameParam param)
		{
		}

		public CharacterBase GetPartCharacter(int index)
		{
			return null;
		}

		public string GetFloorText(int index)
		{
			return null;
		}

		public static void NotifyBuffDebuffStatusChange(CharacterBase chara)
		{
		}

		public void SetPause(bool isPause)
		{
		}

		public void SetDangerActive(bool isActive)
		{
		}

		public void BeginEnemyAttackReticle(CharacterBase c, Vector3 offsetPos, float displayTime = 0f)
		{
		}

		public void EndEnemyAttackReticle()
		{
		}

		public InGameEventExtendAtlasManager CreateEventExtendAtlasManager(InGameUIConst.DecorationType type)
		{
			return null;
		}

		public string GetTeamColorStr(int actorId)
		{
			return null;
		}

		private void TryShowGoToSoloPlay()
		{
		}

		public static Sprite CreateSprite(Material material)
		{
			return null;
		}

		public static bool CreateSprite(ref Material originMaterial, float spriteWidth, float spriteHeight, bool isCrippingRect, out Sprite sprite, out Material material)
		{
			return default(bool);
		}

		public static bool CreateSprite(ref Material originMaterial, bool isCrippingRect, out Sprite sprite, out Material material)
		{
			return default(bool);
		}

		public static bool SetSprite(SpriteRenderer obj, Sprite sprite, Material material)
		{
			return default(bool);
		}

		public static void SetupObjectSortingOrder(GameObject obj, int sortingOrder, out Canvas canvas, out GraphicRaycaster ray)
		{
		}

		public static void SetupObjectSortingOrder(GameObject obj, int sortingOrder, out Canvas canvas)
		{
		}

		public static int GetDigit(int num)
		{
			return default(int);
		}

		public static int GetDigit(long num)
		{
			return default(int);
		}

		public static bool HasEnhanceGaugeOfDragonTransform(CharacterBase chara)
		{
			return default(bool);
		}

		public static bool HasEnhanceGaugeOfUniqueTransform(DragonCharacter dragon)
		{
			return default(bool);
		}

		public static bool GetEnemySwitchElementText(EnemyCharacter enemy, out string text)
		{
			return default(bool);
		}

		public static bool GetEnemySwitchElementFormatText(ElementalType element, out string text)
		{
			return default(bool);
		}

		public static void SetAnimFade(SpriteRenderer sprite, float fade)
		{
		}

		public static void SetAnimFade(Image image, float fade)
		{
		}

		public static void SetAnimFade(Text text, float fade)
		{
		}

		public static void SetAnimColor(SpriteRenderer sprite, Color color)
		{
		}

		public static void SetAnimPos(Transform trans, Vector3 pos)
		{
		}

		public static void SetAnimPosX(Transform trans, float posX)
		{
		}

		public static void SetAnimPosY(Transform trans, float posY)
		{
		}

		public static void SetAnimScale(Transform trans, float scale)
		{
		}

		public static void SetAnimScale(Transform trans, Vector3 scale)
		{
		}

		public static void SetAnimScaleY(Transform trans, float scaleY)
		{
		}

		public static void SetAnimRotZ(Transform trans, float rotZ)
		{
		}

		public static void OnUpdateAnimFade(SpriteRenderer sprite, float to, float from, float t)
		{
		}

		public static void OnUpdateAnimFade(Text text, float to, float from, float t)
		{
		}

		public static void OnUpdateAnimColor(SpriteRenderer sprite, Color to, Color from, float t)
		{
		}

		public static void OnUpdateAnimPos(Transform trans, Vector3 to, Vector3 from, float t)
		{
		}

		public static void OnUpdateAnimPosX(Transform trans, float to, float from, float t)
		{
		}

		public static void OnUpdateAnimPosY(Transform trans, float to, float from, float t)
		{
		}

		public static void OnUpdateAnimScale(Transform trans, float to, float from, float t)
		{
		}

		public static void OnUpdateAnimScale(Transform trans, Vector3 to, Vector3 from, float t)
		{
		}

		public static void OnUpdateAnimRotZ(Transform trans, float to, float from, float t)
		{
		}
	}
}
