using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EnemyPopType
	{
		NONE,
		POPPED,
		LINK_ENEMY,
		LINK_OBJECT,
		ENTER,
		HP,
		SUMMON,
		OVERDRIVE,
		GAMEMASTER,
		WALL_BOSS,
		RESERVE_03,
		RESERVE_04,
		RESERVE_05
	}
}
