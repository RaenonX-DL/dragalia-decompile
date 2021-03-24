/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeProductData
	{
		// Fields
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
	
		// Nested types
		public enum PlatformType
		{
			None = 0,
			iOS = 1,
			Android = 2
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
			// Fields
			[CompilerGenerated]
			private CommonShopType _shopType_k__BackingField;
			public List<CommonShopItemData> items;
	
			// Properties
			public CommonShopType shopType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<MissionSpecialDataElement, int> __9__14_0;
				public static Func<ShopCommonIcon.SpecialIconSetting, bool> __9__15_0;
				public static Comparison<CommonShopItemData> __9__23_0;
				public static Comparison<CommonShopItemData> __9__23_2;
				public static Comparison<CommonShopItemData> __9__23_3;
				public static Comparison<CommonShopItemData> __9__23_1;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal int _CreateCommonItemDataContentList_b__14_0(MissionSpecialDataElement x);
				internal bool _CreateCommonItemDataContentList_b__15_0(ShopCommonIcon.SpecialIconSetting x);
				internal int _SortByPriorityAndStatus_b__23_0(CommonShopItemData a, CommonShopItemData b);
				internal int _SortByPriorityAndStatus_b__23_2(CommonShopItemData a, CommonShopItemData b);
				internal int _SortByPriorityAndStatus_b__23_3(CommonShopItemData a, CommonShopItemData b);
				internal int _SortByPriorityAndStatus_b__23_1(CommonShopItemData a, CommonShopItemData b);
			}
	
			// Constructors
			public CommonShopData(CommonShopType type);
	
			// Methods
			public void Clear();
			private bool ShouldCommonMasterItemOnList(string commenceDate, string completeDate, QuestType requiredQuestType, int requiredQuestId, bool checkDayOfWeek = false, DayOfWeek dayOfWeek = DayOfWeek.Monday, PlatformType platform = PlatformType.None);
			private bool CheckPlatform(PlatformType platform);
			public bool ShouldCommonMasterItemOnList(SpecialShopElement elem);
			private bool ShouldCommonMasterItemOnList(MaterialShopDailyElement elem);
			private bool ShouldCommonMasterItemOnList(MaterialShopWeeklyElement elem);
			private bool ShouldCommonMasterItemOnList(MaterialShopMonthlyElement elem);
			private bool ShouldCommonMasterItemOnList(NormalShopElement elem);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(EntityData[] contentDataList = null, ShopCommonIcon.SpecialIconSetting[] specialIcons = null, int missionGroup = 0);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(SpecialShopElement elem);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopDailyElement elem);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopWeeklyElement elem);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(MaterialShopMonthlyElement elem);
			private List<CommonShopItemContentData> CreateCommonItemDataContentList(NormalShopElement elem);
			public void LoadData();
			private void LoadExpendableItemDragonDiamondData();
			private void LoadSpecialItem(SpecialShopElement data, bool forPurchaseStonePopup = false);
			public void SortByPriorityAndStatus();
			public CommonShopItemData ShopWeeklyLoadData(int id);
			private bool IsOpenAstralRaid();
		}
	
		public class CommonShopItemContentData
		{
			// Fields
			public GiftType giftType;
			public int id;
			public int count;
			public int limitBreak;
			public bool isMission;
			public ShopCommonIcon.SpecialIconSetting specialIconSetting;
	
			// Constructors
			public CommonShopItemContentData();
		}
	
		public class CommonShopItemData
		{
			// Fields
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
	
			// Properties
			public CommonShopType groupedShopType { get; }
			public string dreamSelectEntityName { get; }
			public bool isSustainableItemEffectiveNoSync { get; }
			public long preOrderEndUnixTime { get; }
			public int preOrderRemainDayCount { get; }
			public QuantityLimitStatus quantityLimitStatus { get; }
			public bool isEmpty { get; }
	
			// Nested types
			public enum PackContentType
			{
				None = 0,
				Item = 10,
				MissionItem = 20,
				StartDash = 30,
				DailyCrystal = 40,
				DailyStamina = 50,
				QuestBonus = 60,
				PeriodLimitSinglePack = 70,
				SSRCharaPack = 80,
				SSRDragonPack = 81,
				SSRCharaDragonPack = 82,
				SSRDragonBoostPack = 83,
				SSRDragonGrowPack = 84,
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
				None = 0,
				GoodsOnly = 1,
				WithBonusItems = 2,
				WithMissionItems = 3
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
				CurrentPurchasable = 0,
				PreOrderable = 1,
				LimitReached = 2
			}
	
			public class DisposableParameters
			{
				// Fields
				public bool sentToPresentBox;
	
				// Constructors
				public DisposableParameters();
			}
	
			// Constructors
			public CommonShopItemData();
			public CommonShopItemData(int tradeId, CommonShopType shopType, PackContentType packContentType);
	
			// Methods
			public bool Equals(CommonShopItemData data);
			public InsufficientInfo CheckSufficiency();
			public void GetSpecialContentNameAndDescription(out ShopCommonIcon.SpecialIconSetting[] specialIcons);
			public void ModifyWithNPFData(double price, string displayPrice, string sku, string title, int amount, int extraAmount);
			public void FillNameAndDescription(string name, string description);
			public void FillResetTypeByMasterResetType(int masterResetType);
			public void FillPriceType(PaymentType paymentType, int optionValue);
			public void FillPurchasedInfo();
			public bool FillProductInfo(int paymentRelationId);
			public void FillSustainableInfo(int masterResetType);
		}
	
		public class AddStorageSpaceInfo
		{
			// Fields
			public int price;
			public int limit;
			public int addCount;
			public int tradeId;
	
			// Constructors
			public AddStorageSpaceInfo();
			public AddStorageSpaceInfo(int price, int limit, int addCount, int tradeId);
		}
	
		public enum InsufficientReason
		{
			None = 0,
			OutOfTimePeriod = 1,
			OverQuantityLimit = 2,
			NeedReleaseStory = 3,
			NeedClearQuest = 4,
			LackOfCoin = 5,
			LackOfMaterial = 6,
			LackOfTicket = 7,
			LackOfCurrency = 8,
			LackOfLimitBreak = 9,
			StorageFull = 10,
			Locked = 11,
			Error = 12
		}
	
		public class InsufficientInfo
		{
			// Fields
			public List<InsufficientReason> failReasonList;
			public List<int> storageFullIndexList;
	
			// Properties
			public bool allGreen { get; }
			public bool shouldEnableButton { get; }
			public bool isOverQuantityLimit { get; }
	
			// Constructors
			public InsufficientInfo();
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
			Max = 256
		}
	
		public class TradeShopData
		{
			// Fields
			[CompilerGenerated]
			private TradeShopType _shopType_k__BackingField;
			public List<TradeShopItemData> items;
	
			// Properties
			public TradeShopType shopType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Comparison<TradeShopItemData> __9__15_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal int _SortByPriority_b__15_0(TradeShopItemData left, TradeShopItemData right);
			}
	
			// Constructors
			public TradeShopData(TradeShopType type);
	
			// Methods
			public void Clear();
			private static void AddNeededMaterials(TradeShopItemData item, int entity_id, int entity_quantity, GiftType entity_type, int limit_break_count);
			public static TradeShopItemData CreateTradeShopItemData(TreasureTradeElement dataItem, TradeShopType tradeShopType);
			public static bool IsTreasureTradeEnable(TreasureTradeElement element);
			public static bool IsTreasureShowEnable(TreasureTradeElement element);
			public static bool IsTreasureTradeGotLimit(TreasureTradeElement element);
			private static int GetTreasureTradedCount(TreasureTradeElement element);
			public static bool IsTreasureStepAvaliable(TreasureTradeElement element);
			public void LoadData();
			public void SortByPriority();
			public static int GetOncePurchaseLimit(GiftType type);
		}
	
		[Serializable]
		public class ViewedRecord
		{
			// Fields
			public List<ulong> record;
	
			// Constructors
			public ViewedRecord();
		}
	
		public class TradeShopItemData
		{
			// Fields
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
	
			// Nested types
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
				Normal = 0,
				RaidUltimateTrade = 1
			}
	
			public class NeedMaterialInfo
			{
				// Fields
				public int id;
				public int quantity;
				public GiftType giftType;
				public int limitBreak;
	
				// Constructors
				public NeedMaterialInfo();
				public NeedMaterialInfo(int id, int count, GiftType giftType = GiftType.MATERIAL, int limitBreak = 0);
			}
	
			// Constructors
			public TradeShopItemData();
	
			// Methods
			public InsufficientReason CheckSufficiency();
			public bool IsLimitOver();
		}
	
		// Constructors
		public ShopTradeProductData();
	
		// Methods
		private static int GetTradeIdByProductIntId(int id);
		public static bool IsValidRegion(SpecialShopElement elem);
		public AddStorageSpaceInfo GetAddStorageSpaceInfo(StorageExtensionPopup.StorageType storageType);
		public static void RecordNewFlag(ref List<TradeShopItemData> tableData);
		public static void RecordNewFlag(ref List<CommonShopItemData> tableData);
		public static List<TradeShopItemData> ApplyFilter(List<TradeShopItemData> originalList, ShopTradeModel.FilterCondition filterCondition = null);
	}
}
