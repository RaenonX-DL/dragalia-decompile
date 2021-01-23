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
	public class StoryCommandPlaySound : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private string soundStr;
		private float vol;
		private bool isAvoidDupricateVoice;
		private bool isAddTextLog;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandPlaySound __4__this;
			private int _frameNum_5__2;
	
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
		public StoryCommandPlaySound();
	
		// Methods
		public void Start(string soundStr, float vol = 1f, bool isAvoidDupricateVoice = true, bool isAddTextLog = true);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		public void PlaySound();
		public string[] GetResourceNames(string soundStr, float vol = 1f, bool isAvoidDupricateVoice = true, bool isAddTextLog = true);
		[CompilerGenerated]
		private void __Update_b__7_0();
	}
}
