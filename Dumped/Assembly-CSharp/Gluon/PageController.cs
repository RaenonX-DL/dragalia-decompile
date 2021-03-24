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
	public class PageController : MonoBehaviour
	{
		// Fields
		private Dictionary<int, PageBase> pages;
		[CompilerGenerated]
		private PageBase _curPage_k__BackingField;
		private int _delayFrame;
	
		// Properties
		public PageBase curPage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int delayFrame { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public SceneBase parentScene;
			public PageController __4__this;
			public SceneNameDefine.PageName pageName;
			public bool delayEnterAnimation;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public PageBase lastPage;
			public Action<PageBase> onLoaded;
			public object data;
			public bool deactivateLastPage;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ChangePage_b__0(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public PageBase lastPage;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public PageBase thisPage;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public SceneBase parentScene;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _WaitForStartingEnterAnimation_b__0();
			internal void _WaitForStartingEnterAnimation_b__1();
			internal bool _WaitForStartingEnterAnimation_b__2();
			internal bool _WaitForStartingEnterAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStartingEnterAnimation_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PageBase lastPage;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public PageBase thisPage;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public SceneBase parentScene;
			public float delayTime;
			private __c__DisplayClass13_0 __8__1;
			public object data;
			public bool deactivateLastPage;
			public Action<PageBase> onLoaded;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStartingEnterAnimation_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PageController();
	
		// Methods
		private void OnDestroy();
		public bool IsLoaded(SceneNameDefine.PageName pageName);
		public void LoadPage(SceneNameDefine.PageName pageName, Transform parentTransform, Action<PageBase> onLoaded = null);
		public void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, SceneBase parentScene, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data = null, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		[IteratorStateMachine]
		private IEnumerator WaitForStartingEnterAnimation(float delayTime, AnimationUICanvas.AnimationPattern enterPattern, AnimationUICanvas.AnimationPattern exitPattern, PageBase lastPage, PageBase thisPage, SceneBase parentScene, Action<PageBase> onLoaded, object data, bool deactivateLastPage);
		public void RemoveCurPage(bool hasAnimation, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1);
		public PageBase GetPage(SceneNameDefine.PageName pageName);
		[CompilerGenerated]
		private void _RemoveCurPage_b__14_0();
	}
}
