using UnityEngine;

namespace Cutt
{
	public struct CuttEventColorData
	{
		public float a;

		public float r;

		public float g;

		public float b;

		public static implicit operator CuttEventColorData(Color data)
		{
			return default(CuttEventColorData);
		}

		public static explicit operator Color(CuttEventColorData data)
		{
			return default(Color);
		}
	}
}
