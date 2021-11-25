using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class PopupCanvas : MonoBehaviour
	{
		private class CanvasSortOrderInfo
		{
			public int sortOrderIndex;

			public PopupCanvas canvas;
		}

		[SerializeField]
		private GameObject blackLayer;

		[SerializeField]
		private GameObject touchGuard;

		[SerializeField]
		private GameObject frontTouchGuard;

		[SerializeField]
		private GameObject initialTouchGuard;

		private CanvasGroup canvasGroup;

		protected bool showStartAnimation;

		protected bool isIndependentTime;

		public bool showOnBaseCanvas;

		private bool _isWaitingAllPopupCanvasClosed;

		public bool _isErrorPopupCanvas;

		[HideInInspector]
		public bool doNotRegisterBackKey;

		private Canvas canvas;

		private static List<CanvasSortOrderInfo> showingCanvasList;

		public bool isWaitingAllPopupCanvasClosed
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public bool isErrorPopupCanvas
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void ApplyAutoSortingOrder()
		{
		}

		protected virtual void Start()
		{
		}

		public static int GetCurrentPopupNum()
		{
			return default(int);
		}

		private static int GetCurrentSortOrderMaxIndex()
		{
			return default(int);
		}

		public static PopupCanvas Create(bool showBlackLayer = false, bool showOnBaseCanvas = false, bool showStartAnimation = true, bool isErrorPopupCanvas = false, bool isIndependentTime = false)
		{
			return null;
		}

		public void ShowBlackLayer(bool isShown)
		{
		}

		public void ShowTouchGuard(bool isShown)
		{
		}

		public void ShowFrontTouchGuard(bool isShown)
		{
		}

		public void ShowInitialTouchGuard(bool isShown)
		{
		}

		public void SetBlackLayerAlpha(float alpha)
		{
		}

		public void StartShowAnimation()
		{
		}

		public void StartCloseAnimation()
		{
		}

		public void StartCloseAnimationAll([Optional] UnityEvent onCompleted)
		{
		}

		private IEnumerator WaitCloseAnimationAll([Optional] UnityEvent onCompleted)
		{
			return null;
		}

		protected virtual void OnDestroy()
		{
		}

		protected void ShowingCanvasListRemove()
		{
		}
	}
}
