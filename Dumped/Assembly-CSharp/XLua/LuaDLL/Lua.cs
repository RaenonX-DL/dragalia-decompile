/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using XLua;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua.LuaDLL
{
	public class Lua
	{
		// Fields
		private const string LUADLL = "xlua";
	
		// Constructors
		public Lua();
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index);
		public static extern int xlua_get_lib_version();
		public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data);
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n);
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n);
		public static extern int lua_pushthread(IntPtr L);
		public static bool lua_isfunction(IntPtr L, int stackPos);
		public static bool lua_islightuserdata(IntPtr L, int stackPos);
		public static bool lua_istable(IntPtr L, int stackPos);
		public static bool lua_isthread(IntPtr L, int stackPos);
		public static int luaL_error(IntPtr L, string message);
		public static extern int lua_setfenv(IntPtr L, int stackPos);
		public static extern IntPtr luaL_newstate();
		public static extern void lua_close(IntPtr L);
		public static extern void luaopen_xlua(IntPtr L);
		public static extern void luaL_openlibs(IntPtr L);
		public static extern uint xlua_objlen(IntPtr L, int stackPos);
		public static extern void lua_createtable(IntPtr L, int narr, int nrec);
		public static void lua_newtable(IntPtr L);
		public static extern int xlua_getglobal(IntPtr L, string name);
		public static extern int xlua_setglobal(IntPtr L, string name);
		public static extern void xlua_getloaders(IntPtr L);
		public static extern void lua_settop(IntPtr L, int newTop);
		public static void lua_pop(IntPtr L, int amount);
		public static extern void lua_insert(IntPtr L, int newTop);
		public static extern void lua_remove(IntPtr L, int index);
		public static extern int lua_rawget(IntPtr L, int index);
		public static extern void lua_rawset(IntPtr L, int index);
		public static extern int lua_setmetatable(IntPtr L, int objIndex);
		public static extern int lua_rawequal(IntPtr L, int index1, int index2);
		public static extern void lua_pushvalue(IntPtr L, int index);
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n);
		public static extern void lua_replace(IntPtr L, int index);
		public static extern int lua_gettop(IntPtr L);
		public static extern LuaTypes lua_type(IntPtr L, int index);
		public static bool lua_isnil(IntPtr L, int index);
		public static extern bool lua_isnumber(IntPtr L, int index);
		public static bool lua_isboolean(IntPtr L, int index);
		public static extern int luaL_ref(IntPtr L, int registryIndex);
		public static int luaL_ref(IntPtr L);
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index);
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index);
		public static void lua_getref(IntPtr L, int reference);
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref);
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference);
		public static void lua_unref(IntPtr L, int reference);
		public static extern bool lua_isstring(IntPtr L, int index);
		public static extern bool lua_isinteger(IntPtr L, int index);
		public static extern void lua_pushnil(IntPtr L);
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0);
		public static extern int xlua_upvalueindex(int n);
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc);
		public static extern double lua_tonumber(IntPtr L, int index);
		public static extern int xlua_tointeger(IntPtr L, int index);
		public static extern uint xlua_touint(IntPtr L, int index);
		public static extern bool lua_toboolean(IntPtr L, int index);
		public static extern IntPtr lua_topointer(IntPtr L, int index);
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen);
		public static string lua_tostring(IntPtr L, int index);
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf);
		public static extern void lua_pushnumber(IntPtr L, double number);
		public static extern void lua_pushboolean(IntPtr L, bool value);
		public static extern void xlua_pushinteger(IntPtr L, int value);
		public static extern void xlua_pushuint(IntPtr L, uint value);
		public static void lua_pushstring(IntPtr L, string str);
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size);
		public static void xlua_pushasciistring(IntPtr L, string str);
		public static void lua_pushstring(IntPtr L, byte[] str);
		public static byte[] lua_tobytes(IntPtr L, int index);
		public static extern int luaL_newmetatable(IntPtr L, string meta);
		public static extern int xlua_pgettable(IntPtr L, int idx);
		public static extern int xlua_psettable(IntPtr L, int idx);
		public static void luaL_getmetatable(IntPtr L, string meta);
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name);
		public static int luaL_loadbuffer(IntPtr L, string buff, string name);
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj);
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj);
		public static int lua_error(IntPtr L);
		public static extern bool lua_checkstack(IntPtr L, int extra);
		public static extern int lua_next(IntPtr L, int index);
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata);
		public static extern IntPtr xlua_tag();
		public static extern void luaL_where(IntPtr L, int level);
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref);
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref);
		public static extern int gen_obj_indexer(IntPtr L);
		public static extern int gen_obj_newindexer(IntPtr L);
		public static extern int gen_cls_indexer(IntPtr L);
		public static extern int gen_cls_newindexer(IntPtr L);
		public static extern int get_error_func_ref(IntPtr L);
		public static extern int load_error_func(IntPtr L, int Ref);
		public static extern int luaopen_i64lib(IntPtr L);
		public static extern int luaopen_socket_core(IntPtr L);
		public static extern void lua_pushint64(IntPtr L, long n);
		public static extern void lua_pushuint64(IntPtr L, ulong n);
		public static extern bool lua_isint64(IntPtr L, int idx);
		public static extern bool lua_isuint64(IntPtr L, int idx);
		public static extern long lua_toint64(IntPtr L, int idx);
		public static extern ulong lua_touint64(IntPtr L, int idx);
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n);
		public static extern int xlua_csharp_str_error(IntPtr L, string message);
		public static extern int xlua_csharp_error(IntPtr L);
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field);
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field);
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field);
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field);
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field);
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field);
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field);
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field);
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field);
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field);
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field);
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field);
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref);
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref);
		public static extern IntPtr lua_touserdata(IntPtr L, int idx);
		public static extern int xlua_gettypeid(IntPtr L, int idx);
		public static extern int xlua_get_registry_index();
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path);
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path);
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2);
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2);
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3);
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3);
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4);
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4);
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5);
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5);
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6);
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6);
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec);
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64);
		public static bool xlua_is_eq_str(IntPtr L, int index, string str);
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len);
		public static extern IntPtr xlua_gl(IntPtr L);
	}
}
