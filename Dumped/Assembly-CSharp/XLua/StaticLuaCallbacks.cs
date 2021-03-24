/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class StaticLuaCallbacks
	{
		// Fields
		internal lua_CSFunction GcMeta;
		internal lua_CSFunction ToStringMeta;
		internal lua_CSFunction EnumAndMeta;
		internal lua_CSFunction EnumOrMeta;
		internal lua_CSFunction StaticCSFunctionWraper;
		internal lua_CSFunction FixCSFunctionWraper;
		internal lua_CSFunction DelegateCtor;
	
		// Constructors
		public StaticLuaCallbacks();
	
		// Methods
		internal static bool __tryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);
		internal static bool __tryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
		[MonoPInvokeCallback]
		public static int EnumAnd(IntPtr L);
		[MonoPInvokeCallback]
		public static int EnumOr(IntPtr L);
		[MonoPInvokeCallback]
		private static int StaticCSFunction(IntPtr L);
		[MonoPInvokeCallback]
		private static int FixCSFunction(IntPtr L);
		[MonoPInvokeCallback]
		public static int DelegateCall(IntPtr L);
		[MonoPInvokeCallback]
		public static int LuaGC(IntPtr L);
		[MonoPInvokeCallback]
		public static int ToString(IntPtr L);
		[MonoPInvokeCallback]
		public static int DelegateCombine(IntPtr L);
		[MonoPInvokeCallback]
		public static int DelegateRemove(IntPtr L);
		private static bool tryPrimitiveArrayGet(Type type, IntPtr L, object obj, int index);
		[MonoPInvokeCallback]
		public static int ArrayIndexer(IntPtr L);
		public static bool TryPrimitiveArraySet(Type type, IntPtr L, object obj, int array_idx, int obj_idx);
		[MonoPInvokeCallback]
		public static int ArrayNewIndexer(IntPtr L);
		[MonoPInvokeCallback]
		public static int ArrayLength(IntPtr L);
		[MonoPInvokeCallback]
		public static int MetaFuncIndex(IntPtr L);
		[MonoPInvokeCallback]
		internal static int Panic(IntPtr L);
		[MonoPInvokeCallback]
		internal static int Print(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadSocketCore(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadCS(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadBuiltinLib(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadFromResource(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadFromStreamingAssetsPath(IntPtr L);
		[MonoPInvokeCallback]
		internal static int LoadFromCustomLoaders(IntPtr L);
		[MonoPInvokeCallback]
		public static int LoadAssembly(IntPtr L);
		[MonoPInvokeCallback]
		public static int ImportType(IntPtr L);
		[MonoPInvokeCallback]
		public static int ImportGenericType(IntPtr L);
		[MonoPInvokeCallback]
		public static int Cast(IntPtr L);
		private static Type getType(IntPtr L, ObjectTranslator translator, int idx);
		[MonoPInvokeCallback]
		public static int XLuaAccess(IntPtr L);
		[MonoPInvokeCallback]
		public static int XLuaPrivateAccessible(IntPtr L);
		[MonoPInvokeCallback]
		public static int XLuaMetatableOperation(IntPtr L);
		[MonoPInvokeCallback]
		public static int DelegateConstructor(IntPtr L);
		[MonoPInvokeCallback]
		public static int ToFunction(IntPtr L);
		[MonoPInvokeCallback]
		public static int GenericMethodWraper(IntPtr L);
		[MonoPInvokeCallback]
		public static int GetGenericMethod(IntPtr L);
		[MonoPInvokeCallback]
		public static int ReleaseCsObject(IntPtr L);
	}
}
