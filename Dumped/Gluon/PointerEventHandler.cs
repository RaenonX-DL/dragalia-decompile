using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	[Serializable]
	public class PointerEventHandler : FastUpdateMonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
	{
		[Serializable]
		public class TouchEvent : UnityEvent<PointerEventData>
		{
		}

		public static WeakReference globalTouchingHandler;

		public UnityEvent onClick;

		public UnityEvent onLongClick;

		public Toggle.ToggleEvent onToggleClicked;

		private TouchEvent _onPointerEnter;

		private TouchEvent _onPointerExit;

		private TouchEvent _onPointerDown;

		private TouchEvent _onPointerUp;

		[HideInInspector]
		public UnityEvent onDelayPressReleased;

		[SerializeField]
		[Header("long touch ã\u0081§ã\u0081\u008dã\u0082\u008bã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		public bool canLongTouch;

		[SerializeField]
		[Header("LongTouchæ\u008a¼ã\u0081\u0097ç¶\u009aã\u0081\u0091ã\u0082\u008bã\u0081«å\u008f\u008då¿\u009cã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		public bool canKeepLongTouch;

		[SerializeField]
		[Header("ã\u0083\u009eã\u0083«ã\u0083\u0081ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088ã\u0082\u0092å\u0087¦ç\u0090\u0086ã\u0081\u0097ã\u0081¾ã\u0081\u0099ã\u0081\u008b")]
		public bool needHandleMultiTouch;

		public float longTouchThreshold;

		public float keepLongTouchDuration;

		public float doubleTouchThreshold;

		private bool isCanceled;

		public static DateTime lastTouchDownDateTime;

		private float touchTime;

		private Vector3 startTouchPos;

		private float lastKeepLongTouchCalledTime;

		private bool isRepeatClick;

		private StandaloneInputModuleCustom inputModule;

		private Selectable targetSelectable;

		private bool isOn;

		private bool isToggle;

		private Coroutine watchTouchCoroutine;

		[HideInInspector]
		public bool isBlockingByUIAnimation;

		public static bool suppressBigEffect;

		public Action onClickAnimation;

		public UnityAction<float> onFlickVertical;

		public float shrinkTouchGap;

		public bool isMultiSelect;

		private bool isPointerDownChecked;

		[SerializeField]
		[Header("ã\u0082¿ã\u0083\u0083ã\u0083\u0097ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0099ã\u0082\u008b")]
		public bool isShowTapEffect;

		[SerializeField]
		[Header("ã\u0082¿ã\u0083\u0083ã\u0083\u0097ã\u0082\u0092é\u009b¢ã\u0081\u0099é\u009a\u009bã\u0081«æ\u008c\u0087ã\u0081®ä\u00b8\u008bã\u0081\u008bã\u0082\u0089ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081\u008cå¤\u0096ã\u0082\u008cã\u0081¦ã\u0081\u009fã\u0082\u0089ã\u0082¿ã\u0083\u0083ã\u0083\u0097ç\u0084¡å\u008a¹ã\u0081«ã\u0081\u0099ã\u0082\u008b")]
		private bool checkExitOnPointerUp;

		public TouchEvent onPointerEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TouchEvent onPointerExit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TouchEvent onPointerDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TouchEvent onPointerUp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float touchGap
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

		private float realShrinkTouchGap
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void StopWatchTouchCoroutine()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		private void RemoveGlobalTouch()
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		private void PreventFortCursol()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void PlaySE()
		{
		}

		private IEnumerator WatchTouch(PointerEventData eventData)
		{
			return null;
		}

		private bool IsMoved(Vector3 curTouchPos)
		{
			return default(bool);
		}

		private float FlickVertical(Vector3 curTouchPos)
		{
			return default(float);
		}

		private bool IsValidClick(PointerEventData pointEventData)
		{
			return default(bool);
		}

		private bool IsTargetValid()
		{
			return default(bool);
		}

		protected override void OnDisable()
		{
		}

		private void ResetToggleState()
		{
		}

		public void ResetFlagWhenIsOnChangedByScript()
		{
		}

		public void ForceReleaseTargetSelectable()
		{
		}

		public void ReplaceCallback(UnityAction callback)
		{
		}
	}
}
