using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeTableViewController : TableViewController<ShopTradeProductData.TradeShopItemData>
	{
		public ShopTradeProductData.TradeShopType shopType;

		public string originalCellPrefabPath;

		[SerializeField]
		[Header("Sort")]
		public Transform sortButtonParent;

		[SerializeField]
		[Header("WarningText")]
		public Text noTradeItemText;

		public Text noTradeByFilterItemText;

		private float cellHeight;

		private List<SimpleAnimationCell> animationCellList;

		private List<ShopTradeProductData.TradeShopItemData> originalData;

		private ShopTradeModel.FilterCondition filterCondition;

		private const int paddingBottomLayoutHeight = 80;

		private bool stopRecordNewState;

		private CommonSortButton sortButton;

		private const string sortButtonPrefabPath = "UI/Buttons/SortButton";

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void SetFitlerTab(int tab)
		{
		}

		protected void ReloadTableData()
		{
		}

		protected void OnFilterApplied(ShopTradeModel.FilterCondition condition)
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

		public void ApplySortToData(List<ShopTradeProductData.TradeShopItemData> originalData, ShopTradeModel.FilterCondition filterCondition)
		{
		}

		protected override void UpdateContents()
		{
		}

		public void ReloadPage()
		{
		}
	}
}
