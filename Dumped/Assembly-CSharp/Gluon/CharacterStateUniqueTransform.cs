/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateUniqueTransform : CharacterStateBase
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public bool enableBlur;
			public Action<EffectObject> __9__0;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _OnStateEnter_Internal_b__0(EffectObject effect);
		}
	
		// Constructors
		public CharacterStateUniqueTransform();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
