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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PopupCanvas : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject blackLayer;
		[SerializeField]
		private GameObject touchGuard;
		[SerializeField]
		private GameObject frontTouchGuard;
		[SerializeField]
		private GameObject initialTouchGuard;
		private CanvasGroup canvasGroup;
		protected bool showStartAnimation;
		protected bool isIndependentTime;
		public bool showOnBaseCanvas;
		private bool _isWaitingAllPopupCanvasClosed;
		public bool _isErrorPopupCanvas;
		[HideInInspector]
		public bool doNotRegisterBackKey;
		private Canvas canvas;
		private static List<CanvasSortOrderInfo> showingCanvasList;
	
		// Properties
		public bool isWaitingAllPopupCanvasClosed { get; private set; }
		public bool isErrorPopupCanvas { get; set; }
	
		// Nested types
		private class CanvasSortOrderInfo
		{
			// Fields
			public int sortOrderIndex;
			public PopupCanvas canvas;
	
			// Constructors
			public CanvasSortOrderInfo();
		}
	
		[CompilerGenerated]
		private sealed class _WaitCloseAnimationAll_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnityEvent onCompleted;
			public PopupCanvas __4__this;
			private List<CanvasSortOrderInfo> __7__wrap1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitCloseAnimationAll_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PopupCanvas();
	
		// Methods
		protected virtual void Awake();
		protected virtual void ApplyAutoSortingOrder();
		protected virtual void Start();
		public static int GetCurrentPopupNum();
		private static int GetCurrentSortOrderMaxIndex();
		public static PopupCanvas Create(bool showBlackLayer = false, bool showOnBaseCanvas = false, bool showStartAnimation = true, bool isErrorPopupCanvas = false, bool isIndependentTime = false);
		public void ShowBlackLayer(bool isShown);
		public void ShowTouchGuard(bool isShown);
		public void ShowFrontTouchGuard(bool isShown);
		public void ShowInitialTouchGuard(bool isShown);
		public void SetBlackLayerAlpha(float alpha);
		public void StartShowAnimation();
		public void StartCloseAnimation();
		public void StartCloseAnimationAll(UnityEvent onCompleted = null);
		[IteratorStateMachine]
		private IEnumerator WaitCloseAnimationAll(UnityEvent onCompleted = null);
		protected virtual void OnDestroy();
		[CompilerGenerated]
		private void _Start_b__22_0(float value);
		[CompilerGenerated]
		private void _Start_b__22_1();
		[CompilerGenerated]
		private void _StartShowAnimation_b__31_0(float value);
		[CompilerGenerated]
		private void _StartShowAnimation_b__31_1();
		[CompilerGenerated]
		private void _StartCloseAnimation_b__32_0(float value);
	}
}
