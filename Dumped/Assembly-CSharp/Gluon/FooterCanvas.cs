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
	public class FooterCanvas : MonoBehaviour
	{
		// Fields
		public Footer footer;
		public Canvas canvas;
		private bool isAnimating;
		[SerializeField]
		private float slideDistance;
		[CompilerGenerated]
		private bool _isSlideOut_k__BackingField;
		[CompilerGenerated]
		private int _defaultSortingOrder_k__BackingField;
		private RectTransform footerRectTrans;
		private float defaultYFooter;
		private static FooterCanvas _instance;
	
		// Properties
		public bool isSlideOut { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int defaultSortingOrder { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static FooterCanvas instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public FooterCanvas obj;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal bool _MoveMeToScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _MoveMeToScene_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FooterCanvas obj;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MoveMeToScene_d__19(int __1__state);
	
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
			public static Func<bool> __9__22_0;
			public static Func<bool> __9__22_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__22_0();
			internal bool _Start_b__22_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FooterCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ResetCameraCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FooterCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetCameraCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FooterCanvas();
		static FooterCanvas();
	
		// Methods
		public static bool IsInstanceEmpty();
		protected virtual void OnDestroy();
		[IteratorStateMachine]
		public static IEnumerator MoveMeToScene(FooterCanvas obj);
		public static bool DoMoveMeToScene(FooterCanvas obj);
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void ResetCamera();
		[IteratorStateMachine]
		private IEnumerator ResetCameraCoroutine();
		public void SlideIn(float duration = 0.3f);
		public void SlideOut(float duration = 0.3f);
		public void SlideInFade(float duration = 0.3f);
		public void SlideOutFade(float duration = 0.3f);
		private void MoveTo(RectTransform targetRectTransform, float startY, float endY, float duration);
		private void MoveWithScaleAndFade(Sequence mainSeq, RectTransform targetRectTransform, float startY, float endY, float duration, float endScale, float endFade);
		public void SetSortingOrder(int order);
		public void ResetSortingOrder();
		[CompilerGenerated]
		private void _SlideInFade_b__27_0();
		[CompilerGenerated]
		private void _SlideOutFade_b__28_0();
		[CompilerGenerated]
		private void _MoveTo_b__29_0();
	}
}
