using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class InitializeWeakData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private AppearEnemyData.ChildType _childType;

		[SerializeField]
		[HideInInspector]
		private float _priorityTargetRange;

		[SerializeField]
		[HideInInspector]
		private int[] _changeHps;

		public AppearEnemyData.ChildType childType => default(AppearEnemyData.ChildType);

		public float priorityTargetRange => default(float);

		public int[] changeHps => null;
	}
}
