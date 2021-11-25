using System.Collections.Generic;

namespace XLua
{
	internal class ReferenceEqualsComparer : IEqualityComparer<object>
	{
		public new bool Equals(object o1, object o2)
		{
			return default(bool);
		}

		public int GetHashCode(object obj)
		{
			return default(int);
		}
	}
}
