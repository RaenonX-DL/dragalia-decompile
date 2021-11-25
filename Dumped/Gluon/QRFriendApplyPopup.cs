using System;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class QRFriendApplyPopup : QuestResultCommonPopup
	{
		[SerializeField]
		public CommonFriendListCell commonFriendListCell;

		private Action<bool> onClose;

		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;

		public static QRFriendApplyPopup Create(QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info, [Optional] Action<bool> onClose)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void OnOk()
		{
		}

		private void OnCancel()
		{
		}

		private void ApiFriendRequest()
		{
		}

		private void ApiOnSuccess(FriendRequestResponse res)
		{
		}

		private void ApiOnError(ErrorType errorType, int resultCode)
		{
		}

		private void OnCloseQuestResultCommonPopup()
		{
		}
	}
}
