using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EnemyBoundaryCondition
	{
		NONE,
		INVINCIBLE,
		IMMUNITY,
		STOP_1,
		RESERVE_01,
		RESERVE_02,
		RESERVE_03,
		RESERVE_04,
		RESERVE_05,
		RESERVE_06
	}
}
