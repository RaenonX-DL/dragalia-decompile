/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateDashAttack : PlayerStateBase
	{
		// Fields
		private int forceCurrentCombo;
	
		// Constructors
		public PlayerStateDashAttack();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		protected override bool CheckAttack(bool ignoreInput = false, Action onReservedNextAttackAction = null);
	}
}
