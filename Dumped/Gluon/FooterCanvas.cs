using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class FooterCanvas : MonoBehaviour
	{
		public Footer footer;

		public Canvas canvas;

		private bool isAnimating;

		[SerializeField]
		private float slideDistance;

		private RectTransform footerRectTrans;

		private float defaultYFooter;

		private static FooterCanvas _instance;

		public bool isSlideOut
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

		public int defaultSortingOrder
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static FooterCanvas instance => null;

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		protected virtual void OnDestroy()
		{
		}

		public static IEnumerator MoveMeToScene(FooterCanvas obj)
		{
			return null;
		}

		public static bool DoMoveMeToScene(FooterCanvas obj)
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void ResetCamera()
		{
		}

		private IEnumerator ResetCameraCoroutine()
		{
			return null;
		}

		public void SlideIn(float duration = 0.3f)
		{
		}

		public void SlideOut(float duration = 0.3f)
		{
		}

		public void SlideInFade(float duration = 0.3f)
		{
		}

		public void SlideOutFade(float duration = 0.3f)
		{
		}

		private void MoveTo(RectTransform targetRectTransform, float startY, float endY, float duration)
		{
		}

		private void MoveWithScaleAndFade(Sequence mainSeq, RectTransform targetRectTransform, float startY, float endY, float duration, float endScale, float endFade)
		{
		}

		public void SetSortingOrder(int order)
		{
		}

		public void ResetSortingOrder()
		{
		}
	}
}
