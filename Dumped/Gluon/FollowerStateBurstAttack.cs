using System.Runtime.CompilerServices;

namespace Gluon
{
	public class FollowerStateBurstAttack : IState<FollowerController>
	{
		private int chargeStartAction;

		public bool isAttacking
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}

		private bool CheckBurstAttack()
		{
			return default(bool);
		}

		private bool IsEnableAimTarget()
		{
			return default(bool);
		}
	}
}
