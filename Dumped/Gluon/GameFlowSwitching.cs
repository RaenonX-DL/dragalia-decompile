using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum GameFlowSwitching
	{
		NONE,
		ENEMY_ABNORMAL,
		CHARACTER_SUDDEN_DEATH,
		BUGFIX_300178_ENABLED,
		BUGFIX_313453_PASSBYREFERENCE_ENABLED,
		BUGFIX_327208_BUGFIX,
		BUGFIX_327969_ENABLED
	}
}
