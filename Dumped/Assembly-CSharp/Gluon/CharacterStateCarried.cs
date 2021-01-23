/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateCarried : CharacterStateBase
	{
		// Fields
		public CharacterBase carryChara;
		[CompilerGenerated]
		private bool _isFalling_k__BackingField;
	
		// Properties
		public bool isFalling { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharacterStateCarried();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
	}
}
