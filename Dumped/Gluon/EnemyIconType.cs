using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EnemyIconType
	{
		NONE,
		ICON_MOB1,
		ICON_MOB2,
		ICON_BOSS1,
		ICON_BOSS2
	}
}
