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
	public class StoryCommandPlayMovie : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private string fileName;
		private bool isPanScan;
		private const string storyMoviePathFormat = "Story/{0}";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandPlayMovie __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandPlayMovie();
	
		// Methods
		public void Start(string fileName, bool isPanScan = false);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		public string[] GetResourceNames(string fileName, bool isPanScan = false);
	}
}
