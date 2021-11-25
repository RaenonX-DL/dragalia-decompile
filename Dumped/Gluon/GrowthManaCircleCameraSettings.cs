using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleCameraSettings : MonoBehaviour
	{
		public Vector3 initialCameraOffset;

		public float initialCameraAnimationDuration;

		public float initialCircleRotationDuration;

		public float initialCircleRotationSpeed;

		public Vector3 screenSaverCameraPosition;

		public Vector3 screenSaverCameraRotation;

		public float screenSaverMoveSpeed;

		public float screenSaverRotationSpeed;

		public float screenSaverStartDuration;

		public float screenSaverFinishDuration;

		public float screenSaverMinOffset;

		public float screenSaverMaxOffset;

		public float screenSaverCancelPositionAdjustDuration;

		public float screenSaverStartTime;

		public void Reset()
		{
		}
	}
}
