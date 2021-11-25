using System.Collections.Generic;

namespace Gluon
{
	public class GrowthWeaponAbilitySelectPopup : CommonPopup
	{
		public GrowthWeaponAbilitySelectPopupListController weaponTypeAbilityListController;

		private GrowthUnitEnhanceModel model;

		private List<int> selectIdList;

		public int[] selectIds => null;

		public static GrowthWeaponAbilitySelectPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		private void LoadCellList()
		{
		}

		private ulong[] SetWeaponPassiveAbilityList()
		{
			return null;
		}

		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OnIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void ShowReleaseConditionPopup(int conditionParam)
		{
		}
	}
}
