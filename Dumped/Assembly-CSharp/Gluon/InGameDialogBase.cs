/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameDialogBase : MonoBehaviour
	{
		// Fields
		protected const float animWaitFrame = 3f;
		protected const float animFrame = 5f;
		protected bool _isClose;
		private RectTransform rectTransform;
		private Vector3 originalPosition;
		private bool _isClosing;
		private Tweener openTweenerPos;
		private Tweener openTweenerAlpha;
		private Tweener closeTweenerPos;
		private Tweener closeTweenerAlpha;
		protected bool isPressedButton;
		protected static Vector3 tmpVec;
		public bool ignoreTimeScale;
	
		// Properties
		public bool isClose { get; }
		public bool isClosing { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public InGameDialogBase __4__this;
			public CanvasGroup canvasGroup;
			public UnityEvent onCompleted;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _StartShowAnimation_b__0(float value);
			internal void _StartShowAnimation_b__1();
			internal void _StartShowAnimation_b__2(float value);
			internal void _StartShowAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _StartShowAnimation_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InGameDialogBase __4__this;
			public UnityEvent onCompleted;
			public float rectHeight;
			private __c__DisplayClass18_0 __8__1;
			private float _moveY_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartShowAnimation_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public InGameDialogBase __4__this;
			public CanvasGroup canvasGroup;
			public UnityEvent onCompleted;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _StartCloseAnimationCoroutine_b__0(float value);
			internal void _StartCloseAnimationCoroutine_b__1();
			internal void _StartCloseAnimationCoroutine_b__2(float value);
			internal void _StartCloseAnimationCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _StartCloseAnimationCoroutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InGameDialogBase __4__this;
			public UnityEvent onCompleted;
			public float rectHeight;
			private __c__DisplayClass19_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartCloseAnimationCoroutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public InGameDialogBase();
		static InGameDialogBase();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		protected IEnumerator StartShowAnimation(float rectHeight, UnityEvent onCompleted = null);
		[IteratorStateMachine]
		protected IEnumerator StartCloseAnimationCoroutine(float rectHeight, UnityEvent onCompleted = null);
		public bool IsPlaying();
		protected Vector3 GetOriginalPosition();
		protected void SetOriginalPosition(Vector3 pos);
	}
}
