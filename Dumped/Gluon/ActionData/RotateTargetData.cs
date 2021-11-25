using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RotateTargetData : ActionParts.PartsData
	{
		public enum Type
		{
			target,
			worldCenter,
			lastHitPosition,
			worldClockwise,
			pivotBase,
			areaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private Type _targetType;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPosition;

		[SerializeField]
		[HideInInspector]
		private bool _homing;

		[SerializeField]
		[HideInInspector]
		private float _rotateSpeed;

		[SerializeField]
		[HideInInspector]
		private float _convergeAngle;

		[SerializeField]
		[HideInInspector]
		private float _clockwiseAngle;

		[SerializeField]
		[HideInInspector]
		private bool _recapture;

		[SerializeField]
		[HideInInspector]
		private bool _isKeepDragon;

		public Type targetType => default(Type);

		public Vector3 offsetPosition => default(Vector3);

		public bool homing => default(bool);

		public float rotateSpeed => default(float);

		public float convergeAngle => default(float);

		public float clockwiseAngle => default(float);

		public bool recapture => default(bool);

		public bool isKeepDragon => default(bool);
	}
}
