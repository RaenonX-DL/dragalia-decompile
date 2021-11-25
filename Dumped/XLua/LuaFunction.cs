using System;

namespace XLua
{
	public class LuaFunction : LuaBase
	{
		public LuaFunction(int reference, LuaEnv luaenv)
		{
		}

		public void Action<T>(T a)
		{
		}

		public TResult Func<TResult, T>(T a)
		{
			return (TResult)null;
		}

		public void Action<T1, T2>(T1 a1, T2 a2)
		{
		}

		public TResult Func<TResult, T1, T2>(T1 a1, T2 a2)
		{
			return (TResult)null;
		}

		public object[] Call(object[] args, Type[] returnTypes)
		{
			return null;
		}

		public object[] Call(object[] args)
		{
			return null;
		}

		public T Cast<T>()
		{
			return (T)null;
		}

		public void SetEnv(LuaTable env)
		{
		}

		internal override void push(IntPtr L)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
