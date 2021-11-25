using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	public enum LuaThreadStatus
	{
		LUA_RESUME_ERROR = -1,
		LUA_OK,
		LUA_YIELD,
		LUA_ERRRUN,
		LUA_ERRSYNTAX,
		LUA_ERRMEM,
		LUA_ERRERR
	}
}
