﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateDash : PlayerStateBase
	{
		// Fields
		private float elapsedTime;
		private DungeonObjectContact dunObjContact;
		private bool needsPlayAnimationForAutoPlayMode;
	
		// Constructors
		public PlayerStateDash();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateExit();
		public override void OnStateUpdate();
		protected override bool IsOperateState();
		private void PlayAnimation();
	}
}