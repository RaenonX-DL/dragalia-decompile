/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class ObjectCasters
	{
		// Fields
		private Dictionary<Type, ObjectCast> castersMap;
		private ObjectTranslator translator;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public ObjectCasters __4__this;
			public Type type;
			public ObjectCast fixTypeGetter;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal object _genCaster_b__0(IntPtr L, int idx, object target);
			internal object _genCaster_b__1(IntPtr L, int idx, object target);
			internal object _genCaster_b__2(IntPtr L, int idx, object target);
			internal object _genCaster_b__3(IntPtr L, int idx, object target);
			internal object _genCaster_b__4(IntPtr L, int idx, object target);
			internal object _genCaster_b__5(IntPtr L, int idx, object target);
			internal object _genCaster_b__6(IntPtr L, int idx, object target);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1
		{
			// Fields
			public Type elementType;
			public ObjectCast elementCaster;
			public __c__DisplayClass23_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass23_1();
	
			// Methods
			internal object _genCaster_b__7(IntPtr L, int idx, object target);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_2
		{
			// Fields
			public Type keyType;
			public Type valueType;
			public ObjectCast keyCaster;
			public ObjectCast valueCaster;
			public __c__DisplayClass23_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass23_2();
	
			// Methods
			internal object _genCaster_b__8(IntPtr L, int idx, object target);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public ObjectCast oc;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal object _genNullableCaster_b__0(IntPtr L, int idx, object target);
		}
	
		// Constructors
		public ObjectCasters(ObjectTranslator translator);
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target);
		private static object sbyteCaster(IntPtr L, int idx, object target);
		private static object byteCaster(IntPtr L, int idx, object target);
		private static object shortCaster(IntPtr L, int idx, object target);
		private static object ushortCaster(IntPtr L, int idx, object target);
		private static object intCaster(IntPtr L, int idx, object target);
		private static object uintCaster(IntPtr L, int idx, object target);
		private static object longCaster(IntPtr L, int idx, object target);
		private static object ulongCaster(IntPtr L, int idx, object target);
		private static object getDouble(IntPtr L, int idx, object target);
		private static object floatCaster(IntPtr L, int idx, object target);
		private object decimalCaster(IntPtr L, int idx, object target);
		private static object getBoolean(IntPtr L, int idx, object target);
		private static object getString(IntPtr L, int idx, object target);
		private object getBytes(IntPtr L, int idx, object target);
		private object getIntptr(IntPtr L, int idx, object target);
		private object getObject(IntPtr L, int idx, object target);
		private object getLuaTable(IntPtr L, int idx, object target);
		private object getLuaFunction(IntPtr L, int idx, object target);
		public void AddCaster(Type type, ObjectCast oc);
		private ObjectCast genCaster(Type type);
		private ObjectCast genNullableCaster(ObjectCast oc);
		public ObjectCast GetCaster(Type type);
	}
}
