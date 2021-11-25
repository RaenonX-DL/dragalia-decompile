using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum WeaponType
	{
		NONE,
		SWD,
		KAT,
		DAG,
		AXE,
		LAN,
		BOW,
		ROD,
		CAN,
		GUN
	}
}
