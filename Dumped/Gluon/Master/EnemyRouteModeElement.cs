using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyRouteModeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _MoveSpeed;

		[SerializeField]
		private float _BackSpeed;

		[SerializeField]
		private float _DistanceOfSight;

		[SerializeField]
		private float _AngleOfSight;

		[SerializeField]
		private float _OutOfRange;

		[SerializeField]
		private int _Obtuse;

		public int Id => default(int);

		public float MoveSpeed => default(float);

		public float BackSpeed => default(float);

		public float DistanceOfSight => default(float);

		public float AngleOfSight => default(float);

		public float OutOfRange => default(float);

		public int Obtuse => default(int);
	}
}
