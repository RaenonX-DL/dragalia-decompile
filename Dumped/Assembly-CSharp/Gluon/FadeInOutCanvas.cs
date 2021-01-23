/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FadeInOutCanvas : SingletonInBaseMonoBehaviour<Gluon.FadeInOutCanvas>
	{
		// Fields
		public Image image;
		[HideInInspector]
		public UnityEvent onFadeInCompleteEvent;
		[HideInInspector]
		public UnityEvent onFadeOutCompleteEvent;
		public const float fadeInDelay = 0f;
		public const float fadeInDuration = 0.5f;
		public const float fadeOutDelay = 0.1f;
		public const float fadeOutDuration = 0.5f;
		public const float slideDuration = 0.6f;
		public const float loadingFadeAlpha = 0.8f;
		private bool isOnFadeIn;
		private bool isOnFadeOut;
		private bool isWhite;
		private RenderTexture renderTexture;
		private NowLoadingCanvas nowLoadingCanvas;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public PostEffect postEffect;
			public FadeInOutCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _LoadingFadeOutCoroutine_b__0(float value);
			internal void _LoadingFadeOutCoroutine_b__1(float value);
			internal void _LoadingFadeOutCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _LoadingFadeOutCoroutine_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FadeInOutCanvas __4__this;
			public float delay;
			public bool slideHeader;
			public bool slideFooter;
			private __c__DisplayClass16_0 __8__1;
			public Camera targetCamera;
			public float duration;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadingFadeOutCoroutine_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PostEffect postEffect;
			public FadeInOutCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _LoadingFadeInCoroutine_b__0(float value);
			internal void _LoadingFadeInCoroutine_b__1();
			internal void _LoadingFadeInCoroutine_b__2(float value);
			internal void _LoadingFadeInCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_1
		{
			// Fields
			public AnimationUICanvas animationUICanvas;
	
			// Constructors
			public __c__DisplayClass21_1();
	
			// Methods
			internal bool _LoadingFadeInCoroutine_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _LoadingFadeInCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FadeInOutCanvas __4__this;
			public float delay;
			public bool slideHeader;
			public bool slideFooter;
			private __c__DisplayClass21_0 __8__1;
			public Camera targetCamera;
			public float duration;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadingFadeInCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FadeInOutCanvas();
	
		// Methods
		private void Start();
		public UnityEvent StartLoadingFadeOut(bool slideHeader = true, bool slideFooter = true, Camera targetCamera = null);
		[IteratorStateMachine]
		private IEnumerator LoadingFadeOutCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Camera targetCamera);
		public UnityEvent StartFadeOut(float duration = 0.5f, bool isWhite = false);
		private void OnFadeOutUpdate(float value);
		private void OnFadeOutComplete();
		public UnityEvent StartLoadingFadeIn(bool slideHeader = true, bool slideFooter = true, Camera targetCamera = null);
		[IteratorStateMachine]
		private IEnumerator LoadingFadeInCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Camera targetCamera);
		public UnityEvent StartFadeIn(float duration = 0.5f, bool isWhite = false, float delay = 0f);
		private void OnFadeInUpdate(float value);
		private void OnFadeInComplete();
		public bool IsOnFade();
		public bool IsFadeOut();
		public bool IsFadeIn();
		public void SetImageEnabled(bool enabled);
		[CompilerGenerated]
		private void _StartFadeOut_b__17_0(float value);
		[CompilerGenerated]
		private void _StartFadeOut_b__17_1();
		[CompilerGenerated]
		private void _StartFadeIn_b__22_0(float value);
		[CompilerGenerated]
		private void _StartFadeIn_b__22_1();
	}
}
