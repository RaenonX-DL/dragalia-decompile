using System.Runtime.InteropServices;

namespace CriMana
{
	[StructLayout(3, Size = 4)]
	public enum CodecType
	{
		Unknown = 0,
		SofdecPrime = 1,
		H264 = 5,
		VP9 = 9
	}
}
