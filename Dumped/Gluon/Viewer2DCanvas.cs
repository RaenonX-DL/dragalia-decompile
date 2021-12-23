using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class Viewer2DCanvas : MonoBehaviour
	{
		[HideInInspector]
		public UnitDetailScene detailScene;

		public RectTransform[] contentView;

		public DragEventScrollRect dragEventScrollRect;

		public RectTransform imageOffset;

		public UnitDetail2dModel unitImage;

		public Transform movingContent;

		public RectTransform talismanImageOffset;

		public UnitDetail2dModel talismanUnitImage;

		public Transform talismanMovingContent;

		public UIImageMaskToAlpha talismanUIImageMaskToAlpha;

		public Image maskImage;

		public Mask mask;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher mainPublisher;

		[SerializeField]
		[Header("CanvasGroup")]
		public CanvasGroup canvasGroup;

		public Transform zoomTarget;

		private float startPinchDistance;

		private float oldPinchDistance;

		private Vector3 viewOffset;

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

		public IEnumerator Mask()
		{
			return null;
		}
	}
}
