using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class Viewer2DCanvas : MonoBehaviour
	{
		[HideInInspector]
		public UnitDetailScene detailScene;

		public RectTransform imageOffset;

		public UnitDetail2dModel unitImage;

		public Transform movingContent;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher mainPublisher;

		[SerializeField]
		[Header("CanvasGroup")]
		public CanvasGroup canvasGroup;

		public Transform zoomTarget;

		private float startPinchDistance;

		private float oldPinchDistance;

		private bool imageSetDone;

		public bool ImageSetDone
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void SwitchFromMainPage()
		{
		}

		public void SwitchSubId(int forceSubId)
		{
		}

		public void SwitchChangeDragonId()
		{
		}

		public void SwitchFrom3DMode()
		{
		}

		public void SwitchTo3DPage()
		{
		}

		public void ReturnToMainPage([Optional] Action onDone)
		{
		}

		protected void OnEnable()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		protected void OnDisable()
		{
		}

		private void Pinch(OutGameTouchManager.PinchState state)
		{
		}

		private float PinchOnDevice(OutGameTouchManager.PinchState state)
		{
			return default(float);
		}

		public void SetUnit2DImage(int forceSubId = -1)
		{
		}
	}
}
