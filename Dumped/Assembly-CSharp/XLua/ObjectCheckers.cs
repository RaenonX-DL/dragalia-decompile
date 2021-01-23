/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class ObjectCheckers
	{
		// Fields
		private Dictionary<Type, ObjectCheck> checkersMap;
		private ObjectTranslator translator;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public ObjectCheckers __4__this;
			public Type type;
			public ObjectCheck fixTypeCheck;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _genChecker_b__0(IntPtr L, int idx);
			internal bool _genChecker_b__1(IntPtr L, int idx);
			internal bool _genChecker_b__2(IntPtr L, int idx);
			internal bool _genChecker_b__3(IntPtr L, int idx);
			internal bool _genChecker_b__4(IntPtr L, int idx);
			internal bool _genChecker_b__5(IntPtr L, int idx);
			internal bool _genChecker_b__6(IntPtr L, int idx);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public ObjectCheck oc;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal bool _genNullableChecker_b__0(IntPtr L, int idx);
		}
	
		// Constructors
		public ObjectCheckers(ObjectTranslator translator);
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx);
		private bool luaTableCheck(IntPtr L, int idx);
		private bool numberCheck(IntPtr L, int idx);
		private bool decimalCheck(IntPtr L, int idx);
		private bool strCheck(IntPtr L, int idx);
		private bool bytesCheck(IntPtr L, int idx);
		private bool boolCheck(IntPtr L, int idx);
		private bool int64Check(IntPtr L, int idx);
		private bool uint64Check(IntPtr L, int idx);
		private bool luaFunctionCheck(IntPtr L, int idx);
		private bool intptrCheck(IntPtr L, int idx);
		private ObjectCheck genChecker(Type type);
		public ObjectCheck genNullableChecker(ObjectCheck oc);
		public ObjectCheck GetChecker(Type type);
	}
}
