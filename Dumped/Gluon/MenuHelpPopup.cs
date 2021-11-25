using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuHelpPopup : CommonPopup, ICustomMessage
	{
		[SerializeField]
		private Text helpText;

		[SerializeField]
		private Text suggestionBoxText;

		[SerializeField]
		private Text faqText;

		[SerializeField]
		private Badge inquireBadge;

		public MenuPopup menuPopup;

		public static MenuHelpPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		private void OnDisable()
		{
		}

		public void OnHelpButtonPressed()
		{
		}

		public void OnSuggestionBoxButtonPressed()
		{
		}

		public void OnFaqButtonPressed()
		{
		}

		public void OnInquiryButtonPressed()
		{
		}

		public void OnSummonHistoryPressed()
		{
		}

		public void UpdateBadge()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
