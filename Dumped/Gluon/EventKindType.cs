using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EventKindType
	{
		NONE,
		RAID,
		FIELD_QUEST,
		RANDOM,
		BUILD,
		COLLECT,
		CLB_01,
		EX_RUSH,
		EX_HUNTER,
		SIMPLE,
		COMBAT,
		BATTLE_ROYAL,
		EARN
	}
}
