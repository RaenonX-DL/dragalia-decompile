using System.Collections.Generic;
using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class CraftTargetSelectListController : TableViewController<CraftTargetSelectCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public UnityAction<CraftTargetSelectCellData, bool> craftCellCallBack;

		public UnityAction<CraftTargetSelectCellData> treeCallBack;

		public List<int> breakNewFlagList;

		public TutorialDataManager.GrowthTutorialType tutorialType;

		protected override void Start()
		{
		}

		public void LoadCraftData(WeaponCraftGroupElement[] datas, bool isShowRootInfo)
		{
		}

		protected override TableViewCell<CraftTargetSelectCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void ClearList()
		{
		}

		public void UpdateShowRootFlag(bool flag)
		{
		}

		private int[] GetRootFinalWeaponList(WeaponCraftTreeElement craftTreeData)
		{
			return null;
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
