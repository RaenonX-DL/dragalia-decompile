/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandTelop : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private string mainText;
		private string subText;
		private string mainRuby;
		private string subRuby;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandTelop __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandTelop();
	
		// Methods
		public void Start(string mainText, string subText = "", string mainRuby = "", string subRuby = "");
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}
