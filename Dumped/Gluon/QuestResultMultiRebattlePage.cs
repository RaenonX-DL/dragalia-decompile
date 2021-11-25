using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultMultiRebattlePage : MonoBehaviour
	{
		public enum EnumGuestStete
		{
			Prepare,
			WaitTryGame,
			WaitHost,
			Exit
		}

		[SerializeField]
		private QuestResultMultiFriendList[] friendList;

		[SerializeField]
		private Text rebattleCountDownText;

		[SerializeField]
		private Text conditionFailedText;

		[SerializeField]
		private Transform friendPanel;

		[SerializeField]
		private CanvasGroup friendCanvas;

		[SerializeField]
		private Transform reBattlePanel;

		[SerializeField]
		private CanvasGroup reBattleCanvas;

		[SerializeField]
		private Button reBattleButton;

		[SerializeField]
		private Button notReBattleButton;

		[SerializeField]
		private UIAnimationPublisher animationPublisher;

		private bool isHost;

		private bool isTapToNextFlag;

		private IngameResultData resultData;

		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;

		private int selectedFriend;

		private DateTime rebattleStartTime;

		private const string NextSceneMatchingRoom = "PartyBase";

		private const string NextSceneMyPage = "MyPage";

		private bool isConnected;

		private bool isHostWait;

		private const float waitTime = 71f / (339f * (float)Math.PI);

		private EventQuestConditionPopup conditionPopup;

		private Action onRebbatlePageEnd;

		private bool isOnMultiPageReballePanelDone;

		private bool isMatchingRoomTransition;

		private List<MatchingService.Player> notMyPlayerList;

		private EnumGuestStete state;

		public bool IsTapToNextFlag => default(bool);

		public EnumGuestStete GuestRebattleSelectState => default(EnumGuestStete);

		private void Update()
		{
		}

		public void Initialize(DateTime startTime, bool connection, Action rebattleEnd)
		{
		}

		private bool IsExtraBattleQuest()
		{
			return default(bool);
		}

		private void onRequestButton(int index)
		{
		}

		private void OnInviteButton(int index)
		{
		}

		private void OnClose(bool onClose)
		{
		}

		public void OnReBattle()
		{
		}

		public void OnNotReBattle()
		{
		}

		private void checkDisconectType()
		{
		}

		private void PopupHostExitConfirmCreate([Optional] UnityAction close)
		{
		}

		private IEnumerator UpdateReBattle()
		{
			return null;
		}

		private void IsReBattleButton(bool enabled)
		{
		}

		private int GetSecondRemain()
		{
			return default(int);
		}

		private void Disconnect()
		{
		}

		private void CloseEventQuestConditionPopup()
		{
		}

		private void GoNextScene(Action loadSceneAction)
		{
		}

		private IEnumerator GoOtherSceneDelayCorutine(Action loadSceneAction, float delayTime)
		{
			return null;
		}
	}
}
