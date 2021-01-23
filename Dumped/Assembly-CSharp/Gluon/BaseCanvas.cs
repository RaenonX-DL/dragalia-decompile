/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BaseCanvas : SingletonInBaseMonoBehaviour<Gluon.BaseCanvas>
	{
		// Fields
		public static bool skipCreateOnStart;
		public static bool showBlackCanvasOnStart;
		public BaseCanvasContents mainCanvas;
		public EventSystem eventSystem;
		public GameObject touchGuardCanvas;
		public GameObject blackCanvas;
		public List<float> touchGuardTimeList;
		[HideInInspector]
		public OutGameSettings outGameSettings;
		protected bool isPopupOpened;
		[SerializeField]
		private List<WeakReference> touchGuardObjectWrefList;
		private bool isAllLoadCompleted;
		private int popupCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _TouchGuardCoroutine_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float duration;
			public BaseCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TouchGuardCoroutine_d__26(int __1__state);
	
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
			public static Predicate<WeakReference> __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UpdateTouchGuardStatus_b__29_0(WeakReference wref);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public TouchGuardObject touchGuardObject;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal bool _RemoveTouchGuardObject_b__0(WeakReference wref);
		}
	
		[CompilerGenerated]
		private sealed class _TouchGuardObjectDelayRemove_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float duration;
			public BaseCanvas __4__this;
			public TouchGuardObject touchGuardObject;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TouchGuardObjectDelayRemove_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BaseCanvas();
	
		// Methods
		private void Start();
		private void SetDragThreshold();
		private void Update();
		public bool IsBlackCanvasActive();
		public void ShowBlackCanvas(bool show);
		public bool IsAllLoadCompleted();
		public void SetActiveBg(ThemeColor themeColor, bool isMyPage = false, bool doExitAnimation = true);
		public void SetCanvasEnable(bool enable);
		public void SetCanvasAlpha(float alpha);
		public void FadeOutCanvas(float duration = 1f, float startAlpha = 1f, float endAlpha = 0f);
		public void FadeInCanvas(float duration = 1f, float startAlpha = 0f, float endAlpha = 1f);
		public void SetTouchGuardEnable(bool enable);
		public bool IsTouchGurdEnable();
		public void CreateTouchGuard(float duration = -1f);
		[IteratorStateMachine]
		private IEnumerator TouchGuardCoroutine(float duration);
		public void RemoveAllTouchGuard();
		public void RemoveTouchGuard();
		private void UpdateTouchGuardStatus();
		public TouchGuardObject CreateTouchGuardObject(string label, float duration = -1f);
		public void RemoveTouchGuardObject(TouchGuardObject touchGuardObject);
		[IteratorStateMachine]
		private IEnumerator TouchGuardObjectDelayRemove(float duration, TouchGuardObject touchGuardObject);
		public void OnPopupOpened();
		public void OnPopupClosed();
		public bool IsPopupOpened();
	}
}
