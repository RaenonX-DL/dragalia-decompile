using System.Runtime.InteropServices;

namespace Cute.Cri
{
	[StructLayout(3, Size = 4)]
	public enum LatencyCheckState
	{
		None,
		Checking,
		ResultOk,
		ResultError
	}
}
