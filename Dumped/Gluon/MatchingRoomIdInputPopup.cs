using System;
using System.Collections;
using System.Collections.Generic;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomIdInputPopup : PopupBase
	{
		[SerializeField]
		private InputFrame inputFrame;

		[SerializeField]
		private Text searchButtonText;

		[SerializeField]
		private Button searchButton;

		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;

		private const int MaxRommInputCount = 7;

		private Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> goPrepareScene;

		private bool searchPrevRoom;

		private static int prevRoomId;

		private static RoomList prevRoomData;

		private static int prevRoomIsFriend;

		public static void ClearPrevRoomData()
		{
		}

		public void Initialize(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> goPrepareScene, bool searchPrevRoom)
		{
		}

		protected override void Start()
		{
		}

		private IEnumerator ShowPrevRoomPopup()
		{
			return null;
		}

		public void OnClearButtonPressed()
		{
		}

		public void OnDeleteButtonPressed()
		{
		}

		public void OnSearchButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		private void OnNumberButtonPressed(List<string> num)
		{
		}

		private void ServerRoomNameGat(int roomId)
		{
		}

		private void OnMatchingGetRoomNameRequestError(ErrorType errorType, int resultCode)
		{
		}

		public static void PopupNothingRoom()
		{
		}

		private void OnMatchingGetRoomNameRequestSuccess(MatchingGetRoomNameResponse res)
		{
		}

		private void GoQuestPrepareScene(int roomQuestId)
		{
		}

		public static void CheckJoinConditions(GameObject gameObject, int questId, Action<bool> onSuccess)
		{
		}
	}
}
