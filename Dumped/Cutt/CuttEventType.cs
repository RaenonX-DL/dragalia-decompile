using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum CuttEventType
	{
		PAUSE,
		WAIT,
		CONTINUE_PRINT,
		PLAYER_ACTION,
		ENEMY_ACTION,
		SKIP_POINT,
		TAP_WAIT,
		ROTATE_CHARA,
		FORCE_SKIP
	}
}
