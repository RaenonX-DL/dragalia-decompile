using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum UnitEnhanceListCellType
	{
		None,
		Status,
		LimitBreak,
		LimitOver,
		WeaponPassiveAbility,
		Slot,
		WeaponBonus,
		WeaponEffect,
		Equip
	}
}
