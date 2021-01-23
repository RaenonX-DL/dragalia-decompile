/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonTopItemView : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public CanvasGroup commonSummonPageCanvasGroup;
		[Header]
		[SerializeField]
		public SummonButton dailyButton;
		public SummonButton singleButton;
		public SummonButton multiButton;
		public SummonButton storyButton;
		private List<SummonButton> buttons;
		[Header]
		[SerializeField]
		public GameObject dailySummonLine;
		public GameObject singleSummonLine;
		public GameObject multiSummonLine;
		public GameObject starLegendInfoLine;
		public GameObject ownedTicketLine;
		public GameObject ownedStoneLine;
		public GameObject owneddragonStoneLine;
		public GameObject singleUseTicketLine;
		public GameObject multiUseTicketLine;
		public GameObject singleUseStoneLine;
		public GameObject multiUseStoneLine;
		public Image whiteFade;
		public GameObject ownTicketBalloon;
		public GameObject oneFreeSummonBalloon;
		public GameObject[] tenSummonBalloon;
		[Header]
		[SerializeField]
		public SummonPageViewBase bannerPageView;
		[SerializeField]
		private GameObject bannerTouchGuard;
		[Header]
		[SerializeField]
		public GameObject movieFrameLine;
		public GameObject otherButtonsMovingTabLine;
		public GameObject ownedMovingTabLine;
		[Header]
		[SerializeField]
		public GameObject switchSummonButton;
		public UnityEngine.UI.Text switchSummonText;
		[Header]
		[SerializeField]
		public Transform singleStonePriceObject;
		public Transform multiStonePriceObject;
		[Header]
		[SerializeField]
		public GameObject dailyDrawnMask;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text ownedPaidStoneCount;
		public UnityEngine.UI.Text ownedFreeStoneCount;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text dailyPrice;
		public UnityEngine.UI.Text singlePrice;
		public UnityEngine.UI.Text multiPrice;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text ownedSingleTicketCount;
		public UnityEngine.UI.Text ownedMultiTicketCount;
		public UnityEngine.UI.Text starLegendPrice;
		public UnityEngine.UI.Text starLegendInfoText;
		[Header]
		[SerializeField]
		public GameObject exchangeSummonNode;
		[SerializeField]
		public UnityEngine.UI.Text exchangeSummonItemCount;
		[Header]
		[SerializeField]
		public PageViewBase pageView;
		public GridLayoutGroup pageViewGridLayout;
		public GameObject pageViewTouchGuard;
		[Header]
		[SerializeField]
		public GameObject pageViewFrameNode;
		public GameObject singleImageViewFrameNode;
		public GameObject startDashButtonAttachNode;
		public GameObject startDashCommentAttachNode;
		[Header]
		[SerializeField]
		public UIAnimationPublisher switchTabPublisher;
		public UIAnimationPublisher toStagePublisher;
		[Header]
		[SerializeField]
		private GameObject dragonSsrButtonsNode;
		[SerializeField]
		private float fadeTimeFactor;
		[HideInInspector]
		public SummonScene scene;
		private SummonTopData topData;
		private float autoRefreshTime;
		private const float movieRefreshTime = 8f;
		private const float topRefreshTime = 3f;
		private const float amuletRefreshTime = 6f;
		private Coroutine autoRefreshCoroutine;
		private float edgeToEdgeMovingHeightAlphaValue;
		private StartDashImageSetting startDashImageSetting;
		private StartDashImageSetting dragonSsrImageSetting;
		private PlatinumImageSetting platinumImageSetting;
		private Image specificDragonSsrTopBannerImage;
		private Image specificCharaSsrTopBannerImage;
		private Vector3 initialOthersButtonLinePos;
		private AnimationUITalkWindow specialSummonTalkWindow;
		private bool onChangingSummon;
		private const int csSummonId = 9999999;
		private SummonTopItemData _data;
		private List<SummonTopItemTabOrderData> bannerDataList;
		private int bannerTabIndex;
		private List<SummonTopItemData> SummonTopItemDataList;
		private SummonTopItemTabType currentTabType;
	
		// Properties
		public SummonTopItemData data { get; }
	
		// Nested types
		public enum SummonTopItemTabType
		{
			None = -1,
			Normal = 0,
			StarLegend = 2,
			Platinum = 3,
			CharaSsr = 4,
			DragonSsr = 5
		}
	
		public enum TenTicketBallonType
		{
			defaultBalloon = 0,
			tenTicketBallon = 1,
			tenFreeBalloon = 2,
			tenFreeBeginnerBallon = 3
		}
	
		public struct SummonTopItemTabOrderData
		{
			// Fields
			public int summonId;
			public SummonTopItemTabType summonType;
	
			// Constructors
			public SummonTopItemTabOrderData(int id, SummonTopItemTabType type);
		}
	
		[CompilerGenerated]
		private sealed class _RefreshByData_d__90 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
			public bool includeBanner;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RefreshByData_d__90(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public SummonTopItemView __4__this;
			public bool exchangePopWait;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _SummonPointCheck_b__0();
			internal bool _SummonPointCheck_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SummonPointCheck_d__92 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonPointCheck_d__92(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public int index;
			public SummonTopItemView __4__this;
	
			// Constructors
			public __c__DisplayClass96_0();
	
			// Methods
			internal void _SetupTabPageView_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<GameObject, int> __9__96_0;
			public static Func<SummonTopItemData, bool> __9__103_0;
			public static Func<SummonTopItemData, bool> __9__103_1;
			public static Func<SummonTopItemData, bool> __9__103_3;
			public static Func<SummonTopItemData, bool> __9__103_4;
			public static Func<SummonTopItemData, bool> __9__103_6;
			public static Func<SummonTopItemData, bool> __9__103_7;
			public static Func<SummonTopItemData, bool> __9__103_9;
			public static Func<SummonTopItemData, bool> __9__103_11;
			public static Action __9__120_0;
			public static Func<SummonTopItemTabOrderData, int> __9__122_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetupTabPageView_b__96_0(GameObject page, int index);
			internal bool _OnSwitchTab_b__103_0(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_1(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_3(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_4(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_6(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_7(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_9(SummonTopItemData x);
			internal bool _OnSwitchTab_b__103_11(SummonTopItemData x);
			internal void _StartToStageAnimation_b__120_0();
			internal int _SortSummonTopItemTabOrderData_b__122_0(SummonTopItemTabOrderData x);
		}
	
		[CompilerGenerated]
		private sealed class _SetupTabPageView_d__96 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
			private int _tabIndex_5__2;
			private List<SummonTopItemTabOrderData> _orderedTabList_5__3;
			private GameObject _bannerPagePrefab_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupTabPageView_d__96(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0
		{
			// Fields
			public GameObject prefab;
			public bool isPrefabLoaded;
			public List<KeyValuePair<int, GameObject>> pageValues;
	
			// Constructors
			public __c__DisplayClass97_0();
	
			// Methods
			internal void _SetupPageView_b__0(GameObject obj);
			internal bool _SetupPageView_b__1();
			internal void _SetupPageView_b__2(GameObject page, int index);
		}
	
		[CompilerGenerated]
		private sealed class _SetupPageView_d__97 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
			private __c__DisplayClass97_0 __8__1;
			private int _pageCount_5__2;
			private PageScrollViewRect _scrollRect_5__3;
			private int _i_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupPageView_d__97(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__99 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
			private int _index_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__99(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public SummonTopItemTabOrderData orderData;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal bool _OnSwitchTab_b__2(SummonTopItemData x);
			internal bool _OnSwitchTab_b__5(SummonTopItemData x);
			internal bool _OnSwitchTab_b__8(SummonTopItemData x);
			internal bool _OnSwitchTab_b__10(SummonTopItemData x);
			internal bool _OnSwitchTab_b__12(SummonTopItemData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_0
		{
			// Fields
			public SummonTopItemTabOrderData data;
	
			// Constructors
			public __c__DisplayClass108_0();
	
			// Methods
			internal bool _OnSwitchSummonPressed_b__0(SummonTopItemData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_0
		{
			// Fields
			public SummonTopItemView __4__this;
			public int summonId;
			public AnimationUICanvas animationCanvas;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass109_0();
	
			// Methods
			internal void _SwitchToSummonWithAnimation_b__0();
			internal void _SwitchToSummonWithAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _AutoRefreshCoroutine_d__115 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonTopItemView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AutoRefreshCoroutine_d__115(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass124_0
		{
			// Fields
			public SummonTopItemView __4__this;
			public int summonId;
			public Action onClose;
			public CommonIconPopup popup;
	
			// Constructors
			public __c__DisplayClass124_0();
	
			// Methods
			internal void _ExchangePopup_b__0();
			internal void _ExchangePopup_b__1();
		}
	
		// Constructors
		public SummonTopItemView();
	
		// Methods
		private void SwitchToSummonTopItemData(SummonTopItemData itemData, bool includeBanner = false);
		private void Awake();
		private string GetTitleImagePath(int index);
		public void DisableButtonsForTutorial(bool enableMultiButton);
		private GameObject CopyNodeFromNodeAndAddToTransform(GameObject from, Transform to);
		private GameObject MoveNode(GameObject from, Transform to);
		public void RefreshPriceAndButton();
		public void SetSummonExchangeUI();
		private void SummonDataUpdate();
		private void SetTenBallon(TenTicketBallonType ballonType);
		[IteratorStateMachine]
		private IEnumerator RefreshByData(bool includeBanner = false);
		private void ShowBannerInCurrentPage();
		[IteratorStateMachine]
		private IEnumerator SummonPointCheck();
		private void LoadSpecialSummonResources();
		private void LoadSpecialDragonSummonResources();
		private void LoadPlatinumResource();
		[IteratorStateMachine]
		private IEnumerator SetupTabPageView();
		[IteratorStateMachine]
		private IEnumerator SetupPageView();
		private List<SummonTopItemTabOrderData> GetListOfShowingTopTabOrderData();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void OnBeforeStartExitAnimation();
		private SummonTopItemTabOrderData ChooseValidOrDefaultTab(SummonTopItemTabOrderData tabData);
		public void SetPlayVoiceState(bool value);
		public void OnSwitchTab(int tabIndex, bool calledFromUI);
		public void SetTopData(SummonTopData topData);
		public void OnButtonPressed(SummonTopItemData.ButtonType buttonType, int summonId);
		public void OnOddsButtonPressed();
		public void OnSummonDetailButtonPressed();
		public void OnSwitchSummonPressed();
		public void SwitchToSummonWithAnimation(int summonId);
		private void LateUpdate();
		public void OnUnitStoryPressed();
		private void SetPageContent(GameObject page, int index);
		private void StartStabilizationAnimation(int index);
		private void StartAutoRefreshCoroutine();
		[IteratorStateMachine]
		private IEnumerator AutoRefreshCoroutine();
		private void TerminateAutoRefreshCoroutine();
		public void OnBeforeSceneLeaving();
		private void OnDestroy();
		private void OnApplicationPause(bool pause);
		public void StartToStageAnimation(Action onDone);
		public void FadeOut();
		private List<SummonTopItemTabOrderData> SortSummonTopItemTabOrderData(List<SummonTopItemTabOrderData> orderedList);
		public void OnCelingSummon();
		public void ExchangePopup(Action onClose);
		[CompilerGenerated]
		private void _SetupTabPageView_b__96_1(int index);
		[CompilerGenerated]
		private void _SetupTabPageView_b__96_3();
		[CompilerGenerated]
		private void _SetupPageView_b__97_3(bool value);
		[CompilerGenerated]
		private void _SetupPageView_b__97_4();
		[CompilerGenerated]
		private void _SetupPageView_b__97_5();
		[CompilerGenerated]
		private void _SetupPageView_b__97_6();
		[CompilerGenerated]
		private void _SetupPageView_b__97_7();
		[CompilerGenerated]
		private void _OnOddsButtonPressed_b__106_0(SummonGetOddsDataResponse res);
		[CompilerGenerated]
		private void _SetPageContent_b__112_0();
		[CompilerGenerated]
		private void _SetPageContent_b__112_1();
		[CompilerGenerated]
		private void _OnCelingSummon_b__123_0();
	}
}
