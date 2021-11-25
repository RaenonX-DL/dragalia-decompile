using System;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class PlayerStateGuard : PlayerStateBase
	{
		private float elapsedTime;

		private float rigorTime;

		private bool isWarning;

		public override void OnStateEnter()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}

		protected override bool CheckAttack(bool ignoreInput = false, [Optional] Action onReservedNextAttackAction)
		{
			return default(bool);
		}
	}
}
