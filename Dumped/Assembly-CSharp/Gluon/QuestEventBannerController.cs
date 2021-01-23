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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventBannerController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public RectTransform pagerCenter;
		public GameObject bannerRoot;
		public UnityEngine.UI.Text titleText;
		public CircleOutline outline;
		private List<QuestEventSubBanner> banners;
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
		private readonly Color normalTextColor;
		private readonly Color normalOutlineColor;
		private readonly Color eventTextColor;
		private readonly Color eventOutlineColor;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public QuestEventBannerController __4__this;
			public List<EventDataElement> bannerData;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _InitCoroutine_b__1(UnityEngine.Object obj);
			internal bool _InitCoroutine_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<EventDataElement> __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _InitCoroutine_b__21_0(EventDataElement a, EventDataElement b);
		}
	
		[CompilerGenerated]
		private sealed class _InitCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEventBannerController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AddBannerCoroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEventBannerController __4__this;
			public EventDataElement element;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AddBannerCoroutine_d__25(int __1__state);
	
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
			public int i;
			public QuestEventBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal bool _SetBannerEnableCoroutine_b__2();
			internal bool _SetBannerEnableCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _SetBannerEnableCoroutine_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEventBannerController __4__this;
			private __c__DisplayClass28_0 __8__1;
			public bool enabled;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetBannerEnableCoroutine_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public QuestEventBannerController __4__this;
			public int pagerNum;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _CreatePagers_b__0(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public RectTransform rectT;
			public Vector2 origPos;
			public QuestEventBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _ShowNextStatusObject_b__0(float value);
			internal void _ShowNextStatusObject_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public RectTransform rectT;
			public Vector2 origPos;
			public QuestEventBannerController __4__this;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _ShowPrevStatusObject_b__0(float value);
			internal void _ShowPrevStatusObject_b__1();
		}
	
		// Constructors
		public QuestEventBannerController();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator InitCoroutine();
		public void Reload();
		private void Update();
		private void AddBanner(EventDataElement element);
		[IteratorStateMachine]
		private IEnumerator AddBannerCoroutine(EventDataElement element);
		public void CloneBanner(QuestEventSubBanner srcBanner);
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
		public void SetTitleText(string str);
		public void SetTextColor();
		public void SetAllPageOff();
		private void SetPageOn(int index);
		private void AddBanner(QuestEventSubBanner banner);
		public bool IsExist();
		[CompilerGenerated]
		private bool _AddBannerCoroutine_b__25_0();
		[CompilerGenerated]
		private bool _SetBannerEnableCoroutine_b__28_0();
		[CompilerGenerated]
		private bool _SetBannerEnableCoroutine_b__28_1();
	}
}
