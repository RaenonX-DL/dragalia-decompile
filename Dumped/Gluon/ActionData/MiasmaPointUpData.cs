using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MiasmaPointUpData : ActionParts.PartsData
	{
		[Serializable]
		public struct PointForEnemyParam
		{
			public float point;

			public int enemyParamId;
		}

		[SerializeField]
		[HideInInspector]
		private float _defaultPoint;

		[SerializeField]
		[HideInInspector]
		private PointForEnemyParam[] _pointForParam;

		[SerializeField]
		[HideInInspector]
		private bool _isSetPoint;

		public float defaultPoint => default(float);

		public PointForEnemyParam[] pointForParam => null;

		public bool isSetPoint => default(bool);
	}
}
