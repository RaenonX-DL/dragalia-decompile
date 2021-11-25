using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GrowthIconType
	{
		None,
		Dragon,
		Weapon,
		Chara,
		Skill,
		Ability,
		Item,
		Amulet
	}
}
