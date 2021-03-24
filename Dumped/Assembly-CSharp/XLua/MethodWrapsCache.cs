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
	public class MethodWrapsCache
	{
		// Fields
		private ObjectTranslator translator;
		private ObjectCheckers objCheckers;
		private ObjectCasters objCasters;
		private Dictionary<Type, lua_CSFunction> constructorCache;
		private Dictionary<Type, Dictionary<string, lua_CSFunction>> methodsCache;
		private Dictionary<Type, lua_CSFunction> delegateCache;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public MethodWrapsCache __4__this;
			public Type type;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal int _GetConstructorWrap_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_1
		{
			// Fields
			public lua_CSFunction ctor;
			public __c__DisplayClass7_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass7_1();
	
			// Methods
			internal int _GetConstructorWrap_b__1(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public MethodWrapsCache __4__this;
			public Type type;
			public string eventName;
	
			// Constructors
			public __c__DisplayClass11_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_1
		{
			// Fields
			public bool is_static;
			public EventInfo eventInfo;
			public int start_idx;
			public MethodInfo add;
			public MethodInfo remove;
			public __c__DisplayClass11_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass11_1();
	
			// Methods
			internal int _GetEventWrap_b__0(IntPtr L);
		}
	
		// Constructors
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters);
	
		// Methods
		public lua_CSFunction GetConstructorWrap(Type type);
		public lua_CSFunction GetMethodWrap(Type type, string methodName);
		public lua_CSFunction GetMethodWrapInCache(Type type, string methodName);
		public lua_CSFunction GetDelegateWrap(Type type);
		public lua_CSFunction GetEventWrap(Type type, string eventName);
		public MethodWrap _GenMethodWrap(Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false);
		private static bool tryMakeGenericMethod(ref MethodBase method);
	}
}
