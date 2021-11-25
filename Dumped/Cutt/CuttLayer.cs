using UnityEngine;

namespace Cutt
{
	public class CuttLayer
	{
		public enum Type
		{
			Default = -1,
			Common0,
			Common1,
			Common2
		}

		public static int GetLayer(Type type)
		{
			return default(int);
		}

		public static void SetLayer(GameObject obj, Type type)
		{
		}

		public static void SetLayer(GameObject obj, int layer)
		{
		}
	}
}
