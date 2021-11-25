using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public struct CuttEventVec2Data
	{
		public float x;

		public float y;

		public static implicit operator CuttEventVec2Data(Vector2 data)
		{
			return default(CuttEventVec2Data);
		}

		public static explicit operator Vector2(CuttEventVec2Data data)
		{
			return default(Vector2);
		}
	}
}
