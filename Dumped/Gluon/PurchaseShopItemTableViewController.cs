using System;
using System.Collections.Generic;

namespace Gluon
{
	public class PurchaseShopItemTableViewController : ShopCommonTableViewController
	{
		public GiftType pickUpGiftType;

		public Action onUpdateCallback;

		protected override void ReloadTableData()
		{
		}

		private List<ShopTradeProductData.CommonShopItemData> PickUpListData(List<ShopTradeProductData.CommonShopItemData> beforeData, GiftType giftType)
		{
			return null;
		}

		protected override TableViewCell<ShopTradeProductData.CommonShopItemData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContents()
		{
		}
	}
}
