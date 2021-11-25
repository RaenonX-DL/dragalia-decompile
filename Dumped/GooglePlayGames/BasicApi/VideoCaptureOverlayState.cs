using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi
{
	[StructLayout(3, Size = 4)]
	public enum VideoCaptureOverlayState
	{
		Unknown = -1,
		Shown = 1,
		Started = 2,
		Stopped = 3,
		Dismissed = 4
	}
}
