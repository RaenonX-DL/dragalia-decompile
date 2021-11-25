using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine.Events;

namespace Gluon
{
	public class TutorialDataManager
	{
		public enum EditSkillTutorialStep
		{
			None = 0,
			Release = 910161,
			Start = 910162,
			Cost = 910163,
			End = 910164
		}

		public enum GrowCrestTutorialStep
		{
			None = 0,
			GoEnhanceScene = 910191,
			Buildup = 910192,
			BuildupEnd = 910193,
			LimitBreak = 910194,
			LimitBreakEnd = 910195
		}

		public enum GrowthWeaponTutorialTopSceneStep
		{
			None = 0,
			OpeneGrowthWeapon = 206231,
			GrowthWeaponDetail = 206232
		}

		public enum GrowthTutorialType
		{
			None = -1,
			GrowthAmulet,
			LimitBreakAmulet,
			ManaCircle,
			Craft
		}

		public enum TutorialCellType
		{
			None,
			TutorialTarget,
			TutorialTarget2,
			TutorialNontarget
		}

		public const int TutorialStep_0_0_Start = 0;

		public const int TutorialStep_0_0_InitialDownloadDone = 5;

		public const int TutorialStep_0_0_NameInput = 10;

		public const int TutorialStep_0_0_TutorialSummon = 15;

		public const int TutorialStep_0_0_Download = 20;

		public const int TutorialStep_0_0_DownloadDone = 29;

		public const int TutorialStep_0_0_LoginBonus = 30;

		public const int TutorialStep_0_0_Done = 99;

		public const int TutorialStep_1_1_Start = 10100;

		public const int TutorialStep_1_1_MypageSummon = 10101;

		public const int TutorialStep_1_1_MypageCharaStory = 10102;

		public const int TutorialStep_1_1_SummonReleased = 10110;

		public const int TutorialStep_1_1_Summon = 10112;

		public const int TutorialStep_1_1_SummonIn = 10114;

		public const int TutorialStep_1_1_MultiSummonResult = 10115;

		public const int TutorialStep_1_1_MultiSummonDone = 10116;

		public const int TutorialStep_1_1_SummonResult = 10117;

		public const int TutorialStep_1_1_SummonDone = 10118;

		public const int TutorialStep_1_1_PartyReleased = 10120;

		public const int TutorialStep_1_1_PartyTopIn = 10130;

		public const int TutorialStep_1_1_PartyAuto = 10140;

		public const int TutorialStep_1_1_PartyAutoDone = 10145;

		public const int TutorialStep_Summon_Exchange_Start = 10147;

		public const int TutorialStep_1_1_QuestReleased = 10150;

		public const int TutorialStep_1_1_QuestReleasedDone = 10155;

		public const int TutorialStep_1_1_QuestChapterSelect = 10159;

		public const int TutorialStep_1_1_QuestSelect = 10160;

		public const int TutorialStep_1_1_QuestSelectDone = 10165;

		public const int TutorialStep_1_1_SupportSelect = 10170;

		public const int TutorialStep_1_1_SupportSelectDone = 10175;

		public const int TutorialStep_1_1_QuestResult = 10180;

		public const int TutorialStep_1_1_GrowthTop = 10190;

		public const int TutorialStep_1_1_Done = 10199;

		public const int TutorialStep_1_2_Start = 10200;

		public const int TutorialStep_1_2_QuestResult = 10210;

		public const int TutorialStep_1_2_MaterialReceiveDone = 10211;

		public const int TutorialStep_1_2_GrowthTop = 10220;

		public const int TutorialStep_1_2_GrowthTopWithImage = 10221;

		public const int TutorialStep_1_2_GrowthTopToGrowthAmulet = 10222;

		public const int TutorialStep_1_2_GrowthAmuletEnhanceSceneTop = 10230;

		public const int TutorialStep_1_2_GrowthAmuletEnhanceEnd = 10231;

		public const int TutorialStep_1_2_LimitBreakAmuletTutorialStart = 10240;

		public const int TutorialStep_1_2_LimitBreakAmuletEnd = 10252;

		public const int TutorialStep_1_2_Done = 10299;

		public const int TutorialStep_1_3_Start = 10300;

		public const int TutorialStep_1_3_Done = 10399;

		public const int TutorialStep_1_4_Start = 10400;

		public const int TutorialStep_1_4_QuestResult = 10420;

		public const int TutorialStep_1_4_GrowthTop = 10430;

		public const int TutorialStep_1_4_TapManaButton = 10440;

		public const int TutorialStep_1_4_SelectCharacter = 10450;

		public const int TutorialStep_1_4_GetBurstAttack = 10460;

		public const int TutorialStep_1_4_Done = 10499;

		public const int TutorialStep_1_5_Start = 10600;

		public const int TutorialStep_1_5_QuestResult = 10610;

		public const int TutorialStep_1_5_FortMenuTop = 10620;

		public const int TutorialStep_1_5_Fort = 10630;

		public const int TutorialStep_1_5_SetCoinPlant = 10640;

		public const int TutorialStep_1_5_SetCoinPlantDone = 10650;

		public const int TutorialStep_1_5_DragonContactStart = 10660;

		public const int TutorialStep_1_5_GoDragonGarden = 10670;

		public const int TutorialStep_1_5_ShowDragonContactPop = 10680;

		public const int TutorialStep_1_5_ReleaseStory = 10685;

		public const int TutorialStep_1_5_Done = 10699;

		public const int TutorialStep_2_1_Start = 20100;

		public const int TutorialStep_2_1_QuestResult = 20110;

		public const int TutorialStep_2_1_Done = 20199;

		public const int TutorialStep_2_1_2_Start = 20200;

		public const int TutorialStep_2_1_2_QuestPrepare = 20210;

		public const int TutorialStep_2_1_2_Done = 20299;

		public const int TutorialStep_2_2_Start = 20300;

		public const int TutorialStep_2_2_QuestResultEvent = 20309;

		public const int TutorialStep_2_2_QuestResult = 20310;

		public const int TutorialStep_2_2_QuestSelectToBackButton = 20311;

		public const int TutorialStep_2_2_Done = 20399;

		public const int TutorialStep_2_6_2_Start = 20620;

		public const int TutorialStep_2_6_2_NewChapterEffect = 20621;

		public const int TutorialStep_2_6_2_NewChapterEffectDone = 20622;

		public const int TutorialStep_2_6_2_GrowthTop = 20623;

		public const int TutorialStep_2_6_2_WeaponCraftTop = 20624;

		public const int TutorialStep_2_6_2_CraftTargetSelectCraftDone = 20625;

		public const int TutorialStep_2_6_2_Fort = 20626;

		public const int TutorialStep_2_6_2_Done = 20629;

		public const int TutorialStep_3_1_Start = 30100;

		public const int TutorialStep_3_1_NewChapterEffect = 30101;

		public const int TutorialStep_3_1_NewChapterEffectDone = 30102;

		public const int TutorialStep_3_1_Done = 30199;

		public const int TutorialStep_5_1_Start = 50100;

		public const int TutorialStep_5_1_NewChapterEffect = 50110;

		public const int TutorialStep_5_1_NewChapterEffectDone = 50120;

		public const int TutorialStep_5_1_ReleaseHard = 50130;

		public const int TutorialStep_5_1_Done = 50199;

		public const int TutorialStep_6_1_Start = 60100;

		public const int TutorialStep_6_1_NewChapterEffect = 60110;

		public const int TutorialStep_6_1_NewChapterEffectDone = 60120;

		public const int TutorialStep_6_1_Done = 60199;

		public const int TutorialStep_Growth_Dragon = 91001;

		public const int TutorialStep_Release_Shop = 91002;

		public const int TutorialStep_Release_Truth_Dragon_Battle = 91003;

		public const int TutorialStep_Party_Attr_Tutorial = 91004;

		public const int TutorialStep_Castle_Story_Tutorial = 91005;

		public const int TutorialStep_Release_Void_Battle = 91006;

		public const int TutorialStep_Release_Plus_Param = 91008;

		public const int TutorialStep_Astral_Raid = 91011;

		public const int TutorialStep_Release_Guild = 91012;

		public const int TutorialStep_Release_VeryHard = 91013;

		public const int TutorialStep_Release_Agito = 91014;

		public const int TutorialStep_Release_Instructor = 91015;

		public const int TutorialStep_Release_EditSkill = 91016;

		public const int TutorialStep_Release_DragonSphere = 91017;

		public const int TutorialStep_Release_Drill_DrillSceneStart = 11100101;

		public const int TutorialStep_Release_Drill_MypageSceneStart = 11100102;

		public const int TutorialStep_Release_WeaponCraft = 91018;

		public const int TutorialStep_Release_GrowCrest = 91019;

		public const int TutorialStep_Release_Diabolos = 160001;

		public const int TutorialStep_Release_Album = 116001;

		public const int TutorialStep_Release_Subdue = 160002;

		public const int TutorialStep_All_Done = 99999999;

		private int[] stepData;

		public const int tutorial_1_1_QuestTargetId = 1000103;

		public const int tutorial_1_2_QuestTargetId = 1000106;

		public const int tutorial_1_4_QuestTargetId = 1000109;

		public const int fortAvailableQuestTargetId = 1000111;

		public const int tutorial_1_5_QuestTargetId = 1000111;

		public const int tutorial_2_1_NewChapterTargetId = 1000201;

		public const int tutorial_2_1_2_ElementTargetId = 100020101;

		public const int tutorial_2_2_MultiPlayTargetId = 1000202;

		public static readonly int[] tutorial_2_2_GuestIds;

		public const int tutorial_2_2_MultiBattleQuestid = 201010101;

		public const int tutorial_2_5_3_QuestTargetId = 1000208;

		public const int tutorial_2_6_2_QuestTargetId = 1000210;

		public const int tutorial_3_1_DragonBattleTargetId = 1000311;

		public const int tutorial_4_1_lastChapterTargetId = 1000412;

		public const int tutorial_5_1_lastChapterTargetId = 1000509;

		public const int tutorial_6_1_lastChapterTargetId = 1000607;

		public const int tutorial_7_1_lastChapterTargetId = 1000709;

		public const int tutorial_9_1_lastChapterTargetId = 1000909;

		public const int tutorial_10_1_lastChapterTargetId = 1001009;

		public const int tutorial_7_questGroupId = 10007;

		public const int tutorial_8_questGroupId = 10008;

		public const int tutorial_9_questGroupId = 10009;

		public const int tutorial_10_questGroupId = 10010;

		public const int tutorial_11_questGroupId = 10011;

		public const int tutorial_1_2_AmuletId = 40020004;

		public const int tutorial_Diabolos_QuestEventMenuId = 2280501;

		public readonly int[] tutorial_Truth_Dragon_Battle_TargetIds;

		public readonly int[] tutorial_Truth_Dragon_Battle_TriggerIds;

		private int step;

		private int stepIndex;

		public int subStep;

		public TutorialStepData TutorialSkipStep;

		private static TutorialDataManager instance;

		private bool _isBlockNormalBackKeyAction;

		private Action actionCallBack;

		public bool isRestartTutorial
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

		public int executingTutorialFlagId
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

		public bool isPlayTutorialStory
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

		public static TutorialDataManager Instance => null;

		public int GetTutorialStep()
		{
			return default(int);
		}

		public void Load()
		{
		}

		public void Reset()
		{
		}

		public int AdvanceTutorialStep()
		{
			return default(int);
		}

		public void SetTutorialStep(int targetStep)
		{
		}

		public void AdvanceToTutorialStep(int targetStep)
		{
		}

		public bool IsPrologueCompleted()
		{
			return default(bool);
		}

		public bool IsOnTutorial()
		{
			return default(bool);
		}

		public void SetTutorialFlag()
		{
		}

		public static int GetGuideWindowMasterId(int tutorialStep)
		{
			return default(int);
		}

		public static TutorialGuideWindowData GetGuideWindowData(int tutorialStep)
		{
			return null;
		}

		public void GoOtherSceneTutorial(bool isDownloadScene = false)
		{
		}

		public bool CheckPlayTutorial()
		{
			return default(bool);
		}

		public bool CheckTutorialRequired()
		{
			return default(bool);
		}

		public bool CheckEventTutorialComplete()
		{
			return default(bool);
		}

		public bool CheckMultiTutorialComplete()
		{
			return default(bool);
		}

		public bool CheckMultiTutorialRequired()
		{
			return default(bool);
		}

		public bool IsReleaseEditSkill()
		{
			return default(bool);
		}

		public bool IsReleaseDragonSphere()
		{
			return default(bool);
		}

		public bool IsOpenDragonSphereFunction()
		{
			return default(bool);
		}

		public bool IsReleasedWeaponCraft()
		{
			return default(bool);
		}

		public bool IsReleasedGrowCrest()
		{
			return default(bool);
		}

		public bool CheckTutorialFlag(TutorialFlagData flagNumber)
		{
			return default(bool);
		}

		public void UpdateTutorialFlag(TutorialFlagData flagNumber, [Optional] UnityAction successCallback)
		{
		}

		public int GetServerTutorialStep()
		{
			return default(int);
		}

		public void UpdateServerTutorialStep(TutorialStepData stepData, bool isSkip = false, int entityId = 0, GiftType giftType = GiftType.NONE, [Optional] Action callback)
		{
		}

		private void SendDataOnSuccess(TutorialUpdateStepResponse res)
		{
		}

		private int GetLocalTutorialStep(TutorialStepData stepData)
		{
			return default(int);
		}

		private int GetNearTutorialStep(TutorialStepData stepData)
		{
			return default(int);
		}

		public bool IsLock(TutorialUIManager.LockButtonType type)
		{
			return default(bool);
		}

		public bool IsBlockNormalBackKeyAction()
		{
			return default(bool);
		}

		public void SetBlockNormalBackKeyAction(bool isBlock)
		{
		}

		public void SetExecutingTutorialFlagId(int tutorialStep)
		{
		}

		public bool IsReleaseTruthDragonBattle()
		{
			return default(bool);
		}

		public static bool IsReleaseChapterNine()
		{
			return default(bool);
		}

		public static bool IsReleaseVeryHard()
		{
			return default(bool);
		}

		public bool IsReleaseInstrctor()
		{
			return default(bool);
		}

		public bool IsReleaseDiabolos()
		{
			return default(bool);
		}

		private void GoQuestSelectWithSetPlayerPrefs(int questStoryId, bool isDownloadScene)
		{
		}

		public bool ShouldShowEditSkillTutorial()
		{
			return default(bool);
		}

		public bool ShouldShowPartyAttrTutorial()
		{
			return default(bool);
		}
	}
}
