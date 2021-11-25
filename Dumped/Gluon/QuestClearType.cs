using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestClearType
	{
		NONE = 0,
		ANNIHILATION = 1,
		BOSS_DEAD = 2,
		TIME_ELAPSED = 4,
		REGION_INSIDE = 6,
		EVENT_DEFENSE = 8,
		SURVIVAL = 9,
		LAST_BOSS_DEAD = 10
	}
}
