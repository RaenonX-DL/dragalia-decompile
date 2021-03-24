/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerEventSender : EventSenderBase
	{
		// Fields
		private CharacterSelector selector;
		private bool isSyncChargeRequested;
		private float lastSendChargePullLength;
		private Vector3 lastSendChargeMarkerPos;
		private float lastSendChargeRotation;
		private int lastSendChangeMode;
		private TransformCharacter transformCharacter;
		private Charge charge;
	
		// Properties
		public override CharacterBase character { get; }
		public PlayerCharacter player { get; }
	
		// Constructors
		public PlayerEventSender();
	
		// Methods
		public override void Initialize(CharacterId characterId, bool useMoveBundle);
		private void OnChangeCharacter(CharacterSelector.Type type, bool isFinishDragon);
		protected override void LateUpdate();
		protected override void UpdateSkillState();
		protected override void UpdateChargeState();
		public void RequestChargeEvent();
		private Charge CreateChargeEvent();
		private bool CheckSendCharge(Charge charge);
		protected void SendChargeEvent(Charge charge);
		private void UpdateSendChangeMode();
	}
}
