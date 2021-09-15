/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerStateBurstAttack : IState<Gluon.FollowerController>
	{
		// Fields
		[CompilerGenerated]
		private bool _isAttacking_k__BackingField;
		private int chargeStartAction;
	
		// Properties
		public bool isAttacking { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public FollowerStateBurstAttack();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		public override void OnStateExit();
		private bool CheckBurstAttack();
		private bool IsEnableAimTarget();
	}
}
