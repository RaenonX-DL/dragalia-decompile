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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UiAnimationHide : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private int interval;
		[Header]
		[SerializeField]
		private float duration;
		[Header]
		[SerializeField]
		private float moveMargin;
		[Header]
		[SerializeField]
		private Ease enterEase;
		[Header]
		[SerializeField]
		private Ease exitEase;
		[Header]
		[SerializeField]
		private int headerMoveOrder;
		[Header]
		[SerializeField]
		private int footerMoveOrder;
		[Header]
		[SerializeField]
		private RectTransform parentObject;
		[Header]
		[SerializeField]
		private AnimationUi[] animationObjects;
		private int timingCount;
	
		// Nested types
		private enum MoveDirection
		{
			UP = 0,
			Down = 1,
			Right = 2,
			Left = 3
		}
	
		private enum UiCondition
		{
			Show = 0,
			Move = 1,
			Hide = 2
		}
	
		[Serializable]
		private class AnimationUi
		{
			// Fields
			public GameObject obj;
			public int moveOrder;
			public MoveDirection moveDirection;
			[NonSerialized]
			public Vector3 defaultPos;
			[NonSerialized]
			public UiCondition condition;
	
			// Constructors
			public AnimationUi();
		}
	
		[CompilerGenerated]
		private sealed class _StartSlideOut_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UiAnimationHide __4__this;
			private int _timing_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartSlideOut_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartSlideIn_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UiAnimationHide __4__this;
			private int _timing_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartSlideIn_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public AnimationUi ui;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _SlideOut_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_1
		{
			// Fields
			public RectTransform rectTransform;
			public __c__DisplayClass18_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass18_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_2
		{
			// Fields
			public Vector3 toPos;
			public __c__DisplayClass18_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass18_2();
	
			// Methods
			internal void _SlideOut_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public AnimationUi ui;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _SlideIn_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public RectTransform rectTransform;
			public __c__DisplayClass19_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass19_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_2
		{
			// Fields
			public Vector3 fromPos;
			public __c__DisplayClass19_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass19_2();
	
			// Methods
			internal void _SlideIn_b__0(float x);
		}
	
		// Constructors
		public UiAnimationHide();
	
		// Methods
		private void Start();
		public void OnUiHideButtonPressed();
		public void OnFinishUiHideButtonPressed();
		[IteratorStateMachine]
		private IEnumerator StartSlideOut();
		[IteratorStateMachine]
		private IEnumerator StartSlideIn();
		private void SlideOut(AnimationUi ui);
		private void SlideIn(AnimationUi ui);
		private Vector3 GetToPosition(AnimationUi ui, RectTransform rectTransform);
		public bool IsMove();
	}
}
