using System;
using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 8)]
	public delegate bool ObjectCheck(IntPtr L, int idx);
}
