/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateDamaged : CharacterStateBase
	{
		// Properties
		public float motionTimeScale { get; set; }
	
		// Constructors
		public CharacterStateDamaged();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
