/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class OverloadMethodWrap
	{
		// Fields
		private ObjectTranslator translator;
		private Type targetType;
		private MethodBase method;
		private ObjectCheck[] checkArray;
		private ObjectCast[] castArray;
		private int[] inPosArray;
		private int[] outPosArray;
		private bool[] isOptionalArray;
		private object[] defaultValueArray;
		private bool isVoid;
		private int luaStackPosStart;
		private bool targetNeeded;
		private object[] args;
		private int[] refPos;
		private Type paramsType;
		[CompilerGenerated]
		private bool _HasDefalutValue_k__BackingField;
	
		// Properties
		public bool HasDefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public OverloadMethodWrap(ObjectTranslator translator, Type targetType, MethodBase method);
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters);
		public bool Check(IntPtr L);
		public int Call(IntPtr L);
	}
}
