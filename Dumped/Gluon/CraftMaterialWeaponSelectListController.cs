using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class CraftMaterialWeaponSelectListController : SelectIconListControllerBase
	{
		[HideInInspector]
		public int[] targetIds;

		[HideInInspector]
		public int[] targetLimitbreak;

		[HideInInspector]
		public List<ulong> usedKeyIdList;

		public Action iconLockCallBack;

		protected override void Start()
		{
		}

		private void LoadListData()
		{
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		public void InitListParam(int[] ids, int[] limitbreak, int needCount, ulong[] usedKeyIds)
		{
		}

		protected override bool IsSelectableData(CommonIconListCellData data)
		{
			return default(bool);
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private ulong[] CreateDataIdList(int[] ids, int[] limitBreakCount)
		{
			return null;
		}

		public void OnSortButtonClicked()
		{
		}

		public void MaterialAutoSelect(int maxSelectCount)
		{
		}
	}
}
