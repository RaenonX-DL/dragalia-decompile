using System;
using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	public enum GenFlag
	{
		No,
		[Obsolete]
		GCOptimize
	}
}
