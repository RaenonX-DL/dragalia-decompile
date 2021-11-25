using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryPopup : PopupBase
	{
		private enum CheckInfo
		{
			UserID,
			AppVersion,
			DeviceOS,
			DeviceName,
			Max
		}

		private const string prefabPath = "Prefabs/OutGame/TitleMenu/InquiryPopup";

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text CancelButtonText;

		[SerializeField]
		private Text OkButtonText;

		private string[] checkInfoStrings;

		private string urlFormat;

		public static InquiryPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnToggleClickedUserID(bool bOn)
		{
		}

		public void OnToggleClickedAppVersion(bool bOn)
		{
		}

		public void OnToggleClickedDeviceOS(bool bOn)
		{
		}

		public void OnToggleClickedDeviceName(bool bOn)
		{
		}
	}
}
