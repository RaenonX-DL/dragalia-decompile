using System;
using System.Collections.Generic;
using System.Reflection;
using Gluon.Shooting;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;

namespace XLua
{
	public class ObjectTranslator
	{
		private class IniterAdderUnityEngineVector2
		{
			static IniterAdderUnityEngineVector2()
			{
			}

			private static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			}
		}

		internal enum LOGLEVEL
		{
			NO,
			INFO,
			WARN,
			ERROR
		}

		public delegate void PushCSObject(IntPtr L, object obj);

		public delegate object GetCSObject(IntPtr L, int idx);

		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);

		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);

		private static IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj;

		private int UnityEngineVector2_TypeID;

		private int UnityEngineVector3_TypeID;

		private int UnityEngineVector4_TypeID;

		private int UnityEngineColor_TypeID;

		private int UnityEngineQuaternion_TypeID;

		private int UnityEngineRay_TypeID;

		private int UnityEngineBounds_TypeID;

		private int UnityEngineRay2D_TypeID;

		private int GluonShootingEnemyManagerTemplateType_TypeID;

		private int GluonShootingEnemyManagerTemplateType_EnumRef;

		private int GluonShootingItemManagerTemplateType_TypeID;

		private int GluonShootingItemManagerTemplateType_EnumRef;

		private static XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj;

		internal MethodWrapsCache methodWrapsCache;

		internal ObjectCheckers objectCheckers;

		internal ObjectCasters objectCasters;

		internal readonly ObjectPool objects;

		internal readonly Dictionary<object, int> reverseMap;

		internal LuaEnv luaEnv;

		internal StaticLuaCallbacks metaFunctions;

		internal List<Assembly> assemblies;

		private lua_CSFunction importTypeFunction;

		private lua_CSFunction loadAssemblyFunction;

		private lua_CSFunction castFunction;

		private readonly Dictionary<Type, Action<IntPtr>> delayWrap;

		private readonly Dictionary<Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators;

		private readonly Dictionary<Type, Type> aliasCfg;

		private Dictionary<Type, bool> loaded_types;

		public int cacheRef;

		private MethodInfo[] genericAction;

		private MethodInfo[] genericFunc;

		private Dictionary<Type, Func<DelegateBridgeBase, Delegate>> genericDelegateCreatorCache;

		private Dictionary<int, WeakReference> delegate_bridges;

		private int common_array_meta;

		private int common_delegate_meta;

		private int enumerable_pairs_func;

		private Dictionary<Type, int> typeIdMap;

		private Dictionary<int, Type> typeMap;

		private HashSet<Type> privateAccessibleFlags;

		private Dictionary<object, int> enumMap;

		private List<lua_CSFunction> fix_cs_functions;

		private Dictionary<Type, PushCSObject> custom_push_funcs;

		private Dictionary<Type, GetCSObject> custom_get_funcs;

		private Dictionary<Type, UpdateCSObject> custom_update_funcs;

		private Dictionary<Type, Delegate> push_func_with_type;

		private Dictionary<Type, Delegate> get_func_with_type;

		private int decimal_type_id;

		private static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj => null;

		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj => null;

		public void PushUnityEngineVector2(IntPtr L, Vector2 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector2 val)
		{
		}

		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val)
		{
		}

		public void PushUnityEngineVector3(IntPtr L, Vector3 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector3 val)
		{
		}

		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val)
		{
		}

		public void PushUnityEngineVector4(IntPtr L, Vector4 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector4 val)
		{
		}

		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val)
		{
		}

		public void PushUnityEngineColor(IntPtr L, Color val)
		{
		}

		public void Get(IntPtr L, int index, out Color val)
		{
		}

		public void UpdateUnityEngineColor(IntPtr L, int index, Color val)
		{
		}

		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val)
		{
		}

		public void Get(IntPtr L, int index, out Quaternion val)
		{
		}

		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val)
		{
		}

		public void PushUnityEngineRay(IntPtr L, Ray val)
		{
		}

		public void Get(IntPtr L, int index, out Ray val)
		{
		}

		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val)
		{
		}

		public void PushUnityEngineBounds(IntPtr L, Bounds val)
		{
		}

		public void Get(IntPtr L, int index, out Bounds val)
		{
		}

		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val)
		{
		}

		public void PushUnityEngineRay2D(IntPtr L, Ray2D val)
		{
		}

		public void Get(IntPtr L, int index, out Ray2D val)
		{
		}

		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val)
		{
		}

		public void PushGluonShootingEnemyManagerTemplateType(IntPtr L, EnemyManager.TemplateType val)
		{
		}

		public void Get(IntPtr L, int index, out EnemyManager.TemplateType val)
		{
		}

		public void UpdateGluonShootingEnemyManagerTemplateType(IntPtr L, int index, EnemyManager.TemplateType val)
		{
		}

		public void PushGluonShootingItemManagerTemplateType(IntPtr L, ItemManager.TemplateType val)
		{
		}

		public void Get(IntPtr L, int index, out ItemManager.TemplateType val)
		{
		}

		public void UpdateGluonShootingItemManagerTemplateType(IntPtr L, int index, ItemManager.TemplateType val)
		{
		}

		public void DelayWrapLoader(Type type, Action<IntPtr> loader)
		{
		}

		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
		{
		}

		public bool TryDelayWrapLoader(IntPtr L, Type type)
		{
			return default(bool);
		}

		public void Alias(Type type, string alias)
		{
		}

		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name)
		{
		}

		public ObjectTranslator(LuaEnv luaenv, IntPtr L)
		{
		}

		private void initCSharpCallLua()
		{
		}

		private Delegate getDelegateUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod)
		{
			return null;
		}

		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType)
		{
			return null;
		}

		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx)
		{
			return null;
		}

		public bool AllDelegateBridgeReleased()
		{
			return default(bool);
		}

		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate)
		{
		}

		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx)
		{
			return null;
		}

		public void CreateArrayMetatable(IntPtr L)
		{
		}

		public void CreateDelegateMetatable(IntPtr L)
		{
		}

		internal void CreateEnumerablePairs(IntPtr L)
		{
		}

		public void OpenLib(IntPtr L)
		{
		}

		internal void createFunctionMetatable(IntPtr L)
		{
		}

		internal Type FindType(string className, bool isQualifiedName = false)
		{
			return null;
		}

		private bool hasMethod(Type type, string methodName)
		{
			return default(bool);
		}

		internal void collectObject(int obj_index_to_collect)
		{
		}

		private int addObject(object obj, bool is_valuetype, bool is_enum)
		{
			return default(int);
		}

		internal object GetObject(IntPtr L, int index)
		{
			return null;
		}

		public Type GetTypeOf(IntPtr L, int idx)
		{
			return null;
		}

		public bool Assignable<T>(IntPtr L, int index)
		{
			return default(bool);
		}

		public bool Assignable(IntPtr L, int index, Type type)
		{
			return default(bool);
		}

		public object GetObject(IntPtr L, int index, Type type)
		{
			return null;
		}

		public void Get<T>(IntPtr L, int index, out T v)
		{
		}

		public void PushByType<T>(IntPtr L, T v)
		{
		}

		public T[] GetParams<T>(IntPtr L, int index)
		{
			return null;
		}

		public Array GetParams(IntPtr L, int index, Type type)
		{
			return null;
		}

		public T GetDelegate<T>(IntPtr L, int index) where T : class
		{
			return null;
		}

		public int GetTypeId(IntPtr L, Type type)
		{
			return default(int);
		}

		public void PrivateAccessible(IntPtr L, Type type)
		{
		}

		internal int getTypeId(IntPtr L, Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN)
		{
			return default(int);
		}

		private void pushPrimitive(IntPtr L, object o)
		{
		}

		public void PushAny(IntPtr L, object o)
		{
		}

		public int TranslateToEnumToTop(IntPtr L, Type type, int idx)
		{
			return default(int);
		}

		public void Push(IntPtr L, lua_CSFunction o)
		{
		}

		public void Push(IntPtr L, LuaBase o)
		{
		}

		public void Push(IntPtr L, object o)
		{
		}

		public void PushObject(IntPtr L, object o, int type_id)
		{
		}

		public void Update(IntPtr L, int index, object obj)
		{
		}

		private object getCsObj(IntPtr L, int index, int udata)
		{
			return null;
		}

		internal object SafeGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		internal object FastGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		internal void ReleaseCSObj(IntPtr L, int index)
		{
		}

		internal lua_CSFunction GetFixCSFunction(int index)
		{
			return null;
		}

		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func)
		{
		}

		internal object[] popValues(IntPtr L, int oldTop)
		{
			return null;
		}

		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes)
		{
			return null;
		}

		private void registerCustomOp(Type type, PushCSObject push, GetCSObject get, UpdateCSObject update)
		{
		}

		public bool HasCustomOp(Type type)
		{
			return default(bool);
		}

		private bool tryGetPushFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		private bool tryGetGetFuncByType<T>(Type type, out T func) where T : class
		{
			return default(bool);
		}

		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update)
		{
		}

		public void RegisterCaster<T>(GetFunc<T> get)
		{
		}

		public void PushDecimal(IntPtr L, decimal val)
		{
		}

		public bool IsDecimal(IntPtr L, int index)
		{
			return default(bool);
		}

		public decimal GetDecimal(IntPtr L, int index)
		{
			return default(decimal);
		}

		public void Get(IntPtr L, int index, out decimal val)
		{
		}
	}
}
