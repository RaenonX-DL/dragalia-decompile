using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CommonIconListType
	{
		None,
		Character,
		Dragon,
		Weapon,
		Amulet,
		Item,
		Skill,
		WeaponPassiveAbility,
		WeaponSkin
	}
}
