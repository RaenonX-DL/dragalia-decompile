using UnityEngine;

namespace Gluon
{
	public class GrowthManaCirclePointFlyingEffect : MonoBehaviour
	{
		public Vector3 targetPosition;

		public Vector3 upVec;

		public float releaseLimitFlyingRotationSpeed;

		public float releaseLimitFlyingShrinkSpeed;

		public float releaseLimitFlyingUpSpeed;

		private float startTime;

		private bool isStopping;
	}
}
