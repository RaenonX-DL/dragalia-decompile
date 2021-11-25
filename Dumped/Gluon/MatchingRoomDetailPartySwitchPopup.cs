using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomDetailPartySwitchPopup : PopupBase
	{
		[SerializeField]
		private RectTransform playerInfoRoot;

		[SerializeField]
		private Image emblemIcon;

		[SerializeField]
		private Text userName;

		[SerializeField]
		private Text userLevel;

		[SerializeField]
		private Text maxPower;

		[SerializeField]
		[Header("Guild")]
		public GameObject guildGO;

		public Text guildNameText;

		public RawImage guildEmblem;

		[SerializeField]
		private QuestResultMultiFriendList playerInfo1;

		[SerializeField]
		private QuestResultMultiFriendList playerInfo2;

		public Text partyPower1;

		public Text partyPower2;

		[SerializeField]
		private Button friendRequestButton;

		public Button guildInviteButton;

		public float playerInfoPositionYForNoInviteButton;

		private MatchingService.Player player;

		private CommonFriendListCellData commonFriendListCellData;

		public static void Create(MatchingService.Player player, AtgenSupportUserDataDetail support, int memberIndex)
		{
		}

		public static void CreateSelf(MatchingService.Player player, int memberIndex)
		{
		}

		private void SetSelfInfo(MatchingService.Player player, int memberIndex)
		{
		}

		private void SetCharaInfo(MatchingService.Player player, AtgenSupportUserDataDetail support, int memberIndex)
		{
		}

		public void onRequestButton()
		{
		}

		private CommonFriendListCellData GetCommonFriendListCellData(UserSupportList support, bool isFriend, bool isFriendApplying)
		{
			return null;
		}

		private void OnClose(bool onClose)
		{
		}

		public void OnInviteButton(int index)
		{
		}

		public static void CreateErrorPopup()
		{
		}

		private void SetSpriteNameData(int playerAnotherNameId)
		{
		}

		private void SetGuildData(int guildId, string guildName, int guildEmblemId, bool isPenaltyGuildName)
		{
		}
	}
}
