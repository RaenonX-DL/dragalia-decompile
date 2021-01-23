/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragEventScrollRect : ScrollRect
	{
		// Fields
		private RectTransform mainCanvasTransform;
		private Rect DragEventAreaRect;
		private bool isSetupEventRect;
		private RectTransform scrollbarRectTran;
		private float scrollbarMinHeight;
		private bool isScrollbarHeightInited;
		private bool isScrollbarHeightDirty;
		private bool wasHorizontalEnabled;
		private bool wasVerticalEnabled;
		[Header]
		[SerializeField]
		private bool useNativeDragEvent;
		public bool resetPositionOnResume;
		private bool isNativeDraggin;
		private float lastValue;
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
		public bool isSkipSafeAreaCheck;
	
		// Properties
		protected bool IsNativeDraggin { get; }
		public bool isMultiTouch { get; set; }
		public bool IsForceCancelDrag { get; }
		public bool nowDrag { get; }
		public Vector3 diffDragVec { get; }
		public float dragDistance { get; }
	
		// Constructors
		public DragEventScrollRect();
	
		// Methods
		public void SetupDragEventRect(RectTransform canvasTransform);
		protected override void LateUpdate();
		public override void OnBeginDrag(PointerEventData eventData);
		public override void OnEndDrag(PointerEventData eventData);
		public override void OnDrag(PointerEventData eventData);
		protected override void OnEnable();
		public void SetAsDefaultState();
		protected override void Start();
		private void SetScrollbarMinHeight();
		private void Update();
		private void OnApplicationPause(bool pause);
		public float GetScrollbarValue();
		public void SetScrollbarValue(float value);
		public void ResetScrollbarValue();
		public void CancelDrag();
		public void ClearActivePointerId();
		public void SetPullAction(Action pullAction);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _Start_b__44_0(Vector2 value);
	}
}
