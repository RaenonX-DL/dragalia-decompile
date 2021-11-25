using UnityEngine;

namespace Gluon
{
	public class MyPageSeasonSkitObjectsSettings : MonoBehaviour
	{
		public string description;

		public bool useTimeline;

		public string timelineName;

		public Vector3 skitInitialCameraPosition;

		public Vector3 skitInitialCameraRotation;

		public float skitInitialCameraFOV;

		public float skitInitialNear;

		public float skitInitialFar;

		public Vector3 skitCameraPosition;

		public Vector3 skitCameraRotation;

		public float skitCameraFOV;

		public float skitNear;

		public float skitFar;

		public float skitCameraAnimationDuration;

		public void Reload()
		{
		}
	}
}
