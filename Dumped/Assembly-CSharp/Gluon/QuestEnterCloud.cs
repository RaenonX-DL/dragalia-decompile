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
	public class QuestEnterCloud : MonoBehaviour
	{
		// Fields
		public RectTransform leftCloud;
		public RectTransform rightCloud;
		public Vector2 firstLeftPosition;
		public Vector2 firstRightPosition;
		public float firstLeftScale;
		public float firstRightScale;
		public float firstDuration;
		public Vector2 secondLeftPosition;
		public Vector2 secondRightPosition;
		public float secondLeftScale;
		public float secondRightScale;
		public float secondDuration;
		public Vector2 thirdLeftPosition;
		public Vector2 thirdRightPosition;
		public float thirdLeftScale;
		public float thirdRightScale;
		private Action _onCompleteCallback;
		private bool _keepClosed;
		private bool _isAnimationDuring;
		private bool _isSecondAnimationDuring;
	
		// Properties
		public Action onCompleteCallback { get; set; }
		public bool keepClosed { get; set; }
		public bool isAnimationDuring { get; }
		public bool isSecondAnimationDuring { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PreloadCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PreloadCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__32_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SecondAnimationCoroutine_b__32_0();
		}
	
		[CompilerGenerated]
		private sealed class _SecondAnimationCoroutine_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEnterCloud __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SecondAnimationCoroutine_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestEnterCloud();
	
		// Methods
		public void StartAnimation();
		[IteratorStateMachine]
		private IEnumerator PreloadCoroutine();
		[IteratorStateMachine]
		private IEnumerator SecondAnimationCoroutine();
		private void OnStartAnimationCompleted();
		[CompilerGenerated]
		private void _StartAnimation_b__30_0(float value);
		[CompilerGenerated]
		private void _StartAnimation_b__30_1();
		[CompilerGenerated]
		private bool _SecondAnimationCoroutine_b__32_1();
		[CompilerGenerated]
		private void _SecondAnimationCoroutine_b__32_2(float value);
		[CompilerGenerated]
		private void _SecondAnimationCoroutine_b__32_3();
	}
}
