using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildReportConfirmPopup : PopupBase
	{
		public enum ReportAbuseType
		{
			Chat,
			Notice,
			Motto,
			GuildName
		}

		public struct ReportData
		{
			public ReportAbuseType type;

			public int guildId;

			public ulong chatId;

			public string content;

			public ReportData(ReportAbuseType type, int guildId, ulong chatId, string content)
			{
			}
		}

		[SerializeField]
		[Header("Components")]
		public Text contentText;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReportConfirmPopup";

		private Action<bool> onAnyActionDone;

		private ReportData reportData;

		public static GuildReportConfirmPopup Create(ReportData reportData, Action<bool> onAnyActionDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnReportButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
