using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum DungeonItemEffect
	{
		NULL,
		HP,
		HP_DMG,
		SP,
		SP_DMG,
		DP,
		DP_DMG
	}
}
