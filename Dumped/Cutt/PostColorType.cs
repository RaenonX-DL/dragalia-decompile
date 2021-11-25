using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 4)]
	public enum PostColorType
	{
		ColorAll,
		Color2TopBottom,
		Color2LeftRight,
		Color4
	}
}
