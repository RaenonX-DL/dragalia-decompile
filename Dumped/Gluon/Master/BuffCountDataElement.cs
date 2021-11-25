using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuffCountDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _LimitRate;

		[SerializeField]
		private float _BaseRate;

		[SerializeField]
		private int _Condition1Id;

		[SerializeField]
		private float _Condition1Rate;

		public int Id => default(int);

		public float LimitRate => default(float);

		public float BaseRate => default(float);

		public int Condition1Id => default(int);

		public float Condition1Rate => default(float);
	}
}
