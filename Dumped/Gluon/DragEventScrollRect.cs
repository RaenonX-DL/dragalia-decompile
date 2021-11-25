using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class DragEventScrollRect : ScrollRect
	{
		private RectTransform mainCanvasTransform;

		private Rect DragEventAreaRect;

		private bool isSetupEventRect;

		private RectTransform scrollbarRectTran;

		private float scrollbarMinHeight;

		private bool isScrollbarHeightInited;

		private bool isScrollbarHeightDirty;

		private bool wasHorizontalEnabled;

		private bool wasVerticalEnabled;

		[SerializeField]
		[Header("Drag Event")]
		private bool useNativeDragEvent;

		public bool resetPositionOnResume;

		private bool isNativeDraggin;

		private float lastValue;

		[SerializeField]
		[Header("ã\u0082¿ã\u0083\u0083ã\u0083\u0097ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0099ã\u0082\u008b")]
		public bool isShowTapEffect;

		private int tapEffectWaitCount;

		private bool needResetScrollview;

		private bool _isMultiTouch;

		public const int defaultPointerId = -2;

		private int activePointerId;

		private const float scrollbarDefaultPosition = 1f;

		private const float pullContentPostionY = -10f;

		private Action onPullAction;

		private bool isForceCancelDrag;

		[SerializeField]
		[Header("iPhoneXã\u0082µã\u0082¤ã\u0082ºã\u0081®ç\u00af\u0084å\u009b²ã\u0083\u0081ã\u0082§ã\u0083\u0083ã\u0082\u00afã\u0082\u0092ç\u0084¡è¦\u0096ã\u0081\u0099ã\u0082\u008b")]
		public bool isSkipSafeAreaCheck;

		protected bool IsNativeDraggin => default(bool);

		public bool isMultiTouch
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IsForceCancelDrag => default(bool);

		public bool nowDrag => default(bool);

		public Vector3 diffDragVec => default(Vector3);

		public float dragDistance => default(float);

		public void SetupDragEventRect(RectTransform canvasTransform)
		{
		}

		protected override void LateUpdate()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		protected override void OnEnable()
		{
		}

		public void SetAsDefaultState()
		{
		}

		protected override void Start()
		{
		}

		private void SetScrollbarMinHeight()
		{
		}

		private void Update()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public float GetScrollbarValue()
		{
			return default(float);
		}

		public void SetScrollbarValue(float value)
		{
		}

		public void ResetScrollbarValue()
		{
		}

		public void CancelDrag()
		{
		}

		public void ClearActivePointerId()
		{
		}

		public void SetPullAction(Action pullAction)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
