using System;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class PlayerStateDashAttack : PlayerStateBase
	{
		private int forceCurrentCombo;

		public override void OnStateEnter()
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
