﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateBlastUp : CharacterStateBase
	{
		// Fields
		private ActionBlastUp action;
		public CharacterBase attacker;
		[CompilerGenerated]
		private bool _disallowRecovery_k__BackingField;
	
		// Properties
		public float gravity { get; set; }
		public float angle { get; set; }
		public float height { get; set; }
		public int reaction { get; set; }
		public bool disallowRecovery { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CharacterStateBlastUp();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
