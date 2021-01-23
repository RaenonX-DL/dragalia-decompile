/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUICaption : AnimationUIBase
	{
		// Fields
		public bool isShown;
		public AnimationUICanvas canvas;
		private Image[] images;
		private UnityEngine.UI.Text[] texts;
		private Action onEnterAnimationDone;
		private Action onExitAnimationDone;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartEnterAnimationCoroutine_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationUICaption __4__this;
			public Action onAnimationDone;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEnterAnimationCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public AnimationUICaption __4__this;
			public Vector3 initialPosition;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _StartEnterAnimationImpl_b__0(float x);
			internal void _StartEnterAnimationImpl_b__1();
			internal void _StartEnterAnimationImpl_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public AnimationUICaption __4__this;
			public Vector3 initialPosition;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _StartExitAnimation_b__0(float x);
			internal void _StartExitAnimation_b__1();
			internal void _StartExitAnimation_b__2();
		}
	
		// Constructors
		public AnimationUICaption();
	
		// Methods
		public override void Awake();
		public override void StartEnterAnimation(Action onAnimationDone = null);
		[IteratorStateMachine]
		private IEnumerator StartEnterAnimationCoroutine(Action onAnimationDone = null);
		private void StartEnterAnimationImpl();
		public override void StartExitAnimation(Action onAnimationDone = null);
		public bool IsOnExitAnimation();
		private void SetUIPartsEnable(bool enabled);
		[CompilerGenerated]
		private bool _StartEnterAnimationCoroutine_b__8_0();
	}
}
