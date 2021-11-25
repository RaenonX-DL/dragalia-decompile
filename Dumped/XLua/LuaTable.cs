using System;
using System.Collections;
using System.Collections.Generic;

namespace XLua
{
	public class LuaTable : LuaBase
	{
		[Obsolete]
		public object this[string field]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public object this[object field]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Length => default(int);

		public LuaTable(int reference, LuaEnv luaenv)
		{
		}

		public void Get<TKey, TValue>(TKey key, out TValue value)
		{
		}

		public bool ContainsKey<TKey>(TKey key)
		{
			return default(bool);
		}

		public void Set<TKey, TValue>(TKey key, TValue value)
		{
		}

		public T GetInPath<T>(string path)
		{
			return (T)null;
		}

		public void SetInPath<T>(string path, T val)
		{
		}

		public void ForEach<TKey, TValue>(Action<TKey, TValue> action)
		{
		}

		public IEnumerable GetKeys()
		{
			return null;
		}

		public IEnumerable<T> GetKeys<T>()
		{
			return null;
		}

		[Obsolete]
		public T Get<T>(object key)
		{
			return (T)null;
		}

		public TValue Get<TValue, TKey>(TKey key)
		{
			return (TValue)null;
		}

		public TValue Get<TValue>(string key)
		{
			return (TValue)null;
		}

		public void SetMetaTable(LuaTable metaTable)
		{
		}

		public T Cast<T>()
		{
			return (T)null;
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
