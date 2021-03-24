/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class EventReceiverBase : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private CharacterId _characterId_k__BackingField;
		[CompilerGenerated]
		private float _ChangeStateWarpRangeSq_k__BackingField;
		protected Vector3 targetPosition;
		protected Quaternion targetRotation;
		protected bool moving;
		protected bool isSkillMove;
		protected float elapsedMoveTime;
		protected float remainMoveTime;
		protected bool externalVelocity;
		private const float RotationInterpolationInvalidThreshold = 120f;
		private bool _isMoveSyncDisabled;
		private Queue<KeyValuePair<float, CharacterState>> characterStateQueue;
		private AIScriptContext lastAIScriptContext;
		private AIScriptContext tmpAIScriptContext;
	
		// Properties
		public CharacterId characterId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public abstract CharacterBase character { get; }
		private float ChangeStateWarpRangeSq { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsMoveSyncDisabled { get; set; }
		public AIScriptContext LastAIScriptContext { get; }
	
		// Constructors
		protected EventReceiverBase();
	
		// Methods
		public virtual void Initialize(CharacterId characterId);
		public virtual void Reset();
		public override void FastUpdate();
		public void Warp(Vector3 position, float rotation);
		public void Move(Move move);
		public void Move(MoveBundleUnit moveBundleUnit);
		public void ChangeState(CharacterState characterState);
		protected virtual void ChangeStateImpl(CharacterState characterState);
		public virtual void ThrowCarryRequest(ThrowCarryRequest throwCarryRequest);
		public virtual void ThrowCarryReply(ThrowCarryReply throwCarryReply);
		public virtual void ThrowRelease(ThrowRelease throwRelease);
		public void OnCarriedStateExit();
		protected void ProcessMove();
		protected virtual void UpdateSkillState();
		protected virtual void UpdateChargeState();
	}
}
