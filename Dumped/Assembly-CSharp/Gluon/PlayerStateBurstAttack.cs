/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateBurstAttack : PlayerStateBase
	{
		// Fields
		[CompilerGenerated]
		private bool _isAttacking_k__BackingField;
		private bool isForcedMoveInCharge;
		[CompilerGenerated]
		private int _chargeStartAction_k__BackingField;
	
		// Properties
		public bool isAttacking { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int chargeStartAction { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public PlayerStateBurstAttack();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		private void StopAutoEscapeFromMarker();
		public override void OnStateExit();
		private bool CheckBurstAttack();
		protected override bool IsOperateState();
	}
}
