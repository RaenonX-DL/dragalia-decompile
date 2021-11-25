using System;
using System.Collections.Generic;
using Gluon.Http;
using NPF;

namespace Gluon
{
	public class ShopTradeModel
	{
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
			MaterialItemShop = 0xF,
			ExpendableItemShop = 0x10,
			CosutmeShop = 17,
			TreasureMaterialSelect = 18,
			AmuletExchange = 19,
			StorageShop = 41,
			SustainableShop = 50,
			LimitedShop = 51
		}

		public class EventTradeTopData
		{
			public int eventGroupId;

			public long beginTime;

			public long endTime;

			public int priority;
		}

		public class TreasureTradeTopData
		{
			public int treasureGroupId;

			public int treasureShopType;

			public long beginTime;

			public long endTime;

			public int priority;
		}

		public class ShopTopData
		{
			public class SustainableBonusData
			{
				public const int crystalBonusTotalCounts = 7;

				public const int staminaBonusTotalDays = 30;

				public const int questBonusTotalDays = 7;

				public int remainDays;

				public ShopSustainableTopButton.Status status;

				public long endUnixTime;
			}

			public SustainableBonusData crystalBonusData;

			public SustainableBonusData staminaBonusData;

			public SustainableBonusData questBonusData;
		}

		public class ShopTopBannerData
		{
			public int imageIndex;

			public PanelType panelType;

			public ShopTradeProductData.CommonShopItemData item;

			public ShopTradeProductData.TradeShopItemData tradeItem;

			public int tabIndex;

			public int eventTradeGroupIndex;

			public ShopTopBannerData(int imageIndex, PanelType panelType, ShopTradeProductData.CommonShopItemData item, int tabIndex)
			{
			}

			public ShopTopBannerData(int imageIndex, PanelType panelType, ShopTradeProductData.TradeShopItemData tradeItem)
			{
			}
		}

		public enum TreasureTradeShopType
		{
			Normal = 1,
			DragonBattle,
			ExDragonBattle,
			InterceptionBattle,
			VoidBattle,
			AgitoBattle,
			MostDefinitelyDiabolosBattle
		}

		public class FilterCondition
		{
			public bool isAffordableOnly;

			public bool isFilterGiftTypeOther;

			public GiftType filterGiftType;

			public CommonSortModel.Condition.FilterCondition.ElementalFilter elementalFilter;

			public int tabGroupIndex;

			public bool isAnyFilterOn()
			{
				return default(bool);
			}
		}

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

		public static ShopTradeModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private ShopTradeModel()
		{
		}

		static ShopTradeModel()
		{
		}

		public List<EventTradeTopData> LoadEventTradeTopData()
		{
			return null;
		}

		public List<TreasureTradeTopData> LoadTreasureTradeTopData()
		{
			return null;
		}

		public static bool CheckIsStorageFullForItem(GiftType giftType, int id)
		{
			return default(bool);
		}

		public static bool checkEntityResultSentToPresentBox(EntityResult entityResult)
		{
			return default(bool);
		}

		public static string GetGiftTypeTitleText(GiftType giftType)
		{
			return null;
		}

		public void UpdateByTopData(ShopGetListResponse.CommonResponse data)
		{
		}

		public void UpdateSustainableBonusData(AtgenStoneBonus[] stoneBonus, AtgenStaminaBonus[] staminaBonus, AtgenQuestBonus[] questBonus)
		{
		}

		public void UpdateMaterialSummonData(int lastSummonTime, int dailySummonCount)
		{
		}

		public static int GetCommonTransitionCountForReset(int lastTransitionTime, int rawCount, ShopTradeProductData.CommonShopItemData.ResetType resetType, bool forceSetToDaily = false)
		{
			return default(int);
		}

		public void ImportBundleInfo(List<NPFPayment.ProductInfo> bundleInfoList)
		{
		}

		public static void GetResetTimes(out DateTime nextDailyTime, out DateTime nextWeeklyTime, out DateTime nextMonthlyTime, bool addResetTimeAndToLocal = true)
		{
		}

		public static bool IsItemOnListAndValid(List<ShopTradeProductData.CommonShopType> typeList, int tradeId)
		{
			return default(bool);
		}

		public static ShopTradeProductData.CommonShopType GetCommonShopTypeByPanelTypeAndGoodsId(PanelType panelType, int goodsId)
		{
			return default(ShopTradeProductData.CommonShopType);
		}

		public static bool IsItemOnListAndValid(ShopTradeProductData.CommonShopType type, int tradeId)
		{
			return default(bool);
		}
	}
}
