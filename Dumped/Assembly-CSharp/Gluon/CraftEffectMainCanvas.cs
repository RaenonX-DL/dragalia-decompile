/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftEffectMainCanvas : MonoBehaviour
	{
		// Fields
		public GameObject craftEffectBaseObject;
		public RectTransform craftEffectResultButtonsRect;
		public Button toPowerUpButtonForCraftResult;
		public UnityEngine.UI.Text toPowerTextForCraftResult;
		public Button closeButtonForCraftResult;
		public UnityEngine.UI.Text closeTextForCraftResult;
		protected Vector2 craftResultEnhanceButtonTargetPos;
		protected Vector2 craftResultCloseButtonTargetPos;
		protected Tweener craftResultEnhanceButtonTween;
		protected Tweener craftResultCloseButtonTween;
		protected RectTransform craftEffectResultEnhanceButtonRect;
		protected RectTransform craftEffectResultCloseButtonRect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CraftEffectMainCanvas __4__this;
			public CanvasGroup group;
			public Vector2 closeButtonStartPos;
			public Vector2 enhanceButtonStartPos;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ShowCraftResultButtons_b__0(float value);
			internal void _ShowCraftResultButtons_b__1(float value);
			internal void _ShowCraftResultButtons_b__2();
		}
	
		[CompilerGenerated]
		private struct _ShowCraftResultButtons_d__14 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public CraftEffectMainCanvas __4__this;
			public Action onComplete;
			private __c__DisplayClass14_0 __8__1;
			private TweenExtensions.TweenAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CraftEffectMainCanvas __4__this;
			public Vector2 enhanceButtonEndPos;
			public CanvasGroup group;
			public Vector2 closeButtonEndPos;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _HideCraftResultButtons_b__0(float value);
			internal void _HideCraftResultButtons_b__1(float value);
			internal void _HideCraftResultButtons_b__2();
		}
	
		[CompilerGenerated]
		private struct _HideCraftResultButtons_d__15 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public CraftEffectMainCanvas __4__this;
			private __c__DisplayClass15_0 __8__1;
			private TweenExtensions.TweenAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public CraftEffectMainCanvas();
	
		// Methods
		protected virtual void Start();
		private void OnDestroy();
		public async void ShowCraftResultButtons(Action onComplete = null);
		public async void HideCraftResultButtons();
		private void DestoryButtonTween();
	}
}
