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
	public class StoryCommandCuttLoadStory : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private static CuttDriverInStory cuttDriver;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
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
		public StoryCommandCuttLoadStory();
		static StoryCommandCuttLoadStory();
	
		// Methods
		public static void ReleaseCuttStory();
		public void Start(string cuttName, int type);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		public static CuttDriverInGame GetCuttDriver();
		public string[] GetResourceNames(string cuttName, int type);
	}
}
