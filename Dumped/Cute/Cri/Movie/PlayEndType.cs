using System.Runtime.InteropServices;

namespace Cute.Cri.Movie
{
	[StructLayout(3, Size = 4)]
	public enum PlayEndType
	{
		Pause,
		Stop,
		Destroy
	}
}
