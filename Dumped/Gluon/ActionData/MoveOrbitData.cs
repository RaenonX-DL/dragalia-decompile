using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveOrbitData : ActionParts.PartsData
	{
		public enum OrbitType
		{
			Anchor,
			Target
		}

		[SerializeField]
		[HideInInspector]
		private OrbitType _type;

		[SerializeField]
		[HideInInspector]
		private Vector3 _anchorPosition;

		[SerializeField]
		[HideInInspector]
		private float _rotateSpeed;

		[SerializeField]
		[HideInInspector]
		private float _winchSpeed;

		public OrbitType type => default(OrbitType);

		public Vector3 anchorPosition => default(Vector3);

		public float rotateSpeed => default(float);

		public float winchSpeed => default(float);
	}
}
