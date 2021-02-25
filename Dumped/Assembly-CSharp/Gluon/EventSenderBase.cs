/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class EventSenderBase : MonoBehaviour
	{
		// Fields
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
		[CompilerGenerated]
		private float _PrevSendMoveEventTime_k__BackingField;
		[CompilerGenerated]
		private bool _IsMoveSyncDisabled_k__BackingField;
	
		// Properties
		public abstract CharacterBase character { get; }
		protected bool delayedCharacterState { get; }
		public float PrevSendMoveEventTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsMoveSyncDisabled { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		protected EventSenderBase();
	
		// Methods
		public virtual void Initialize(CharacterId characterId, bool useMoveBundle);
		public virtual void Reset();
		public void OnWarp();
		public MoveBundleUnit OnBulkWarp();
		public void RequestSyncPosition();
		public bool CheckSendMoving(Vector3 lastSendPosition, float lastSendRotation, out bool moving, out bool externalVelocity);
		private bool CanSendStateChange();
		protected void OnStateChanged(int state, int[] param, float[] paramf, RunActionEvent runActionEvent, bool ignoreSync);
		protected virtual void LateUpdate();
		protected virtual bool IsAiAwake();
		protected void SendMoveEvent(bool moving, bool externalVelocity, bool isSkillMove);
		private void SendWarpEvent();
		protected virtual void UpdateSkillState();
		protected virtual void UpdateChargeState();
		private void SendAllChangeStateQueue();
	}
}
