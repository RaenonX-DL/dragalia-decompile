/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCharacterSlideout : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private bool visible;
		private string charaId;
		private int type;
		private float sec;
		private bool fade;
		private float moveValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public StoryCharacter data;
			public StoryCommandCharacterSlideout __4__this;
			public StoryImageManager.SlideDirection direction;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void __Update_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__9_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void __Update_b__9_1();
		}
	
		[CompilerGenerated]
		private sealed class __Update_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandCharacterSlideout __4__this;
			private __c__DisplayClass9_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandCharacterSlideout();
	
		// Methods
		public void Start(string charaId, int type, float sec, bool fade = true, float moveValue = 100f);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}
