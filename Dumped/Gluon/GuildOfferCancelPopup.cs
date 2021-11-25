using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GuildOfferCancelPopup : PopupBase
	{
		[SerializeField]
		private Transform guildInfoParent;

		private GuildInfoCellData guildInfo;

		private const string prefabPath = "Prefabs/OutGame/Guild/GuildOfferCancelPopup";

		public static GuildOfferCancelPopup Create()
		{
			return null;
		}

		public void Setup(GuildData guildInfo)
		{
		}

		private void SetGuildInfoCell(GuildInfoCellData guildInfo)
		{
		}

		public void OnOfferCancelPressed()
		{
		}
	}
}
