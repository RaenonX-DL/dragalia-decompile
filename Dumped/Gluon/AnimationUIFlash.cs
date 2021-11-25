using UnityEngine;

namespace Gluon
{
	public class AnimationUIFlash : AnimationUIBase
	{
		public enum AlphaAnimType
		{
			FadeInOut,
			FadeOutIn
		}

		[SerializeField]
		private AlphaAnimType alphaAnimType;

		[SerializeField]
		private bool useAlphaCurve;

		[SerializeField]
		private AnimationCurve alphaCurve;

		private FlashPlayer _flashPlayer;

		public FlashPlayer flashPlayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void AddToDefaultEnterAnimation()
		{
		}

		protected override void AddToDefaultExitAnimation()
		{
		}

		private void SetFlashAlpha(float alpha)
		{
		}

		private void GetStartEndAlpha(bool isEnter, out float startAlpha, out float endAlpha)
		{
		}
	}
}
