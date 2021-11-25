using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ElementalType
	{
		NONE = 0,
		FIRE = 1,
		WATER = 2,
		WIND = 3,
		LIGHT = 4,
		DARK = 5,
		NOELEMENT = 99
	}
}
