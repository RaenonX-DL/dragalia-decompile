using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum CuttTimelineSoundOperationID
	{
		CONTINUE,
		PLAY_3D,
		PLAY_NORMAL,
		STOP,
		PLAY_INGAME
	}
}
