using UnityEngine;

namespace Gluon
{
	public static class InGameUIConst
	{
		public enum DecorationType
		{
			None,
			NewYear,
			Easter,
			FEH,
			RUSH,
			Hunter,
			Eight
		}

		public enum QuestSkillType
		{
			None,
			BarrelBomb,
			AreaTrap,
			HolyLight,
			AlloutAssault,
			Angel,
			Angel2
		}

		public enum QuestSkillSubType
		{
			Angel2_1,
			Angel2_2
		}

		public static readonly int NumPlayer;

		public static readonly int BRNumPlayer;

		public static readonly int Raid16NumPlayer;

		public static readonly int MaxCharacter;

		public static readonly int BRMaxCharacter;

		public static readonly int PSMaxCharacter;

		public static readonly int DmodeMaxCharacter;

		public static readonly int WalkQuestMaxCharacter;

		public static readonly int WalkQuestMaxStampIcon;

		public static readonly int MaxGroup;

		public static readonly float ScaleCurrentPartyButton;

		public static readonly float ScalePartyButton;

		public static readonly float SizeCurrentPartyButton;

		public static readonly float MarginPartyButton;

		public static readonly float OffsetPartyButton;

		public static readonly float OffsetPartyY;

		public static readonly float MaxButtonCircleTimerValue;

		public static readonly int TutorialMidgardsormrDamageAdjust;

		public static readonly int ODCounterMarkReserveNum;

		public static readonly float BlinkAnimTime;

		public static readonly float ChainSkillAnimTime;

		public static readonly string PathPrefab;

		public static readonly string PathPrefabFlash;

		public static readonly string PathPrefabFlash2;

		public static readonly string PathPrefabFlashTutorial;

		public static readonly string PathFlashFolderReplaceQuest;

		public static readonly string PathFlashFolderDefaltQuest;

		public static readonly string PathFlashFolderRaidQuest;

		public static readonly string PathFlashFolderRaidFishGradeQuest;

		public static readonly string PathFlashFolderReplaceEvent;

		public static readonly string PathFlashFolderFEHEvent;

		public static readonly string PathFlashFolderHunterEvent;

		public static readonly string PathFlashFolderEightEvent;

		public static readonly string PathFlashFolderReplaceBR;

		public static readonly string PathFlashFolderReplaceDmode;

		public static readonly string PathFlashFolderReplaceAngel;

		public static readonly string PathFlashFolderCharaSpecific;

		public static readonly string PathCharaFaceImage;

		public static readonly string PathDragonFaceImage;

		public static readonly string PathRaidFaceImage;

		public static readonly string PathCharaSkillCutIn;

		public static readonly string PathDragonSkillCutIn;

		public static readonly string PathCharaSkillCutInParam;

		public static readonly string PathMovieSkillCutInBase;

		public static readonly string PathMovieSkillCutInLocalBase;

		public static readonly string PathCharaMovieSkillCutIn;

		public static readonly string PathDragonMovieSkillCutIn;

		public static readonly string PathCharaBustUpImage;

		public static readonly string PathDragonBustUpImage;

		public static readonly string PathOtherCutInImage;

		public static readonly string PathBootyImage;

		public static readonly string NamePartyButton;

		public static readonly string NamePartyButton2;

		public static readonly string NamePartyButton3;

		public static readonly string NamePartyCursor;

		public static readonly string NamePartyCursor2;

		public static readonly string NameSkillButton;

		public static readonly string NameSkillButtonL;

		public static readonly string NameShareSkillSelectButton;

		public static readonly string NameShareSkillSelectButtonL;

		public static readonly string NameDmageNum;

		public static readonly string NameDamageFig;

		public static readonly string NameHumanMark;

		public static readonly string NameHumanMark2;

		public static readonly string NameHumanMarkWin;

		public static readonly string NameDragonMark;

		public static readonly string NameEnemyMark;

		public static readonly string NameEnemyMark2;

		public static readonly string NameEnemyMarkSimple;

		public static readonly string NameDefenseUnitMark;

		public static readonly string NameDefenseUnitMark2;

		public static readonly string NameODCounterMark;

		public static readonly string NameDangerImage;

		public static readonly string NameComboUI;

		public static readonly string NamePlayerFootMark;

		public static readonly string NamePlayerFootMarkMulti;

		public static readonly string NameCharaFootMark;

		public static readonly string NameStick;

		public static readonly string NameBootyInfoUI;

		public static readonly string NameBootyInfoUI2;

		public static readonly string NameDragonImage;

		public static readonly string NameFadeImage;

		public static readonly string NameMenuButton;

		public static readonly string NameFinger;

		public static readonly string NameInGameFTU;

		public static readonly string NameCharaDialogueCtrl;

		public static readonly string NameCharaDialogue;

		public static readonly string NameDropItemCtrl;

		public static readonly string NameDropItem;

		public static readonly string NameItemGlitter;

		public static readonly string NameDropItemBright;

		public static readonly string NameDropCoinGlitter;

		public static readonly string NameBossBreak;

		public static readonly string NameBossBreak2;

		public static readonly string NameEnemyAbilityCtrl;

		public static readonly string NameEnemyAbility;

		public static readonly string NameDragonButton;

		public static readonly string NameDragonButtonL;

		public static readonly string NameDragonSelectButton;

		public static readonly string NameDragonSelectButtonL;

		public static readonly string NameUniqueTransButton;

		public static readonly string NameUniqueTransButtonL;

		public static readonly string NameInventoryButton;

		public static readonly string NameInventoryButtonL;

		public static readonly string NameCountDown;

		public static readonly string NameRaidCountDown;

		public static readonly string NameSandTimer;

		public static readonly string NameHitCount;

		public static readonly string NameVesselBomb;

		public static readonly string NameCharaCircleGaugeElectrified;

		public static readonly string NameCharaCircleGaugeVirus;

		public static readonly string NameCharaCircleGaugeMultiWeakPoint;

		public static readonly string NameCharaCircleGaugeScapegoat;

		public static readonly string NameCharaCircleGaugeMiasma;

		public static readonly string NameCharaCircleGaugeAbilityReborn;

		public static readonly string NameCharaCircleGaugeDrasticForce;

		public static readonly string NameEnemyAbilityHeadGaugeUI;

		public static readonly string NameBarrelBombGauge;

		public static readonly string NameInGameBattleLogCtrl;

		public static readonly string NameInGameBattleLog;

		public static readonly string NameAutoPlayUI;

		public static readonly string NameAutoPlayUI2;

		public static readonly string NameSumUpTotalDamageInfoUI;

		public static readonly string NameSystemMsg;

		public static readonly string NameResult;

		public static readonly string NameStamp;

		public static readonly string NameLoading;

		public static readonly string NamePartBreak;

		public static readonly string NameEnemySkill;

		public static readonly string NameEmotionIconCtrl;

		public static readonly string NameEmotionIcon;

		public static readonly string NameCommonDialog;

		public static readonly string NameSysMessage;

		public static readonly string NameOneButton;

		public static readonly string NameStrategyDialog;

		public static readonly string NameStrategyDialog2;

		public static readonly string NameRetryVoteDialog;

		public static readonly string NameRetireConfirmDialog;

		public static readonly string NameRetireConfirmDialog2;

		public static readonly string NameContinueDialog;

		public static readonly string NameContinueCameraDialog;

		public static readonly string NameContinueConfirmDialog;

		public static readonly string NameDmodeContinueDialog;

		public static readonly string NameDmodeNextFloorConfirmDialog;

		public static readonly string NameInGameFooter;

		public static readonly string NameInGameFooter2;

		public static readonly string NameInGameFooterL;

		public static readonly string NameInGameFooter2L;

		public static readonly string NameRaidPlayerBase;

		public static readonly string NameRaidPlayer;

		public static readonly string NameQuestInfo;

		public static readonly string NamePlaceName;

		public static readonly string NamePlaceNameRich;

		public static readonly string NameCautionBoss;

		public static readonly string NameSupportButton;

		public static readonly string NameSupportButtonL;

		public static readonly string NameQuestSkillButton;

		public static readonly string NameQuestSkillButtonL;

		public static readonly string NameQuestSkillButtonSelector;

		public static readonly string NameQuestSkillButtonEx;

		public static readonly string NameQuestSkillButtonExL;

		public static readonly string NameWalkerQuestButton;

		public static readonly string NameEmphasizeInfo;

		public static readonly string NameBuffCaption;

		public static readonly string NameBattleResultRanking;

		public static readonly string NameButtonThrow;

		public static readonly string NameBuffUI;

		public static readonly string NameInGameTouchGuard;

		public static readonly string NameCharaGimmickGaugeCtrl;

		public static readonly string NameCharaGimmickActiveGaugeUI;

		public static readonly string NameCharaGimmickModeGaugeUI;

		public static readonly string NameCharaGimmickOverflowGaugeUI;

		public static readonly string NameCharaGimmickOverflowGaugeUI2;

		public static readonly string NameCharaGimmickOverflowGaugeUI3;

		public static readonly string NameCharaGimmickCustomPointGaugeUI;

		public static readonly string NameCharaGimmickCustomPointGaugeUI2;

		public static readonly string NameCharaGimmickCustomPointGaugeUI3;

		public static readonly string NameCharaGimmickCustomPointGaugeUI4;

		public static readonly string NameCharaGimmickGunChargeGaugeUI;

		public static readonly string NameCharaGimmickGunChargeGaugeUI2;

		public static readonly string NameCharaGimmickRequiredBuffGaugeUI;

		public static readonly string NameCharaGimmickAddCountInput;

		public static readonly string NameCharaGimmickAddGaugeInput;

		public static readonly string NameCharaStatusInfoUI;

		public static readonly string NameRebornCountDownUI;

		public static readonly string NameRebornCountDownLifeUI;

		public static readonly string NameRebornPartyLifeUI;

		public static readonly string NameRebornFooterLifeUI;

		public static readonly string NameButtonModeSelect;

		public static readonly string NameInGameBRInfoUI;

		public static readonly string NameInGameDmodeInfoUI;

		public static readonly string NameInGameScoringEventInfoUI;

		public static readonly string NameInGameScoringEventCountDownUI;

		public static readonly string PathPrefabEventExtend;

		public static readonly string NameEventExtendAtlas_0001;

		public static readonly string NameDefenseEventProgressInfoUI_Format;

		public static readonly string NameDefenseEventProgressInfoUI_0001;

		public static readonly int DefenseEventDefaultPresetID;

		public static readonly Color BattleBlueColor;

		public static readonly Color BattleRedColor;

		public static readonly Color BattleBlueOutlineColor;

		public static readonly Color BattleRedOutlineColor;

		public static readonly string BattleBlueColorStr;

		public static readonly string BattleRedColorStr;

		public static readonly Color RaidBlueColor;

		public static readonly Color RaidRedColor;

		public static readonly Color RaidYellowColor;

		public static readonly Color RaidGreenColor;

		public static readonly string RaidDefaultColorStr;

		public static readonly string RaidBlueColorStr;

		public static readonly string RaidRedColorStr;

		public static readonly string RaidYellowColorStr;

		public static readonly string RaidGreenColorStr;

		public static readonly Color[] TeamColorArray;

		public static readonly string NameSkillCutInFlash;

		public static readonly string NameSkillCutInFlashDragon;

		public static readonly string NameFlashQuestStart;

		public static readonly string NameFlashTreasureTime;

		public static readonly string NameFlashQuestClear;

		public static readonly string NameFlashQuestFailure;

		public static readonly string NameFlashQuestBossBattle;

		public static readonly string NameFlashQuestTimeUp;

		public static readonly string NameFlashQuestBreak;

		public static readonly string NameFlashQuestBreakGauge;

		public const int IndexFlashQuestBreakGaugeMotion = 1;

		public static readonly string NameFlashQuestChance;

		public static readonly string NameFlashOverdrive;

		public static readonly string NameFlashOverdriveGauge;

		public const int IndexFlashOverdriveGaugeMotion = 1;

		public static readonly string NameFlashBerserk;

		public static readonly string NameFlashRaidFishGrade;

		public static readonly string LabelFlashRaidFishGrade;

		public static readonly string LabelFlashRaidFishGrade2;

		public static readonly string LabelFlashRaidFishGrade3;

		public static readonly string LabelFlashRaidFishGrade4;

		public static readonly string LabelFlashRaidFishGrade5;

		public static readonly string NameFlashRareEnemyAppear;

		public static readonly string NameFlashRareEnemyDefeat;

		public static readonly string NameFlashPowerfulEnemyAppear;

		public static readonly string NameFlashRareGet;

		public static readonly string NameFlashRareGet2;

		public static readonly string NameFlashWaveAppearance;

		public static readonly string LabelFlashWaveAppearanceFirst;

		public static readonly string LabelFlashWaveAppearanceFinal;

		public static readonly string LabelFlashWaveAppearance;

		public static readonly string NameBootyItemGetCoin;

		public static readonly string NameBootyItemGetMana;

		public static readonly string NameBootyItemGetOther;

		public static readonly string NameFlashChangePlayer;

		public static readonly string NameFlashChangePlayerL;

		public static readonly string LabelFlashChangePlayer;

		public static readonly string LabelFlashPausePlayer;

		public static readonly string LabelFlashDragonPlayer;

		public static readonly string LabelFlashDamagePlayer;

		public static readonly string LabelFlashDamageCharacterIn;

		public static readonly string LabelFlashDamageCharacterOut;

		public const int IndexFlashDamageCharacterMotion = 1;

		public static readonly string NameFlashPartySwitch;

		public static readonly string NameFlashPartySwitchCurrMemberPlane01;

		public static readonly string NameFlashPartySwitchCurrMemberPlane02;

		public static readonly string NameFlashPartySwitchCurrMemberPlane03;

		public static readonly string NameFlashPartySwitchCurrMemberPlane04;

		public static readonly string NameFlashPartySwitchNextMemberPlane01;

		public static readonly string NameFlashPartySwitchNextMemberPlane02;

		public static readonly string NameFlashPartySwitchNextMemberPlane03;

		public static readonly string NameFlashPartySwitchNextMemberPlane04;

		public static readonly string NameFlashPartySwitchCurrPlayerNoPlaneFormat;

		public static readonly string NameFlashPartySwitchNextPlayerNoPlaneFormat;

		public static readonly string[] NameFlashPartySwitchCurrMemberPlaneArray;

		public static readonly string[] NameFlashPartySwitchNextMemberPlaneArray;

		public static readonly string NameFlashRaidBattleDemolish;

		public static readonly string NameFlashRaidQuestReady;

		public static readonly string NameFlashDefenseEventInfo;

		public static readonly string NameFlashDefenseEventInfoPlane01;

		public static readonly string NameFlashDefenseEventInfoPlane02;

		public static readonly string NameFlashDefenseEventInfoPlane03;

		public static readonly string NameFlashDefenseEventInfoPlane04;

		public static readonly string NameFlashDefenseEventInfoPlaneFree;

		public const int IndexFlashDefenseEventInfoMotion = 78;

		public const int IndexFlashDefenseEventInfoMotionFree = 79;

		public static readonly string LabelFlashDefenseEventInfoMotionFree;

		public static readonly string NameFlashDmodeExp;

		public static readonly string NameFlashDmodeLevelUp;

		public static readonly string NameFlashDragonLR;

		public static readonly string LabelFlashDragonLR_Close;

		public static readonly string PathStampIcon;

		public static readonly string PathSkillIcon;

		public static readonly string PathSkillIconM;

		public static readonly string PathCharaUI;

		public static readonly string PathQuestSkillIcon;

		public static readonly string PathDragonIcon;

		public static readonly string PathModeChangeIcon;

		public static readonly string PathUniqueTransIcon;

		public static readonly string PathCharaGimmickGaugeIcon;

		public static readonly string NameTutorialSkill;

		public static readonly string NameTutorialDragon;

		public static readonly string NameTutorialNaviFlick;

		public static readonly string NameTutorialSwipe;

		public static readonly string NameTutorialTouch;

		public static readonly string NameTutorialReact1;

		public static readonly string NameTutorialReact2;

		public static readonly string NameTutorialReact3;

		public static readonly string NameSeHunterQuestFailure;

		public static readonly float DyingHP;

		public static readonly float RemainWarnDragonize;

		public static readonly float PlayTimeFlashSkillCutin;

		public static readonly float PlayTimeFlashCharaSpecificEightServantCutIn;

		public const int StartCharaID = 100000;

		public const int StartDragonID = 200000;

		public const int StartRaidID = 400000;

		public static Vector3 SpriteRendererDefaultScale;

		public const int SortingOrderUIArrow = 100;

		public const int SortingOrderUIArrowTop = 101;

		public const int BootyAttachPriorityBossBreakUI = 1;

		public const int BootyAttachPriorityPartBreakUI = 2;

		public const int BootyAttachPriorityEnemyAbilityUI = 3;

		public const int BootyAttachPriorityEventProgressUI = 4;

		public const int BootyAttachPriorityCharaDialogueUI = 5;

		public const int DialogDisplayManaMaxNum = 999999999;

		public const int DialogDisplayCointMaxNum = 999999999;

		public const int DialogDisplaySackMaxNum = 9999999;

		public const int DialogDisplaySackRareMaxNum = 9999999;

		public const int DialogDisplayWeaponMaxNum = 9999999;

		public const int DialogDisplayWeaponRareMaxNum = 9999999;

		public const int DialogDisplayAmuletMaxNum = 9999999;

		public const int DialogDisplayAmuletRareMaxNum = 9999999;

		public static readonly int HidingStampId;

		public static readonly int RemoveStampIconId;

		public static readonly string RemoveStampIconName;

		public const int SortingOrderCharaDialogue = 2;

		public const int SortingOrderEnemyStatus = 3;

		public const int SortingOrderFtuWeak = 3;

		public const int SortingOrderFtuTutorial = 7;

		public const int SortingOrderAutoPlayeDefault = 10;

		public const int SortingOrderFtuDmodeLevelUp = 18;

		public const int SortingOrderFtuOverDrive = 20;

		public const int SortingOrderFtuChangePlayer = 20;

		public const int SortingOrderFtuBooty = 20;

		public const int SortingOrderMinimapButton = 20;

		public const int SortingOrderBattleLogButton = 20;

		public const int SortingOrderManuButton = 21;

		public const int SortingOrderFtuQuestReady = 21;

		public const int SortingOrderFtuQuestStart = 21;

		public const int SortingOrderAutoPlayeStart = 40;

		public const int SortingOrderFtuDmodeEventInfo = 89;

		public const int SortingOrderMinimapButtonContinueCamera = 101;

		public const int SortingOrderBattleLogButtonContinueCamera = 101;

		public const int SortingOrderRetryVoteDialog = 101;

		public const int SortingOrderStrategyDialog = 106;

		public const int SortingOrderRetireConfirmDialog = 106;

		public const int SortingOrderDmodeContinueDialog = 106;

		public const int SortingOrderDmodeNextFloorDialog = 106;

		public const int SortingOrderInGameOptionDialog = 107;

		public const int SortingOrderPerformanceModeDialog = 107;

		public const int SortingOrderButtonPressedEffect = 108;

		public const int SortingOrderDebugDialog = 109;

		public const float DisplayOffertZStick = -0.01f;

		public const float DisplayOffertZFlashDefenseEventInfo = 2.5f;

		public const float DisplayOffertZFlashSkillCutIn = -0.5f;

		public const float DisplayOffertZFlashDmodeEventInfo = -0.51f;

		public const float DisplayOffertZStrategyDialog = -0.6f;

		public const float DisplayOffertZStrategyDialog2 = -0.9f;

		public const float DisplayOffertZRetryVoteDialog = -0.6f;

		public const int BackKeyEventIdInGameUICtrl = 1000;

		public const int BackKeyEventIdStorategyDiaog = 2000;

		public const int BackKeyEventIdCommonDialog = 3000;

		public const int BackKeyEventIdContinueDialog = 4000;

		public const int BackKeyEventIdContinueCamaraDialog = 5000;

		public const int BackKeyEventIdRetireConfirmDialog = 6000;

		public const int BackKeyEventIdContinueConfirmDialog = 7000;

		public const int BackKeyEventIdTutorialDualWindow = 8000;

		public const int BackKeyEventIdErrorPopup = 9000;

		public const int BackKeyEventIdStrategyRetireDialog = 10000;

		public const int BackKeyEventIdDmodeNextFloorDialog = 11000;

		public const int BackKeyEventIdDmodeContinueDialog = 12000;

		public static readonly int DigitNumDamage;

		public static readonly int DigitNumDamageFig;

		public static readonly int DigitNumRecoverySp;

		public static readonly int DigitNumLevel;

		public static readonly int DigitNumScore;

		public static readonly int DigitNumFloor;

		public static readonly int DigitNumDpoint;

		public static readonly int MaxNumDamage;

		public static readonly int MaxNumRecoverySp;

		public static readonly int MaxNumLevel;

		public static readonly int MaxNumScore;

		public static readonly int MaxNumFloor;

		public static readonly int MaxNumDpoint;

		public const float PlaySEDelayTimePartySwitchRollArrow = 1.3f;

		public static readonly Color DisableButtonFrameColor;

		public static readonly Color DisableButtonTextColor;

		public static int skillButtonNum => default(int);
	}
}
