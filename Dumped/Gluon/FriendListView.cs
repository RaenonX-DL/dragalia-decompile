using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendListView : FriendPanelBase
	{
		private static Action onHttpDone;

		public Transform frameParent;

		public RectTransform referenceRect;

		[SerializeField]
		private FriendListController listController;

		[SerializeField]
		private Button allDenyButton;

		[SerializeField]
		private Text friendNumText;

		private List<FriendListCellData> cellDataList;

		private const int friendListUnmatchedErrorCode = 7005;

		private const int friendRequestErrorCode = 7012;

		public static FriendListView Create(Transform parent, FriendScene scene)
		{
			return null;
		}

		private void Start()
		{
		}

		public override void PlayExitAnimation(Action onFinished)
		{
		}

		private void SetFriendList()
		{
		}

		public void OnFriendAllDenyButtonPressed()
		{
		}

		private void CreateConfirmFriendRemovePopup(FriendListCellData data)
		{
		}

		private void RequestFriendRemove(FriendListCellData data)
		{
		}

		private void RequestFriendCancel(FriendListCellData data)
		{
		}

		private void RequestFriendReplyApproval(FriendListCellData data)
		{
		}

		private void RequestFriendReplyDeny(FriendListCellData data)
		{
		}

		private void RequestFriendAllDeny()
		{
		}

		public static void OnGuildInviteButton(FriendListCellData data)
		{
		}

		public static void OnGuildJoinButton(FriendListCellData data)
		{
		}

		private static void SearchById(int guildId)
		{
		}

		private static void Apply(int guildId, GuildInfoCellData data, [Optional] Action onApplyDone)
		{
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		public static void OnEntryHttpSuccess()
		{
		}

		public void OnSortButtonPressed()
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void ReloadPanelList()
		{
		}
	}
}
