using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ExtraBuffType
	{
		NONE,
		GOLDEN_BARRIER,
		OVER_CHARGE,
		LOCKED_ON,
		IRON_WALL,
		RESIST_ALL_ABNORMAL,
		BLUE_SCALE,
		UNDISPELLABLE,
		DISSONANCE,
		PHOENIX,
		SUBSTITUDE_DAMAGE,
		HL_EXCLUSIVE,
		PURSUIT,
		RESERVE_12,
		RESERVE_13,
		RESERVE_14,
		RESERVE_15,
		RESERVE_16,
		RESERVE_17,
		RESERVE_18,
		RESERVE_19
	}
}
