using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class SummonModel : SummonModelBase
	{
		public enum StageEffectType
		{
			None = -1,
			R,
			SR,
			SSR,
			SSSR
		}

		public enum StagePredictionEffectType
		{
			None,
			Pigeon,
			TriPigeon,
			Fafnir,
			GemLight
		}

		public class Util
		{
			private const string imagesAtlasAssetsAssetTemplate = "Images/OutGame/Summon/Top/{0:D6}/Images";

			private const string localizedAtlasAssetsAssetTemplate = "Images/OutGame/Summon/Top/{0:D6}/Localized";

			public const string startDashAtlasPath = "Images/OutGame/Summon/Top/StartDash/Atlas";

			public const string imagesAtlasPattern = "^(Images/OutGame/Summon/Top/[0-9]*/Images)";

			public const string localizedAtlasPattern = "^(Images/OutGame/Summon/Top/[0-9]*/Localized)";

			public const string illustrationImageNameTemplate = "Summon_Character_Illust_{0:D2}";

			public const string coverBGImageName = "Summon_Top_BG";

			public const string coverUnitImageName = "Summon_Top_Character";

			public const string coverCardImageName = "Summon_Top_Card";

			public const string topBannerImageName = "Summon_Top_Banner";

			public const string topLogoImageName = "Summon_Top_logo";

			public const string topActivePeriodImageName = "Summon_Bg_ActivePeriod";

			public const string commentImageNameTemplate = "Summon_Character_Comment_{0:D2}";

			public const string skillImageNameTemplate = "Summon_Character_Skill_{0:D2}";

			public const string bottomInfoImageNameTemplate = "Summon_Character_Info_{0:D2}";

			public const string csBannerName = "Summon_Switch_Banner";

			public const string btnCampaignSummonNormalImageName = "Btn_Summon_06_Normal";

			public const string btnCampaignSummonPressedImageName = "Btn_Summon_06_Pressed";

			public const string bannerInfoScratchSummon = "Banner_Info_ScratchSummon";

			public const string bannerInfoUpdateSsrSummon = "Banner_Info_StartDash_02";

			public static void GetImageAtlasAssetsPath(int summonId, out string assetPath)
			{
			}

			public static void GetLocalizedAtlasAssetsPath(int summonId, out string assetPath)
			{
			}
		}

		private static SummonModel instance;

		private SummonTopItemData _itemData;

		public const string summonPrefabCommonPath = "Prefabs/OutGame/SummonShop/";

		public SummonTopData topData;

		public SummonTopItemData.ButtonType drawingSummonButtonType;

		public SummonType drawingSummonType;

		public int drawingSummonId;

		public int drawingSummonGroupId;

		public int useMultiSingleTicketCount;

		public int summonPoint;

		public static bool isInStage;

		public int currentStagePlayingIndex;

		public Rarity overallMaxRarity;

		public SummonTopItemView.SummonTopItemTabType lastSelectedSummonType;

		public static bool isExchangeSummonPointLoginCheck;

		public StageEffectType stageEffectType;

		public StagePredictionEffectType predictionEffectType;

		public int upgradeIndex;

		public static SummonModel Instance => null;

		public SummonTopItemData itemData => null;

		public override int singlePrice => default(int);

		public override int multiPrice => default(int);

		public static void DeleteInstance()
		{
		}

		private SummonModel()
		{
		}

		static SummonModel()
		{
		}

		public void ClearItemData()
		{
		}

		public override bool CanReSummon()
		{
			return default(bool);
		}

		public int GetQuestResultFreeMultiSummonCount(int summonId)
		{
			return default(int);
		}

		public void RecordDrawingSummonInfo(SummonTopItemData.ButtonType buttonType, int summonId)
		{
		}

		public override int GetTicketCount(bool multi)
		{
			return default(int);
		}

		public override bool IsSingle()
		{
			return default(bool);
		}

		public static string GetSingleTicketName()
		{
			return null;
		}

		public static string GetMultiTicketName()
		{
			return null;
		}

		public static string GetStartDashTicketName(SummonType type)
		{
			return null;
		}

		public static string GetStartDashTicketSummonIdName(SummonType type, int summonId)
		{
			return null;
		}

		public static int GetTicketOwnedCount(SummonType type)
		{
			return default(int);
		}

		public static int GetTicketTypeCount(SummonType type, int summonId)
		{
			return default(int);
		}

		public static SummonList GetSummonDataManagerItemBySummonId(int summonId)
		{
			return null;
		}

		public static bool IsCsSummon(int summonId)
		{
			return default(bool);
		}

		public static bool IsFreeSummonPeriod(int summonId)
		{
			return default(bool);
		}

		public static bool IsConsecutionCampaignRest(int summonId)
		{
			return default(bool);
		}

		private static bool IsFreeSummonRestCount(UserSummonList summonList)
		{
			return default(bool);
		}

		private static bool IsBeginnerFreeSummonRestCount(UserSummonList summonList)
		{
			return default(bool);
		}

		private static bool IsConsecutionCampaignRestCount(UserSummonList summonList)
		{
			return default(bool);
		}

		private static SummonList[] GameDataToArray(DataManager.GameData<SummonList> gameDataList)
		{
			return null;
		}

		public SummonTopItemData GetAnyTopItemDataBySummonGroupId(int summonGroupId)
		{
			return null;
		}

		public int GetAnyDrawnPlatinumSummonId()
		{
			return default(int);
		}

		public SummonTopItemData GetTopItemDataBySummonId(int summonId = -1)
		{
			return null;
		}

		public bool CheckDrawingSufficiency(int summonId, SummonTopItemData.ButtonType buttonType, bool checkForPaidStone)
		{
			return default(bool);
		}

		public int[] GetSummonIdListFromSummonGroup(int summonGroupId)
		{
			return null;
		}

		public static bool IsLimitSummonCount(SummonDataElement summon)
		{
			return default(bool);
		}

		public static int GetCsSummonComplateTime(int summonId)
		{
			return default(int);
		}

		public static int GetSummonPoint(int summonId)
		{
			return default(int);
		}

		public static int GetSummonExchangePoint(int summonId)
		{
			return default(int);
		}

		public static string GetSummonExchangeItemAname()
		{
			return null;
		}

		public static string GetSummonExchangeItemBname()
		{
			return null;
		}

		public static int GetCampaginSummonCountRest(int summonId)
		{
			return default(int);
		}
	}
}
