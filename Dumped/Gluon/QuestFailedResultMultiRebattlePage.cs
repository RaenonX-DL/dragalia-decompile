using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestFailedResultMultiRebattlePage : MonoBehaviour
	{
		public enum EnumGuestStete
		{
			Prepare,
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
		private Button nextButton;

		[SerializeField]
		private UIAnimationPublisher animationPublisher;

		[SerializeField]
		private UIAnimationPublisher animationPublisherNextButton;

		[SerializeField]
		private float yDiffFirendAnimation;

		private bool isHost;

		private bool isTapToNextFlag;

		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;

		private int selectedFriend;

		private DateTime rebattleStartTime;

		private const string NextSceneMatchingRoom = "PartyBase";

		private bool isConnected;

		private bool isHostWait;

		private const float waitTime = 71f / (339f * (float)Math.PI);

		private EventQuestConditionPopup conditionPopup;

		private QuestResultMultiReBattleConfirm reBattleConfirm;

		private Action onRebbatlePageEnd;

		private bool isOnMultiPageReballePanelDone;

		private bool isMatchingRoomTransition;

		private List<MatchingService.Player> notMyPlayerList;

		private int questId;

		private List<QuestResultModel.FriendApplyModel.SingleFriendApplyInfo> supportList;

		private EnumGuestStete state;

		public bool IsTapToNextFlag => default(bool);

		public EnumGuestStete GuestRebattleSelectState => default(EnumGuestStete);

		private void Update()
		{
		}

		public void Initialize(DateTime startTime, bool connection, Action rebattleEnd, int questId, List<MatchingService.Player> matchingPlayerModel)
		{
		}

		private void OnRequestButton(int index)
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

		private void HideRebattlePanel(Action onFinished)
		{
		}

		private void ShowNextButton()
		{
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

		private void PlayExitAnimation()
		{
		}

		private IEnumerator DelayActionCoroutine(float delayTime, Action action)
		{
			return null;
		}
	}
}
