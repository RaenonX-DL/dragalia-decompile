using Cute.Http;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuOptoutPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Menu/MenuOptoutPopup";

		public Toggle sendUsageInfoToggle;

		public Text checkBoxText;

		public static MenuOptoutPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnToggleClickedSendUsageInfo(bool bOn)
		{
		}

		private void RequestUserOptOutSetting(UnityAction successCallback)
		{
		}

		public static void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
