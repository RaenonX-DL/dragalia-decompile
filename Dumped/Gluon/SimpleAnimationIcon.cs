using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleAnimationIcon : MonoBehaviour
	{
		public enum Type
		{
			ExpandWithDelay,
			Expand,
			FadeIn,
			None
		}

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®å\u008b\u0095ã\u0081\u008dã\u0081®ç\u00a8®é¡\u009e")]
		public Type type;

		[HideInInspector]
		public int delayIndex;

		private RectTransform rectTransform;

		private const float expandRate = 1.15f;

		private const float expandDuration = 4f / 15f;

		private const float bounceDuration = 142f / (339f * (float)Math.PI);

		private const float fadeInDuration = 0.5f;

		private CanvasGroup canvasGroup;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartAnimation()
		{
		}

		public static float GetDelayTimeByAnimationType(int index, Type animType)
		{
			return default(float);
		}

		protected void StartExpandAnimation(float delay)
		{
		}

		public void SkipAnimation()
		{
		}

		protected void StartFadeInAnimation(float delay)
		{
		}
	}
}
