using System.Runtime.InteropServices;
using UnityEngine;

namespace Cutt
{
	[StructLayout(0, Size = 16)]
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
