using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PageScrollViewRect : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Serializable]
		public class PointerEventDataEvent : UnityEvent<PointerEventData>
		{
		}

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

		protected bool _isAnimating;

		[HideInInspector]
		public Action<bool> onAnimating;

		private bool isTouchGuardSet;

		private float animationSpeed;

		public float duration;

		public float backOffset;

		public float backDuration;

		public const float moveInterval = 0.05f;

		public const float slideThresholdDistance = 0.01f;

		protected const float leftX = 0f;

		public const float centerX = 0.5f;

		protected const float rightX = 1f;

		public bool ignoreIPhoneXSafeAreaCheck;

		[SerializeField]
		[Header("swipeã\u0081®å\u0088¤å®\u009aæ\u0099\u0082é\u0096\u0093ã\u0080\u0081ç§\u0092")]
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

		[SerializeField]
		private float pageDragOffsetX;

		public float overshootOrAmplitudeCustom;

		private CustomEaseFunction _easeFunction;

		public bool isPressing
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isAnimating
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public bool isDragging
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float startX
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float startY
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int indexDelta
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DragEventScrollRect dragEventScrollRect => null;

		public CustomEaseFunction easeFunction => null;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		private bool isSubtleMove(Vector2 screenPosNow, Vector2 screenPosPrev)
		{
			return default(bool);
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private float CalcPageNormalizedWidth()
		{
			return default(float);
		}

		private Bounds GetContentsBounds()
		{
			return default(Bounds);
		}

		public void StartMovingToNextAnimation(bool playFlipSE = true)
		{
		}

		public void StartMovingToPreviousPageAnimation(bool playFlipSE = true)
		{
		}

		public void StartMovingToCurrentPageAnimation()
		{
		}

		public void StartAnimation(float srcX, float dstX, float duration, bool willPageChange, bool playFlipSE)
		{
		}

		public void SkipScrollToNextPageAnimation()
		{
		}

		private void OnDestroy()
		{
		}

		protected void SetInAnimationTouchGuard(bool isOn)
		{
		}

		private IEnumerator OnAnimationComplete()
		{
			return null;
		}

		public void SetTouchUpDownEvent(Action touchDown, Action touchUp)
		{
		}

		public void SetDraggingBeginEndEvent(Action beginDrag, Action endDrag)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void SetAnimationSpeed()
		{
		}
	}
}
