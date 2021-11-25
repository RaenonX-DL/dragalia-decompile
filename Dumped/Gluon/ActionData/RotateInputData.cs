using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RotateInputData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _rotateSpeed;

		public float rotateSpeed => default(float);
	}
}
