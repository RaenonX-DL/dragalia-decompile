using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RotateData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Vector3 _rotation;

		public Vector3 rotation => default(Vector3);
	}
}
