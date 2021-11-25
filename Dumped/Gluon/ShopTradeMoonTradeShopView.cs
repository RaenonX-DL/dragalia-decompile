using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeMoonTradeShopView : ShopTradePanelBase
	{
		private enum MoonType
		{
			None,
			Bronze,
			Silver,
			Gold
		}

		[SerializeField]
		[Header("Tab")]
		public TabBase tabController;

		[SerializeField]
		[Header("Title")]
		public Text[] ownedCountText;

		[SerializeField]
		[Header("TableView")]
		public ShopTradeTableViewController[] tableviews;

		private int[] ownedMoonCount;

		private MoonType currentTabType;

		private static Action onHttpDone;

		private ShopTradeProductData.TradeShopItemData selectedData;

		public static ShopTradeMoonTradeShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		public void OnSwitchTab(int tabIndex, bool calledFromUI)
		{
		}

		private static void ReloadData()
		{
		}

		private void Awake()
		{
		}

		private void UpdateTitleCount()
		{
		}

		private void Start()
		{
		}

		private void LoadTabs()
		{
		}

		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data)
		{
		}

		public void ReloadPage()
		{
		}

		public override void RefreshCurrentPage()
		{
		}
	}
}
