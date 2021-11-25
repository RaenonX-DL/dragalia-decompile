using UnityEngine;

namespace Gluon
{
	public class RandomXorshift
	{
		private uint x;

		private uint y;

		private uint z;

		private uint w;

		public Vector2 insideUnitCircle => default(Vector2);

		public Vector3 insideUnitSphere => default(Vector3);

		public Vector3 onUnitSphere => default(Vector3);

		public float value => default(float);

		public RandomXorshift()
		{
		}

		public RandomXorshift(uint seed)
		{
		}

		public void SetSeed(uint seed)
		{
		}

		public int Range(int min, int max)
		{
			return default(int);
		}

		public float Range(float min, float max)
		{
			return default(float);
		}

		private int Next()
		{
			return default(int);
		}

		private double NextDouble()
		{
			return default(double);
		}

		private uint NextU()
		{
			return default(uint);
		}

		private uint CalcNext()
		{
			return default(uint);
		}
	}
}
