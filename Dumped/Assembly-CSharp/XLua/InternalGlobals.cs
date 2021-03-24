/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	internal class InternalGlobals
	{
		// Fields
		internal static byte[] strBuff;
		internal static TryArrayGet genTryArrayGetPtr;
		internal static TryArraySet genTryArraySetPtr;
		internal static ObjectTranslatorPool objectTranslatorPool;
		internal static int LUA_REGISTRYINDEX;
		internal static Dictionary<string, string> supportOp;
		internal static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap;
		internal static lua_CSFunction LazyReflectionWrap;
	
		// Nested types
		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);
	
		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
	
		// Constructors
		static InternalGlobals();
		public InternalGlobals();
	}
}
