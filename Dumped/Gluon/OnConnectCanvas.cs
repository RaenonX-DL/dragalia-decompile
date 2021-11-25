using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class OnConnectCanvas : MonoBehaviour
	{
		public Camera nhaamCamera;

		public Camera dummyFlashCamera;

		public GameObject touchGuard;

		public CanvasGroup blackLayer;

		public RawImage rawImage;

		private float alpha;

		private bool showBlackLayer;

		private Tweener alphaTweener;

		private Tweener colorTweener;

		private int showCount;

		private bool _isPaymentMask;

		private FlashPlayer flashPlayer;

		private GameObject flashObject;

		private bool showNextFlashWithColor;

		private RenderTexture renderTexture;

		private static OnConnectCanvas _instance;

		public bool isPaymentMask
		{
			set
			{
			}
		}

		public static OnConnectCanvas instance => null;

		public static bool IsInstanceEmpty => default(bool);

		private void Awake()
		{
		}

		public void ShowNextFlashInWhiteBg(bool withColor)
		{
		}

		public void Show(bool showBlackLayer = false)
		{
		}

		public IEnumerator ShowCoroutine(bool showBlackLayer = false)
		{
			return null;
		}

		public void Hide(float delay = 0.3f)
		{
		}

		public void HideForce()
		{
		}

		public bool IsShowing()
		{
			return default(bool);
		}

		private IEnumerator HideCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator OnComplete(float delay)
		{
			return null;
		}

		public bool IsOnConnect()
		{
			return default(bool);
		}
	}
}
