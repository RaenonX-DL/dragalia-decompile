using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomListPopup : PopupBase
	{
		private enum SearchMode
		{
			Any,
			Quest,
			Location
		}

		public enum TabType
		{
			Raid = 0,
			LimitedTime = 1,
			Normal = 2,
			None = -1
		}

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
		private Text filterOnOffText;

		[SerializeField]
		private Transform filterColonTransform;

		[SerializeField]
		private float getLocationMaxWaitTime;

		[SerializeField]
		private Text titleText;

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

		public Text partyNameText;

		public Text powerText;

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

		private TabType initTab;

		private PartySwitchPopup switchPopup;

		private bool nowOpenRaidEvent
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, TabType initTab, int questId = 0, [Optional] Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> gotoPrepareSceneAction, [Optional] Action onPartyChangedAction)
		{
		}

		public void InitializeForLocationSearch(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, [Optional] Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> gotoPrepareSceneAction)
		{
		}

		private bool IsAvailableFilter()
		{
			return default(bool);
		}

		protected override void Start()
		{
		}

		private void ErrorTypeCheck(MultiPlayError error)
		{
		}

		private void SearchLocation(string regionName)
		{
		}

		private void OnGetLocationInfoFailed()
		{
		}

		private void OnBestRegionFound(string regionName)
		{
		}

		private void ServerGetRoomList()
		{
		}

		private void OnMatchingGetRoomListRequestError(ErrorType errorType, int resultCode)
		{
		}

		private void UpdateRoomList()
		{
		}

		private void OnMatchingGetRoomListRequestSuccess(MatchingGetRoomListResponse res)
		{
		}

		private void OnMatchingGetRoomListByQuestIdRequestSuccess(MatchingGetRoomListByQuestIdResponse res)
		{
		}

		private void OnMatchingGetRoomListByLocationRequestSuccess(MatchingGetRoomListByLocationResponse res)
		{
		}

		private IEnumerator Load()
		{
			return null;
		}

		private List<RoomListData> GetRoomListPriorityGuild(RoomListData[] roomList)
		{
			return null;
		}

		public void RoomListLoad()
		{
		}

		public void OnSelectedTab(int num)
		{
		}

		private void OnListButtonClick(RoomList data)
		{
		}

		private void OnPartySwitchPopupClose()
		{
		}

		private void GoQuestPrepareScene(int roomQuestId)
		{
		}

		private void JoinRoom(RoomList data, QuestDataElement qde)
		{
		}

		private bool IsRequireConditionFullFilled(RoomList data)
		{
			return default(bool);
		}

		private void PhotonConnect(RoomList data)
		{
		}

		protected override void OnDestroy()
		{
		}

		private QuestAutoTransitionUtil.GuestEnterRoomFromType GetEnterFromType()
		{
			return default(QuestAutoTransitionUtil.GuestEnterRoomFromType);
		}

		private void OnMatchingServiceStateChangedForJoinRoom(MatchingService.StateType state)
		{
		}

		private void OnMatchingServiceStateChangedForSearchBestRegion(MatchingService.StateType state)
		{
		}

		private void PopupNothingRoom()
		{
		}

		private void PopupInvalidCompatibleId()
		{
		}

		private void PopupLimitRoomCreate()
		{
		}

		public void OnReResearchButton()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		private void SearchSetting(bool enable)
		{
		}

		private List<RoomListData> GetFilteredRoomList(List<RoomListData> roomList)
		{
			return null;
		}

		private bool IsRaidLikeBattle()
		{
			return default(bool);
		}

		public static bool IsAstralRaidNowOpen()
		{
			return default(bool);
		}

		private bool IsRaidLikeQuestNowOpen()
		{
			return default(bool);
		}

		private MatchingConditionPopup.FilterSetting GetFilterSetting()
		{
			return null;
		}

		private void SetFilterSetting(MatchingConditionPopup.FilterSetting setting)
		{
		}

		private void UpdateFilterText()
		{
		}

		public void OnFilterPressed()
		{
		}

		public void SetFromMultiPlaySelector()
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		private void OnPagerPressed(int pressedPagerIndex)
		{
		}

		private void UpdatePartyData()
		{
		}

		public void OnArrowPressed(int increment)
		{
		}

		private void ReloadPager()
		{
		}
	}
}
