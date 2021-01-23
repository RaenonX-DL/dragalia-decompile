/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerEventReceiver : EventReceiverBase
	{
		// Fields
		[CompilerGenerated]
		private CharacterSelector _selector_k__BackingField;
		[CompilerGenerated]
		private int _proxyActorId_k__BackingField;
		[CompilerGenerated]
		private int _LastDp_k__BackingField;
		private bool _controlled;
		private float targetChargePullLength;
		private Vector3 targetChargeMarkerPos;
		private Quaternion targetChargeRotation;
		private float remainChargeTime;
		private int targetChangeMode;
	
		// Properties
		public override CharacterBase character { get; }
		public PlayerCharacter player { get; }
		public CharacterSelector selector { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int proxyActorId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool controlled { get; set; }
		public bool LastControlled { get; }
		public int LastDp { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PlayerEventReceiver();
	
		// Methods
		public override void Initialize(CharacterId characterId);
		public override void FastUpdate();
		public override void ThrowCarryRequest(ThrowCarryRequest throwCarryRequest);
		public override void ThrowCarryReply(ThrowCarryReply throwCarryReply);
		public override void ThrowRelease(ThrowRelease throwRelease);
		public void Charge(Charge charge);
		public void SetCurrentChangeMode(int mode);
		protected override void ChangeStateImpl(CharacterState characterState);
		protected override void UpdateSkillState();
		protected override void UpdateChargeState();
		protected void ProcessCharge(bool isChargeDirectionIndependent);
		protected void ProcessChargeAfterMove(bool isChargeDirectionIndependent);
		private void UpdateChangeMode();
		public static bool NeedModeChangeSync(PlayerCharacter.ModeChangeType modeChangeType);
		private void CheckDragonTransformEffect();
	}
}
