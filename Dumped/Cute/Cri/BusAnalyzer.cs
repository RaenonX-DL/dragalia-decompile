using System;
using System.Runtime.InteropServices;

namespace Cute.Cri
{
	public class BusAnalyzer : IDisposable
	{
		private GCHandle gch;

		private byte[] bytes;

		private IntPtr Ptr => default(IntPtr);

		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info);

		public void Dispose()
		{
		}

		public float GetPeakLevel(int bus, int channel)
		{
			return default(float);
		}
	}
}
