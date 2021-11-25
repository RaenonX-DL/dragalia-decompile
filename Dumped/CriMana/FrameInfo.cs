using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(0, Size = 64)]
	public class FrameInfo
	{
		public int frameNo;

		public int frameNoPerFile;

		public uint width;

		public uint height;

		public uint dispWidth;

		public uint dispHeight;

		public uint framerateN;

		public uint framerateD;

		public ulong time;

		public ulong tunit;

		public uint cntConcatenatedMovie;

		private AlphaType alphaType;

		public uint cntSkippedFrames;

		public uint totalFramesPerFile;
	}
}
