using UnityEngine;

namespace Gluon
{
	public class MyPageSkitCameraSettings : MonoBehaviour
	{
		public static int optionCameraIndex;

		public static int optionCameraNum;

		public string description;

		public bool useTimeline;

		public Vector3 initialCameraPosition;

		public Vector3 initialCameraRotation;

		public float initialCameraFOV;

		public float initialNear;

		public float initialFar;

		public Vector3 cameraPosition;

		public Vector3 cameraRotation;

		public float cameraFOV;

		public float near;

		public float far;

		public float cameraAnimationDuration;

		public bool hasSecondCameraSetting;

		public Vector3 initialCameraPosition2;

		public Vector3 initialCameraRotation2;

		public float initialCameraFOV2;

		public float initialNear2;

		public float initialFar2;

		public Vector3 cameraPosition2;

		public Vector3 cameraRotation2;

		public float cameraFOV2;

		public float near2;

		public float far2;

		public float cameraAnimationDuration2;

		public Color color;

		public void Reload()
		{
		}
	}
}
