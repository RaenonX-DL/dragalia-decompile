using System;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildReportDetailPopup : PopupBase
	{
		[SerializeField]
		[Header("Components")]
		public InputField commentInput;

		public Text maxCharText;

		public Text inputCharText;

		public Text selectCategoryText;

		public Button okButton;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReportDetailPopup";

		private Action<bool> onAnyActionDone;

		private GuildReportConfirmPopup.ReportData reportData;

		private CommonReportCategoryElement[] _cats;

		private const int maxChar = 200;

		private int selectCategoryListIndex;

		private CommonReportCategoryElement[] cats => null;

		public static GuildReportDetailPopup Create(GuildReportConfirmPopup.ReportData reportData, Action<bool> onAnyActionDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		private void SetInputChar(int count)
		{
		}

		public void OnValueChanged(string text)
		{
		}

		public void OnEndEdit(string text)
		{
		}

		private Task<GuildChatPostReportResponse> RequestPostReport(string message, int cateoryId)
		{
			return null;
		}

		private Task<GuildPostReportResponse> RequestCommonPostReport(string message, int cateoryId)
		{
			return null;
		}

		public void OnCategorySelectButtonPressed()
		{
		}
	}
}
