/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateStopDash : PlayerStateBase
	{
		// Fields
		private float elapsedTime;
		[CompilerGenerated]
		private float _AttackInterval_k__BackingField;
	
		// Properties
		public float AttackInterval { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PlayerStateStopDash();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		protected bool CheckDashAttack();
	}
}
