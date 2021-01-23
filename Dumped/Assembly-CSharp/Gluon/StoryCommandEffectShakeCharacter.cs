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
	public class StoryCommandEffectShakeCharacter : IStoryCommand
	{
		// Fields
		private IEnumerator coroutine;
		private int type;
		private float peekSec;
		private float stopSec;
		private int ease;
		private bool isWithBg;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public StoryCommandEffectShakeCharacter __4__this;
			public float value;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void __Update_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void __Update_b__8_0();
		}
	
		[CompilerGenerated]
		private sealed class __Update_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryCommandEffectShakeCharacter __4__this;
			private Tweener _tween_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __Update_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryCommandEffectShakeCharacter();
	
		// Methods
		public void Start(int type, float peekSec = 3f, float stopSec = 3f, int ease = 1);
		public override bool Update();
		[IteratorStateMachine]
		private IEnumerator _Update();
	}
}
