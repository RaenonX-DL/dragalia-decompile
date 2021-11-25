using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildInviteConfirmPopup : PopupBase
	{
		[SerializeField]
		private Transform guildInfoParent;

		[SerializeField]
		private Text inviteText;

		[SerializeField]
		private Transform playerInfoParent;

		[SerializeField]
		private GameObject cautionMessageObject;

		private Action onConfirmInvite;

		private GuildInfoCellData guildInfo;

		private GuildModel.MemberInfo playerInfo;

		private const string prefabPath = "Prefabs/OutGame/Guild/GuildInviteConfirmPopup";

		public static GuildInviteConfirmPopup Create()
		{
			return null;
		}

		public void Setup(GuildInfoCellData guildInfo, GuildModel.MemberInfo playerInfo, Action onConfirmInvite)
		{
		}

		private void SetGuildInfoCell(GuildInfoCellData guildInfo)
		{
		}

		private void SetInviteText(int num)
		{
		}

		private void SetPlayerInfo(GuildModel.MemberInfo playerInfo)
		{
		}

		private void SetCautionButtonState()
		{
		}

		public void OnInviteConfirmButtonPressed()
		{
		}

		private void Apply(GuildInfoCellData data, [Optional] Action onApplyDone)
		{
		}
	}
}
