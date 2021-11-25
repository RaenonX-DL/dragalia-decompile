using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopMaterialItemShopView : ShopTradePanelBase
	{
		private enum TabType
		{
			None,
			Daily,
			Weekly,
			Monthly
		}

		[SerializeField]
		[Header("Tab")]
		public TabBase tabController;

		[SerializeField]
		[Header("TableView")]
		public ShopCommonTableViewController[] tableviews;

		[SerializeField]
		[Header("Summon")]
		public GameObject freeSummonGO;

		public GameObject allFreeSummonGO;

		public GameObject campaignMarkGO;

		public GameObject normalSummonGO;

		public GameObject unavailableSummonGO;

		[SerializeField]
		[Header("Campaign")]
		public Text campaignRemainTimeText;

		[SerializeField]
		[Header("UpdateDateText")]
		public Text updateDateText;

		public Text updatePeriodText;

		public Text summonPriceText;

		public Button summonButton;

		public GameObject[] summonBadges;

		private TabType currentTabType;

		public static ShopMaterialItemShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void RaiseTalk(bool isTouched)
		{
		}

		public void OnSwitchTab(int tabIndex, bool calledFromUI)
		{
		}

		private void Update()
		{
		}

		private string GetTimeLeftString(DateTime from, DateTime to, string templateDays, string templateHours, string templateMinutes)
		{
			return null;
		}

		private void LoadTabs()
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

		public static int GetCurrentSummonPrice()
		{
			return default(int);
		}

		private void RefreshSummon()
		{
		}

		public void OnDrawMaterialSummonButtonPressed()
		{
		}

		public void OnDrawMaterialSummonOddsButtonPressed()
		{
		}
	}
}
