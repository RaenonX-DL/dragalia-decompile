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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PopupBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEvent closeButtonPressed;
		[SerializeField]
		public UnityEvent beforeCloseAnimation;
		[SerializeField]
		protected PointerEventHandler backKeyEventHandler;
		protected UnityEvent overrideBackKeyEvent;
		protected bool showStartAnimation;
		protected bool isWaitingCloseAnimation;
		[CompilerGenerated]
		private Canvas _popupCanvas_k__BackingField;
		public AnimationType animationType;
		public int animationFrame;
		private const int slowAnimationFrame = 6;
		private const int fastAnimationFrame = 5;
		private Vector2 oldMaskSizeForFloating;
		public static int popupCount;
	
		// Properties
		public Canvas popupCanvas { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum AnimationType
		{
			None = -1,
			Normal = 0,
			Floating = 1
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStartAnimation_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PopupBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStartAnimation_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public UnityEvent onCompleted;
			public PopupCanvas popupCanvasComponent;
			public TweenCallback completeCallback;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _StartShowAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public RectTransform rectTransform;
			public Vector3 originalPosition;
			public CanvasGroup canvasGroup;
			public RectMask2D rectMask;
			public __c__DisplayClass22_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _StartShowAnimation_b__1(float value);
			internal void _StartShowAnimation_b__2(float value);
			internal void _StartShowAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public UnityEvent onCompleted;
			public PopupCanvas popupCanvasComponent;
			public PopupBase __4__this;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StartCloseAnimationCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public RectTransform rectTransform;
			public Vector3 originalPosition;
			public CanvasGroup canvasGroup;
			public __c__DisplayClass24_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal void _StartCloseAnimationCoroutine_b__0(float value);
			internal void _StartCloseAnimationCoroutine_b__1(float value);
			internal void _StartCloseAnimationCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _StartCloseAnimationCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnityEvent onCompleted;
			public PopupBase __4__this;
			private __c__DisplayClass24_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartCloseAnimationCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PopupBase();
		static PopupBase();
	
		// Methods
		public static T Create<T>(string path, Transform parentTransform = null, bool useAssetLoader = true, bool asErrorPopup = false)
			where T : PopupBase;
		public static bool isPopupCreate();
		protected virtual void Start();
		[IteratorStateMachine]
		private IEnumerator WaitForStartAnimation();
		public void SetOverrideBackKeyEvent(UnityEvent backKeyEvent);
		public virtual void StartShowAnimation(UnityEvent onCompleted = null);
		public virtual void StartCloseAnimation(UnityEvent onCompleted = null);
		[IteratorStateMachine]
		protected virtual IEnumerator StartCloseAnimationCoroutine(UnityEvent onCompleted = null);
		public bool IsWaitingCloseAnimation();
		public void Close();
		protected virtual void OnDestroy();
		public void CloseWithAnimation();
		public void Show(bool withAnimation);
		public void Hide(bool withAnimation);
		[CompilerGenerated]
		private void _Hide_b__30_0();
	}
}
