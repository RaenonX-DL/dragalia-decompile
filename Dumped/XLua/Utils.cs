using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	public static class Utils
	{
		private struct MethodKey
		{
			public string Name;

			public bool IsStatic;
		}

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

		public static bool LoadField(IntPtr L, int idx, string field_name)
		{
			return default(bool);
		}

		public static IntPtr GetMainState(IntPtr L)
		{
			return default(IntPtr);
		}

		public static List<Type> GetAllTypes(bool exclude_generic_definition = true)
		{
			return null;
		}

		private static lua_CSFunction genFieldGetter(Type type, FieldInfo field)
		{
			return null;
		}

		private static lua_CSFunction genFieldSetter(Type type, FieldInfo field)
		{
			return null;
		}

		private static lua_CSFunction genItemGetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		private static lua_CSFunction genItemSetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		private static lua_CSFunction genEnumCastFrom(Type type)
		{
			return null;
		}

		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(Type type_to_be_extend)
		{
			return null;
		}

		private static void makeReflectionWrap(IntPtr L, Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access)
		{
		}

		public static void loadUpvalue(IntPtr L, Type type, string metafunc, int num)
		{
		}

		public static void MakePrivateAccessible(IntPtr L, Type type)
		{
		}

		internal static int LazyReflectionCall(IntPtr L)
		{
			return default(int);
		}

		public static void ReflectionWrap(IntPtr L, Type type, bool privateAccessible)
		{
		}

		public static void BeginObjectRegister(Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1)
		{
		}

		private static int abs_idx(int top, int idx)
		{
			return default(int);
		}

		public static void EndObjectRegister(Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer)
		{
		}

		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func)
		{
		}

		public static void RegisterLazyFunc(IntPtr L, int idx, string name, Type type, LazyMemberTypes memberType, bool isStatic)
		{
		}

		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj)
		{
		}

		public static void BeginClassRegister(Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count)
		{
		}

		public static void EndClassRegister(Type type, IntPtr L, ObjectTranslator translator)
		{
		}

		private static List<string> getPathOfType(Type type)
		{
			return null;
		}

		public static void LoadCSTable(IntPtr L, Type type)
		{
		}

		public static void SetCSTable(IntPtr L, Type type, int cls_table)
		{
		}

		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod)
		{
			return default(bool);
		}

		public static bool IsSupportedMethod(MethodInfo method)
		{
			return default(bool);
		}

		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method)
		{
			return null;
		}

		private static Type getExtendedType(MethodInfo method)
		{
			return null;
		}

		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction)
		{
			return default(bool);
		}

		public static bool IsPublic(Type type)
		{
			return default(bool);
		}
	}
}
