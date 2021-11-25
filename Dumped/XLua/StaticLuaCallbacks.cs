using System;
using XLua.LuaDLL;

namespace XLua
{
	public class StaticLuaCallbacks
	{
		internal lua_CSFunction GcMeta;

		internal lua_CSFunction ToStringMeta;

		internal lua_CSFunction EnumAndMeta;

		internal lua_CSFunction EnumOrMeta;

		internal lua_CSFunction StaticCSFunctionWraper;

		internal lua_CSFunction FixCSFunctionWraper;

		internal lua_CSFunction DelegateCtor;

		internal static bool __tryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index)
		{
			return default(bool);
		}

		internal static bool __tryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
			return default(bool);
		}

		public static int EnumAnd(IntPtr L)
		{
			return default(int);
		}

		public static int EnumOr(IntPtr L)
		{
			return default(int);
		}

		private static int StaticCSFunction(IntPtr L)
		{
			return default(int);
		}

		private static int FixCSFunction(IntPtr L)
		{
			return default(int);
		}

		public static int DelegateCall(IntPtr L)
		{
			return default(int);
		}

		public static int LuaGC(IntPtr L)
		{
			return default(int);
		}

		public static int ToString(IntPtr L)
		{
			return default(int);
		}

		public static int DelegateCombine(IntPtr L)
		{
			return default(int);
		}

		public static int DelegateRemove(IntPtr L)
		{
			return default(int);
		}

		private static bool tryPrimitiveArrayGet(Type type, IntPtr L, object obj, int index)
		{
			return default(bool);
		}

		public static int ArrayIndexer(IntPtr L)
		{
			return default(int);
		}

		public static bool TryPrimitiveArraySet(Type type, IntPtr L, object obj, int array_idx, int obj_idx)
		{
			return default(bool);
		}

		public static int ArrayNewIndexer(IntPtr L)
		{
			return default(int);
		}

		public static int ArrayLength(IntPtr L)
		{
			return default(int);
		}

		public static int MetaFuncIndex(IntPtr L)
		{
			return default(int);
		}

		internal static int Panic(IntPtr L)
		{
			return default(int);
		}

		internal static int Print(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadSocketCore(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadCS(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadBuiltinLib(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadFromResource(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadFromStreamingAssetsPath(IntPtr L)
		{
			return default(int);
		}

		internal static int LoadFromCustomLoaders(IntPtr L)
		{
			return default(int);
		}

		public static int LoadAssembly(IntPtr L)
		{
			return default(int);
		}

		public static int ImportType(IntPtr L)
		{
			return default(int);
		}

		public static int ImportGenericType(IntPtr L)
		{
			return default(int);
		}

		public static int Cast(IntPtr L)
		{
			return default(int);
		}

		private static Type getType(IntPtr L, ObjectTranslator translator, int idx)
		{
			return null;
		}

		public static int XLuaAccess(IntPtr L)
		{
			return default(int);
		}

		public static int XLuaPrivateAccessible(IntPtr L)
		{
			return default(int);
		}

		public static int XLuaMetatableOperation(IntPtr L)
		{
			return default(int);
		}

		public static int DelegateConstructor(IntPtr L)
		{
			return default(int);
		}

		public static int ToFunction(IntPtr L)
		{
			return default(int);
		}

		public static int GenericMethodWraper(IntPtr L)
		{
			return default(int);
		}

		public static int GetGenericMethod(IntPtr L)
		{
			return default(int);
		}

		public static int ReleaseCsObject(IntPtr L)
		{
			return default(int);
		}
	}
}
