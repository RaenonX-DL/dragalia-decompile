/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateMove : PlayerStateBase
	{
		// Fields
		private float elapsedTime;
		private bool needsPlayAnimationForAutoPlayMode;
		public const float WALK_INTERVAL_SEC = 1f;
	
		// Constructors
		public PlayerStateMove();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateExit();
		public override void OnStateUpdate();
		protected override bool IsOperateState();
		private void PlayAnimation();
	}
}
