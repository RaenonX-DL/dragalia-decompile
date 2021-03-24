/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class PageScrollViewRect : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Fields
		[SerializeField]
		protected PageViewBase controller;
		[SerializeField]
		public ScrollRect scrollRect;
		[SerializeField]
		public bool customVerticalDrag;
		[SerializeField]
		public bool autoPlayPageChangedSE;
		public PointerEventDataEvent customVerticalDragAction;
		[HideInInspector]
		public PointerEventDataEvent customVerticalPotentialBeginDragAction;
		[HideInInspector]
		public PointerEventDataEvent customVerticalEndDragAction;
		[HideInInspector]
		public bool doNotRaiseTouchGuardInAnimation;
		[CompilerGenerated]
		private bool _isPressing_k__BackingField;
		protected bool _isAnimating;
		[HideInInspector]
		public Action<bool> onAnimating;
		private bool isTouchGuardSet;
		[CompilerGenerated]
		private bool _isDragging_k__BackingField;
		private float animationSpeed;
		public float duration;
		public float backOffset;
		public float backDuration;
		public const float moveInterval = 0.05f;
		public const float slideThresholdDistance = 0.01f;
		protected const float leftX = 0f;
		public const float centerX = 0.5f;
		protected const float rightX = 1f;
		[CompilerGenerated]
		private float _startX_k__BackingField;
		[CompilerGenerated]
		private float _startY_k__BackingField;
		[CompilerGenerated]
		private int _indexDelta_k__BackingField;
		public bool ignoreIPhoneXSafeAreaCheck;
		[Header]
		[SerializeField]
		private float swipeDuration;
		private DateTime startTime;
		private bool isChangedPageInThisDragging;
		private Action onTouchDown;
		private Action onTouchUp;
		private Action onDraggingBegin;
		private Action onDragginEnd;
		private Tweener scrollToNextPageTweener;
		private bool isCheckingDirection;
		private bool isVerticalDrag;
		private readonly Vector3[] boundCorners;
		private const float subtleDistanceByInches = 0.07f;
		[Range]
		[SerializeField]
		private float pageDragOffsetX;
		public float overshootOrAmplitudeCustom;
		private CustomEaseFunction _easeFunction;
	
		// Properties
		public bool isPressing { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAnimating { get; private set; }
		public bool isDragging { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float startX { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float startY { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int indexDelta { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public DragEventScrollRect dragEventScrollRect { get; }
		public CustomEaseFunction easeFunction { get; }
	
		// Nested types
		[Serializable]
		public class PointerEventDataEvent : UnityEvent<PointerEventData>
		{
			// Constructors
			public PointerEventDataEvent();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public PageScrollViewRect __4__this;
			public float dstX;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _StartAnimation_b__0();
			internal void _StartAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnAnimationComplete_d__79 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PageScrollViewRect __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAnimationComplete_d__79(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PageScrollViewRect();
	
		// Methods
		private void OnEnable();
		private void Start();
		public void OnBeginDrag(PointerEventData eventData);
		private bool isSubtleMove(Vector2 screenPosNow, Vector2 screenPosPrev);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		private float CalcPageNormalizedWidth();
		private Bounds GetContentsBounds();
		public void StartMovingToNextAnimation(bool playFlipSE = true);
		public void StartMovingToPreviousPageAnimation(bool playFlipSE = true);
		public void StartMovingToCurrentPageAnimation();
		public void StartAnimation(float srcX, float dstX, float duration, bool willPageChange, bool playFlipSE);
		public void SkipScrollToNextPageAnimation();
		private void OnDestroy();
		protected void SetInAnimationTouchGuard(bool isOn);
		[IteratorStateMachine]
		private IEnumerator OnAnimationComplete();
		public void SetTouchUpDownEvent(Action touchDown, Action touchUp);
		public void SetDraggingBeginEndEvent(Action beginDrag, Action endDrag);
		public void OnPointerDown(PointerEventData eventData);
		public void OnPointerUp(PointerEventData eventData);
		public void SetAnimationSpeed();
	}
}
