﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateAttack : PlayerStateBase
	{
		// Fields
		private bool isReserveBurst;
		private bool voicePlayed;
		private bool checkAutoBurst;
		private int additionalInputCount;
	
		// Constructors
		public PlayerStateAttack();
	
		// Methods
		protected override bool NeedsUpdateLastWakeOnCollidedTime();
		public override void OnStateEnter();
		public override void OnStateUpdate();
		private bool CheckBurstAttack();
		protected override bool IsOperateState();
		private bool CheckAdditionalInput();
		public override void OnStateExit();
		[CompilerGenerated]
		private void _OnStateUpdate_b__6_0();
	}
}
