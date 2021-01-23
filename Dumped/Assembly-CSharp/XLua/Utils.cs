/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public static class Utils
	{
		// Fields
		public const int OBJ_META_IDX = -4;
		public const int METHOD_IDX = -3;
		public const int GETTER_IDX = -2;
		public const int SETTER_IDX = -1;
		public const int CLS_IDX = -4;
		public const int CLS_META_IDX = -3;
		public const int CLS_GETTER_IDX = -2;
		public const int CLS_SETTER_IDX = -1;
		public const string LuaIndexsFieldName = "LuaIndexs";
		public const string LuaNewIndexsFieldName = "LuaNewIndexs";
		public const string LuaClassIndexsFieldName = "LuaClassIndexs";
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs";
	
		// Nested types
		private struct MethodKey
		{
			// Fields
			public string Name;
			public bool IsStatic;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public bool exclude_generic_definition;
			public Func<Type, bool> __9__0;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal bool _GetAllTypes_b__0(Type type);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public FieldInfo field;
			public Type type;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal int _genFieldGetter_b__0(IntPtr L);
			internal int _genFieldGetter_b__1(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public FieldInfo field;
			public Type type;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal int _genFieldSetter_b__0(IntPtr L);
			internal int _genFieldSetter_b__1(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Type type;
			public PropertyInfo[] props;
			public Type[] params_type;
			public object[] arg;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal int _genItemGetter_b__1(IntPtr L);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<PropertyInfo, bool> __9__5_0;
			public static Func<PropertyInfo, bool> __9__6_0;
			public static Func<Type, bool> __9__8_7;
			public static Func<Type, bool> __9__8_8;
			public static Func<Type, IEnumerable<MethodInfo>> __9__8_0;
			public static Func<Type, MethodInfo, __f__AnonymousType1<Type, MethodInfo>> __9__8_1;
			public static Func<__f__AnonymousType1<Type, MethodInfo>, bool> __9__8_2;
			public static Func<__f__AnonymousType1<Type, MethodInfo>, Type> __9__8_3;
			public static Func<__f__AnonymousType1<Type, MethodInfo>, MethodInfo> __9__8_4;
			public static Func<IGrouping<Type, MethodInfo>, Type> __9__8_5;
			public static Func<IGrouping<Type, MethodInfo>, IEnumerable<MethodInfo>> __9__8_6;
			public static Func<MethodInfo, string> __9__10_0;
			public static Func<MethodInfo, string> __9__10_1;
			public static Func<MethodInfo, MethodInfo, MethodInfo> __9__10_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _genItemGetter_b__5_0(PropertyInfo prop);
			internal bool _genItemSetter_b__6_0(PropertyInfo prop);
			internal bool _GetExtensionMethodsOf_b__8_7(Type t);
			internal bool _GetExtensionMethodsOf_b__8_8(Type t);
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__8_0(Type type);
			internal __f__AnonymousType1<Type, MethodInfo> _GetExtensionMethodsOf_b__8_1(Type type, MethodInfo method);
			internal bool _GetExtensionMethodsOf_b__8_2(__f__AnonymousType1<Type, MethodInfo> __h__TransparentIdentifier0);
			internal Type _GetExtensionMethodsOf_b__8_3(__f__AnonymousType1<Type, MethodInfo> __h__TransparentIdentifier0);
			internal MethodInfo _GetExtensionMethodsOf_b__8_4(__f__AnonymousType1<Type, MethodInfo> __h__TransparentIdentifier0);
			internal Type _GetExtensionMethodsOf_b__8_5(IGrouping<Type, MethodInfo> g);
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__8_6(IGrouping<Type, MethodInfo> g);
			internal string _makeReflectionWrap_b__10_0(MethodInfo p);
			internal string _makeReflectionWrap_b__10_1(MethodInfo q);
			internal MethodInfo _makeReflectionWrap_b__10_2(MethodInfo p, MethodInfo q);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Type type;
			public PropertyInfo[] props;
			public Type[] params_type;
			public object[] arg;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal int _genItemSetter_b__1(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public Type type;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal int _genEnumCastFrom_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public string fieldName;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal bool _makeReflectionWrap_b__3(EventInfo e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public string memberName;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _LazyReflectionCall_b__0(MethodInfo m);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public Type type;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal int _ReflectionWrap_b__0(IntPtr LL);
		}
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name);
		public static IntPtr GetMainState(IntPtr L);
		public static List<Type> GetAllTypes(bool exclude_generic_definition = true);
		private static lua_CSFunction genFieldGetter(Type type, FieldInfo field);
		private static lua_CSFunction genFieldSetter(Type type, FieldInfo field);
		private static lua_CSFunction genItemGetter(Type type, PropertyInfo[] props);
		private static lua_CSFunction genItemSetter(Type type, PropertyInfo[] props);
		private static lua_CSFunction genEnumCastFrom(Type type);
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(Type type_to_be_extend);
		private static void makeReflectionWrap(IntPtr L, Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access);
		public static void loadUpvalue(IntPtr L, Type type, string metafunc, int num);
		public static void MakePrivateAccessible(IntPtr L, Type type);
		[MonoPInvokeCallback]
		internal static int LazyReflectionCall(IntPtr L);
		public static void ReflectionWrap(IntPtr L, Type type, bool privateAccessible);
		public static void BeginObjectRegister(Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1);
		private static int abs_idx(int top, int idx);
		public static void EndObjectRegister(Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer);
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func);
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, Type type, LazyMemberTypes memberType, bool isStatic);
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj);
		public static void BeginClassRegister(Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count);
		public static void EndClassRegister(Type type, IntPtr L, ObjectTranslator translator);
		private static List<string> getPathOfType(Type type);
		public static void LoadCSTable(IntPtr L, Type type);
		public static void SetCSTable(IntPtr L, Type type, int cls_table);
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod);
		public static bool IsSupportedMethod(MethodInfo method);
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method);
		private static Type getExtendedType(MethodInfo method);
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction);
		public static bool IsPublic(Type type);
	}
}
