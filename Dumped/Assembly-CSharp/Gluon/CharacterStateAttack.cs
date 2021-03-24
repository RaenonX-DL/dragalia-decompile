/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateAttack : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		private int currActionId;
		private bool isWaitingForAdditinalInput;
		private CharacterStateAdditionalInputCountSyncBody receivedAdditionalInput;
		private CharacterStateAdditionalInputCountSyncBody reservedAdditionalInputForDisconnect;
	
		// Properties
		public int actionId { get; set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool firstAction { get; set; }
	
		// Constructors
		public CharacterStateAttack();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
		private void UpdateChargeMarker();
		private float GetActionTempoForDifficulty(int actionId);
		protected override bool NeedsResetHidingBuffOnEnter();
		private void ComboActionFinishCallback(ActionBase action);
		private bool CheckAdditionInputChangedAction(ref PlayerActionElement pae, ActionStartParameter startParameter);
		private void RunNextAction(int nextActionId, bool dontLootAtReservedTarget = false);
		public override void OnRecieveExSync(CharacterStateExtraSync recvData);
	}
}
