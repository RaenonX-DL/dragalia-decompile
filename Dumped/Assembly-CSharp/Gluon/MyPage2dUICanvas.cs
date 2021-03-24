/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPage2dUICanvas : AnimationUICanvas
	{
		// Fields
		public MyPageScene scene;
		public PageViewBase pageViewBase;
		public GameObject content;
		private List<int> characterIds;
		public static int pageIndex;
		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public List<KeyValuePair<int, GameObject>> pageValues;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _Start_b__1(GameObject page, int index);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__6_0;
			public static Func<bool> __9__6_2;
			public static Func<bool> __9__6_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__6_0();
			internal bool _Start_b__6_2();
			internal bool _Start_b__6_3();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPage2dUICanvas __4__this;
			private __c__DisplayClass6_0 __8__1;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPage2dUICanvas();
		static MyPage2dUICanvas();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void SetPage(GameObject page, int index);
		public void OnHide();
		public void OnFinishHide();
		private void SetMyPage2dCharacterClickAction(Action action);
		[CompilerGenerated]
		private void _OnHide_b__8_0();
	}
}
