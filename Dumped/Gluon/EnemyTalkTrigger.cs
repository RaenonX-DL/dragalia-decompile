using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EnemyTalkTrigger
	{
		NONE,
		ENTRY_TIMING,
		DEAD_TIMING,
		HP_RATE,
		BREAK_HP_RATE,
		ENTRY_TIMING_2,
		EVENT_SKILL_SATAN_1,
		EVENT_SKILL_SATAN_2,
		RESERVE_04,
		RESERVE_05
	}
}
