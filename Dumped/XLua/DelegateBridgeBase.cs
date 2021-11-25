using System;
using System.Collections.Generic;

namespace XLua
{
	public abstract class DelegateBridgeBase : LuaBase
	{
		private Type firstKey;

		private Delegate firstValue;

		private Dictionary<Type, Delegate> bindTo;

		protected int errorFuncRef;

		public DelegateBridgeBase(int reference, LuaEnv luaenv)
		{
		}

		public bool TryGetDelegate(Type key, out Delegate value)
		{
			return default(bool);
		}

		public void AddDelegate(Type key, Delegate value)
		{
		}

		public virtual Delegate GetDelegateByType(Type type)
		{
			return null;
		}
	}
}
