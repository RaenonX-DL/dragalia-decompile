using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum LookToDamageType
	{
		OLD_STYLE,
		NO_LOOK,
		HIT_POS,
		ATTACKER,
		REVERSE,
		RESERVE_01,
		RESERVE_02,
		RESERVE_03
	}
}
