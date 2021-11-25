namespace Gluon
{
	public class PlayerStateMove : PlayerStateBase
	{
		private float elapsedTime;

		private bool needsPlayAnimationForAutoPlayMode;

		public const float WALK_INTERVAL_SEC = 1f;

		public override void OnStateEnter()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}

		protected override bool IsOperateState()
		{
			return default(bool);
		}

		private void PlayAnimation()
		{
		}
	}
}
