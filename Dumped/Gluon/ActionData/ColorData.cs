using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ColorData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Vector3 _color;

		[SerializeField]
		[HideInInspector]
		private float _colorPower;

		[SerializeField]
		[HideInInspector]
		private float _smoothSec;

		public Vector3 color => default(Vector3);

		public float colorPower => default(float);

		public float smoothSec => default(float);
	}
}
