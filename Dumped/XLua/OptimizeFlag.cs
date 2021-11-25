using System;
using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	[Flags]
	public enum OptimizeFlag
	{
		Default = 0x0,
		PackAsTable = 0x1
	}
}
