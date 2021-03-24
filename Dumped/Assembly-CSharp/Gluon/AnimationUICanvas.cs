/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class AnimationUICanvas : MonoBehaviour
	{
		// Fields
		private bool _animationEnabled;
		private AnimationUIBase[] animationUIs;
		private UIAnimationPublisher[] animationPublishers;
		public Canvas canvas;
	
		// Properties
		public bool animationEnabled { get; set; }
	
		// Nested types
		public enum AnimationPattern
		{
			Pattern_Any = -1,
			Pattern_1 = 0,
			Pattern_2 = 1,
			Pattern_3 = 2,
			Pattern_4 = 3,
			Pattern_5 = 4,
			Pattern_6 = 5
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _RegisterToManagerCoroutine_b__10_0();
		}
	
		[CompilerGenerated]
		private sealed class _RegisterToManagerCoroutine_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RegisterToManagerCoroutine_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public AnimationUICanvas __4__this;
			public AnimationPattern pattern;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _WaitForAnimationComplete_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForAnimationComplete_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationUICanvas __4__this;
			public AnimationPattern pattern;
			private __c__DisplayClass13_0 __8__1;
			public Action onAnimationDone;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForAnimationComplete_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AnimationUICanvas();
	
		// Methods
		protected virtual void Awake();
		public void RegisterToManager();
		[IteratorStateMachine]
		private IEnumerator RegisterToManagerCoroutine();
		public void RecollectAnimationUIs();
		public virtual void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitForAnimationComplete(AnimationPattern pattern, Action onAnimationDone);
		public virtual void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void ForceResetPlayedState(bool enterState, bool exitState, AnimationPattern pattern = AnimationPattern.Pattern_1);
		public virtual bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public bool IsOnAnyAnimation();
		public void ResetUIAnimations();
		protected virtual void OnDestroy();
	}
}
