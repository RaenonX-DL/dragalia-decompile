using System.Runtime.CompilerServices;

namespace Gluon
{
	public class PlayerStateBurstAttack : PlayerStateBase
	{
		private bool isForcedMoveInCharge;

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

		private void StopAutoEscapeFromMarker()
		{
		}

		public override void OnStateExit()
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
	}
}
