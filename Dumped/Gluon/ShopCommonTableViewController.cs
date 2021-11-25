using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonTableViewController : TableViewController<ShopTradeProductData.CommonShopItemData>
	{
		private float cellHeight;

		private float cellWidth;

		public GameObject bottomNode;

		public GameObject maintenanceObject;

		[SerializeField]
		[Header("WarningText")]
		public Text noItemText;

		public ShopTradeProductData.CommonShopType shopType;

		private const string originalCellPrefabPath = "Prefabs/OutGame/ShopTrade/TableViewCell/ShopCommonItemCell";

		private const int paddingBottomLayoutHeight = 100;

		private const int paddingCellAdjustHeight = 56;

		private const int captionHeight = 68;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void ReloadTableData()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		public virtual void OnCellButtonPressedForCommonItem(ShopTradeProductData.CommonShopItemData data)
		{
		}

		protected override TableViewCell<ShopTradeProductData.CommonShopItemData> CreateCellForIndex(int index)
		{
			return null;
		}

		private void AppendAnimationForBottomItem(int index)
		{
		}

		protected override void UpdateContents()
		{
		}

		public void ScrollToItem(int tradeId)
		{
		}

		private float GetItemPosAtIndex(int findIndex)
		{
			return default(float);
		}
	}
}
