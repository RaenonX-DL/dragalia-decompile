/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateBlastSp : CharacterStateBase
	{
		// Fields
		private ActionBlastSp action;
	
		// Properties
		public float gravity { get; set; }
		public float angle { get; set; }
		public float height { get; set; }
	
		// Constructors
		public CharacterStateBlastSp();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
	}
}
