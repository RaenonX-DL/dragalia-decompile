/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateCharge : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private bool _isChargeCompleted_k__BackingField;
		private State state;
		private float elapsedTime;
		private float orgMass;
		private CharacterStateChargeImpactSyncBody receivedChargeImpact;
		private int startActionId;
		private int loopActionId;
		private ActionChargeStep actionChargeStep;
	
		// Properties
		public bool isChargeCompleted { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isChargeCanceled { get; }
	
		// Nested types
		private enum State
		{
			Start = 0,
			Charge = 1,
			Cancel = 2
		}
	
		private enum ActionChargeStep
		{
			None = 0,
			Charging = 1,
			Charged = 2
		}
	
		// Constructors
		public CharacterStateCharge();
	
		// Methods
		private void chargePhase1ActionFinishCallback(ActionBase action);
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
		public void Cancel(bool keepCurrentAction);
		public override void OnRecieveExSync(CharacterStateExtraSync recvData);
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
