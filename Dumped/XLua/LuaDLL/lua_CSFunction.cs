using System;
using System.Runtime.InteropServices;

namespace XLua.LuaDLL
{
	[StructLayout(3, Size = 8)]
	public delegate int lua_CSFunction(IntPtr L);
}
