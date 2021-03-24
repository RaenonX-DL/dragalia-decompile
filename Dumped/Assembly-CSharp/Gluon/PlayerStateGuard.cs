/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateGuard : PlayerStateBase
	{
		// Fields
		private float elapsedTime;
		private float rigorTime;
		private bool isWarning;
	
		// Constructors
		public PlayerStateGuard();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateExit();
		public override void OnStateUpdate();
		protected override bool CheckAttack(bool ignoreInput = false, Action onReservedNextAttackAction = null);
	}
}
