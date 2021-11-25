using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	public enum LuaGCOptions
	{
		LUA_GCSTOP,
		LUA_GCRESTART,
		LUA_GCCOLLECT,
		LUA_GCCOUNT,
		LUA_GCCOUNTB,
		LUA_GCSTEP,
		LUA_GCSETPAUSE,
		LUA_GCSETSTEPMUL
	}
}
