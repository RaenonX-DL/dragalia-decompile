using UnityEngine;

namespace Gluon
{
	public class GuildCreateOrJoinPopup : PopupBase
	{
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildCreateOrJoinPopup";

		[SerializeField]
		private GameObject inviteBadge;

		public static GuildCreateOrJoinPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCreateGuildButtonPressed()
		{
		}

		public void OnJoinGuildButtonPressed()
		{
		}

		public void OnCheckInviteGuildButtonPressed()
		{
		}
	}
}
