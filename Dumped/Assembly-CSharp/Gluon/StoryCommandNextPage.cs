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
	public class StoryCommandNextPage : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private float waitTime;
		private bool isNoNeedTouch;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandNextPage __4__this;
			private bool _isTouchAtTouchWait_5__2;
	
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
		public StoryCommandNextPage();
	
		// Methods
		public void Start(float waitTime = 0.3f);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}
