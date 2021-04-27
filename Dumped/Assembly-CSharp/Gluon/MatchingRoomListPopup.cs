/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomListPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private QuestRoomListController questRoomListCtrl;
		[SerializeField]
		private TabBase questRoomTabs;
		[SerializeField]
		private TabBase questRoomTabsWithRaid;
		[SerializeField]
		private MatchingSearchBlock searchBlock;
		[SerializeField]
		private GameObject filterRoot;
		[SerializeField]
		private UnityEngine.UI.Text filterOnOffText;
		[SerializeField]
		private Transform filterColonTransform;
		[SerializeField]
		private float getLocationMaxWaitTime;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private GameObject pagerRoot;
		[SerializeField]
		private GameObject pagerParent;
		[SerializeField]
		private float pagerWidth;
		private List<PartyPager> pagers;
		private int selectPartyNo;
		private int selectPartyGroup;
		public Image partyGroupIcon;
		public Sprite[] partyGroupSprites;
		public UnityEngine.UI.Text partyNameText;
		public UnityEngine.UI.Text powerText;
		public GameObject partyInfoRoot;
		public GameObject partyChangeButtonRoot;
		private List<RoomListData> roomDataList;
		private bool _serverGetRoomListRunning;
		private bool isJoinRoomRunning;
		private string _bestRegionCache;
		private TabType selectedTab;
		private MatchingService matchingService;
		private int questId;
		private MatchingConditionPopup.FilterSetting raidFilterSetting;
		private MatchingConditionPopup.FilterSetting filterSetting;
		private List<RoomListData> roomList;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private bool isFromMultiPlaySelector;
		private Action onPartyChangedAction;
		private SearchMode searchMode;
		private Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> gotoPrepareSceneAction;
		private const int maxFriendRoomCount = 3;
		private const int maxNotFriendRoomCount = 10;
		private const int maxListCount = 100;
		private const int maxPickListCount = 10;
		private const int maxGuildRoomCount = 3;
		private const float minBlockViewTime = 0.5f;
		[CompilerGenerated]
		private bool _nowOpenRaidEvent_k__BackingField;
		private TabType initTab;
		private PartySwitchPopup switchPopup;
	
		// Properties
		private bool nowOpenRaidEvent { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum SearchMode
		{
			Any = 0,
			Quest = 1,
			Location = 2
		}
	
		public enum TabType
		{
			None = -1,
			Raid = 0,
			LimitedTime = 1,
			Normal = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _OnGetLocationInfoFailed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public string regionName;
	
			// Constructors
			public __c__DisplayClass57_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public __c__DisplayClass57_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass57_1();
	
			// Methods
			internal void _OnBestRegionFound_b__0();
			internal void _OnBestRegionFound_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<RoomListData, Guid> __9__61_0;
			public static Func<RoomListData, Guid> __9__62_0;
			public static Func<RoomListData, Guid> __9__63_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal Guid _OnMatchingGetRoomListRequestSuccess_b__61_0(RoomListData i);
			internal Guid _OnMatchingGetRoomListByQuestIdRequestSuccess_b__62_0(RoomListData i);
			internal Guid _OnMatchingGetRoomListByLocationRequestSuccess_b__63_0(RoomListData i);
		}
	
		[CompilerGenerated]
		private sealed class _Load_d__64 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomListPopup __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Load_d__64(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public RoomList data;
			public QuestDataElement qde;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _OnListButtonClick_b__0();
			internal void _OnListButtonClick_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public RoomList data;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass71_0();
	
			// Methods
			internal void _JoinRoom_b__0(bool isRecoveredStamina);
			internal void _JoinRoom_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_1
		{
			// Fields
			public QuestLimitedConfirmPopup popup;
			public __c__DisplayClass71_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass71_1();
	
			// Methods
			internal void _JoinRoom_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public RoomList data;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _PhotonConnect_b__0();
			internal void _PhotonConnect_b__1();
			internal void _PhotonConnect_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal void _PopupNothingRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _PopupInvalidCompatibleId_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public MatchingRoomListPopup __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _PopupLimitRoomCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0
		{
			// Fields
			public MatchingConditionPopup popup;
			public MatchingRoomListPopup __4__this;
			public bool isRaidBattle;
	
			// Constructors
			public __c__DisplayClass91_0();
	
			// Methods
			internal void _OnFilterPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public PartySwitchPopup popup;
			public MatchingRoomListPopup __4__this;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_1
		{
			// Fields
			public PartyChangePopup popup;
			public int nowPartyIndex;
			public MatchingRoomListPopup __4__this;
	
			// Constructors
			public __c__DisplayClass93_1();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__2(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__3(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__4();
		}
	
		// Constructors
		public MatchingRoomListPopup();
	
		// Methods
		public void Initialize(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, TabType initTab, int questId = 0, Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> gotoPrepareSceneAction = null, Action onPartyChangedAction = null);
		public void InitializeForLocationSearch(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> gotoPrepareSceneAction = null);
		private bool IsAvailableFilter();
		protected override void Start();
		private void ErrorTypeCheck(MultiPlayError error);
		private void SearchLocation(string regionName);
		private void OnGetLocationInfoFailed();
		private void OnBestRegionFound(string regionName);
		private void ServerGetRoomList();
		private void OnMatchingGetRoomListRequestError(ErrorType errorType, int resultCode);
		private void UpdateRoomList();
		private void OnMatchingGetRoomListRequestSuccess(MatchingGetRoomListResponse res);
		private void OnMatchingGetRoomListByQuestIdRequestSuccess(MatchingGetRoomListByQuestIdResponse res);
		private void OnMatchingGetRoomListByLocationRequestSuccess(MatchingGetRoomListByLocationResponse res);
		[IteratorStateMachine]
		private IEnumerator Load();
		private List<RoomListData> GetRoomListPriorityGuild(RoomListData[] roomList);
		public void RoomListLoad();
		public void OnSelectedTab(int num);
		private void OnListButtonClick(RoomList data);
		private void OnPartySwitchPopupClose();
		private void GoQuestPrepareScene(int roomQuestId);
		private void JoinRoom(RoomList data, QuestDataElement qde);
		private bool IsRequireConditionFullFilled(RoomList data);
		private void PhotonConnect(RoomList data);
		protected override void OnDestroy();
		private QuestAutoTransitionUtil.GuestEnterRoomFromType GetEnterFromType();
		private void OnMatchingServiceStateChangedForJoinRoom(MatchingService.StateType state);
		private void OnMatchingServiceStateChangedForSearchBestRegion(MatchingService.StateType state);
		private void PopupNothingRoom();
		private void PopupInvalidCompatibleId();
		private void PopupLimitRoomCreate();
		public void OnReResearchButton();
		public void OnCancelButtonPressed();
		private void SearchSetting(bool enable);
		private List<RoomListData> GetFilteredRoomList(List<RoomListData> roomList);
		private bool IsRaidLikeBattle();
		public static bool IsAstralRaidNowOpen();
		private bool IsRaidLikeQuestNowOpen();
		private MatchingConditionPopup.FilterSetting GetFilterSetting();
		private void SetFilterSetting(MatchingConditionPopup.FilterSetting setting);
		private void UpdateFilterText();
		public void OnFilterPressed();
		public void SetFromMultiPlaySelector();
		public void OnPartyChangeButtonPressed();
		private void OnPagerPressed(int pressedPagerIndex);
		private void UpdatePartyData();
		public void OnArrowPressed(int increment);
		private void ReloadPager();
		[CompilerGenerated]
		private void _Initialize_b__50_0(int index);
		[CompilerGenerated]
		private void _OnPartyChangeButtonPressed_b__93_0();
		[CompilerGenerated]
		private void _OnPartyChangeButtonPressed_b__93_5();
		[CompilerGenerated]
		private void _OnPagerPressed_b__94_0();
		[CompilerGenerated]
		private void _ReloadPager_b__97_0(int index);
		[CompilerGenerated]
		private void _ReloadPager_b__97_1();
	}
}
