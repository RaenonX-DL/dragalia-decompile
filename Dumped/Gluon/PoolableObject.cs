using System.Collections.Generic;

namespace Gluon
{
	public class PoolableObject<T> where T : IPoolableObject, new()
	{
		private List<T> pool;

		public int Count => default(int);

		public PoolableObject(int initialCapacity)
		{
		}

		public T Fetch()
		{
			return (T)null;
		}

		public void ReleaseAll()
		{
		}
	}
}
