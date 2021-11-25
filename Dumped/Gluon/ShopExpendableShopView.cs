using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class ShopExpendableShopView : ShopTradePanelBase
	{
		private enum TabType
		{
			None,
			Diamond,
			Stamina,
			Storage
		}

		public Transform frameParent;

		public RectTransform referenceRect;

		[SerializeField]
		[Header("Tab")]
		public TabBase tabController;

		[SerializeField]
		[Header("TableView")]
		public ShopCommonTableViewController[] tableviews;

		private TabType currentTabType;

		private bool shopInitialized;

		public static ShopExpendableShopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void OnSwitchTab(int tabIndex, bool calledFromUI)
		{
		}

		private IEnumerator ReloadDiamondDataWait()
		{
			return null;
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void LoadTabs()
		{
		}

		private static void ReloadData()
		{
		}

		private void OnDestroy()
		{
		}

		public void ReloadPage()
		{
		}

		public override void RefreshCurrentPage()
		{
		}

		public void OnExtendWeaponQuantityButtonPressed()
		{
		}

		private void CreateExceedWeaponLimitPopup()
		{
		}

		private void CreateWeaponExtensionPopup()
		{
		}

		private void CheckStoneForWeaponExtension(bool isPaidStone)
		{
		}

		public void OnExtendDragonQuantityButtonPressed()
		{
		}

		private void CreateExceedDragonLimitPopup()
		{
		}

		private void CreateDragonExtensionPopup()
		{
		}

		private void CheckStoneForDragonExtension(bool isPaidStone)
		{
		}

		public void OnExtendAmuletQuantityButtonPressed()
		{
		}

		private void CreateExceedAmuletLimitPopup()
		{
		}

		private void CreateAmuletExtensionPopup()
		{
		}

		private void CheckStoneForAmuletExtension(bool isPaidStone)
		{
		}
	}
}
