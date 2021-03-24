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
	public abstract class DelegateBridgeBase : LuaBase
	{
		// Fields
		private Type firstKey;
		private Delegate firstValue;
		private Dictionary<Type, Delegate> bindTo;
		protected int errorFuncRef;
	
		// Constructors
		public DelegateBridgeBase(int reference, LuaEnv luaenv);
	
		// Methods
		public bool TryGetDelegate(Type key, out Delegate value);
		public void AddDelegate(Type key, Delegate value);
		public virtual Delegate GetDelegateByType(Type type);
	}
}
