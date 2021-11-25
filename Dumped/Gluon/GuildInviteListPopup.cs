using System;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildInviteListPopup : PopupBase
	{
		[SerializeField]
		[Header("Recommended")]
		private GuildInfoTableViewController searchList;

		[SerializeField]
		private Button ArrDenyButton;

		[SerializeField]
		private Text noMessageText;

		private List<GuildInfoCellData> cellDataList;

		private AtgenGuildInviteParamsList[] guildInviteParamsList;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildInviteListPopup";

		public static void Create()
		{
		}

		public static GuildInviteListPopup Create(DataManager.GameData<GuildInviteReceiveList> dataList)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCellPressed(GuildInfoCellData data)
		{
		}

		private static void RequestGuildList(Action onFinished)
		{
		}

		private static AtgenGuildInviteParamsList[] GetAtgenGuildInviteParamsList(DataManager.GameData<GuildInviteReceiveList> dataList)
		{
			return null;
		}

		private void UpdateList()
		{
		}

		public void OnPressAllDenyButton()
		{
		}

		private void RejectAction(GuildInfoCellData cellData)
		{
		}

		private void OnRejectRequest(GuildInfoCellData data, Action onFinished)
		{
		}
	}
}
