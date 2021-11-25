using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class TradeItemOnTheSpotTableView : TableViewController<ShopTradeProductData.TradeShopItemData>
	{
		private float cellHeight;

		public TradeItemOnTheSpotPopup parentPopup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void LoadData(List<ShopTradeProductData.TradeShopItemData> dataList)
		{
		}

		protected override TableViewCell<ShopTradeProductData.TradeShopItemData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
