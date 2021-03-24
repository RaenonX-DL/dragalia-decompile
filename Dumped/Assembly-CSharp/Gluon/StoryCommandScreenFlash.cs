/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandScreenFlash : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private Color color;
		private float sec;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandScreenFlash __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandScreenFlash();
	
		// Methods
		public void Start(float sec, params int[] rgb);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		[CompilerGenerated]
		private void __Update_b__5_1();
		[CompilerGenerated]
		private void __Update_b__5_0();
		[CompilerGenerated]
		private void __Update_b__5_2();
	}
}
