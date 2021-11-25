using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class SelectIconListControllerBase : CommonIconListController
	{
		[HideInInspector]
		public List<ulong> selectKeys;

		public Action<CommonIconListCellData> onIconPressedCallBack;

		[HideInInspector]
		protected int maxSelectCount;

		protected bool isAllListIconLock;

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

		public int CheckSelectIcon(ulong keyId)
		{
			return default(int);
		}

		public void UpdateCellByKeyIds(ulong[] keyIds)
		{
		}

		public void SetMultiSelectFlag(bool flag)
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

		protected void UpdateSelectIconNumber()
		{
		}

		protected virtual void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		protected virtual bool IsSelectableData(CommonIconListCellData data)
		{
			return default(bool);
		}

		protected virtual void UnSelectIcon(ulong targetKey)
		{
		}

		protected void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}
	}
}
