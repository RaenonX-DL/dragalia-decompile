using UnityEngine;

namespace Gluon
{
	public class ShopTradeExchangeTopView : ShopTradePanelBase
	{
		private enum TabType
		{
			None,
			Normal,
			Event
		}

		[SerializeField]
		[Header("Tab")]
		public TabBase tabController;

		[SerializeField]
		[Header("TableView")]
		public ShopTreasureTradeTopTableViewController normalTableView;

		public ShopEventTradeTopTableViewController eventTableView;

		private static TabType lastSelectedTab;

		private TabType currentTabType;

		public static ShopTradeExchangeTopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnSwitchTab(int tabIndex, bool calledFromUI)
		{
		}

		private void LoadTabs()
		{
		}

		public void OnTreasureCellButtonPressed(int groupId)
		{
		}

		public void OnEventCellButtonPressed(int groupId)
		{
		}

		public static void ClearLastSelectedTab()
		{
		}

		private void DisableButtonForReason(GameObject tab, TutorialUIManager.LockButtonType type)
		{
		}
	}
}
