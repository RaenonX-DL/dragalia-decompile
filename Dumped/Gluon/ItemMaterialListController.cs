using Gluon.Http;
using UnityEngine.Events;

namespace Gluon
{
	public class ItemMaterialListController : TableViewController<ItemMaterialCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public GrowMaterialListBase materialListBase;

		public UnityAction<int, int> itemCellCallback;

		public int nowExp;

		public int maxExp;

		public int maxHpPlus;

		public int maxAtkPlus;

		public TutorialDataManager.GrowthTutorialType tutorialType;

		public int CellCount => default(int);

		public void LoadItemData(MaterialList[] useItemDatas)
		{
		}

		private int GetMaxUseItemCount(int itemId)
		{
			return default(int);
		}

		public void ItemCellCountLock(bool isExpItemLock, bool isHpPlusItemLock, bool isAtkPlusItemLock)
		{
		}

		public void Reload()
		{
		}

		public void ClearList()
		{
		}

		public void ItemListCountClear()
		{
		}

		private void CellLock(MaterialType type, bool isLock)
		{
		}

		public ItemMaterialCellData[] GetAutoSelectMaterial(int expMargin)
		{
			return null;
		}

		protected override TableViewCell<ItemMaterialCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		private void OnApplicationPause(bool stop)
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
	}
}
