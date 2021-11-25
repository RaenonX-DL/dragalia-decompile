using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftMaterialWeaponSelectPopup : CommonPopup
	{
		public Action<int> createMaterialWeaponCallBack;

		[SerializeField]
		private CraftMaterialWeaponTargetCell[] materialTargetIcon;

		[SerializeField]
		private Text needCountText;

		[SerializeField]
		private CraftMaterialWeaponSelectListController listController;

		private int needCount;

		public ulong[] selectMaterialKeyIds => null;

		public static CraftMaterialWeaponSelectPopup Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPopup(CraftMaterialCellData cellData, ulong[] usedKeyIds, bool isLockDetailPopup = false)
		{
		}

		public void SetSelectKeyIds(ulong[] selectKeyIds)
		{
		}

		public void OnAutoSelectPressed()
		{
		}

		public void UpdatePopup()
		{
		}

		private void OnMaterialIconPressed(CommonIconListCellData cellData)
		{
		}

		private void ShowDetailPopup(int weaponId)
		{
		}
	}
}
