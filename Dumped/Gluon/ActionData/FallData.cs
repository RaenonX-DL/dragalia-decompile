using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FallData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _fallSpeed;

		[SerializeField]
		[HideInInspector]
		private int _landingActionId;

		public float fallSpeed => default(float);

		public int landingActionId => default(int);
	}
}
