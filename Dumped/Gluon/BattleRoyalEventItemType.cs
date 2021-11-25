using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum BattleRoyalEventItemType
	{
		NONE = 0,
		EVENT_POINT = 10101,
		BR_UNIT_UNLOCK_ITEM = 10201,
		BR_UNIT_SKIN_ITEM = 10301
	}
}
