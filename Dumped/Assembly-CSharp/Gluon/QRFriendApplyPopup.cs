/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRFriendApplyPopup : QuestResultCommonPopup
	{
		// Fields
		[SerializeField]
		public CommonFriendListCell commonFriendListCell;
		private Action<bool> onClose;
		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;
	
		// Constructors
		public QRFriendApplyPopup();
	
		// Methods
		public static QRFriendApplyPopup Create(QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info, Action<bool> onClose = null);
		protected override void Start();
		private void OnOk();
		private void OnCancel();
		private void ApiFriendRequest();
		private void ApiOnSuccess(FriendRequestResponse res);
		private void ApiOnError(ErrorType errorType, int resultCode);
		private void OnCloseQuestResultCommonPopup();
		[CompilerGenerated]
		private void _ApiOnError_b__9_0();
	}
}
