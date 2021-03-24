/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Cri;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestScene : SceneBase, ICustomMessage
	{
		// Fields
		private static bool isShowEventInfo;
		private static bool isGoingEventQuestScene;
		[CompilerGenerated]
		private static EventQuestScene _instance_k__BackingField;
		private EventStatusInfoCtrl _statusInfo;
		[SerializeField]
		private Camera _uiCamera;
		[SerializeField]
		private Camera _flashCamera;
		private readonly int WaitPrevSceneExitFrameNum;
		[CompilerGenerated]
		private EventQuestModel _eventQuestModel_k__BackingField;
		private EffectObject treasureTimeEffect;
		[SerializeField]
		private Canvas commonUICanvas;
		[CompilerGenerated]
		private Button _backButton_k__BackingField;
		[CompilerGenerated]
		private EventQuestCharacterShaderSettings _charaShaderSettings_k__BackingField;
		private UnityAction backButtonSoundAction;
		public EventQuestDetailCanvas questDetailCanvas;
		private SceneNameDefine.PageName firstPageName;
		private bool isAutoGoingEventQuestListPage;
		private bool isCheckStoryReward;
		private int lastQuestStoryIdOnAwake;
		private int lastEventLocationIdOnAwake;
		private const string charaFormalJoined = "playerPref_CharaFormalJoined";
		private const string charaQuit = "playerPref_CharaQuit";
		private const string eventQuestDetailCanvasPath = "Prefabs/OutGame/EventQuest/EventQuestDetailCanvas";
		private bool isFirstStoryRead;
		private StateType state;
	
		// Properties
		public static EventQuestScene instance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public EventStatusInfoCtrl statusInfo { get; }
		public Camera flashCamera { get; }
		public Camera uiCamera { get; }
		public EventQuestModel eventQuestModel { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Button backButton { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EventQuestCharacterShaderSettings charaShaderSettings { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isEventEnable { get; }
	
		// Nested types
		private enum StateType
		{
			Initialized = 0,
			CreatingRoom = 1,
			Matching = 2
		}
	
		[CompilerGenerated]
		private sealed class _StartExitAnimationCoroutine_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartExitAnimationCoroutine_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__50_0;
			public static Func<bool> __9__50_1;
			public static Action __9__50_2;
			public static Action __9__50_5;
			public static Action __9__52_0;
			public static Action<RaidEventEntryResponse> __9__67_0;
			public static Action<MazeEventEntryResponse> __9__68_0;
			public static Action<BuildEventEntryResponse> __9__69_0;
			public static Action<Clb01EventEntryResponse> __9__70_0;
			public static Action<ExRushEventEntryResponse> __9__71_0;
			public static Action<ExHunterEventEntryResponse> __9__72_0;
			public static Action<CollectEventEntryResponse> __9__73_0;
			public static Action<CombatEventEntryResponse> __9__74_0;
			public static Action<BattleRoyalEventEntryResponse> __9__75_0;
			public static Action __9__76_0;
			public static Func<bool> __9__89_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExitAndInit_b__50_0();
			internal bool _WaitPrevSceneExitAndInit_b__50_1();
			internal void _WaitPrevSceneExitAndInit_b__50_2();
			internal void _WaitPrevSceneExitAndInit_b__50_5();
			internal void _UpdateExchangeInformation_b__52_0();
			internal void _RequestRaidEventEntry_b__67_0(RaidEventEntryResponse response);
			internal void _RequestRandomEventEntry_b__68_0(MazeEventEntryResponse response);
			internal void _RequestBuildEventEntry_b__69_0(BuildEventEntryResponse response);
			internal void _RequestClb01EventEntry_b__70_0(Clb01EventEntryResponse response);
			internal void _RequestExRushEventEntry_b__71_0(ExRushEventEntryResponse response);
			internal void _RequestExHunterEventEntry_b__72_0(ExHunterEventEntryResponse response);
			internal void _RequestCollectEventEntry_b__73_0(CollectEventEntryResponse response);
			internal void _RequestCombatEventEntry_b__74_0(CombatEventEntryResponse response);
			internal void _RequestBattleRoyalEventEntry_b__75_0(BattleRoyalEventEntryResponse response);
			internal void _GotoPrologue_b__76_0();
			internal bool _ShowTreasureTimeEffect_b__89_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExitAndInit_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExitAndInit_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _RequestRaidEventData_b__0(RaidEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _RequestRandomEventData_b__0(MazeEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _RequestBuildEventData_b__0(BuildEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _RequestClb01EventData_b__0(Clb01EventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _RequestExRushEventData_b__0(ExRushEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _RequestExHunterEventData_b__0(ExHunterEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _RequestCombatEventData_b__0(CombatEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _RequestBattleRoyalEventData_b__0(BattleRoyalEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _RequestCollectEventData_b__0(CollectEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public EventQuestScene __4__this;
			public Action onClosePU;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _ShowEventInfoPopup_b__0();
			internal void _ShowEventInfoPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action onClosePU;
	
			// Constructors
			public __c__DisplayClass83_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass83_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass83_1();
	
			// Methods
			internal void _ShowAnnouncementPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_2
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass83_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass83_2();
	
			// Methods
			internal void _ShowAnnouncementPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public EventQuestScene __4__this;
			public Action onClose;
			public bool isFirstTime;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _CheckStroyReward_b__0();
			internal void _CheckStroyReward_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ShowTreasureTimeEffect_d__89 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool toShow;
			public EventQuestScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowTreasureTimeEffect_d__89(int __1__state);
	
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
			public SimpleAnimationButton simpleAnimationButton;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _BindBackButtonCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public UnityAction completeCallback;
			public UnityAction cancelledCallback;
			public Action gotEventDataCallback;
			public Action<EventTradeGetListResponse> __9__2;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _CheckForBeforeTransition_b__0();
			internal void _CheckForBeforeTransition_b__1();
			internal void _CheckForBeforeTransition_b__2(EventTradeGetListResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public UnityAction completeCallback;
			public DownloadOperation downloadOperation;
			public UnityAction cancelledCallback;
	
			// Constructors
			public __c__DisplayClass94_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_1
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass94_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass94_1();
	
			// Methods
			internal void _DownLoadStoryData_b__0();
			internal void _DownLoadStoryData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal void _RequestEventData_b__0(EventDataElement x);
			internal void _RequestEventData_b__1(EventDataElement x);
			internal void _RequestEventData_b__2(EventDataElement x);
			internal void _RequestEventData_b__3(EventDataElement x);
			internal void _RequestEventData_b__4(EventDataElement x);
			internal void _RequestEventData_b__5(EventDataElement x);
			internal void _RequestEventData_b__6(EventDataElement x);
			internal void _RequestEventData_b__7(EventDataElement x);
			internal void _RequestEventData_b__8(EventDataElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass102_0
		{
			// Fields
			public EventQuestScene __4__this;
			public SceneNameDefine.PageName pageName;
			public Transform parentTransform;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public Action<PageBase> onLoaded;
			public object data;
			public bool allowSamePageReload;
			public bool delayEnterAnimation;
			public bool deactivateLastPage;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass102_0();
	
			// Methods
			internal void _ChangePageToQuestSelectSupport_b__0(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public EventQuestScene __4__this;
			public SceneNameDefine.PageName pageName;
			public Transform parentTransform;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public Action<PageBase> onLoaded;
			public object data;
			public bool allowSamePageReload;
			public bool delayEnterAnimation;
			public bool deactivateLastPage;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal void _ChangePageToQuestDetailList_b__0(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_0
		{
			// Fields
			public EventQuestScene __4__this;
			public EventQuestDetailListPage questDetailListPage;
			public Action<PageBase> __9__2;
	
			// Constructors
			public __c__DisplayClass104_0();
	
			// Methods
			internal void _OnQuestDetailListPageActive_b__0();
			internal void _OnQuestDetailListPageActive_b__1();
			internal void _OnQuestDetailListPageActive_b__2(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public EventQuestScene __4__this;
			public EventQuestDetailListPage questDetailListPage;
			public Action<PageBase> __9__2;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal void _OnCombatQuestDetailListPageActive_b__0();
			internal void _OnCombatQuestDetailListPageActive_b__1();
			internal void _OnCombatQuestDetailListPageActive_b__2(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_0
		{
			// Fields
			public CombatEventLocationElement location;
			public EventQuestScene __4__this;
	
			// Constructors
			public __c__DisplayClass121_0();
	
			// Methods
			internal void _CheckBefreEventEndReward_b__0();
		}
	
		// Constructors
		public EventQuestScene();
		static EventQuestScene();
	
		// Methods
		private void Awake();
		public override void OnBeforeLeaving();
		public override void StartExitAnimation();
		public TabCategory GetDefaultMissionType();
		[IteratorStateMachine]
		private IEnumerator StartExitAnimationCoroutine();
		public void ForceMoveBackButton(bool isIn);
		private void Start();
		[IteratorStateMachine]
		private IEnumerator WaitPrevSceneExitAndInit();
		private void LoadEventStatus();
		private void UpdateExchangeInformation();
		public static void GotoEventQuestScene(Action continueChangingToEventScene = null);
		public static void RemoveTouchGuardHandler();
		public static void GoToEventQuestSceneErrorHandler(ErrorType errorType, int errorCode);
		private static void RequestRaidEventData(Action continueChangingToEventScene);
		public static void RequestRandomEventData(Action continueChangingToEventScene);
		public static void RequestBuildEventData(Action continueChangingToEventScene);
		public static void RequestClb01EventData(Action continueChangingToEventScene);
		public static void RequestExRushEventData(Action continueChangingToEventScene);
		public static void RequestExHunterEventData(Action continueChangingToEventScene);
		public static void RequestCombatEventData(Action continueChangingToEventScene);
		public static void RequestBattleRoyalEventData(Action continueChangingToEventScene);
		public static void RequestCollectEventData(Action continueChangingToEventScene);
		private static void OnGotEventData(Action continueChangingToEventScene);
		public static void RequestEntry();
		public static void RequestRaidEventEntry();
		public static void RequestRandomEventEntry();
		public static void RequestBuildEventEntry();
		public static void RequestClb01EventEntry();
		public static void RequestExRushEventEntry();
		public static void RequestExHunterEventEntry();
		public static void RequestCollectEventEntry();
		public static void RequestCombatEventEntry();
		public static void RequestBattleRoyalEventEntry();
		private static bool GotoPrologue();
		private static bool IsEntryRequestNeeded();
		private static bool ShouldGotoPrologue();
		public static bool IsGotoPrologue();
		public static bool IsGotoEpilogue();
		public bool ShowBeginningPopup(Action onClosePU);
		private bool ShowEventInfoPopup(Action onClosePU);
		public bool ShowAnnouncementPopup(Action onClosePU);
		private bool CheckChara();
		public void CheckStroyReward(Action onClose, bool isFirstTime = false);
		public void ShowEventStoryRewardPopup(UnityAction onDone);
		public void SetEventStatusInfo();
		public EventRewardConfirmPopup ShowReceiveRewardPopup(bool isAllReward, GiftType giftType = GiftType.NONE, int itemId = 0);
		[IteratorStateMachine]
		public IEnumerator ShowTreasureTimeEffect(bool toShow);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void SetCharacterShader();
		public void BindBackButtonCallback(UnityAction callback, bool showExitAnimationWhenClick);
		public static void CheckForBeforeTransition(int EventId, UnityAction completeCallback, UnityAction cancelledCallback = null);
		private static void DownLoadStoryData(int storyId, UnityAction completeCallback, UnityAction cancelledCallback);
		public static void RequestEventData(int eventId, Action successCallback, Action<ErrorType, int> onError, bool forceRequest = true);
		public static AudioPlayback PlayBgm(int eventId);
		public override void OnPresentReceived();
		private void Update();
		public override void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, Action<PageBase> onLoaded = null, object data = null, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		private void ChangePageToQuestSelectSupport(Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage);
		private void ChangePageToQuestDetailList(Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage);
		private void OnQuestDetailListPageActive(EventQuestDetailListPage questDetailListPage, Clb01EventLocationElement location);
		private void OnCombatQuestDetailListPageActive(EventQuestDetailListPage questDetailListPage, CombatEventLocationElement location);
		private void OnSupportPageActive();
		private void OnSupportPageStartAnimation(bool isFromQuestPrepare);
		private void OnSupportPageExitAnimation();
		private void OnSupportPageEnterAnimationEnded();
		public void OnSupportPageBackButtonPressed();
		public void HideScreenshotBackImage();
		public bool IsAutoTransitionToQuestSelect();
		public void SetAutoTransitionDoneToQuestSelect();
		public bool IsCheckStoryReward();
		public void SetCheckStoryReward();
		public Clb01EventLocationElement GetAutoTransitionLocation();
		private static Clb01EventLocationElement GetLocationFromStoryId(int eventId, int storyId);
		private static Clb01EventLocationElement GetLocationFromReleaseQuestStoryId(int eventId, int storyId);
		private static Clb01EventLocationElement GetLocation(int eventId, int locationId);
		public CombatEventLocationElement GetAutoTransitionCombatLocation();
		private void CheckBefreEventEndReward();
		[CompilerGenerated]
		private bool _StartExitAnimationCoroutine_b__47_0();
		[CompilerGenerated]
		private bool _WaitPrevSceneExitAndInit_b__50_3();
		[CompilerGenerated]
		private bool _WaitPrevSceneExitAndInit_b__50_4();
		[CompilerGenerated]
		private void _LoadEventStatus_b__51_0(GameObject prefab);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage);
		[CompilerGenerated]
		private void _CheckBefreEventEndReward_b__121_1();
	}
}
