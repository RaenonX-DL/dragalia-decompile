/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateBlastDown : CharacterStateBase
	{
		// Fields
		private ActionBlastDown action;
		private const float DIE_TIMING = 0.2f;
		private float _elapsed;
		private bool hasDead;
	
		// Properties
		public float gravity { get; set; }
		public float angle { get; set; }
		public float height { get; set; }
	
		// Constructors
		public CharacterStateBlastDown();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
	}
}
