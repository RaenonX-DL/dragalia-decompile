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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleMenuCanvas : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public RectTransform frame;
		public CanvasGroup canvasGroup;
		public CanvasGroup bgCanvasGroup;
		public Canvas canvas;
		public GameObject listButton;
		public GameObject growthButton;
		public GameObject awakeningButton;
		public RectTransform maskTransform;
		public float enterAnimationDuration;
		public Ease enterAnimationEase;
		public float exitAnimationDuration;
		public Ease exitAnimationEase;
		public Action growthButtonPressAction;
		public Action awakeningButtonPressAction;
		public GrowthManaCircleModel manaCircle2DModel;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleMenuCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__17(int __1__state);
	
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
			public GrowthManaCircleMenuCanvas __4__this;
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0(float value);
			internal void _StartEnterAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public GrowthManaCircleMenuCanvas __4__this;
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _StartExitAnimation_b__0(float value);
			internal void _StartExitAnimation_b__1();
		}
	
		// Constructors
		public GrowthManaCircleMenuCanvas();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void StartEnterAnimation(Action onCompleted = null);
		private void StartExitAnimation(Action onCompleted = null);
		private void OnDestroy();
		public void OnCloseAreaPressed();
		public void OnListButtonPressed();
		public void OnGrowthButtonPressed();
		public void OnAwakeningButtonPressed();
		[CompilerGenerated]
		private void _Start_b__17_0();
		[CompilerGenerated]
		private void _OnCloseAreaPressed_b__21_0();
		[CompilerGenerated]
		private void _OnListButtonPressed_b__22_0();
	}
}
