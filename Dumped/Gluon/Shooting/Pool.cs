using UnityEngine;

namespace Gluon.Shooting
{
	public class Pool
	{
		public BaseObject[] pool;

		public bool useRenderer;

		private int currentIndex;

		public void CreatePool(GameObject template, int count, Transform parent, bool useRenderer = false)
		{
		}

		public void DestroyPool()
		{
		}

		public BaseObject Rent(out int index)
		{
			return null;
		}

		public void Return(BaseObject bo)
		{
		}
	}
}
