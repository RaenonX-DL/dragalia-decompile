using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(0, Size = 440)]
	public class MovieInfo
	{
		private uint _reserved1;

		private uint _hasAlpha;

		public uint width;

		public uint height;

		public uint dispWidth;

		public uint dispHeight;

		public uint framerateN;

		public uint framerateD;

		public uint totalFrames;

		private uint _codecType;

		private uint _alphaCodecType;

		public uint numAudioStreams;

		public AudioInfo[] audioPrm;

		public uint numSubtitleChannels;

		public uint maxSubtitleSize;

		public bool hasAlpha
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CodecType codecType
		{
			get
			{
				return default(CodecType);
			}
			set
			{
			}
		}

		public CodecType alphaCodecType
		{
			get
			{
				return default(CodecType);
			}
			set
			{
			}
		}
	}
}
