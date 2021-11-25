using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class TradeItemOnTheSpotPopup : CommonPopup
	{
		public Transform contentParent;

		[SerializeField]
		private TradeItemOnTheSpotTableView tableView;

		private int itemId;

		private List<ShopTradeProductData.TradeShopItemData> items;

		public static TradeItemOnTheSpotPopup Create(int itemId)
		{
			return null;
		}

		private void RequestTradeData(int itemId)
		{
		}

		private void OnEntryHttpSuccess(TreasureTradeGetListAllResponse response)
		{
		}

		public void RefreshExchangeView()
		{
		}
	}
}
