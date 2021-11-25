using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlUIInputDirectionTypes
	{
		Up,
		Down,
		Left,
		Right,
		UpperLeft,
		UpperRight,
		DownLeft,
		DownRight,
		None
	}
}
