/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeModel
	{
		// Fields
		private static ShopTradeModel instance;
		public ShopTradeScene scene;
		public PanelType currentPanel;
		public PanelType nextPanel;
		public int enterSceneScrollToItem;
		public ShopTradeProductData.CommonShopItemData.PackContentType enterSceneScrollToItemType;
		public ShopTradeProductData.CommonShopItemData.SpecialShopCategory enterSceneScrollToItemSpecialShopCategory;
		public const string prefabPath = "Prefabs/OutGame/ShopTrade/";
		public ShopTradeProductData data;
		public int currentMaterialSummonStepIndex;
		public List<NPFPayment.ProductInfo> productInfoList;
		public Dictionary<int, ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData> abilityCrestTradeDataDic;
		public ShopTopData shopTopData;
		public int selectedEventGroupID;
		public int selectedTreasureGroupID;
		public bool purchaseStoneDataUpdated;
	
		// Properties
		public static ShopTradeModel Instance { get; }
	
		// Nested types
		public enum PanelType
		{
			None = 0,
			Top = 1,
			StoneShop = 2,
			ItemShopTop = 3,
			ExchangeTop = 6,
			TreasureTradeShop = 7,
			MoonExchangeShop = 8,
			TicketExchangeShop = 9,
			DividendsExchangeShop = 10,
			EventTreasureTradeTop = 11,
			EventTreasureTradeShop = 12,
			TreasureTradeShopTop = 13,
			SpecialItemShop = 14,
			MaterialItemShop = 15,
			ExpendableItemShop = 16,
			CosutmeShop = 17,
			TreasureMaterialSelect = 18,
			AmuletExchange = 19,
			StorageShop = 41,
			SustainableShop = 50,
			LimitedShop = 51
		}
	
		public class EventTradeTopData
		{
			// Fields
			public int eventGroupId;
			public long beginTime;
			public long endTime;
			public int priority;
	
			// Constructors
			public EventTradeTopData();
		}
	
		public class TreasureTradeTopData
		{
			// Fields
			public int treasureGroupId;
			public int treasureShopType;
			public long beginTime;
			public long endTime;
			public int priority;
	
			// Constructors
			public TreasureTradeTopData();
		}
	
		public class ShopTopData
		{
			// Fields
			public SustainableBonusData crystalBonusData;
			public SustainableBonusData staminaBonusData;
			public SustainableBonusData questBonusData;
	
			// Nested types
			public class SustainableBonusData
			{
				// Fields
				public const int crystalBonusTotalCounts = 7;
				public const int staminaBonusTotalDays = 30;
				public const int questBonusTotalDays = 7;
				public int remainDays;
				public ShopSustainableTopButton.Status status;
				public long endUnixTime;
	
				// Constructors
				public SustainableBonusData();
			}
	
			// Constructors
			public ShopTopData();
		}
	
		public class ShopTopBannerData
		{
			// Fields
			public int imageIndex;
			public PanelType panelType;
			public ShopTradeProductData.CommonShopItemData item;
			public ShopTradeProductData.TradeShopItemData tradeItem;
			public int tabIndex;
			public int eventTradeGroupIndex;
	
			// Constructors
			public ShopTopBannerData(int imageIndex, PanelType panelType, ShopTradeProductData.CommonShopItemData item, int tabIndex);
			public ShopTopBannerData(int imageIndex, PanelType panelType, ShopTradeProductData.TradeShopItemData tradeItem);
		}
	
		public enum TreasureTradeShopType
		{
			Normal = 1,
			DragonBattle = 2,
			ExDragonBattle = 3,
			InterceptionBattle = 4,
			VoidBattle = 5,
			AgitoBattle = 6,
			MostDefinitelyDiabolosBattle = 7
		}
	
		public class FilterCondition
		{
			// Fields
			public bool isAffordableOnly;
			public bool isFilterGiftTypeOther;
			public GiftType filterGiftType;
			public CommonSortModel.Condition.FilterCondition.ElementalFilter elementalFilter;
			public int tabGroupIndex;
	
			// Constructors
			public FilterCondition();
	
			// Methods
			public bool isAnyFilterOn();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<EventTradeTopData, int> __9__25_0;
			public static Comparison<TreasureTradeTopData> __9__27_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadEventTradeTopData_b__25_0(EventTradeTopData x);
			internal int _LoadTreasureTradeTopData_b__27_0(TreasureTradeTopData a, TreasureTradeTopData b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public int goodsId;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal bool _GetCommonShopTypeByPanelTypeAndGoodsId_b__0(ShopTradeProductData.CommonShopItemData x);
			internal bool _GetCommonShopTypeByPanelTypeAndGoodsId_b__1(ShopTradeProductData.CommonShopItemData x);
		}
	
		// Constructors
		private ShopTradeModel();
		static ShopTradeModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceNull();
		public List<EventTradeTopData> LoadEventTradeTopData();
		public List<TreasureTradeTopData> LoadTreasureTradeTopData();
		public static bool CheckIsStorageFullForItem(GiftType giftType, int id);
		public static bool checkEntityResultSentToPresentBox(EntityResult entityResult);
		public static string GetGiftTypeTitleText(GiftType giftType);
		public void UpdateByTopData(ShopGetListResponse.CommonResponse data);
		public void UpdateSustainableBonusData(AtgenStoneBonus[] stoneBonus, AtgenStaminaBonus[] staminaBonus, AtgenQuestBonus[] questBonus);
		public void UpdateMaterialSummonData(int lastSummonTime, int dailySummonCount);
		public static int GetCommonTransitionCountForReset(int lastTransitionTime, int rawCount, ShopTradeProductData.CommonShopItemData.ResetType resetType, bool forceSetToDaily = false);
		public void ImportBundleInfo(List<NPFPayment.ProductInfo> bundleInfoList);
		public static void GetResetTimes(out DateTime nextDailyTime, out DateTime nextWeeklyTime, out DateTime nextMonthlyTime, bool addResetTimeAndToLocal = true);
		public static bool IsItemOnListAndValid(List<ShopTradeProductData.CommonShopType> typeList, int tradeId);
		public static ShopTradeProductData.CommonShopType GetCommonShopTypeByPanelTypeAndGoodsId(PanelType panelType, int goodsId);
		public static bool IsItemOnListAndValid(ShopTradeProductData.CommonShopType type, int tradeId);
	}
}
