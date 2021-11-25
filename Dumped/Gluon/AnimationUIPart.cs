using DG.Tweening;

namespace Gluon
{
	public class AnimationUIPart : AnimationUIPartBase
	{
		public Ease easeType;

		public float duration;

		public float delay;

		public float delayReverse;

		public EaseFunction customEaseFunction;

		public EaseFunction customEaseFunctionReverse;

		public float overshootOrAmplitudeCustom;

		private CustomEaseFunction _easeFunction;

		public Tweener curTweener;

		public CustomEaseFunction easeFunction => null;

		public override void Init()
		{
		}
	}
}
