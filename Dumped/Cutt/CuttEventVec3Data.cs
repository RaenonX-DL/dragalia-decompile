using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	[StructLayout(0, Size = 12)]
	public struct CuttEventVec3Data
	{
		public float x;

		public float y;

		public float z;

		public static implicit operator CuttEventVec3Data(Vector3 data)
		{
			return default(CuttEventVec3Data);
		}

		public static explicit operator Vector3(CuttEventVec3Data data)
		{
			return default(Vector3);
		}
	}
}
