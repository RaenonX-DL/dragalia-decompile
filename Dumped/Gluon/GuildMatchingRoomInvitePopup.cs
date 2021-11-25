using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GuildMatchingRoomInvitePopup : PopupBase
	{
		[SerializeField]
		private QuestResultMultiFriendList playerInfo;

		private MatchingService.Player player;

		private CommonFriendListCellData commonFriendListCellData;

		public static void Create(ulong viewerId, AtgenSupportUserDataDetail support, bool isGuildPopup = true)
		{
		}

		private void SetPlayerInfo(MatchingService.Player player, AtgenSupportUserDataDetail support)
		{
		}

		private void onRequestButton(int index)
		{
		}

		private CommonFriendListCellData GetCommonFriendListCellData(UserSupportList support, bool isFriend, bool isFriendApplying)
		{
			return null;
		}

		private void OnClose(bool onClose)
		{
		}

		private void OnInviteButton(int index)
		{
		}

		public static void CreateErrorPopup()
		{
		}
	}
}
