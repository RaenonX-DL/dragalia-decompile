using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class B00250Data : ActionParts.PartsData
	{
		public enum Behavior
		{
			attack,
			retreat
		}

		[SerializeField]
		[HideInInspector]
		private Behavior _behavior;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private float _moveDuration;

		public Behavior behavior => default(Behavior);

		public int childActionId => default(int);

		public float moveDuration => default(float);
	}
}
