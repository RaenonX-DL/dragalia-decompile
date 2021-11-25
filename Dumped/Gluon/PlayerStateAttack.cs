namespace Gluon
{
	public class PlayerStateAttack : PlayerStateBase
	{
		private bool isReserveBurst;

		private bool voicePlayed;

		private bool checkAutoBurst;

		private int additionalInputCount;

		protected override bool NeedsUpdateLastWakeOnCollidedTime()
		{
			return default(bool);
		}

		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		private bool CheckBurstAttack()
		{
			return default(bool);
		}

		protected override bool IsOperateState()
		{
			return default(bool);
		}

		private bool CheckAdditionalInput()
		{
			return default(bool);
		}

		public override void OnStateExit()
		{
		}
	}
}
