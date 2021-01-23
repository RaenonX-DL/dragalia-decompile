/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageUICanvas : AnimationUICanvas
	{
		// Fields
		public CanvasGroup canvasGroup;
		public RawImage fadeoutImage;
		public MyPageScene scene;
		public Badge missionBadge;
		public Image pickupMissionBadge;
		public Badge shopBadge;
		public GameObject shopNewIcon;
		public Button infoButton;
		public Badge guildBadge;
		[SerializeField]
		private GameObject inviteBadge;
		public Button missionButton;
		public Button shopButton;
		public Button guildButton;
		public Button bannerButton;
		public Image bannerLockImage;
		public GameObject campaignButtonParent;
		public Button campaignButton;
		public Button uiHideButton;
		[SerializeField]
		public Button drillButton;
		public GameObject subBannerNode;
		public MyPageSubBannerController subBannerController;
		public GameObject startDash;
		public Image startDashTextImage;
		public UnityEngine.UI.Text startDashTimeText;
		public GameObject specialShopBalloon;
		public UnityEngine.UI.Text specialShopTimeText;
		public Image mainBannerImage;
		public UnityEngine.UI.Text mainBannerText;
		public bool isMainBannerEnabled;
		public Badge mainBannerBadge;
		public CanvasGroup mainBannerCanvasGroup;
		public bool isTutorialCheckComplete;
		private const int emptyEventId = 20101;
		private const int voidEventId = 30000;
		private int mainBannerEventId;
		private MainBannerType mainBannerType;
		[SerializeField]
		private GameObject guideTopObj;
		[SerializeField]
		private GameObject mainStoryGuideObj;
		[SerializeField]
		private GameObject missionGuideObj;
		[SerializeField]
		private Button guideToggleButton;
		[SerializeField]
		private Animator missionGuideAnimator;
		private const string missionGuideToggleKey = "MypPageMissionGuideToggleState";
		[SerializeField]
		private UnityEngine.UI.Text mainStoryGuideTitle;
		[SerializeField]
		private UnityEngine.UI.Text mainStoryGuideText;
		[SerializeField]
		private UnityEngine.UI.Text mainStoryMissionTopTitle;
		[SerializeField]
		private MypageMainStoryMissionCell mainStoryMissionTitleCell;
		[SerializeField]
		private MypageMainStoryMissionCell[] mainStoryMissionCells;
		[SerializeField]
		private GameObject mainStoryMissionUIObj;
		[SerializeField]
		private UnityEngine.UI.Text dailyMissionGuideText;
		private bool isEventBannerTransitionProcessing;
		[SerializeField]
		private GameObject hideFinishButton;
		[SerializeField]
		private UiAnimationHide uiAnimationHide;
		[SerializeField]
		private MyPageMissionDrillGuide missionDrillGuide;
		[SerializeField]
		private Transform missionGuidePositionAnchor;
	
		// Nested types
		private enum MainBannerType
		{
			QuestEvent = 1,
			QuestEventGroup = 2,
			Event = 3
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__56 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__56(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CheckSubBannerEnabled_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageUICanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckSubBannerEnabled_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public MyPageUICanvas __4__this;
			public Action<Material> onCompleted;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _SetMainBannerImage_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public MyPageBannerElement bannerData;
			public MyPageUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _SetMainBanner_b__2(Material mat);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<MyPageCenterBannerElement> __9__61_0;
			public static Comparison<MyPageBannerElement> __9__61_1;
			public static Comparison<MainStoryGuideElement> __9__84_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetMainBanner_b__61_0(MyPageCenterBannerElement a, MyPageCenterBannerElement b);
			internal int _SetMainBanner_b__61_1(MyPageBannerElement a, MyPageBannerElement b);
			internal int _UpdateMissionGuideText_b__84_0(MainStoryGuideElement a, MainStoryGuideElement b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public int questId;
			public MyPageUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _OnEventBannerButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public MyPageUICanvas __4__this;
			public CampaignListPopup popup;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _OnCampaignButtonPressed_b__0();
			internal void _OnCampaignButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialCheckCoroutine_d__81 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageUICanvas __4__this;
			public bool enable;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialCheckCoroutine_d__81(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0
		{
			// Fields
			public MissionGuidePopup popup;
	
			// Constructors
			public __c__DisplayClass88_0();
	
			// Methods
			internal void _OnMissionGuideButtonPressed_b__0();
		}
	
		// Constructors
		public MyPageUICanvas();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		[IteratorStateMachine]
		private IEnumerator CheckSubBannerEnabled();
		private void SetMainBannerText(EventDataElement eventData);
		private void SetMainBannerImage(int bannerImageId, string bannerImageName, Action<Material> onCompleted = null);
		private bool GetEventDataWithinPeriod(int eventDataId, out EventDataElement eventData);
		private void SetMainBanner();
		public void Reload();
		public void UpdateMissionBadgeMark();
		public void ShowStartDash();
		public void ShowShopBadge(bool visible);
		public static bool IsGuildBadgeVisible();
		public void ShowGuildBadge();
		public void OnQuestButtonPressed(bool state);
		public void OnEventButtonPressed(bool state);
		public void OnEventBannerButtonPressed(bool state);
		public void OnGuildButtonPressed();
		public void OnNoticeButtonPressed(bool state);
		public InformationPopup CreateInformationPopup(bool state);
		public void OnMissionButtonPressed(bool state);
		public void OnPvPButtonPressed();
		public void OnCampaignButtonPressed();
		public void OnShopButtonPressed();
		public void OnMainStoryMissionButtonPressed();
		public void SetSceneeAllButton(bool enable);
		private void SetEnableColorForBanner(bool enable);
		[IteratorStateMachine]
		private IEnumerator TutorialCheckCoroutine(bool enable);
		public void CheckShopNewBadge();
		private void UpdateTutorialGuide();
		private void UpdateMissionGuideText();
		private void UpdateMissionGuideToggle();
		private void SetMissionGuideToggle(bool isOpen, bool isSave = true);
		public void OnChangeMissionGuideToggle();
		public void OnMissionGuideButtonPressed();
		public void UpdateDrillMissionGuide();
		private void ShowSpecialShop();
		public void OnUiHideButtonPressed();
		public void OnMissionDrillButtonPressed();
		public void OnFinishUiHideButtonPressed();
		[CompilerGenerated]
		private bool _Start_b__56_0();
		[CompilerGenerated]
		private bool _CheckSubBannerEnabled_b__57_0();
		[CompilerGenerated]
		private void _SetMainBanner_b__61_3(Material mat2);
		[CompilerGenerated]
		private void _OnEventBannerButtonPressed_b__70_0();
		[CompilerGenerated]
		private void _OnEventBannerButtonPressed_b__70_1();
		[CompilerGenerated]
		private void _OnGuildButtonPressed_b__71_0();
		[CompilerGenerated]
		private void _CreateInformationPopup_b__73_0();
		[CompilerGenerated]
		private void _OnMissionButtonPressed_b__74_0(MissionSelectPopup popup);
		[CompilerGenerated]
		private void _OnMissionButtonPressed_b__74_1();
	}
}
