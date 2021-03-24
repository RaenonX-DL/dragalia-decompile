/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestDetailHeader : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected Image descripImage;
		[SerializeField]
		private RectTransform maskRectTransform;
		private bool isShown;
		[SerializeField]
		public RawImage render3dImageBlack;
		[SerializeField]
		private Image outerFrame;
		private Vector2 descripImageDefaultPos;
		private Sequence animationSeq;
		[SerializeField]
		private RectTransform dummyRectEventQuestTop;
		[SerializeField]
		private RectTransform dummyRectEventQuestTopFrame;
		[SerializeField]
		private RectTransform dummyRectEventQuestMiddle;
		[SerializeField]
		private RectTransform dummyRectEventQuestMiddleFrame;
		[SerializeField]
		private ButtonWithSelectedImage howToButtonRight;
		[SerializeField]
		private ButtonWithSelectedImage howtoButtonLeft;
		private AnimationUIBase detailButtonAnimation;
		public bool isPrepare;
		private FlashPlayerManager fpMgr;
		private FlashPlayer questTransitionEffect;
		public float mapMove;
		public float mapMoveTime;
		public bool isMapAnim;
		public float fadeout;
		private bool isAnimating;
		private TouchGuardObject goQuestPrepareTouchGuard;
		private const float animationFrame = 0.26666668f;
		private const string howToPlayCheckedKeyTemplate = "{0}_Loc_{1}_HowToPlayChecked";
		private string howToPlayImageTemplate;
		private const int howToPlayImageCountDefault = 3;
		private const int howToPlayImageCountArena = 1;
		private int howToPlayImageCount;
		private const string commonTopBannerPathTemplate = "EventQuestMenuDetail{0:D2}";
		[SerializeField]
		private GameObject needItemInfoObject;
		[SerializeField]
		private UnityEngine.UI.Text needItemNum;
		[SerializeField]
		private Image needItemImage;
		[SerializeField]
		private GameObject payItemInfoObject;
		[SerializeField]
		private UnityEngine.UI.Text payItemNum;
		[SerializeField]
		private Image payItemImage;
	
		// Properties
		private ButtonWithSelectedImage detailButtonWithSelectedImage { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _SetContent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _SetContent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _SetContentCommon_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class _MapFadeOutAnimationCorutine_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestDetailHeader __4__this;
			public Action showQuestPrepare3dImage;
			private Canvas _detailCanvas_5__2;
			private int _oldSortingOrder_5__3;
			private int _i_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapFadeOutAnimationCorutine_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public int eventId;
			public CombatEventLocationElement location;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal bool _SetNeedItemInfo_b__0(QuestEventMenuElement x);
		}
	
		// Constructors
		public EventQuestDetailHeader();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetContent(int eventId, Clb01EventLocationElement location, Action onCompleted);
		public void SetContent(int eventId, CombatEventLocationElement location, Action onCompleted);
		public void SetContentCommon(int eventId, int topBannerImageId, Action onCompleted);
		protected void SetContentCommon(int eventId, string topBannerImagePath, Action onCompleted);
		public void StartEnterAnimation(float duration = 0.2f);
		public void OnQuestDetail();
		public void StartExitAnimation(float duration = 0.2f, bool inActiveOnComplete = false);
		public Tweener SetScreenTransVisible(bool visible, float time = 2f);
		public void MapFadeOutAnimation(Action showQuestPrepare3dImage);
		[IteratorStateMachine]
		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage);
		private void FrameDefault();
		public bool IsOnAnimation();
		private void SetNeedItemInfo(int eventId, CombatEventLocationElement location);
		[CompilerGenerated]
		private void _StartEnterAnimation_b__45_0();
		[CompilerGenerated]
		private void _OnQuestDetail_b__46_0();
		[CompilerGenerated]
		private void _StartExitAnimation_b__47_0();
		[CompilerGenerated]
		private void _StartExitAnimation_b__47_1();
		[CompilerGenerated]
		private void _StartExitAnimation_b__47_2();
		[CompilerGenerated]
		private bool _MapFadeOutAnimationCorutine_b__50_0();
	}
}
