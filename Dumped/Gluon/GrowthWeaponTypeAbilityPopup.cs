using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponTypeAbilityPopup : CommonPopup
	{
		public TabBase weaponTypeTabBase;

		public GrowthWeaponTypeAbilityListController weaponTypeAbilityListController;

		public GameObject emptyTextObject;

		public Text changeButtonText;

		private int tabIndex;

		private List<ulong> weaponPassiveAbilityList;

		public static GrowthWeaponTypeAbilityPopup Create()
		{
			return null;
		}

		public void InitPopup(int defaultTabIndex = 1)
		{
		}

		public void OnTabSelected(int index)
		{
		}

		public void OnChangeListTypeButtonPressed()
		{
		}

		private void LoadCellList()
		{
		}

		private void ReloadList()
		{
		}

		private void SetWeaponPassiveAbilityList(WeaponType type)
		{
		}

		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}
	}
}
