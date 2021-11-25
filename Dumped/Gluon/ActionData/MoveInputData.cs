using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveInputData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _moveSpeed;

		public float moveSpeed => default(float);
	}
}
