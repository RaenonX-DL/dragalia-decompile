using System;
using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 8)]
	public delegate object ObjectCast(IntPtr L, int idx, object target);
}
