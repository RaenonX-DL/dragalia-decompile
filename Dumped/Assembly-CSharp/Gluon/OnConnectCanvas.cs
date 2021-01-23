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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OnConnectCanvas : MonoBehaviour
	{
		// Fields
		public Camera nhaamCamera;
		public Camera dummyFlashCamera;
		public GameObject touchGuard;
		public CanvasGroup blackLayer;
		public RawImage rawImage;
		private float alpha;
		private bool showBlackLayer;
		private Tweener alphaTweener;
		private Tweener colorTweener;
		private int showCount;
		private bool _isPaymentMask;
		private FlashPlayer flashPlayer;
		private GameObject flashObject;
		private bool showNextFlashWithColor;
		private RenderTexture renderTexture;
		private static OnConnectCanvas _instance;
	
		// Properties
		public bool isPaymentMask { set; }
		public static OnConnectCanvas instance { get; }
		public static bool IsInstanceEmpty { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ShowCoroutine_b__25_0();
		}
	
		[CompilerGenerated]
		private sealed class _ShowCoroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OnConnectCanvas __4__this;
			public bool showBlackLayer;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowCoroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _HideCoroutine_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public OnConnectCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _HideCoroutine_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnComplete_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public OnConnectCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnComplete_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public OnConnectCanvas();
	
		// Methods
		private void Awake();
		public void ShowNextFlashInWhiteBg(bool withColor);
		public void Show(bool showBlackLayer = false);
		[IteratorStateMachine]
		public IEnumerator ShowCoroutine(bool showBlackLayer = false);
		public void Hide(float delay = 0.3f);
		public void HideForce();
		public bool IsShowing();
		[IteratorStateMachine]
		private IEnumerator HideCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnComplete(float delay);
		public bool IsOnConnect();
		[CompilerGenerated]
		private void _ShowCoroutine_b__25_1();
		[CompilerGenerated]
		private void _HideCoroutine_b__29_0(float value);
		[CompilerGenerated]
		private void _HideCoroutine_b__29_1();
		[CompilerGenerated]
		private void _HideCoroutine_b__29_2();
		[CompilerGenerated]
		private void _HideCoroutine_b__29_3(float value);
		[CompilerGenerated]
		private void _HideCoroutine_b__29_4();
	}
}
