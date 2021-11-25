using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum TribeType
	{
		NONE,
		MAGIC_CREATURE,
		NATURAL,
		DEMI_HUMAN,
		BEAST,
		UNDEAD,
		DEMON,
		HUMAN,
		DRAGON
	}
}
