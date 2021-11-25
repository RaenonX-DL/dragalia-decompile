using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum WeaponAttackRangeType
	{
		NONE = 0,
		SHORT = 1,
		LONG = 2,
		ALL = 99
	}
}
