using UnityEngine;

namespace Gluon
{
	public class ShopSpecialItemShopView : ShopTradePanelBase
	{
		[SerializeField]
		[Header("TableView")]
		public ShopCommonTableViewController tableview;

		public static ShopSpecialItemShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private static void ReloadData()
		{
		}

		public void ReloadPage()
		{
		}

		public override void RefreshCurrentPage()
		{
		}

		public override void ScrollToItem(int tradeId)
		{
		}
	}
}
