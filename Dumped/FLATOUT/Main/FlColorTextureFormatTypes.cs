using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlColorTextureFormatTypes
	{
		Compress,
		RGB16Bit,
		RGB24Bit,
		None
	}
}
