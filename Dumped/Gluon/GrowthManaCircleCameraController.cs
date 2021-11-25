using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class GrowthManaCircleCameraController : MonoBehaviour
	{
		private enum ScreenSaverStatus
		{
			None,
			Starting,
			Doing,
			Finishing
		}

		public GrowthManaCircleScene scene;

		public Camera mainCamera;

		[HideInInspector]
		public bool isCameraAnimating;

		private ScreenSaverStatus screenSaverStatus;

		private Vector3 initialCameraPosition;

		private Vector3 initialCameraEulerAngles;

		private Vector3 finishCameraPosition;

		private Quaternion finishCameraRotation;

		private Vector3 offset;

		private Vector3 rotation;

		private Vector3 secondPosition;

		private Vector3 secondRotation;

		private Vector3 initialRootPosition;

		private Quaternion initialRootRotation;

		private Vector3 finishRootPosition;

		private Quaternion finishRootRotation;

		private float firstDelay;

		private float secondDelay;

		private float thirdDelay;

		private float firstDuration;

		private float secondDuration;

		private float screenSaverMoveSpeed;

		private GrowthManaCircleObjectSettings objectSettings;

		private GrowthManaCircleEffectSettings effectSettings;

		private GrowthManaCircleCameraSettings cameraSettings;

		private GrowthManaCircleModel model;

		private UnityEvent onCompleteEvent;

		private Sequence limitReleaseSequence;

		private float screenSaverY;

		private void Start()
		{
		}

		public UnityEvent SetupEvent()
		{
			return null;
		}

		public void OnCameraAnimationStarted()
		{
		}

		public void OnCameraAnimationFinished()
		{
		}

		public void StartInitialCameraMove(bool isSetEndPiecePos = false)
		{
		}

		public void StartReleaseLimitCameraMove()
		{
		}

		private void StartCameraMove()
		{
		}

		public bool IsScreenSaverModeOn()
		{
			return default(bool);
		}

		public void StartScreenSaverMode()
		{
		}

		public bool CanFinishScreenSaverMode()
		{
			return default(bool);
		}

		public void FinishScreenSaverMode()
		{
		}

		private void Update()
		{
		}

		public void Reset()
		{
		}
	}
}
