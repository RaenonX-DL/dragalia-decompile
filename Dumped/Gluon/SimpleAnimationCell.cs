using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class SimpleAnimationCell : MonoBehaviour
	{
		public enum Type
		{
			FadeInUpward,
			None
		}

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®å\u008b\u0095ã\u0081\u008dã\u0081®ç\u00a8®é¡\u009e")]
		public Type type;

		[HideInInspector]
		public int delayIndex;

		public bool autoExcuteInStart;

		protected float fadeinDuration;

		protected float fadeOutDuration;

		protected float moveDistance;

		protected float delayFactor;

		protected float delayFactorFadeOut;

		protected Sequence animationSequence;

		private Vector3 initAnchoredPosition;

		public RectTransform rectTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CanvasGroup canvasGroup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isOnAnimation
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

		public bool isResetPositionBeforeStartAnimation
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

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartAnimation()
		{
		}

		public void SetFadeInDuration(float v)
		{
		}

		public void StartFadeInUpwardAnimation(int delayIndex)
		{
		}

		public void StartFadeOutDownwardAnimation(int delayIndex)
		{
		}

		public void SkipAnimation()
		{
		}

		public void SetAlpha(float alpha)
		{
		}
	}
}
