namespace Gluon
{
	public class UIAnimationInnerMove : UIAnimationBase
	{
		protected float moveDistance;

		protected float overrunBounceDistance;

		protected float postOverrunExtension;

		protected override void JoinEnterCanvasGroupAnimation()
		{
		}

		protected override void JoinExitCanvasGroupAnimation()
		{
		}

		public override void ApplySetting(UIAnimationSetting anotherSetting)
		{
		}

		protected override void JoinEnterAnimation()
		{
		}

		protected override void JoinExitAnimation()
		{
		}

		protected override float AppendExtraToEnterAnimation()
		{
			return default(float);
		}

		protected override float AppendExtraToExitAnimation()
		{
			return default(float);
		}
	}
}
