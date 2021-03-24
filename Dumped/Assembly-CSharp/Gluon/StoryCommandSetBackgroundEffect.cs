/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandSetBackgroundEffect : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private string[] effectIds;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandSetBackgroundEffect __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandSetBackgroundEffect();
	
		// Methods
		public void Start(params string[] effectIds);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		private void SetBackgroundEffect(string[] effectIds);
		public string[] GetResourceNames(params string[] effectIds);
		[CompilerGenerated]
		private void __Update_b__4_0();
	}
}
