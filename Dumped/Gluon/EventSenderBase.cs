using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public abstract class EventSenderBase : MonoBehaviour
	{
		protected float sendTimer;

		protected float idleTimer;

		private Move move;

		private Queue<CharacterState> _characterStateSendQueue;

		private Queue<CharacterState> _unusedCharacterStatePool;

		protected Vector3 lastSendPosition;

		protected float lastSendRotation;

		private bool sendMoveBundle;

		private AIScriptContext lastSendAIScriptContext;

		private AIScriptContext tmpSendAIScriptContext;

		private bool isSyncPositionRequested;

		private CharacterId _characterId;

		public abstract CharacterBase character { get; }

		protected bool delayedCharacterState => default(bool);

		public float PrevSendMoveEventTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsMoveSyncDisabled
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

		public virtual void Initialize(CharacterId characterId, bool useMoveBundle)
		{
		}

		public virtual void Reset()
		{
		}

		public void OnWarp()
		{
		}

		public MoveBundleUnit OnBulkWarp()
		{
			return null;
		}

		public void RequestSyncPosition()
		{
		}

		public bool CheckSendMoving(Vector3 lastSendPosition, float lastSendRotation, out bool moving, out bool externalVelocity)
		{
			return default(bool);
		}

		private bool CanSendStateChange()
		{
			return default(bool);
		}

		protected void OnStateChanged(int state, int[] param, float[] paramf, RunActionEvent runActionEvent, bool ignoreSync)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual bool IsAiAwake()
		{
			return default(bool);
		}

		protected void SendMoveEvent(bool moving, bool externalVelocity, bool isSkillMove)
		{
		}

		private void SendWarpEvent()
		{
		}

		protected virtual void UpdateSkillState()
		{
		}

		protected virtual void UpdateChargeState()
		{
		}

		private void SendAllChangeStateQueue()
		{
		}
	}
}
