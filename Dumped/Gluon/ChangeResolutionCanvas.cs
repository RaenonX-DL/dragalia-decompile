using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class ChangeResolutionCanvas : UIBehaviour
	{
		private Canvas canvas;

		private RectTransform canvasRect;

		private Vector2 resolution;

		private float scaleFactor;

		private CameraGroup uiCameraGroup;

		private CameraGroup mainCameraGroup;

		private Transform uiCameraTrs;

		[HideInInspector]
		public bool changedPre;

		[HideInInspector]
		public bool changedPost;

		public void Initialize(Canvas canvas, CameraGroup uiCameraGroup, CameraGroup mainCameraGroup)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public void SetCamera()
		{
		}

		public void SetCanvas()
		{
		}
	}
}
