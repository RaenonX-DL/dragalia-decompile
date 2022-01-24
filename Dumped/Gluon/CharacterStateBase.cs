using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;

namespace Gluon
{
	public class CharacterStateBase : IState<CharacterBase>
	{
		public const int paramSize = 3;

		public int[] param;

		public float[] paramf;

		private RunActionEvent _runActionEvent;

		private RunActionEvent _reservedActionEvent;

		private bool _isStateActive;

		public bool ignoreSync
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetRunActionEvent(RunActionEvent runActionEvent)
		{
		}

		private void OnBeforeStateEnter()
		{
		}

		protected virtual void OnStateEnter_Internal()
		{
		}

		protected void CheckStateEnterExitAbility(bool isEnter, int actionId)
		{
		}

		private void OnEndStateEnter()
		{
		}

		public sealed override void OnStateEnter()
		{
		}

		public override void OnStateExit()
		{
		}

		protected virtual ActionBase RunAction(int actionId, int skillId = 0, float tempoScale = 1f, [Optional] CommonObjectStatus target, [Optional] Action<ActionBase> actionFinishCallback, int overrideActionProductId = -1, bool dontLootAtReservedTarget = false, bool isFromOption = false, [Optional] Action<ActionBase> onActionLoadedCallback, [Optional] Action<ActionBase> onActionRunCallback)
		{
			return null;
		}

		protected ActionBase RunAction(ActionBase action)
		{
			return null;
		}

		public virtual void OnRecieveExSync(CharacterStateExtraSync recvData)
		{
		}

		public virtual void OnDisconnectOwner()
		{
		}

		protected virtual bool NeedsResetHidingBuffOnEnter()
		{
			return default(bool);
		}
	}
}
