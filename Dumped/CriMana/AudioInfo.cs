using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(0, Size = 12)]
	public struct AudioInfo
	{
		public uint samplingRate;

		public uint numChannels;

		public uint totalSamples;
	}
}
