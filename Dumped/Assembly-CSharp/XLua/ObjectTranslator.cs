/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gluon.Shooting;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class ObjectTranslator
	{
		// Fields
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
	
		// Properties
		private static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj { get; }
		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj { get; }
	
		// Nested types
		private class IniterAdderUnityEngineVector2
		{
			// Constructors
			static IniterAdderUnityEngineVector2();
			public IniterAdderUnityEngineVector2();
	
			// Methods
			private static void Init(LuaEnv luaenv, ObjectTranslator translator);
		}
	
		internal enum LOGLEVEL
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		public delegate void PushCSObject(IntPtr L, object obj);
	
		public delegate object GetCSObject(IntPtr L, int idx);
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public Type delegateType;
	
			// Constructors
			public __c__DisplayClass76_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_1
		{
			// Fields
			public MethodInfo genericMethodInfo;
			public __c__DisplayClass76_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass76_1();
	
			// Methods
			internal Delegate _getDelegateUsingGeneric_b__7(DelegateBridgeBase o);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_2
		{
			// Fields
			public MethodInfo methodInfo;
			public __c__DisplayClass76_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass76_2();
	
			// Methods
			internal Delegate _getDelegateUsingGeneric_b__8(DelegateBridgeBase o);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MethodInfo, bool> __9__76_1;
			public static Func<MethodInfo, int> __9__76_2;
			public static Func<MethodInfo, bool> __9__76_3;
			public static Func<MethodInfo, int> __9__76_4;
			public static Func<DelegateBridgeBase, Delegate> __9__76_0;
			public static Func<DelegateBridgeBase, Delegate> __9__76_5;
			public static Func<ParameterInfo, Type> __9__76_6;
			public static Func<MethodInfo, bool> __9__77_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _getDelegateUsingGeneric_b__76_1(MethodInfo m);
			internal int _getDelegateUsingGeneric_b__76_2(MethodInfo m);
			internal bool _getDelegateUsingGeneric_b__76_3(MethodInfo m);
			internal int _getDelegateUsingGeneric_b__76_4(MethodInfo m);
			internal Delegate _getDelegateUsingGeneric_b__76_0(DelegateBridgeBase x);
			internal Delegate _getDelegateUsingGeneric_b__76_5(DelegateBridgeBase x);
			internal Type _getDelegateUsingGeneric_b__76_6(ParameterInfo pinfo);
			internal bool _getDelegate_b__77_0(MethodInfo m);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__138<T>
			where T : class
		{
			// Fields
			public static readonly __c__138<T> __9;
			public static Action<IntPtr, byte> __9__138_0;
			public static Action<IntPtr, sbyte> __9__138_1;
			public static Action<IntPtr, char> __9__138_2;
			public static Action<IntPtr, short> __9__138_3;
			public static Action<IntPtr, ushort> __9__138_4;
			public static Action<IntPtr, float> __9__138_5;
	
			// Constructors
			static __c__138();
			public __c__138();
	
			// Methods
			internal void _tryGetPushFuncByType_b__138_0(IntPtr L, byte v);
			internal void _tryGetPushFuncByType_b__138_1(IntPtr L, sbyte v);
			internal void _tryGetPushFuncByType_b__138_2(IntPtr L, char v);
			internal void _tryGetPushFuncByType_b__138_3(IntPtr L, short v);
			internal void _tryGetPushFuncByType_b__138_4(IntPtr L, ushort v);
			internal void _tryGetPushFuncByType_b__138_5(IntPtr L, float v);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__140<T>
			where T : class
		{
			// Fields
			public static readonly __c__140<T> __9;
			public static Func<IntPtr, int, byte> __9__140_1;
			public static Func<IntPtr, int, sbyte> __9__140_2;
			public static Func<IntPtr, int, char> __9__140_3;
			public static Func<IntPtr, int, short> __9__140_4;
			public static Func<IntPtr, int, ushort> __9__140_5;
			public static Func<IntPtr, int, float> __9__140_6;
	
			// Constructors
			static __c__140();
			public __c__140();
	
			// Methods
			internal byte _tryGetGetFuncByType_b__140_1(IntPtr L, int idx);
			internal sbyte _tryGetGetFuncByType_b__140_2(IntPtr L, int idx);
			internal char _tryGetGetFuncByType_b__140_3(IntPtr L, int idx);
			internal short _tryGetGetFuncByType_b__140_4(IntPtr L, int idx);
			internal ushort _tryGetGetFuncByType_b__140_5(IntPtr L, int idx);
			internal float _tryGetGetFuncByType_b__140_6(IntPtr L, int idx);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass142_0<T>
		{
			// Fields
			public GetFunc<T> get;
			public Action<IntPtr, T> push;
			public Action<IntPtr, int, T> update;
	
			// Constructors
			public __c__DisplayClass142_0();
	
			// Methods
			internal T _RegisterPushAndGetAndUpdate_b__0(IntPtr L, int idx);
			internal void _RegisterPushAndGetAndUpdate_b__1(IntPtr L, object obj);
			internal object _RegisterPushAndGetAndUpdate_b__2(IntPtr L, int idx);
			internal void _RegisterPushAndGetAndUpdate_b__3(IntPtr L, int idx, object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass143_0<T>
		{
			// Fields
			public GetFunc<T> get;
	
			// Constructors
			public __c__DisplayClass143_0();
	
			// Methods
			internal object _RegisterCaster_b__0(IntPtr L, int idx, object o);
		}
	
		// Constructors
		public ObjectTranslator(LuaEnv luaenv, IntPtr L);
		static ObjectTranslator();
	
		// Methods
		public void PushUnityEngineVector2(IntPtr L, Vector2 val);
		public void Get(IntPtr L, int index, out Vector2 val);
		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val);
		public void PushUnityEngineVector3(IntPtr L, Vector3 val);
		public void Get(IntPtr L, int index, out Vector3 val);
		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val);
		public void PushUnityEngineVector4(IntPtr L, Vector4 val);
		public void Get(IntPtr L, int index, out Vector4 val);
		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val);
		public void PushUnityEngineColor(IntPtr L, Color val);
		public void Get(IntPtr L, int index, out Color val);
		public void UpdateUnityEngineColor(IntPtr L, int index, Color val);
		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val);
		public void Get(IntPtr L, int index, out Quaternion val);
		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val);
		public void PushUnityEngineRay(IntPtr L, Ray val);
		public void Get(IntPtr L, int index, out Ray val);
		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val);
		public void PushUnityEngineBounds(IntPtr L, Bounds val);
		public void Get(IntPtr L, int index, out Bounds val);
		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val);
		public void PushUnityEngineRay2D(IntPtr L, Ray2D val);
		public void Get(IntPtr L, int index, out Ray2D val);
		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val);
		public void PushGluonShootingEnemyManagerTemplateType(IntPtr L, EnemyManager.TemplateType val);
		public void Get(IntPtr L, int index, out EnemyManager.TemplateType val);
		public void UpdateGluonShootingEnemyManagerTemplateType(IntPtr L, int index, EnemyManager.TemplateType val);
		public void PushGluonShootingItemManagerTemplateType(IntPtr L, ItemManager.TemplateType val);
		public void Get(IntPtr L, int index, out ItemManager.TemplateType val);
		public void UpdateGluonShootingItemManagerTemplateType(IntPtr L, int index, ItemManager.TemplateType val);
		public void DelayWrapLoader(Type type, Action<IntPtr> loader);
		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator);
		public bool TryDelayWrapLoader(IntPtr L, Type type);
		public void Alias(Type type, string alias);
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name);
		private void initCSharpCallLua();
		private Delegate getDelegateUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod);
		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType);
		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx);
		public bool AllDelegateBridgeReleased();
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate);
		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx);
		public void CreateArrayMetatable(IntPtr L);
		public void CreateDelegateMetatable(IntPtr L);
		internal void CreateEnumerablePairs(IntPtr L);
		public void OpenLib(IntPtr L);
		internal void createFunctionMetatable(IntPtr L);
		internal Type FindType(string className, bool isQualifiedName = false);
		private bool hasMethod(Type type, string methodName);
		internal void collectObject(int obj_index_to_collect);
		private int addObject(object obj, bool is_valuetype, bool is_enum);
		internal object GetObject(IntPtr L, int index);
		public Type GetTypeOf(IntPtr L, int idx);
		public bool Assignable<T>(IntPtr L, int index);
		public bool Assignable(IntPtr L, int index, Type type);
		public object GetObject(IntPtr L, int index, Type type);
		public void Get<T>(IntPtr L, int index, out T v);
		public void PushByType<T>(IntPtr L, T v);
		public T[] GetParams<T>(IntPtr L, int index);
		public Array GetParams(IntPtr L, int index, Type type);
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class;
		public int GetTypeId(IntPtr L, Type type);
		public void PrivateAccessible(IntPtr L, Type type);
		internal int getTypeId(IntPtr L, Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN);
		private void pushPrimitive(IntPtr L, object o);
		public void PushAny(IntPtr L, object o);
		public int TranslateToEnumToTop(IntPtr L, Type type, int idx);
		public void Push(IntPtr L, lua_CSFunction o);
		public void Push(IntPtr L, LuaBase o);
		public void Push(IntPtr L, object o);
		public void PushObject(IntPtr L, object o, int type_id);
		public void Update(IntPtr L, int index, object obj);
		private object getCsObj(IntPtr L, int index, int udata);
		internal object SafeGetCSObj(IntPtr L, int index);
		internal object FastGetCSObj(IntPtr L, int index);
		internal void ReleaseCSObj(IntPtr L, int index);
		internal lua_CSFunction GetFixCSFunction(int index);
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func);
		internal object[] popValues(IntPtr L, int oldTop);
		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes);
		private void registerCustomOp(Type type, PushCSObject push, GetCSObject get, UpdateCSObject update);
		public bool HasCustomOp(Type type);
		private bool tryGetPushFuncByType<T>(Type type, out T func)
			where T : class;
		private bool tryGetGetFuncByType<T>(Type type, out T func)
			where T : class;
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update);
		public void RegisterCaster<T>(GetFunc<T> get);
		public void PushDecimal(IntPtr L, decimal val);
		public bool IsDecimal(IntPtr L, int index);
		public decimal GetDecimal(IntPtr L, int index);
		public void Get(IntPtr L, int index, out decimal val);
		[CompilerGenerated]
		private decimal _tryGetGetFuncByType_b__140_0<T>(IntPtr L, int idx)
			where T : class;
	}
}
