using UnityEngine;

namespace Gluon
{
	public class SellIconListController : CommonDualListTableViewController
	{
		[SerializeField]
		private Vector2 weaponListCellSize;

		public SellListScene scene;

		public int CellCount => default(int);

		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		public void UpdateCellByKeyIds(ulong[] keyIds)
		{
		}

		public void SetMultiSelectFlag(bool flag)
		{
		}

		protected override void UpdateContents()
		{
		}

		public void UpdateAutoSelectButtonState()
		{
		}

		public void UpdateCellDataSelectNumber()
		{
		}

		public void AllListIconLock()
		{
		}

		public void AllListIconUnlock()
		{
		}

		public void IconListSelectClear()
		{
		}

		public ulong[] GetAutoSelectKeys(int maxSelect)
		{
			return null;
		}

		public void SetLock(SellEquipIconCellData data, bool isLock, bool setUpdateFlag)
		{
		}

		protected override void CustomSort()
		{
		}
	}
}
