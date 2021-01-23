/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateSleep : CharacterStateBase
	{
		// Fields
		public float dbgEnchant;
		public CollisionHitAttribute hitAttr;
	
		// Properties
		public int conditionId { get; set; }
	
		// Constructors
		public CharacterStateSleep();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
	}
}
