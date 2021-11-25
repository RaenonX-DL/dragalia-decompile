using System;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeEventTradeShopView : ShopTradePanelBase
	{
		[SerializeField]
		[Header("TableView")]
		private ShopTradeTableViewController tableview;

		[SerializeField]
		[Header("TabControl")]
		public TabBase[] tabControllers;

		[SerializeField]
		[Header("ResetInfo")]
		public Text resetInfoText;

		[SerializeField]
		public RectTransform frameDialogRectTransform;

		private List<ShopTradeTableViewController> tableViewList;

		private TabBase usingTabBase;

		private static Action onHttpDone;

		private ShopTradeProductData.TradeShopItemData selectedData;

		public static ShopTradeEventTradeShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		private void Awake()
		{
		}

		private static void ReloadData()
		{
		}

		public static void OnEntryHttpSuccess(EventTradeGetListResponse response)
		{
		}

		private void OnEnable()
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

		public void SetSelectTabIndex(int index)
		{
		}
	}
}
