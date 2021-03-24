/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateReserverIn : CharacterStateBase
	{
		// Fields
		private State state;
		private ActionMoveGravity fallAction;
	
		// Nested types
		private enum State
		{
			Fall = 0,
			Landing = 1
		}
	
		// Constructors
		public CharacterStateReserverIn();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		public override void OnStateUpdate();
	}
}
