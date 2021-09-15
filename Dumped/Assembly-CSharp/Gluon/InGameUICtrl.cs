/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Dungeon;
using Gluon.Master;
using Gluon.PostEffectParams;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameUICtrl : FastUpdateMonoBehaviour
	{
		// Fields
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
		private Dictionary<CharacterBase, CharacterMarkUI> _charaMarkDic;
		private List<ODCounterMarkUI> _odCounterMarkList;
		private Dictionary<CharacterBase, ODCounterMarkUI> _usedODCounterMarkDic;
		[CompilerGenerated]
		private bool _IsShowSandTimerUI_k__BackingField;
		[CompilerGenerated]
		private bool _IsShowCircleGaugeUI_k__BackingField;
		[CompilerGenerated]
		private bool _IsVisibleCharaMarkUI_k__BackingField;
		private Dictionary<GameObject, BarrelBombGaugeUI> barrelBombGaugeUIList;
		[CompilerGenerated]
		private bool _isVisibleBarrelBombGaugeUI_k__BackingField;
		private CharaGimmickGaugeCtrl charaGimmickGaugeCtrl;
		private CharaGimmickInputCtrl charaGimmickInputCtrl;
		public ModeSelectButtonCtrl modeSelectButtonCtrl;
		[CompilerGenerated]
		private DefenseEventInfoCtrl _defenseEventInfoCtrl_k__BackingField;
		private int[] partyOrder;
		[SerializeField]
		private float partyButtonMoveSec;
		private CharacterBase targetChara;
		[CompilerGenerated]
		private SkillInfo[] _skillInfos_k__BackingField;
		private DragonButton dragonButton;
		private UniqueTransButton uniqueTransButton;
		private SupportButton supportButton;
		[CompilerGenerated]
		private QuestSkillButtonBase _questSkillButton_k__BackingField;
		public QuestSkillButtonBase.Param questSkillButtonParam;
		public Action onClickQuestSkillButton;
		private float statusInfoPageChangeTime;
		private const float statusInfoPageChangeDuration = 2f;
		private BootyUI bootyUI;
		[CompilerGenerated]
		private BootyUI.ItemData _bootyTotalItemData_k__BackingField;
		[CompilerGenerated]
		private BootyUI.ItemData _bootyItemData_k__BackingField;
		private CountDownUI countDownUI;
		private float countDownTime;
		private RebornCountDownUI rebornCountDownUI;
		private InGameSystemMsgUI systemMsgUI;
		private PlaceNameUI placeName;
		private PlaceNameRichUI placeNameRich;
		private GameObject menuButonObject;
		private Button menuButton;
		private RectTransform menuButtonRectTransform;
		[CompilerGenerated]
		private bool _IsOpenMenuRequest_k__BackingField;
		[CompilerGenerated]
		private bool _IsOpendMenu_k__BackingField;
		private bool isEnableBackKey;
		private bool activeMenu;
		private PlayerFootMark playerFootMark;
		[CompilerGenerated]
		private CharaFootMark _charaFootMark_k__BackingField;
		private PlayFTU playFTU;
		private CharaDialogueCtrl charaDialogueCtrl;
		private StampUIInGame _stampUI;
		private EmotionIconCtrl emotionIconCtrl;
		private InGameFooterUI _footerUI;
		private RaidPlayerBase raidPlayer;
		private CommonDialog _commonDialog;
		private CommonDialog.Param _commonDialogParam;
		private StrategyDialog _strategyDialog;
		private StrategyDialog.Param _strategyDialogParam;
		private RetireConfirmDialog _retireConfirmDialog;
		private RetireConfirmDialog.Param _retireConfirmDialogParam;
		private RetryVoteDialog _retryVoteDialog;
		private GameObject prefabHumanMark;
		private GameObject prefabDragonMark;
		private GameObject prefabEnemyMark;
		private GameObject prefabBattlePortalUnitMark;
		private GameObject prefabDefenseUnitMark;
		[CompilerGenerated]
		private MiniMapCtrl _miniMapCtrl_k__BackingField;
		[CompilerGenerated]
		private AutoPlayUI _autoPlayUI_k__BackingField;
		[CompilerGenerated]
		private WalkerQuestButton _walkerQuestButton_k__BackingField;
		public InGameBRInfoUI _brInfoUI;
		public InGameScoringEventInfoUI scoringEventInfoUI;
		public InGameScoringEventCountDownUI scoringEventCountDownUI;
		private const bool changePartyButton = false;
		[CompilerGenerated]
		private bool _IsForceUIHiding_k__BackingField;
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
		private TouchHandler touchHandler;
		private BossBreakUI bossGaugeUI;
		private PartBreakUI bossPartGaugeUI;
		private PartBreakUI.Param bossPartGaugeParam;
		private Dictionary<CharacterBase, string> enemyExtensionNameList;
		[CompilerGenerated]
		private CharacterBase _bossCharacter_k__BackingField;
		private CharacterBase[] partCharacter;
		private GameObject multiMarkPrefab;
		private Mesh[] multiMarkMeshArray;
		private List<PlayerFootMarkMulti> playerFootMarkMulti;
		private EnemySkillUI enemySkill;
		private EnemyAbilityUICtrl enemyAbilityUICtrl;
		private CharaCircleGaugeMiasmaUI bossMiasmaGaugeUI;
		public InGameBattleLogCtrl battleLogCtrl;
		private InGameBattleLogCtrl.LogData battleLogData;
		[CompilerGenerated]
		private InGameEventExtendAtlasManager _EventExtendAtlasManager_k__BackingField;
		private bool isStartGame;
		private static readonly Dictionary<ElementalType, string> EnemySwitchElementFormatLabelDic;
	
		// Properties
		public CameraGroup inGameUICameraGroup { get; set; }
		public CameraGroup mainCameraGroup { get; set; }
		public InGameCanvas noneRaycastCanvas { get; }
		public InGameCanvas useRaycastCanvas { get; }
		public InGameCanvasData useRaycastCanvasData { get; }
		public InGameCanvas useRaycastCanvasTop { get; }
		public InGameCanvasData useRaycastCanvasTopData { get; }
		public InGameCanvas noneRaycastCanvasTop { get; }
		public bool IsShowSandTimerUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsShowCircleGaugeUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsVisibleCharaMarkUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isVisibleBarrelBombGaugeUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DefenseEventInfoCtrl defenseEventInfoCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public SkillInfo[] skillInfos { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestSkillButtonBase questSkillButton { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BootyUI.ItemData bootyTotalItemData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BootyUI.ItemData bootyItemData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsOpenMenuRequest { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsOpendMenu { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharaFootMark charaFootMark { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public StampUIInGame stampUI { get; }
		public InGameFooterUI FooterUI { get; }
		public CommonDialog.Param CommonDialogParam { get; }
		public MiniMapCtrl miniMapCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AutoPlayUI autoPlayUI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public WalkerQuestButton walkerQuestButton { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsLeftLayout { get; }
		public bool IsForceUIHiding { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public TouchHandler _TouchHandler { get; set; }
		public CharacterBase bossCharacter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public InGameEventExtendAtlasManager EventExtendAtlasManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		public class InGameCanvasData
		{
			// Fields
			public InGameCanvas inGameCanvas;
			public RectTransform rootUI;
			public RectTransform buttonUI;
	
			// Constructors
			public InGameCanvasData();
		}
	
		[CompilerGenerated]
		private sealed class _ShowDelayDamageUI_d__202 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InGameUICtrl __4__this;
			public float delay;
			public CharacterBase character;
			public int value;
			public Vector3 position;
			public bool isCritical;
			public bool isDragon;
			public DamageNumUI.DamageType damageType;
			public DamageNumUI.Target target;
			public bool isRaid;
			public bool isAttackControlPlayer;
			public bool isTotalDamage;
			public int totalDamageIndex;
			public bool isDebuffExtraDamage;
			public AbnormalStatusType abnormalStatusType;
			public CharacterBuffType buffType;
			public int buffIconId;
			public bool isHitCount;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowDelayDamageUI_d__202(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass370_0
		{
			// Fields
			public bool prevCanvasRaycasterEnable;
			public bool prevPlayerEnableInput;
			public InGameUICtrl __4__this;
	
			// Constructors
			public __c__DisplayClass370_0();
	
			// Methods
			internal void _SetMoveIn_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass370_1
		{
			// Fields
			public bool prevCanvasRaycasterEnable;
			public bool prevPlayerEnableInput;
			public InGameUICtrl __4__this;
	
			// Constructors
			public __c__DisplayClass370_1();
	
			// Methods
			internal void _SetMoveIn_b__5();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<BuffCaption> __9__380_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UpdateBuffCaption_b__380_0(BuffCaption item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass561_0
		{
			// Fields
			public NotifyCharacter.SkillCutInParam skillParam;
			public InGameUICtrl __4__this;
	
			// Constructors
			public __c__DisplayClass561_0();
	
			// Methods
			internal void _PlayQuestEffectSkillCuttInCharacter_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass562_0
		{
			// Fields
			public NotifyCharacter.SkillCutInParam skillParam;
			public InGameUICtrl __4__this;
	
			// Constructors
			public __c__DisplayClass562_0();
	
			// Methods
			internal void _PlayQuestEffectSkillCuttInDragon_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass574_0
		{
			// Fields
			public Action<DefenseEventIconType, int> endFunc;
			public DefenseEventIconType type;
	
			// Constructors
			public __c__DisplayClass574_0();
	
			// Methods
			internal void _PlayQuestEffectDefenseEventInfo_b__0(PlayFTU PlayFTU);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass575_0
		{
			// Fields
			public Action<DefenseEventIconType, int> endFunc;
			public int nextAreaMessage;
	
			// Constructors
			public __c__DisplayClass575_0();
	
			// Methods
			internal void _PlayQuestEffectDefenseEventInfo_b__0(PlayFTU PlayFTU);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass576_0
		{
			// Fields
			public Action endFunc;
	
			// Constructors
			public __c__DisplayClass576_0();
	
			// Methods
			internal void _PlayQuestEffectPartySwitch_b__0(PlayFTU PlayFTU);
		}
	
		// Constructors
		public InGameUICtrl();
		static InGameUICtrl();
	
		// Methods
		public int GetCharaDialogueNumQueue();
		public void Initialize();
		public void InitializeAfter();
		public void CharaDialogueInit();
		private void OnDestroy();
		public void PostInitialize();
		public void Release();
		public override void FastUpdate();
		private void LoadDamageSprites();
		private void LoadPrefabCharaMarks();
		private GameObject LoadPrefabPartyButton();
		private GameObject LoadPrefabPartyCursor();
		public void ShowDamageUI(CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount);
		[IteratorStateMachine]
		private IEnumerator ShowDelayDamageUI(float delay, CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount);
		public void ShowNoDamageUI(Vector3 position, DamageFigUI.NoDamageType noDamageType, Color color);
		public void ShowRecoverHP(int value, Vector3 position);
		public void ShowRecoverSP(int value, Vector3 position);
		public void ShowTotalDamage(CharacterBase character, int skillId);
		public void AddTotalDamage(CharacterBase character, int actionId, int skillId, int actionProductId, int damage, bool isHitCountDamage);
		public void ResetTotalDamage(CharacterBase character, int skillId);
		public void StopAllDamageUI();
		private void GenerateButton();
		public void LoadFooter(bool isLeft, bool isActive);
		private void ApplyFooterChangeCharaIcon();
		private void InitializeFootMark();
		private void InitializeBooty();
		private void InitializeMenu();
		public void ActiveMenu(bool b);
		public void EnableMenu(bool b);
		public void OpenMenu();
		private void OpenMenuDialog();
		public void CloseMenuDialog(bool isPlayCloseSE = false, bool ignoreRetryVoteDialog = false);
		private void OnRetryButtonPressedFromStrategyDialog(StrategyDialog sender);
		private void OnRetireButtonPressedFromStrategyDialog(StrategyDialog sender);
		private void OnCloseButtonPressedFromStrategyDialog(StrategyDialog sender);
		private void ExecCloseButtonPressedFromStrategyDialog();
		private void OnRetryButtonPressedFromConfirmDialog(RetireConfirmDialog sender);
		private void OnRetireButtonPressedFromConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromConfirmDialog(RetireConfirmDialog sender);
		public bool IsEnableRetryButton(bool checkLastVote = false);
		public void OpenRetryVoteDialog(bool isOpenMyself = true);
		private void InitializePartyUI();
		private void ReleasePartyUI();
		private int EntryPartyUI(HumanCharacter human, DragonCharacter dragon, int entry, InGameDef.SwitchPartyNoList switchPartyNo, bool isMulti);
		public int UpdatePartyUIGauge(CharacterBase chara, bool immediate = false);
		public void UpdatePartyUIGauge(bool immediate = false);
		private void SetPartySlotIndex(int idx);
		public void UpdateFooterUIGauge(CharacterBase chara, bool isDamage, bool immediate = false);
		public int GetSlotPartyUI(CharacterBase chara);
		public int GetCurrentPartySlotNum();
		public void SetEnablePartyButton(bool isEnable);
		private void CreateChainSkillFrame();
		private void SetupChainSkillFrame();
		public void SetSkillInfoEnabled(bool b);
		private void InitializeMiniMap();
		private void InitializeAutoPlayUI(bool isEnable);
		private void InitializeWalkerQuestButton();
		private void SetEnableDof(bool enableDof);
		private void SetDofParameter(float dofValue);
		private void CreateBRInfUI();
		public void SetButtonAlignment();
		public void RealignmentPartyButton();
		private void OnMovePartyButtonInactive(MoveControlUI sender);
		public void RealignmentSkillButton();
		public void ApplyMembersInfo();
		public void ApplyMemberInfo(CharacterBase chara, bool isSelected = true);
		private void ApplyImagePartyButton(int index, CharacterBase chara);
		public void DisableSkillButton(int index, bool isDisable, bool isDisableGrayOut = true, bool isEnableReturnValue = true);
		private void ApplyImageSkillButton(PlayerCharacter player);
		public void ApplySkillButton(bool immediate = false);
		public void ApplyImageSupportButton();
		private void ApplyTransformButtonImage(bool immediate = true, bool withEffectAndSE = false);
		private void ApplyQuestSkillButton();
		private void ApplyRebornUI();
		public void ApplyDropItemPosition();
		public bool GetPartyButtonFaceImage(CharacterBase chara, out Sprite sprite, out Material material, out Sprite numberSprite);
		private void AttachPlayerMark(CharacterBase player, InGameDef.SwitchPartyNoList switchPartyNo);
		public void AttachEnemyMark(CharacterBase chara);
		public void SetActiveEnemyMark(CharacterBase chara, bool isActive);
		private void EntryCharaMark(CharacterBase chara, CharacterMarkUI mark);
		private void RemoveCharaMark(CharacterBase chara);
		public CharacterMarkUI FindCharaMark(CharacterBase chara);
		public void UpdateCharaMarkPosition(bool interpolation = true);
		public void VisibleCharaMark(bool visible);
		private void CreateODCounterMark();
		public void ShowODCounterMark(CharacterBase chara, Vector3 pos, Vector2 adjustPos2D);
		public void ShowODCounterMark(CharacterBase chara, Vector3 pos);
		public void HideODCounterMark(CharacterBase chara);
		public void CreateSandTimerUI();
		public void ShowSandTimerUI();
		public void ShowSandTimerUI(int actorId);
		public void HideSandTimerUI();
		public void HideSandTimerUI(int actorId);
		public void SetSandTimerUICount(int actorId, int count);
		public void SetSandTimerUICountColor(int actorId, SandTimerUI.CountColorType type);
		public void CreateCircleGaugeElectrifiedUI();
		public void CreateCircleGaugeVirusUI();
		public void CreateCircleGaugeMultiWeakPointUI(CharacterBase owner);
		public void CreateCircleGaugeAbilityRebornUI(CharacterBase owner);
		public void CreateCircleGaugeDrasticForceUI(CharacterSelector selector);
		public void CreateCircleGaugeDrasticForceUI(CharacterBase owner);
		public void ShowCircleGaugeUI(CharacterSelector selector, CharaCircleGaugeUI.Type type);
		public void ShowCircleGaugeUI(CharacterBase chara, CharaCircleGaugeUI.Type type);
		public void HideCircleGaugeUI(CharacterSelector selector, CharaCircleGaugeUI.Type type);
		public void HideCircleGaugeUI(CharacterBase chara, CharaCircleGaugeUI.Type type);
		public void SetCircleGaugeUIGaugeTimer(CharacterSelector selector, CharaCircleGaugeUI.Type type, float time, float initialTime);
		public void SetCircleGaugeUIGaugeTimer(CharacterBase chara, CharaCircleGaugeUI.Type type, float time, float initialTime);
		public void SetCircleGaugeUICount(CharacterSelector selector, CharaCircleGaugeUI.Type type, int count);
		public void SetCircleGaugeUICount(CharacterBase chara, CharaCircleGaugeUI.Type type, int count);
		public void SetCircleGaugeUIAdjustPos(CharacterBase chara, CharaCircleGaugeUI.Type type, Vector3 pos);
		public void SetCircleGaugeUIAdjustScale(CharacterBase chara, CharaCircleGaugeUI.Type type, float scale);
		public static bool HasCharaCircleGaugeFromEnemy(EnemyCharacter enemy, bool ignoreMultiWeak = false);
		public BarrelBombGaugeUI CreateBarrelBombGaugeUI(GameObject owner);
		private void EntryBarrelBombGaugeUI(GameObject owner, BarrelBombGaugeUI mark);
		public void RemoveBarrelBombGaugeUI(GameObject owner);
		public BarrelBombGaugeUI FindBarrelBombGaugeUI(GameObject owner);
		public void VisibleBarrelBombGaugeUI(bool visible);
		public void CreateBossMiasmaGaugeUI();
		public void SetBossMiasmaGaugeUIGrayScale(bool b);
		public void SetBossMiasmaGaugeUIGaugeValue(float value, float maxValue, bool isForce = false);
		private void CreateDefenseQuestUI();
		public void CreateQuestSkillButtonUI(int counter, bool notCounter = false, bool changeAnim = false, bool readyAnim = false);
		public void DeleteQuestSkillButton();
		public void CreateQuestSkillButtonUIEX(Action onClick);
		public void ShowQuestSkillButtonEX(bool isForce = false, bool isImmediate = false);
		public void HideQuestSkillButtonEX(bool isForce = false, bool isImmediate = false);
		public void SetDisplayingStampId(CharacterBase chara, int stampId);
		public int GetDisplayingStampId(CharacterBase chara);
		public bool IsDisplayingStamp(CharacterBase chara);
		public void ValidateDragonButton(bool valid);
		public void ValidateSkillButton(bool valid);
		private void UpdateDisableByBuffState(PlayerCharacter player, int index);
		public void SetSkillValue(CharacterBase chara, bool immediate = false);
		public void CheckCommonAnim();
		public void CheckCommonAnim(PlayerCharacter player);
		public void CreateBlinkAnim();
		public void OnUpdateBlinkAnim(float value);
		public void CreateChainSkillAnim();
		public void CreateHpGaugeShineAnim();
		public void OnUpdateBossHpGaugeShineBgFade(float value);
		public void OnUpdateBossHpGaugeShineGaugeFade(float value);
		public void OnUpdateBossHpGaugeShineLocalPosX(float value);
		public void OnUpdateHpGaugeShineGaugeFade(float value);
		public void OnUpdateHpGaugeShineLocalPosX(float value);
		public Vector2 GetSkillButtonPosition(int index);
		public Vector2 GetSkillButtonSize(int index);
		public Vector2 GetSkillButtonPositionBySystemIndex(int index);
		public Vector2 GetDragonButtonPosition();
		public Vector2 GetDragonButtonSize();
		public void DisplayCountDown(float countDownTime);
		public float GetRemainTime();
		public void CreateRebornCountDown(bool isUnlimitReborn, int rebornNum);
		public void ShowRebornCountDown(int restRebornCount, int consumeRebornCount);
		public void SetRebornCountDownTime(float elapsed, float duration);
		public void PlayFooterRebornShowAnim();
		public void PlayFooterRebornConsumeAnim(int restRebornCount, Action onComplete = null);
		public void SetPlayerRebornLifeCount(bool isUnlimitReborn, int count);
		protected bool GetPartyCharaRebornLifeCount(int playerNo, int rebornNum, ref Dictionary<int, int> rebornNumDic);
		public void SetPartyRebornLifeCountByOtherPlayer();
		public void SetPartyRebornTimeByOtherPlayer(CharacterBase owner, float elapsed, float duration);
		public void OnEndDrop(DropItemElement.Type type, int value, bool isRare, bool isApplyBootyUI);
		private void UpdateTotalDrop();
		public bool IsEnablePlayerButton();
		public void OnButtonSkillTouched(SkillInfo sender);
		public void OnClickSupport(SupportButton sender);
		public void OnClickQuestSkill(QuestSkillButton sender);
		public void OnClickQuestSkillEX();
		public void OnClickParty(CharacterBase chara, int index);
		private void OnClickChangePlayer();
		private bool CanChangePlayerCharacter();
		private void ChangePlayerCharacter(CharacterBase chara, int index);
		public void OnClickDragon(DragonButton sender);
		public void OnClickUniqueTrans(UniqueTransButton sender);
		private void OnRetryMenu();
		private void OnRetireMenu();
		public void OnClickMinimap();
		public void GetBootyPositionWeaponIcon(ref Vector3 _pos);
		public void GetBootyPositionSackIcon(ref Vector3 _pos);
		public void GetBootyPositionCoinIcon(ref Vector3 _pos);
		public void GetBootyPositionManaIcon(ref Vector3 _pos);
		public void GetBootyPositionAmuletIcon(ref Vector3 _pos);
		public void SetMoveIn(bool moveIn, float time = 0.3f);
		private void SetInputEnable(bool canvasRaycasterEnable, bool playerEnableInput);
		public void SetMoveInDirect(bool moveIn);
		public bool IsInsideUI();
		public bool IsOutsideUI();
		public void OnAreaChange();
		public float GetMovePosition(float outPosition);
		public RectTransform GetCanvasRectTransform();
		private void UpdatePartyUI();
		private void UpdateMenu();
		private void UpdateBuffCaption();
		private void StopAllBuffCaption();
		private void UpdateEnemyAttackReticle();
		private void UpdateDangerUI();
		private void UpdateDefenseQuestUI();
		private void UpdateRetryVoteDialog();
		private void UpdateBackKey();
		public bool IsShowUI();
		public bool IsShowDangerUI();
		public void DispBuffCaption(CharacterBase chara, string text, BuffCaption.Param.DisplayIconType iconType = BuffCaption.Param.DisplayIconType.None, int iconElement = 0, string iconName = "", int conditionId = 0, float rate = 0f, bool isDisplayCheck = false, bool isSync = false, bool isDisplayCheckIncludeStack = false);
		public BuffCaption GetBuffCaption(CharacterBase chara);
		public bool IsDisplayBuffCaption(CharacterBase chara, string text = "", bool isIncludeStack = false);
		public void SetBuffCaptionCharacter(CharacterBase chara, CharacterBase newChara);
		public void DispCancelDragonTransform(CharacterSelector selector);
		public void DispCancelUniqueTransform(CharacterBase chara);
		public void SetActiveMarkUI(bool active);
		public void InitialiseSystemMessage();
		public void SystemMessagePrologueAdjustPosY(float adjustPosY);
		public void DisplaySystemMessage(string text, float tm = 3f, bool isQueueing = true);
		public bool IsDisplayingSystemMessage(string msg = "");
		public InGameSystemMsgUI.MessageStatus GetSystemMessageCurrentStatus();
		public bool IsDisplayingSystemMessage_forGameSystemMsgUI(string msg = "");
		public void OpenSystemMessage(string text, bool se);
		public void CloseSystemMessage();
		public RectTransform GetStampButtonArrangementTransform();
		public void SetEnableMenuBackkey(bool enabled);
		public void SetActiveUI(bool isActive);
		public void SetActiveFooterUI(bool isActive);
		public void SetForceUIHiding(bool isHide, bool isForce = false);
		public void OnUpdateCameraModeExtra();
		private void ChangeCharaGimmick(CharacterBase chara);
		public void ShowCharaGimmickGauge(CharacterBase chara);
		public void HideCharaGimmickGauge(CharacterBase chara, bool isOnlyOverflow = false);
		public void HideCharaGimmickGauge();
		private bool IsOverflowGauge(CharacterBase chara);
		public void ShowCharaGimmickInput(CharacterBase chara);
		public void HideCharaGimmickInput(CharacterBase chara, bool anim = true);
		public bool IsVisibleGimmickInput(CharacterBase chara);
		public void HideCharaGimmickInput(bool anim = true);
		public void AttachCharaGimmickGauge(CharacterBase chara, CharaGimmickGaugeCtrl.GaugeType type);
		public void AttachCharaGimmickGauge(CharacterBase chara);
		public void AttachCharaGimmickInput(CharacterBase chara);
		public void SetCharaGimmickGaugeValue(CharacterBase chara, int idx, int value, int consumeValue, int maxValue, float delay = 0f, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false);
		public void SetCharaGimmickModeGaugeMode(CharacterBase chara, int mode);
		public void SetCharaGimmickGaugeAnimCompleteCallback(CharacterBase chara, CharacterCustomPointController ctrl, int idx, Action<int> onComplete);
		public void SetCharaGimmickGaugeAnimCompleteCallback(CharacterBase chara, CharacterCustomPointController ctrl, int idx, Action<int, int, int> onComplete);
		public float GetCharaGimmickGaugeMoveTime(CharacterBase chara);
		public void ChangeCharaGimmickAppearance(CharacterBase chara, int type);
		public void SetCharaGimmickGaugeAbilityData(CharacterBase chara, ref List<AbilityDataElement> list);
		public void SetCharaGimmickAdditionalInputCount(CharacterBase chara, int num, bool force = false, bool immediate = false);
		public static float GetIPhoneXFooterMargin();
		public string RegistEnemyExtensionName(EnemyCharacter enemy);
		public string GetEnemyExtensionName(EnemyCharacter enemy, bool isGaugeName = false);
		public void RemoveEnemyExtensionName(EnemyCharacter enemy);
		public CharacterSelector GetOriginalPlayerSelector();
		public PlayerCharacter GetOriginalPlayerChara();
		public bool IsOriginalPlayerChara(CharacterBase chara);
		public void UpdatePartySwitch(List<HumanCharacter> currMemberList, List<HumanCharacter> nextMemberList);
		public static bool IsTutorialMidgardsormr(ref CharacterBase chara);
		public static bool GetQuestData(out QuestDataElement qde);
		public static bool GetQuestId(out int questId, out int questGroupId);
		public static bool GetQuestOverrideView(out QuestOverrideViewElement ove);
		public static bool CheckChangeDecorationSackIcon(QuestDataElement qde, out InGameUIConst.DecorationType decorationType);
		public static bool CheckChangeDecorationHpGauge(QuestDataElement qde, out InGameUIConst.DecorationType decorationType);
		public static bool CheckChangeDecorationFTU(QuestDataElement qde, out string dirName);
		public static bool CheckChangeDecorationQuestFailureSe(QuestDataElement qde, out string seName);
		public static bool GetDecorationTypeFromDefenseQuest(QuestDataElement qde, out InGameUIConst.DecorationType decorationType);
		public static int GetDecorationType(QuestDataElement qde);
		public void CreateBattleLogUI(bool isLeft);
		public void StartBattleLogUI();
		public void AddBattleLogUIByEnemyDefeated(string winnerCharaName, string loserCharaName);
		public void AddBattleLogUIByEnemyDefeated(string winnerCharaName, EnemyCharacter enemy);
		public void AddBattleLogUIByWeaponEnhancement(string charaName, int level);
		public void AddBattleLogUIByRemainingNumber(int num);
		private void UpdateStatusInfoUI();
		private void SetStatusInfoUIChangePage();
		public void CreateScoringEventInfoUI(bool isLeft);
		public void CreateScoringEventCountDownUI();
		public static string GetCharaName(CharacterBase chara);
		public static string GetEnemyBaseName(EnemyCharacter enemy, bool isGaugeName = false);
		public static int GetFloat2PercentInt(float value);
		public static string GetFloat2PercentText(float value);
		public static string GetFloat2PercentFormatText(string text, float v, bool abs = true);
		public static string GetDurationNumText(string name, int count, bool isMax);
		public static bool GetDurationNumText(int conditionId, int count, bool isMax, out string text);
		private void InitializeStick();
		public void DisplayTap();
		public void DisplaySwipe();
		public void DisplayCharge(bool value);
		public void DisplayChargeEnd();
		public void ForceInputBurst();
		public void ResetInput();
		public void DisplayEffectClickButton();
		public void ApplyFlickSensitivity();
		public void InitializeNotify();
		private void ReceiveNotificationPlayer(CharacterBase sender, NotifyCharacter.NoticeType notice, object param);
		private void ReceiveNotificationCharacter(CharacterBase sender, NotifyCharacter.NoticeType notice, object param);
		private void ReceiveNotificationOther(CharacterBase sender, NotifyCharacter.NoticeType notice, object param);
		private void ReceiveNotificationBoss(CharacterBase sender, NotifyCharacter.NoticeType notice, object param);
		private void ReceiveNotificationObject(DungeonObjectBase sender, NotifyDungeonObject.NoticeType notice, object param);
		public BossBreakUI GetBossGaugeUI();
		public bool IsVisibleBossGaugeUI();
		public void ShowBossGaugeUI(EnemyCharacter enemy);
		public void CloseBossGaugeUI(CharacterBase sender);
		public void SetBossGaugeUIBreakGaugeValue(CharacterBase sender, float rate, bool immediate = false);
		public void SetBossPartGaugeUIForType(CharacterBase sender, int type, float rate, bool immediate = false);
		private void ApplyBossPartGaugeUI(CharacterBase part);
		private void ApplyTransformButtonValue(bool immediate = true, bool withEffectAndSE = true);
		public void SetActionDragonPointMax(Action onMaxDP);
		private void SetPlayerNo();
		public static int GetOwnPlayerNo();
		private void PlayerFootMarkMultiVisible(CharacterBase chara, bool visible);
		public void SetCurrentPlayerMark(bool on);
		private void DisplayDragonTimer(DragonCharacter dragon);
		public void SetDragonTimeValue(DragonCharacter dragon, bool immediate);
		public bool IsDragonDamageAnimation(DragonCharacter dragon);
		public void DisplayDragonTimerForMulti(DragonCharacter dragon);
		public static Sequence GetPauseSequence();
		public static void StopTweener(ref Tweener tweener, bool complete = false);
		public static void StopSequence(ref Sequence sequence, bool complete = false);
		public static void VisibleUIObj(RectTransform rt, bool value);
		public static void VisibleUIObj(Transform rt, bool value);
		public float GetScaleFactor();
		public Vector2 GetCanvasSize();
		public Vector2 WorldToScreen(Vector3 pos);
		public static void SetSortingLayer(GameObject obj, string layer);
		public static void SetSortingLayerInCanvas(Canvas cv, string layer);
		public void OpenCommonDialog();
		public void EnableTouchUI(bool enable);
		public bool IsPlaceNameOpened();
		public void ClosePlaceName();
		public void GetBossGaugeUIGaugeEffectPos(ref Vector3 pos);
		public void GetBossGaugeUIRaidFishGradeEffectPos(ref Vector3 pos);
		public void GetSkillButtonPos(ref Vector3 pos);
		public void GetTutorialReactionPos(ref Vector3 pos);
		public void SetTutorialReactionFlip(ref Vector3 scale);
		public void GetDragonButtonPos(ref Vector3 pos, Vector2? scale = default);
		public void DispEnemySkill(string param);
		public void EntryEnemyAbility(List<EnemyAbilityProcBase> abilities);
		public void OpenEnemyAbility(List<EnemyAbilityProcBase> abilities);
		public void CloseEnemyAbility();
		public void EnableEnemyAbility(int id);
		public void DisableEnemyAbility(int id);
		public EnemyAbilityUI GetEnemyAbility(int id);
		public Material GetEnemyAbilityIcon(string iconId);
		public void PlayQuestEffect(PlayFTU.Type type, Action<PlayFTU> endFunc = null, bool isKeeping = false, string label = null, bool isRemove = true);
		public bool PlayQuestEffectCharaSpecific(CharacterBase chara, PlayFTU.CharaSpecificFlashType csfType, bool isRemove, PlayFTU.CharaSpecificFlashAlignment csfAlign = PlayFTU.CharaSpecificFlashAlignment.Auto, Action<PlayFTU> endFunc = null, bool isKeeping = false, string label = null);
		public bool PlayQuestEffectCharaSpecific(CharacterBase chara, string fileName, bool isRemove, PlayFTU.CharaSpecificFlashAlignment csfAlign = PlayFTU.CharaSpecificFlashAlignment.Auto, Action<PlayFTU> endFunc = null, bool isKeeping = false, string label = null);
		public void PlayQuestEffectMotionIndex(PlayFTU.Type type, string label, int playMotionIdx);
		public bool IsPlayingQuestEffect(PlayFTU.Type type);
		public void StopQuestEffect(PlayFTU.Type type);
		public void PreloadQuestEffect(PlayFTU.Type type, Action<PlayFTU> endFunc = null);
		public void PreloadQuestEffectCharaSpecific(CharacterBase chara, string fileName, Action<PlayFTU> endFunc = null);
		public void ReleaseQuestEffect(PlayFTU.Type type);
		public void PlayQuestEffectSkillCuttInCharacter(CharacterBase sender, NotifyCharacter.SkillCutInParam param);
		public void PlayQuestEffectSkillCuttInDragon(CharacterBase sender, NotifyCharacter.SkillCutInParam param);
		public void PlayQuestEffectBreak(CharacterBase sender, float param);
		public void StopQuestEffectBreak(CharacterBase sender);
		public void PlayQuestEffectOverdrive(CharacterBase sender);
		public void StopQuestEffectOverdrive(CharacterBase sender);
		public void PlayQuestEffectBerserk(CharacterBase sender);
		public void StopQuestEffectBerserk(CharacterBase sender);
		public void PlayQuestEffectWaveStart(int waveCount, int maxWaveCount);
		public void PlayQuestEffectBooty(PlayFTU.Type type, Action<PlayFTU> endFunc = null);
		public void PlayQuestEffectRareGet(Vector2 pos, Transform parent = null);
		public void PlayQuestEffectRareGet2(Vector2 pos, Transform parent = null);
		public void PlayQuestEffectRaidFishGrade(int grade, Action<PlayFTU> endFunc = null);
		public void PlayQuestEffectDefenseEventInfo(string desc, DefenseEventIconType type, Action<DefenseEventIconType, int> endFunc);
		public void PlayQuestEffectDefenseEventInfo(string desc, int nextAreaMessage, List<PlayFTU.MaterialInfo> materialInfoList, Action<DefenseEventIconType, int> endFunc);
		public void PlayQuestEffectPartySwitch(List<HumanCharacter> currMemberList, List<HumanCharacter> nextMemberList, Action endFunc);
		public void OpenPlaceName(NotifyCharacter.OpenPlaceNameParam param);
		public CharacterBase GetPartCharacter(int index);
		public string GetFloorText(int index);
		public static void NotifyBuffDebuffStatusChange(CharacterBase chara);
		public void SetPause(bool isPause);
		public void SetDangerActive(bool isActive);
		public void BeginEnemyAttackReticle(CharacterBase c, Vector3 offsetPos, float displayTime = 0f);
		public void EndEnemyAttackReticle();
		public InGameEventExtendAtlasManager CreateEventExtendAtlasManager(InGameUIConst.DecorationType type);
		public string GetTeamColorStr(int actorId);
		private void TryShowGoToSoloPlay();
		public static Sprite CreateSprite(Material material);
		public static bool CreateSprite(ref Material originMaterial, float spriteWidth, float spriteHeight, bool isCrippingRect, out Sprite sprite, out Material material);
		public static bool CreateSprite(ref Material originMaterial, bool isCrippingRect, out Sprite sprite, out Material material);
		public static bool SetSprite(SpriteRenderer obj, Sprite sprite, Material material);
		public static void SetupObjectSortingOrder(GameObject obj, int sortingOrder, out Canvas canvas, out GraphicRaycaster ray);
		public static void SetupObjectSortingOrder(GameObject obj, int sortingOrder, out Canvas canvas);
		public static int GetDigit(int num);
		public static bool HasEnhanceGaugeOfDragonTransform(CharacterBase chara);
		public static bool HasEnhanceGaugeOfUniqueTransform(DragonCharacter dragon);
		public static bool GetEnemySwitchElementText(EnemyCharacter enemy, out string text);
		public static bool GetEnemySwitchElementFormatText(ElementalType element, out string text);
		public static void SetAnimFade(SpriteRenderer sprite, float fade);
		public static void SetAnimScale(Transform trans, float scale);
		public static void SetAnimScale(Transform trans, Vector3 scale);
		public static void OnUpdateAnimFade(SpriteRenderer sprite, float to, float from, float t);
		public static void OnUpdateAnimScale(Transform trans, float to, float from, float t);
		public static void OnUpdateAnimScale(Transform trans, Vector3 to, Vector3 from, float t);
		[CompilerGenerated]
		private void _InitializeMenu_b__215_0();
		[CompilerGenerated]
		private void _InitializeMenu_b__215_1();
		[CompilerGenerated]
		private void _InitializeWalkerQuestButton_b__245_0();
		[CompilerGenerated]
		private void _InitializeWalkerQuestButton_b__245_1();
		[CompilerGenerated]
		private void _InitializeWalkerQuestButton_b__245_2();
		[CompilerGenerated]
		private void _InitializeWalkerQuestButton_b__245_3(float dofValue);
		[CompilerGenerated]
		private void _InitializeWalkerQuestButton_b__245_4(bool enableDof);
		[CompilerGenerated]
		private void _CreateBlinkAnim_b__324_0(float t);
		[CompilerGenerated]
		private void _CreateChainSkillAnim_b__326_0(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_0(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_1(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_2(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_3(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_4(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_5(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_6(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_7(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_8(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_9(float t);
		[CompilerGenerated]
		private void _CreateHpGaugeShineAnim_b__327_10(float t);
		[CompilerGenerated]
		private float _SetMoveIn_b__370_0();
		[CompilerGenerated]
		private void _SetMoveIn_b__370_1(float val);
		[CompilerGenerated]
		private float _SetMoveIn_b__370_3();
		[CompilerGenerated]
		private void _SetMoveIn_b__370_4(float val);
	}
}
