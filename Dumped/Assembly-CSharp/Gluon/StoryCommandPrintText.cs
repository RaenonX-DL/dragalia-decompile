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
	public class StoryCommandPrintText : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private bool isEnd;
		private string name;
		private string text;
		private string voice;
		private bool isVisiblePageIcon;
		private bool isEndLipSynch;
		private string overLineText;
		private const string hideTrigger = "#";
		private const string hideSecondTrigger = "$";
		public const int waitFrameCountForDummyVoiceCheck = 5;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __Update_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandPrintText __4__this;
			private bool _isLineOverPrint_5__2;
			private bool _isExistVoice_5__3;
			private CuttDriverInGame _driver_5__4;
			private bool _isTouchAtTouchWait_5__5;
			private int _frameNum_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __UpdateWindowFadein_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandPrintText __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __UpdateWindowFadein_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandPrintText();
	
		// Methods
		public void Start(bool isEnd, string name = "", string text = "", string voice = "");
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
		private void UpdateLipSynch();
		public string[] GetResourceNames(bool isEnd, string name = "", string text = "", string voice = "");
		[IteratorStateMachine]
		private IEnumerator _UpdateWindowFadein();
		public static bool IsExistVoice(string voice);
		private static CuttDriverInGame GetCuttDriver();
	}
}
