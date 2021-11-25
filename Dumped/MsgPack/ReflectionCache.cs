using System;
using System.Collections.Generic;

namespace MsgPack
{
	public static class ReflectionCache
	{
		private static Dictionary<Type, ReflectionCacheEntry> _cache;

		static ReflectionCache()
		{
		}

		public static ReflectionCacheEntry Lookup(Type type)
		{
			return null;
		}

		public static void RemoveCache(Type type)
		{
		}

		public static void Clear()
		{
		}
	}
}
