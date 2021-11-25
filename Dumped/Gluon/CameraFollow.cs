using UnityEngine;

namespace Gluon
{
	[AddComponentMenu("Camera-Control/Smooth Follow")]
	public class CameraFollow : MonoBehaviour
	{
		private struct ShakeCtrl
		{
			public bool isActive;

			public float sec;

			public float power;

			public bool isResume;
		}

		public Transform target;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float minDistance;

		[SerializeField]
		private float maxDistance;

		private float addDistance;

		[SerializeField]
		private float distanceDamping;

		private bool _isZoomControl;

		private float zoomRatio;

		[SerializeField]
		private Vector3 rotate;

		private ShakeCtrl shakeCtrl;

		public bool isZoomControl => default(bool);

		private void LateUpdate()
		{
		}

		public void ZoomOutWithDash()
		{
		}

		public void SetShake(float sec = 0.2f, float power = 0.08f, bool resume = false)
		{
		}

		private void UpdateShakeCtrl(Transform target)
		{
		}

		public void AddDistance(float value)
		{
		}

		public float GetDistance()
		{
			return default(float);
		}
	}
}
