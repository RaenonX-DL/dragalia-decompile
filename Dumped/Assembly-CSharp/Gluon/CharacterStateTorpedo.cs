/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateTorpedo : CharacterStateBase
	{
		// Fields
		private State state;
		public CharacterBase throwChara;
		private float elapsedTime;
		private float downLoopTime;
		private const string animDownName = "blast_dead";
		private const string animStandupName = "blast_6";
	
		// Nested types
		private enum State
		{
			None = 0,
			Torpedo = 1,
			Down = 2,
			Standup = 3
		}
	
		// Constructors
		public CharacterStateTorpedo();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
	}
}
