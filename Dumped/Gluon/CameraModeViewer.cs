using UnityEngine;

namespace Gluon
{
	public class CameraModeViewer : CameraModeBase
	{
		private Transform _cameraAnchor;

		private static readonly Vector3 _initializePosition;

		private bool isMouseDown;

		private const float swipeTurnSpeed = 30f;

		private float basePinchDistance;

		private const float pinchZoomSpeed = 0.02f;

		private OutGameTouchManager _touchManager;

		public CameraModeViewer(CameraController controller)
		{
		}

		public void Setup()
		{
		}

		public override void Update()
		{
		}

		private void Pinch(OutGameTouchManager.PinchState pinchState)
		{
		}

		private void DollyCamera(float deltaDistance)
		{
		}

		private bool IsInRange()
		{
			return default(bool);
		}
	}
}
