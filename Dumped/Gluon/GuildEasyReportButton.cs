using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildEasyReportButton : MonoBehaviour
	{
		[SerializeField]
		public GuildReportConfirmPopup.ReportAbuseType type;

		public Button onClickEventButton;

		private PointerEventHandler eventHandler;

		private Text text;

		private bool isDeletedContent;

		public int targetGuildId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static GuildEasyReportButton BindToText(Text text, GuildReportConfirmPopup.ReportAbuseType type, int guildId, bool isDeletedContent, [Optional] Button onClickEventButton)
		{
			return null;
		}

		private void RefreshComponent()
		{
		}

		private void Start()
		{
		}

		public void OnLongTouched()
		{
		}
	}
}
