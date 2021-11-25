using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class CharacterStateCharge : CharacterStateBase
	{
		private enum State
		{
			Start,
			Charge,
			Cancel
		}

		private enum ActionChargeStep
		{
			None,
			Charging,
			Charged
		}

		private State state;

		private float elapsedTime;

		private float orgMass;

		private CharacterStateChargeImpactSyncBody receivedChargeImpact;

		private int startActionId;

		private int loopActionId;

		private ActionChargeStep actionChargeStep;

		public bool isChargeCompleted
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

		public bool isChargeCanceled => default(bool);

		private void chargePhase1ActionFinishCallback(ActionBase action)
		{
		}

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}

		public void Cancel(bool keepCurrentAction)
		{
		}

		public override void OnRecieveExSync(CharacterStateExtraSync recvData)
		{
		}

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
