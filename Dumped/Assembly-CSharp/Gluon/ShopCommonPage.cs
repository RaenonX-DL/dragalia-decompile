/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonPage : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public PageViewBase pageView;
		public GameObject pageViewNode;
		public CanvasGroup pageViewCanvasGroup;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text holdingGoldText;
		public UnityEngine.UI.Text holdingManaText;
		public UnityEngine.UI.Text holdingMoonText;
		[Header]
		[SerializeField]
		public RectTransform maskMovingPart;
		public GameObject topHidePart;
		public CanvasGroup bgCanvasGroup;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text characterNameText;
		[SerializeField]
		private UnityEngine.UI.Text talkText;
		[SerializeField]
		public ShopTradeCharaTalkSelector charaTalkSelector;
		[SerializeField]
		private GameObject balloon;
		[SerializeField]
		private OutGameBgChara bgChara;
		[SerializeField]
		private KeepStableToTransform keepStable;
		[Header]
		[SerializeField]
		public UIAnimationPublisher topToPageWithMaskPublisher;
		public UIAnimationPublisher pageToUpwardWithMaskPublisher;
		public UIAnimationPublisher enterTopPublisher;
		public UIAnimationPublisher maskTopPartPublisher;
		public UIAnimationPublisher maskBottomPartPublisher;
		public UIAnimationPublisher topCharaInnerMovePublisher;
		public UIAnimationPublisher hideTopCharaPublisher;
		private const float maskMovingY = 1024f;
		public static string charaVoiceGroupName;
		private Coroutine talkCoroutine;
		private bool isBalloonOn;
		private const float autoMoveTime = 8f;
		private float moveTimer;
		private bool autoMove;
		private GameObject preLoadedPage;
		private bool initTalkDone;
	
		// Nested types
		public class TalkTypeInfo
		{
			// Fields
			public ShopTradeModel.PanelType panelType;
			public int tabIndex;
			public bool hasSummon;
			public bool isCharaTouched;
	
			// Constructors
			public TalkTypeInfo();
			public TalkTypeInfo(ShopTradeModel.PanelType panelType, int tabIndex = -1, bool hasSummon = false, bool isCharaTouched = false);
		}
	
		public enum TopPartPattern
		{
			None = 0,
			TopPage = 1,
			Masked = 2,
			OutOfScreen = 3
		}
	
		[CompilerGenerated]
		private struct _Start_d__35 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ShopCommonPage __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public List<ShopTopBannerModel.BannerData> finalList;
			public ShopTradeModel.PanelType nextPanel;
			public ShopCommonPage __4__this;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _GenerateTopBanners_b__0(GameObject go, int index);
			internal void _GenerateTopBanners_b__1(int index);
		}
	
		[CompilerGenerated]
		private struct _GenerateTopBanners_d__38 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ShopTradeModel.PanelType nextPanel;
			public ShopCommonPage __4__this;
			public ShopTradeModel.PanelType curPanel;
			private __c__DisplayClass38_0 __8__1;
			private bool _withFadeAnimation_5__2;
			private TweenExtensions.TweenAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _StartTalkCoroutine_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float preWaitTime;
			public ShopCommonPage __4__this;
			public TalkTypeInfo info;
			public bool soundOnly;
			public float postWaitTime;
			private OutGameTopCharaTalkSelector.TalkData _talkData_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartTalkCoroutine_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public ShopCommonPage __4__this;
			public OutGameTopCharaTalkSelector.TalkData talkData;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _StartBalloonAnimation_b__0();
		}
	
		// Constructors
		public ShopCommonPage();
		static ShopCommonPage();
	
		// Methods
		public static ShopCommonPage Create(Transform parent, ShopTradeScene scene);
		private void Awake();
		private async void Start();
		public void SetTopHidePartVisibility(bool v);
		private void HideBGCharaAndShowPage();
		private async void GenerateTopBanners(ShopTradeModel.PanelType curPanel, ShopTradeModel.PanelType nextPanel);
		private void Update();
		public void RaiseTalk(TopPartPattern nextPattern, TopPartPattern currentPattern, TalkTypeInfo info);
		private void ShowBalloon(OutGameTopCharaTalkSelector.TalkData talkData);
		private void HideBalloon();
		[IteratorStateMachine]
		private IEnumerator StartTalkCoroutine(TalkTypeInfo info, float preWaitTime, float postWaitTime, bool soundOnly);
		private void PlayTalk(OutGameTopCharaTalkSelector.TalkData talkData);
		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false);
		public void OnCharaPressed();
		public void OnStonePurchaseButtonPressed();
		private void RefreshHoldings();
		public override void RefreshCurrentPage();
		private TopPartPattern GetTopPartPattern(ShopTradeModel.PanelType panelType);
		private void FadeBG(bool isFadeIn, float durationInFrame = 6f);
		public void StartExitAnimation();
		private void SwitchTopBanner(ShopTradeModel.PanelType currentPanel, ShopTradeModel.PanelType nextPanel);
		public void OnSwitchPanel(ShopTradeModel.PanelType currentPanel, ShopTradeModel.PanelType nextPanel, bool allowFromNone = false);
		[CompilerGenerated]
		private bool _Start_b__35_0();
		[CompilerGenerated]
		private bool _Start_b__35_1();
		[CompilerGenerated]
		private void _HideBGCharaAndShowPage_b__37_0();
		[CompilerGenerated]
		private void _OnSwitchPanel_b__54_3();
		[CompilerGenerated]
		private void _OnSwitchPanel_b__54_0();
		[CompilerGenerated]
		private void _OnSwitchPanel_b__54_1();
		[CompilerGenerated]
		private void _OnSwitchPanel_b__54_2();
		[CompilerGenerated]
		private void _OnSwitchPanel_b__54_4();
	}
}
