using System;

namespace XLua
{
	public abstract class LuaBase : IDisposable
	{
		protected bool disposed;

		protected int luaReference;

		protected LuaEnv luaEnv;

		public LuaBase(int reference, LuaEnv luaenv)
		{
		}

		~LuaBase()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposeManagedResources)
		{
		}

		public override bool Equals(object o)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		internal virtual void push(IntPtr L)
		{
		}
	}
}
