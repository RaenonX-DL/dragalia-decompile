using System.Collections.Generic;

namespace Gluon
{
	public class AbilityPageData
	{
		public AbilityConst.UnitType abilityGiftType;

		public int abilityId;

		public ElementalType abilityElementType;

		public WeaponType abilityWeaponType;

		public bool isReleased;

		public List<int> duplicationAbilityIds;

		public List<int> duplicationShiftAbilityIds;
	}
}
