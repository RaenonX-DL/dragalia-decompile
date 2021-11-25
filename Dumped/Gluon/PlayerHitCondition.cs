using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum PlayerHitCondition
	{
		NONE,
		HIT_TARGET_NUM_IN_P1P2,
		HIT_NUM_IN_P1P2,
		HIT_TARGET_HAS_P1_BUFF
	}
}
