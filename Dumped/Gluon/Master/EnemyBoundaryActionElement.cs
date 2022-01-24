using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyBoundaryActionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DataId;

		[SerializeField]
		private int _ParamId;

		[SerializeField]
		private int _BoundaryValue;

		[SerializeField]
		private float _BoundaryRate;

		[SerializeField]
		private int _Action;

		[SerializeField]
		private EnemyBoundaryCondition _Condition;

		[SerializeField]
		private int _NoCancelStop1;

		public int Id => default(int);

		public int DataId => default(int);

		public int ParamId => default(int);

		public int BoundaryValue => default(int);

		public float BoundaryRate => default(float);

		public int Action => default(int);

		public EnemyBoundaryCondition Condition => default(EnemyBoundaryCondition);

		public int NoCancelStop1 => default(int);
	}
}
