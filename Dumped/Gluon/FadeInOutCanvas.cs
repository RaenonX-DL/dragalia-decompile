using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FadeInOutCanvas : SingletonInBaseMonoBehaviour<FadeInOutCanvas>
	{
		public Image image;

		[HideInInspector]
		public UnityEvent onFadeInCompleteEvent;

		[HideInInspector]
		public UnityEvent onFadeOutCompleteEvent;

		public const float fadeInDelay = 0f;

		public const float fadeInDuration = 0.5f;

		public const float fadeOutDelay = 0.1f;

		public const float fadeOutDuration = 0.5f;

		public const float slideDuration = 0.6f;

		public const float loadingFadeAlpha = 0.8f;

		private bool isOnFadeIn;

		private bool isOnFadeOut;

		private bool isWhite;

		private RenderTexture renderTexture;

		private NowLoadingCanvas nowLoadingCanvas;

		private void Start()
		{
		}

		public UnityEvent StartLoadingFadeOut(bool slideHeader = true, bool slideFooter = true, [Optional] Camera targetCamera)
		{
			return null;
		}

		private IEnumerator LoadingFadeOutCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Camera targetCamera)
		{
			return null;
		}

		public UnityEvent StartFadeOut(float duration = 0.5f, bool isWhite = false)
		{
			return null;
		}

		private void OnFadeOutUpdate(float value)
		{
		}

		private void OnFadeOutComplete()
		{
		}

		public UnityEvent StartLoadingFadeIn(bool slideHeader = true, bool slideFooter = true, [Optional] Camera targetCamera)
		{
			return null;
		}

		private IEnumerator LoadingFadeInCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Camera targetCamera)
		{
			return null;
		}

		public UnityEvent StartFadeIn(float duration = 0.5f, bool isWhite = false, float delay = 0f)
		{
			return null;
		}

		private void OnFadeInUpdate(float value)
		{
		}

		private void OnFadeInComplete()
		{
		}

		public bool IsOnFade()
		{
			return default(bool);
		}

		public bool IsFadeOut()
		{
			return default(bool);
		}

		public bool IsFadeIn()
		{
			return default(bool);
		}

		public void SetImageEnabled(bool enabled)
		{
		}
	}
}
