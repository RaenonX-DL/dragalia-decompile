using System;
using System.Collections.Generic;
using Cute.Http;
using Gluon.Http;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionReceiveResultPopup : CommonPopup
	{
		public enum State
		{
			None = -1,
			Discard,
			ToPresent,
			Receive
		}

		private const string prefabPath = "Prefabs/OutGame/Mission/Popup/MissionReceiveResultPopup";

		[SerializeField]
		private MyPagePresentGroupListController successGroupListController;

		[SerializeField]
		private Text successText;

		[SerializeField]
		private MyPagePresentGroupListController failedGroupListController;

		[SerializeField]
		private Text failedText;

		private MyPagePresentGroupListController groupListController;

		private static bool isSingleReceive;

		public static List<ConvertedEntityList> convertedList;

		private Action onPressedSceneButtonCallback;

		public static MissionReceiveResultPopup Create()
		{
			return null;
		}

		public void InitSetting(List<MyPagePresentGroupListCellData> receiveCellDataList, Action onReceivedCallback, Action onPressedSceneButtonCallback, State state = State.None)
		{
		}

		private void LoadReceiveList(List<MyPagePresentGroupListCellData> groupCellDataList, bool isReceived)
		{
		}

		private void OnPressedSceneButtonCallback(MyPagePresentListPopup.NextScenePattern nextScenePattern)
		{
		}

		private void CreateNoReceivedList(List<MyPagePresentGroupListCellData> groupCellDataList, State state)
		{
		}

		private void RemoveNoReceivedList(List<MyPagePresentGroupListCellData> groupCellDataList, State state)
		{
		}

		private MyPagePresentGroupListCellData GetGroupCellDataForTargetItem(List<MyPagePresentGroupListCellData> groupCellDataList, GiftType type, int id)
		{
			return null;
		}

		public static void RequestMissionReceiveReward(TabCategory category, MissionTableViewData[] dataList, Action successCallback, bool isSingle = false)
		{
		}

		private static void RequestMissionReceiveDailyReward(AtgenMissionParamsList[] list, Action successCallback)
		{
		}

		private static void RequestMissionReceivePeriodReward(int[] list, Action successCallback)
		{
		}

		private static void RequestMissionReceiveNormalReward(int[] normalList, int[] storyMissionList, int[] eventMissionList, int[] albumMissionList, Action successCallback)
		{
		}

		private static void RequestMissionReceiveBeginnerReward(int[] list, Action successCallback)
		{
		}

		private static void RequestMissionReceiveSpecialReward(int[] list, Action successCallback)
		{
		}

		private static void RequestMissionReceiveDrillReward(int[] missionDrillIdList, int[] missionDrillGroupIdList, Action successCallback)
		{
		}

		private static void OnError(ErrorType errorType, int resultCode)
		{
		}

		private static void ShowConvertConfirmPop(ConvertedEntityList[] converted_entity_list, Action successCallback)
		{
		}
	}
}
