using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EnemyToughType
	{
		COMMON,
		RARE,
		STRONG,
		BOSS,
		SYNC,
		RAID,
		PARTS,
		GM,
		PROTECTION,
		FRIEND,
		RESERVE_04,
		RESERVE_05
	}
}
