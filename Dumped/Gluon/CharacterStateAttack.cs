using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterStateAttack : CharacterStateBase
	{
		private int currActionId;

		private int forceCurrentCombo;

		private bool isWaitingForAdditinalInput;

		private CharacterStateAdditionalInputCountSyncBody receivedAdditionalInput;

		private CharacterStateAdditionalInputCountSyncBody reservedAdditionalInputForDisconnect;

		public int actionId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public CommonObjectStatus target
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool firstAction
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
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

		private void UpdateChargeMarker()
		{
		}

		private float GetActionTempoForDifficulty(int actionId)
		{
			return default(float);
		}

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}

		private void ComboActionFinishCallback(ActionBase action)
		{
		}

		private bool CheckAdditionInputChangedAction(ref PlayerActionElement pae, ActionStartParameter startParameter)
		{
			return default(bool);
		}

		private void RunNextAction(int nextActionId, bool dontLootAtReservedTarget = false)
		{
		}

		public override void OnRecieveExSync(CharacterStateExtraSync recvData)
		{
		}
	}
}
