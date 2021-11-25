using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class GyroControl : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class OverrunInfo
		{
			public Transform targetTransform;

			public float mulValVertical;

			public float mulValHorizontal;
		}

		[SerializeField]
		public float rotateVertical;

		public float rotateHorizontal;

		public float gyroAngleOffsetMaxVertical;

		public float gyroAngleOffsetMaxHorizontal;

		public float chaseSpeed;

		public OverrunInfo[] overruns;

		private Quaternion initAttitude;

		private bool forceStable;

		private float lastX;

		private float lastY;

		private void Awake()
		{
		}

		public void ResetInitAttitude()
		{
		}

		public void SetForceState(bool forceStable)
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
