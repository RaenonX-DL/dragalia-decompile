using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum BattleRoyalDungeonItemSet
	{
		NONE,
		EMPTY,
		COMMON,
		RARE,
		RECOVERY,
		UPGRADE_WEAPON_1,
		UPGRADE_WEAPON_2,
		UPGRADE_WEAPON_3,
		ITEM_ABILITY_1,
		ITEM_ABILITY_2,
		ITEM_ABILITY_3,
		ITEM_ABILITY_4,
		ITEM_ABILITY_5
	}
}
