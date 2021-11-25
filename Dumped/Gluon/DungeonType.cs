using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum DungeonType
	{
		NONE = 0,
		NORMAL = 1,
		RAID = 2,
		RANDOM = 3,
		FIELD = 4,
		VERSUS = 5,
		WAVE = 6,
		DEFENSE = 7,
		TUTORIAL = 9,
		RAID_SINGLE = 10,
		DRAGON_SOLO = 11,
		DRAGON_RELAY = 12,
		BATTLE_ROYAL = 13,
		NORMAL_SOLO = 14,
		PARTY_SWITCH = 0xF,
		WALKER = 0x10,
		SCORING = 17,
		RAID_SIXTEEN = 18
	}
}
