using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponTypeAbilityListController : CommonDualListTableViewController
	{
		[HideInInspector]
		public WeaponType targetWeaponType;

		protected override CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected override void CustomSort()
		{
		}
	}
}
