using System;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class MatchingRoomIdInputEntryConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Frame")]
		public Transform cellFrame;

		private const string matchingRoomListCellPrefabPath = "UI/Popup/MyPage/MatchingRoomListCell";

		private RoomListData roomListData;

		private Action onEnterRoom;

		private Action<int> goPrepareScene;

		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;

		private QuestRoomList cell;

		private PartySwitchPopup switchPopup;

		public static MatchingRoomIdInputEntryConfirmPopup Create(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, RoomList roomList, bool isFriend, Action onEnterRoom, Action<int> goPrepareScene, [Optional] Transform parentTransform)
		{
			return null;
		}

		private void SetupWithData(RoomList roomList, bool isFriend)
		{
		}

		public void OnEnterButtonPressed()
		{
		}

		private void EnterRoom()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void OnMatchingServiceStateChanged(MatchingService.StateType state)
		{
		}

		private void ErrorTypeCheck(MultiPlayError error)
		{
		}

		private void PopupNothingRoom()
		{
		}

		private void PopupLimitRoomCreate()
		{
		}

		private void PopupInvalidCompatibleId()
		{
		}
	}
}
