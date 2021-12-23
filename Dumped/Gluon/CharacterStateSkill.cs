using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterStateSkill : CharacterStateBase
	{
		private int currSkillIndex;

		private int currActionId;

		private int currProductId;

		private int loopActionProductId;

		private bool isWaitingForAdditinalInput;

		private CharacterStateAdditionalInputCountSyncBody reservedAdditionalInputForDisconnect;

		private CharacterStateAdditionalInputCountSyncBody receivedAdditionalInput;

		private bool _prevEnableNavMeshAgent;

		private ActionStartParameter startParameter;

		private bool isBuffPaused;

		private bool hasHiding;

		public int skillIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

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

		public int skillId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
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

		protected override ActionBase RunAction(int actionId, int skillId = 0, float tempoScale = 1f, [Optional] CommonObjectStatus target, [Optional] Action<ActionBase> actionFinishCallback, int overrideActionProductId = -1, bool dontLootAtReservedTarget = false, bool isFromOption = false, [Optional] Action<ActionBase> onActionLoadedCallback, [Optional] Action<ActionBase> onActionRunCallback)
		{
			return null;
		}

		private void SkillActionFinishCallback(ActionBase action)
		{
		}

		private void CheckAdditionInputAction(ref PlayerActionElement pae)
		{
		}

		private bool CheckAdditionInputChangedAction(ref PlayerActionElement pae, ActionStartParameter startParameter)
		{
			return default(bool);
		}

		private void SetStartParam(ActionContainer container)
		{
		}

		private void RunNextAction(int nextActionId, bool dontLootAtReservedTarget = false)
		{
		}

		private void RunAdditionalInputAction(int actionId)
		{
		}

		private void StartModeChange()
		{
		}

		private void StartTransformSkill()
		{
		}

		private void TransformSkill()
		{
		}

		private bool SetChainSkill(PlayerCharacter player, int index)
		{
			return default(bool);
		}

		private void ResetTensionBuff(RemoveBuffReason reason, ActionStartParameter startParameter)
		{
		}

		private void ResetInspirationBuff(RemoveBuffReason reason, ActionStartParameter startParameter)
		{
		}

		private void SetLoopActionProductId(int actionId)
		{
		}

		private void SetLoopActionProductId()
		{
		}

		public override void OnRecieveExSync(CharacterStateExtraSync recvData)
		{
		}

		public override void OnDisconnectOwner()
		{
		}

		protected override bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
