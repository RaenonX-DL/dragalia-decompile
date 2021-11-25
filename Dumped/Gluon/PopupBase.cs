using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class PopupBase : MonoBehaviour
	{
		public enum AnimationType
		{
			None = -1,
			Normal,
			Floating
		}

		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent closeButtonPressed;

		[SerializeField]
		public UnityEvent beforeCloseAnimation;

		[SerializeField]
		protected PointerEventHandler backKeyEventHandler;

		protected UnityEvent overrideBackKeyEvent;

		protected bool showStartAnimation;

		protected bool isWaitingCloseAnimation;

		public AnimationType animationType;

		public int animationFrame;

		private const int slowAnimationFrame = 6;

		private const int fastAnimationFrame = 5;

		private Vector2 oldMaskSizeForFloating;

		protected bool isStartAnimationEnd;

		public static int popupCount;

		public Canvas popupCanvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsStartAnimationEnd => default(bool);

		public static T Create<T>(string path, [Optional] Transform parentTransform, bool useAssetLoader = true, bool asErrorPopup = false) where T : PopupBase
		{
			return null;
		}

		public static bool isPopupCreate()
		{
			return default(bool);
		}

		protected virtual void Start()
		{
		}

		private IEnumerator WaitForStartAnimation()
		{
			return null;
		}

		public void SetOverrideBackKeyEvent(UnityEvent backKeyEvent)
		{
		}

		public virtual void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}

		public virtual void StartCloseAnimation([Optional] UnityEvent onCompleted)
		{
		}

		protected virtual IEnumerator StartCloseAnimationCoroutine([Optional] UnityEvent onCompleted)
		{
			return null;
		}

		public bool IsWaitingCloseAnimation()
		{
			return default(bool);
		}

		public void Close()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void CloseWithAnimation()
		{
		}

		public void CloseWithAnimation(bool invokeCloseEvent)
		{
		}

		public void Show(bool withAnimation)
		{
		}

		public void Hide(bool withAnimation)
		{
		}
	}
}
