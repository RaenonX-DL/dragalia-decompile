/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HeaderMessageBase<T> : MonoBehaviour
		where T : MessageDataBase
	{
		// Fields
		public UnityEngine.UI.Text title;
		public UnityEngine.UI.Text desc;
		public ThemeColorImageSwitcher imageSwitcher;
		public RectTransform rectTransform;
		public float initialY;
		public float middleY;
		public float lastY;
		public float initialFrame;
		public float waitFrame;
		public float lastFrame;
		protected static bool isShowing;
		protected Coroutine showNoticeCoroutine;
		protected Coroutine waitForOtherNoticeCoroutine;
		protected static List<T> messageDataList;
		public const int maxMessage = 5;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForOtherNotice_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HeaderMessageBase<T> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForOtherNotice_d__19(int __1__state);
	
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
			public HeaderMessageBase<T> __4__this;
			public float x;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal bool _AnimationLoop_b__0();
			internal void _AnimationLoop_b__1(float y);
			internal void _AnimationLoop_b__2(float y);
			internal void _AnimationLoop_b__3(float y);
		}
	
		[CompilerGenerated]
		private sealed class _AnimationLoop_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HeaderMessageBase<T> __4__this;
			public float delay;
			private __c__DisplayClass21_0<T> __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AnimationLoop_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public HeaderMessageBase();
		static HeaderMessageBase();
	
		// Methods
		protected virtual void Awake();
		protected virtual void OnDestroy();
		public void ShowNotice();
		protected virtual bool isShowOtherNotice();
		[IteratorStateMachine]
		private IEnumerator WaitForOtherNotice();
		protected virtual bool IsWaitNeeded();
		[IteratorStateMachine]
		private IEnumerator AnimationLoop(float delay = 0f);
		protected virtual void UpdateMessageUI(T messageData);
		[CompilerGenerated]
		private bool _WaitForOtherNotice_b__19_0();
	}
}
