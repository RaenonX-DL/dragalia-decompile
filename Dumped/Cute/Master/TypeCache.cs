using System;
using System.Collections.Generic;

namespace Cute.Master
{
	public static class TypeCache
	{
		private static Dictionary<string, Type> typeCachesFullName;

		private static Dictionary<string, Type> typeCachesName;

		public static Type GetType(string name)
		{
			return null;
		}

		public static void ForEach(Action<Type> action)
		{
		}

		private static void CreateCache()
		{
		}
	}
}
