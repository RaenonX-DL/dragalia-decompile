using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	internal class DirectionController
	{
		private struct DirectionData
		{
			public Vector3 direction;

			public float nowPower;

			public float nowPowerRate;

			public bool isStart;
		}

		private DirectionData[] _dataArray;

		public float maxPower
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float attenuationRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 outDirection
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float outPower
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector4 startTimeParam
		{
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private bool IsEmptyDirection()
		{
			return default(bool);
		}

		private int GetUseID()
		{
			return default(int);
		}

		public static Vector4 GetNowTimeParam()
		{
			return default(Vector4);
		}

		public void Init(int count, float maxpower, float attenuationrate)
		{
		}

		public void Update()
		{
		}

		public void SetDirection(Vector3 dirction, float power)
		{
		}

		public void CalcDirection()
		{
		}
	}
}
