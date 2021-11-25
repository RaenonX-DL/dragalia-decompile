using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildMemberListPopup : PopupBase
	{
		private enum TabType
		{
			Member,
			Waiting,
			Inviting
		}

		[SerializeField]
		[Header("Title")]
		public Text titleText;

		[SerializeField]
		[Header("TabView")]
		public TabBase tabView;

		public GameObject tabViewLine;

		private int activeTabIndex;

		[SerializeField]
		[Header("TableViews")]
		public GuildMemberTableViewController memberController;

		public GuildMemberTableViewController waitingController;

		public GuildMemberTableViewController invitingController;

		[SerializeField]
		[Header("RejectAll")]
		public Button rejectAllButton;

		public GameObject rejectAllGO;

		[SerializeField]
		[Header("Badge")]
		public Badge waitingListBadge;

		public GameObject invitingListBadge;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberListPopup";

		private TabType currentTab;

		private List<GuildModel.MemberInfo> memberDataList;

		private List<GuildModel.MemberInfo> waitingDataList;

		private List<GuildModel.MemberInfo> invitingDataList;

		private GuildModel.Occupation occupation;

		[SerializeField]
		private Text inviteNumText;

		public static void CreateModule(GuildModel.Occupation occupation, UnityAction onClose)
		{
		}

		private void SetupWithOccupation(GuildModel.Occupation occupation)
		{
		}

		private static Task<GuildGetGuildMemberDataResponse> RequestMemberList()
		{
			return null;
		}

		private Task<GuildGetGuildApplyDataResponse> RequestWaitingList()
		{
			return null;
		}

		private Task<GuildInviteGetGuildInviteSendDataResponse> RequestInvitingList()
		{
			return null;
		}

		private void RequestUpdateMemberList()
		{
		}

		private void RequestUpdateWaitingList(bool updateData = true)
		{
		}

		private void RequestUpdateInvitingList(bool updateData = true)
		{
		}

		public void OnRejectAllButtonPressed()
		{
		}

		private void Update()
		{
		}

		private void SetTitleText()
		{
		}

		protected override void Start()
		{
		}

		private IEnumerator EnterCoroutine()
		{
			return null;
		}
	}
}
