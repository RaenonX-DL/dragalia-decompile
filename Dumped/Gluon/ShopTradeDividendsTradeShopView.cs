using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeDividendsTradeShopView : ShopTradePanelBase
	{
		[SerializeField]
		[Header("TableView")]
		public ShopTradeTableViewController tableview;

		[SerializeField]
		[Header("Holding")]
		public Text ownedCountText;

		private static Action onHttpDone;

		private ShopTradeProductData.TradeShopItemData selectedData;

		public static ShopTradeDividendsTradeShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private static void ReloadData()
		{
		}

		private void Start()
		{
		}

		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data)
		{
		}

		private void SetupHoldingCount()
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
