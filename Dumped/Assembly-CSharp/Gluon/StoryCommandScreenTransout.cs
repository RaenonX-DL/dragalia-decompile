/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandScreenTransout : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private bool visible;
		private int type;
		private float sec;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public StoryCommandScreenTransout __4__this;
			public StoryImageManager.SlideDirection direction;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void __Update_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__6_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void __Update_b__6_1();
		}
	
		[CompilerGenerated]
		private sealed class __Update_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandScreenTransout __4__this;
	
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
		public StoryCommandScreenTransout();
	
		// Methods
		public void Start(int type, float sec);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}
