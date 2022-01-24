using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildChatView : MonoBehaviour
	{
		[SerializeField]
		[Header("TableView")]
		private GuildChatTableViewController tableView;

		[SerializeField]
		private DragEventScrollRect scrolRect;

		[SerializeField]
		public CustomInputField textField;

		[SerializeField]
		private Button sendButton;

		[SerializeField]
		private GameObject pageDownButton;

		[SerializeField]
		private float pageDownTimeMinimum;

		[SerializeField]
		private float pageDownTimeMagnification;

		[SerializeField]
		private Ease pageDownEaseType;

		[SerializeField]
		private float newChatAppearTime;

		[SerializeField]
		private Ease newChatAppearEaseType;

		[SerializeField]
		private float scrollBottomSpace;

		[SerializeField]
		private float pageDownButtonSpace;

		[SerializeField]
		private GameObject loadingObject;

		[SerializeField]
		private GameObject newMessageObject;

		private float pollChatInterval;

		private MatchingStampPopup stampPopup;

		private GuildChatModel guildChatModel;

		private float pollingIntervalCount;

		private bool isPollingEnable;

		private bool isViewingLatestChat;

		private Tweener scrollTweener;

		private readonly string stampVoice;

		private bool isOpenStampPopup;

		private bool isLoading;

		private Canvas _canvas;

		[SerializeField]
		private List<GuildChatModel.ContentType> enableContentType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Canvas canvas => null;

		public static GuildChatView Create(Transform parent, List<GuildChatModel.ContentType> filter)
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void ResetPollingIntervalCount()
		{
		}

		private bool IsExistPopup()
		{
			return default(bool);
		}

		private void PollChat()
		{
		}

		private void GetPastLog()
		{
		}

		public void StartPoling()
		{
		}

		public void StopPoling()
		{
		}

		public void PostChat(string text, [Optional] Action onSucsess)
		{
		}

		public void PostStamp(int stampId)
		{
		}

		private void LoadChat(bool isNew, bool isFirst = false, bool isDisplayNewMessage = true)
		{
		}

		private void RefreshChat(bool isNew, bool isFirst = false)
		{
		}

		private void UpdateTableView(bool isNew, bool isFirst)
		{
		}

		private IEnumerator UpdateTableViewAfterAnimation(bool isNew, bool isFirst)
		{
			return null;
		}

		public void OnStampButtonPressed()
		{
		}

		private void OnClickStamp(int stampId)
		{
		}

		public void OnSendButtonPressed()
		{
		}

		private void UpdateSendButton()
		{
		}

		private void CheckViewingLatestChatFlag()
		{
		}

		private void CheckPageDownButtonActive()
		{
		}

		private void SetPageDownButtonActive(bool isActive)
		{
		}

		public IEnumerator StartScrollDown()
		{
			return null;
		}

		public void OnPageDownPressed()
		{
		}

		private Tweener GetScrollTweener(Ease ease, float time)
		{
			return null;
		}

		private void KillScrollTweener()
		{
		}

		private bool IsTween()
		{
			return default(bool);
		}

		private void SetLoadingObject(bool isActive)
		{
		}

		private void SetNewMessageObject(bool isActive)
		{
		}

		private void OnDestroy()
		{
		}

		public void OnValueChangedChatMessage(string text)
		{
		}
	}
}
