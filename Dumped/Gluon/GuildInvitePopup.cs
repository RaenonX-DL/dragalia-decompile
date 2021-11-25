using UnityEngine;

namespace Gluon
{
	public class GuildInvitePopup : PopupBase
	{
		[SerializeField]
		private Transform guildInfoParent;

		[SerializeField]
		private CommonSettingToggleBase[] inviteMessageToggles;

		[SerializeField]
		private Transform playerInfoParent;

		private GuildInfoCellData guildInfo;

		private GuildModel.MemberInfo playerInfo;

		private const string prefabPath = "Prefabs/OutGame/Guild/GuildInvitePopup";

		public static GuildInvitePopup Create()
		{
			return null;
		}

		public void Setup(GuildInfoCellData guildInfo, GuildModel.MemberInfo playerInfo)
		{
		}

		private void SetGuildInfoCell(GuildInfoCellData guildInfo)
		{
		}

		private void SetPlayerInfo(GuildModel.MemberInfo playerInfo)
		{
		}

		public void OnToggleChanged(int num)
		{
		}

		public void OnInviteButtonPressed()
		{
		}

		private int GetMessageId()
		{
			return default(int);
		}
	}
}
