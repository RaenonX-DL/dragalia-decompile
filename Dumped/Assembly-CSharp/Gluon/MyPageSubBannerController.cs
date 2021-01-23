/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSubBannerController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public RectTransform pagerCenter;
		public GameObject bannerRoot;
		[HideInInspector]
		public MyPageScene scene;
		private MyPageSubBanner dummyBanner;
		private List<MyPageSubBanner> banners;
		private List<CommonPager> pagers;
		private GameObject bannerPrefab;
		private Vector2 beginDragPosition;
		private bool isDragging;
		private bool isAnimating;
		private int currentIndex;
		private int bannerCount;
		private float lastMoveTime;
		private const float moveInterval = 8f;
		private const float bannerWidth = 280f;
		private const float resolutionFixRate = 100f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public MyPageSubBannerController __4__this;
			public List<MyPageBannerElement> elementList;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal bool _InitCoroutine_b__0();
			internal void _InitCoroutine_b__2(UnityEngine.Object obj);
			internal bool _InitCoroutine_b__3();
			internal Color _InitCoroutine_b__4();
			internal void _InitCoroutine_b__5(Color color);
			internal void _InitCoroutine_b__6();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<MyPageBannerElement> __9__17_1;
			public static Comparison<MyPageBannerElement> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _InitCoroutine_b__17_1(MyPageBannerElement a, MyPageBannerElement b);
			internal int _GetSummonBannerElement_b__18_0(MyPageBannerElement a, MyPageBannerElement b);
		}
	
		[CompilerGenerated]
		private sealed class _InitCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSubBannerController __4__this;
			private __c__DisplayClass17_0 __8__1;
			private bool _isErrer_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CreateDummyBannerCoroutine_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSubBannerController __4__this;
			public MyPageBannerElement element;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateDummyBannerCoroutine_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AddBannerCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSubBannerController __4__this;
			public MyPageSubBanner.BannerInfo info;
			public MyPageBannerElement element;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AddBannerCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public int i;
			public MyPageSubBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal bool _SetBannerEnableCoroutine_b__2();
			internal bool _SetBannerEnableCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _SetBannerEnableCoroutine_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSubBannerController __4__this;
			private __c__DisplayClass27_0 __8__1;
			public bool enabled;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetBannerEnableCoroutine_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public MyPageSubBannerController __4__this;
			public int pagerNum;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _CreatePagers_b__0(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public RectTransform rectT;
			public Vector2 origPos;
			public MyPageSubBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _ShowNextStatusObject_b__0(float value);
			internal void _ShowNextStatusObject_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public RectTransform rectT;
			public Vector2 origPos;
			public MyPageSubBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _ShowPrevStatusObject_b__0(float value);
			internal void _ShowPrevStatusObject_b__1();
		}
	
		// Constructors
		public MyPageSubBannerController();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator InitCoroutine();
		private MyPageBannerElement GetSummonBannerElement();
		public void Reload();
		private void Update();
		private void CreateDummyBanner();
		[IteratorStateMachine]
		private IEnumerator CreateDummyBannerCoroutine(MyPageBannerElement element);
		private void AddBanner(MyPageBannerElement element);
		[IteratorStateMachine]
		private IEnumerator AddBannerCoroutine(MyPageSubBanner.BannerInfo info, MyPageBannerElement element);
		public void CloneBanner(MyPageSubBanner srcBanner);
		public void SetBannersEnable(bool enabled);
		[IteratorStateMachine]
		private IEnumerator SetBannerEnableCoroutine(bool enabled);
		private void CreatePagers(int pagerNum);
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		public void OnPressed();
		public void ShowNextStatusObject();
		public void ShowPrevStatusObject();
		public void SetAllPageOff();
		private void SetPageOn(int index);
		private void AddBanner(MyPageSubBanner banner);
		public bool IsExist();
		[CompilerGenerated]
		private void _CreateDummyBannerCoroutine_b__22_0(UnityEngine.Object obj);
		[CompilerGenerated]
		private bool _CreateDummyBannerCoroutine_b__22_1();
		[CompilerGenerated]
		private bool _SetBannerEnableCoroutine_b__27_0();
		[CompilerGenerated]
		private bool _SetBannerEnableCoroutine_b__27_1();
	}
}
