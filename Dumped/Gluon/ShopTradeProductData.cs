using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;

namespace Gluon
{
	public class ShopTradeProductData
	{
		public enum PlatformType
		{
			None,
			iOS,
			Android
		}

		public enum CommonShopType
		{
			None = 0,
			SpecialItem = 70,
			Sustainable = 71,
			Limited = 72,
			MaterialItemDaily = 80,
			MaterialItemWeekly = 81,
			MaterialItemMonthly = 82,
			ExpendableItemDragonDiamond = 90,
			ExpendableItemStamina = 91,
			ExpendableItemStorage = 92,
			Costume = 120
		}

		public class CommonShopData
		{
			public List<CommonShopItemData> items;

			public CommonShopType shopType
			{
				[CompilerGenerated]
				get
				{
					return default(CommonShopType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public CommonShopData(CommonShopType type)
			{
			}

			public void Clear()
			{
			}

			private bool ShouldCommonMasterItemOnList(string commenceDate, string completeDate, QuestType requiredQuestType, int requiredQuestId, bool checkDayOfWeek = false, DayOfWeek dayOfWeek = DayOfWeek.Monday, PlatformType platform = PlatformType.None)
			{
				return default(bool);
			}

			private bool CheckPlatform(PlatformType platform)
			{
				return default(bool);
			}

			public bool ShouldCommonMasterItemOnList(SpecialShopElement elem)
			{
				return default(bool);
			}

			private bool ShouldCommonMasterItemOnList(MaterialShopDailyElement elem)
			{
				return default(bool);
			}

			private bool ShouldCommonMasterItemOnList(MaterialShopWeeklyElement elem)
			{
				return default(bool);
			}

			private bool ShouldCommonMasterItemOnList(MaterialShopMonthlyElement elem)
			{
				return default(bool);
			}

			private bool ShouldCommonMasterItemOnList(NormalShopElement elem)
			{
				return default(bool);
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList([Optional] EntityData[] contentDataList, [Optional] ShopCommonIcon.SpecialIconSetting[] specialIcons, int missionGroup = 0)
			{
				return null;
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList(SpecialShopElement elem)
			{
				return null;
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopDailyElement elem)
			{
				return null;
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopWeeklyElement elem)
			{
				return null;
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopMonthlyElement elem)
			{
				return null;
			}

			private List<CommonShopItemContentData> CreateCommonItemDataContentList(NormalShopElement elem)
			{
				return null;
			}

			public void LoadData()
			{
			}

			private void LoadExpendableItemDragonDiamondData()
			{
			}

			private void LoadSpecialItem(SpecialShopElement data, bool forPurchaseStonePopup = false)
			{
			}

			public void SortByPriorityAndStatus()
			{
			}

			public CommonShopItemData ShopWeeklyLoadData(int id)
			{
				return null;
			}

			private bool IsOpenAstralRaid()
			{
				return default(bool);
			}
		}

		public class CommonShopItemContentData
		{
			public GiftType giftType;

			public int id;

			public int count;

			public int limitBreak;

			public bool isMission;

			public ShopCommonIcon.SpecialIconSetting specialIconSetting;
		}

		public class CommonShopItemData
		{
			public enum PackContentType
			{
				None = 0,
				Item = 10,
				MissionItem = 20,
				StartDash = 30,
				WelcomePack2 = 0x1F,
				DailyCrystal = 40,
				DailyStamina = 50,
				QuestBonus = 60,
				PeriodLimitSinglePack = 70,
				SSRCharaPack = 80,
				SSRDragonPack = 81,
				SSRCharaDragonPack = 82,
				SSRDragonBoostPack = 83,
				SSRDragonGrowPack = 84,
				SSRCharaUpdatePack = 85,
				SSRDragonUpdatePack = 86,
				SingleStamina = 110,
				MultiStamina = 111,
				WeaponStorage = 120,
				AmuletStorage = 121,
				DragonStorage = 122,
				AllStorage = 123,
				AstralItem = 124
			}

			public enum PackContentSubType
			{
				None,
				GoodsOnly,
				WithBonusItems,
				WithMissionItems
			}

			public enum SpecialShopCategory
			{
				None = 0,
				StarterPack = 1,
				SustainablePack = 2,
				MissionPack = 3,
				LimitPeriod = 4,
				Unavailable = 200
			}

			public enum ResetType
			{
				None = 0,
				Daily = 1,
				Weekly = 2,
				Monthly = 3,
				BattleRoyalCycle = 6
			}

			public enum QuantityLimitStatus
			{
				CurrentPurchasable,
				PreOrderable,
				LimitReached
			}

			public class DisposableParameters
			{
				public bool sentToPresentBox;
			}

			public const int preOrderableCountDownDay = 3;

			public int tradeId;

			public string productId;

			public string bannerFileName;

			public string itemName;

			public int boughtCount;

			public bool isLocked;

			public int purchaseLimit;

			public int sustainableItemDuration;

			public DateTime lastPurchasedDate;

			public PaymentType priceType;

			public PaymentType originalPriceType;

			public int serviceFlowType;

			public int priceChangeGroupId;

			public string displayPrice;

			public int price;

			public int priority;

			public int recommendLabelType;

			public DateTime completeDateUtc;

			public long endUnixTime;

			public string description;

			public ResetType resetType;

			public CommonShopType shopType;

			public PackContentType packContentType;

			public PackContentSubType packContentSubType;

			public SpecialShopCategory originalDivisionType;

			public SpecialShopCategory divisionType;

			public int specialShopGroupPriority;

			public string groupTitle;

			public bool firstItemInDivision;

			public int limitViewType;

			public int viewPlatform;

			public int dreamSelectEntityId;

			public int dreamSelectEntityType;

			public bool willSendToPresentBox;

			public bool shouldDisplayNew;

			public List<CommonShopItemContentData> contentList;

			public CommonShopType groupedShopType => default(CommonShopType);

			public string dreamSelectEntityName => null;

			public bool isSustainableItemEffectiveNoSync => default(bool);

			public long preOrderEndUnixTime => default(long);

			public int preOrderRemainDayCount => default(int);

			public QuantityLimitStatus quantityLimitStatus => default(QuantityLimitStatus);

			public bool isEmpty => default(bool);

			public bool Equals(CommonShopItemData data)
			{
				return default(bool);
			}

			public CommonShopItemData()
			{
			}

			public CommonShopItemData(int tradeId, CommonShopType shopType, PackContentType packContentType)
			{
			}

			public InsufficientInfo CheckSufficiency()
			{
				return null;
			}

			public void GetSpecialContentNameAndDescription(out ShopCommonIcon.SpecialIconSetting[] specialIcons)
			{
			}

			public void ModifyWithNPFData(double price, string displayPrice, string sku, string title, int amount, int extraAmount)
			{
			}

			public void FillNameAndDescription(string name, string description)
			{
			}

			public void FillResetTypeByMasterResetType(int masterResetType)
			{
			}

			public void FillPriceType(PaymentType paymentType, int optionValue)
			{
			}

			public void FillPurchasedInfo()
			{
			}

			public bool FillProductInfo(int paymentRelationId)
			{
				return default(bool);
			}

			public void FillSustainableInfo(int masterResetType)
			{
			}
		}

		public class AddStorageSpaceInfo
		{
			public int price;

			public int limit;

			public int addCount;

			public int tradeId;

			public AddStorageSpaceInfo()
			{
			}

			public AddStorageSpaceInfo(int price, int limit, int addCount, int tradeId)
			{
			}
		}

		public enum InsufficientReason
		{
			None,
			OutOfTimePeriod,
			OverQuantityLimit,
			NeedReleaseStory,
			NeedClearQuest,
			LackOfCoin,
			LackOfMaterial,
			LackOfTicket,
			LackOfCurrency,
			LackOfLimitBreak,
			StorageFull,
			Locked,
			Error
		}

		public class InsufficientInfo
		{
			public List<InsufficientReason> failReasonList;

			public List<int> storageFullIndexList;

			public bool allGreen => default(bool);

			public bool shouldEnableButton => default(bool);

			public bool isOverQuantityLimit => default(bool);
		}

		public enum TradeShopType
		{
			TreasureTrade = 10,
			MoonBronze = 20,
			MoonSilver = 21,
			MoonGold = 22,
			DividendsTrade = 30,
			EventTrade = 40,
			TicketCharacter = 60,
			TicketDragon = 61,
			FreeExchange = 70,
			Max = 0x100
		}

		public class TradeShopData
		{
			public List<TradeShopItemData> items;

			public TradeShopType shopType
			{
				[CompilerGenerated]
				get
				{
					return default(TradeShopType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TradeShopData(TradeShopType type)
			{
			}

			public void Clear()
			{
			}

			private static void AddNeededMaterials(TradeShopItemData item, int entity_id, int entity_quantity, GiftType entity_type, int limit_break_count)
			{
			}

			public static TradeShopItemData CreateTradeShopItemData(TreasureTradeElement dataItem, TradeShopType tradeShopType)
			{
				return null;
			}

			public static bool IsTreasureTradeEnable(TreasureTradeElement element)
			{
				return default(bool);
			}

			public static bool IsTreasureShowEnable(TreasureTradeElement element)
			{
				return default(bool);
			}

			public static bool IsTreasureTradeGotLimit(TreasureTradeElement element)
			{
				return default(bool);
			}

			private static int GetTreasureTradedCount(TreasureTradeElement element)
			{
				return default(int);
			}

			public static bool IsTreasureStepAvaliable(TreasureTradeElement element)
			{
				return default(bool);
			}

			public void LoadData()
			{
			}

			public void SortByPriority()
			{
			}

			public static int GetOncePurchaseLimit(GiftType type)
			{
				return default(int);
			}
		}

		[Serializable]
		public class ViewedRecord
		{
			public List<ulong> record;
		}

		public class TradeShopItemData
		{
			public enum ResetType
			{
				None = 0,
				Daily = 1,
				Weekly = 2,
				Monthly = 3,
				BattleRoyalCycle = 6
			}

			public enum SpecialLayoutType
			{
				Normal,
				RaidUltimateTrade
			}

			public class NeedMaterialInfo
			{
				public int id;

				public int quantity;

				public GiftType giftType;

				public int limitBreak;

				public NeedMaterialInfo()
				{
				}

				public NeedMaterialInfo(int id, int count, GiftType giftType = GiftType.MATERIAL, int limitBreak = 0)
				{
				}
			}

			public int tradeId;

			public int eventId;

			public int needLimitBreakAbilityCrestId;

			public string itemName;

			public int itemId;

			public int itemLimitBreakCount;

			public GiftType giftType;

			public int bunchCount;

			public int priority;

			public int boughtCount;

			public int purchaseLimit;

			public int oncePurchaseLimit;

			public int price;

			public string endTime;

			public int endUnixTime;

			public string description;

			public int needStoryCount;

			public int lockByQuestId;

			public int tabGroupId;

			public int startUnixTime;

			public bool isLockView;

			public SpecialLayoutType layoutType;

			public List<NeedMaterialInfo> needMaterialInfoList;

			public ResetType resetType;

			public TradeShopType shopType;

			public bool sentToPresentBox;

			public bool shouldDisplayNew;

			public string itemNoticeText;

			public InsufficientReason CheckSufficiency()
			{
				return default(InsufficientReason);
			}

			public bool IsLimitOver()
			{
				return default(bool);
			}
		}

		public CommonShopData stoneShopData;

		public TradeShopData treasureTradeShopData;

		public TradeShopData moonBronzeShopData;

		public TradeShopData moonSilverShopData;

		public TradeShopData moonGoldShopData;

		public TradeShopData ticketCharacterData;

		public TradeShopData ticketDragonShopData;

		public TradeShopData dividendsShopData;

		public TradeShopData currentEventTradeShopData;

		public CommonShopData specialItemShopData;

		public CommonShopData sustainableItemShopData;

		public CommonShopData limitedItemShopData;

		public CommonShopData materialDailyItemShopData;

		public CommonShopData materialWeeklyItemShopData;

		public CommonShopData materialMonthlyItemShopData;

		public CommonShopData expendableItemDragonDiamondShopData;

		public CommonShopData expendableItemStaminaShopData;

		public CommonShopData expendableItemStorageShopData;

		public CommonShopData costumeShopData;

		private const int tableViewColumnCount = 2;

		private static int GetTradeIdByProductIntId(int id)
		{
			return default(int);
		}

		public static bool IsValidRegion(SpecialShopElement elem)
		{
			return default(bool);
		}

		public AddStorageSpaceInfo GetAddStorageSpaceInfo(StorageExtensionPopup.StorageType storageType)
		{
			return null;
		}

		public static void RecordNewFlag(ref List<TradeShopItemData> tableData)
		{
		}

		public static void RecordNewFlag(ref List<CommonShopItemData> tableData)
		{
		}

		public static List<TradeShopItemData> ApplyFilter(List<TradeShopItemData> originalList, [Optional] ShopTradeModel.FilterCondition filterCondition)
		{
			return null;
		}
	}
}
