using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	internal class InternalGlobals
	{
		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);

		internal static byte[] strBuff;

		internal static TryArrayGet genTryArrayGetPtr;

		internal static TryArraySet genTryArraySetPtr;

		internal static ObjectTranslatorPool objectTranslatorPool;

		internal static int LUA_REGISTRYINDEX;

		internal static Dictionary<string, string> supportOp;

		internal static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap;

		internal static lua_CSFunction LazyReflectionWrap;

		static InternalGlobals()
		{
		}
	}
}
