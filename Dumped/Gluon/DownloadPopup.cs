using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DownloadPopup : CommonPopup
	{
		[SerializeField]
		private Text confirmText;

		[SerializeField]
		private Text downloadText;

		[SerializeField]
		private Text wifiText;

		[SerializeField]
		private Text helpText;

		private const string prefabPath = "UI/Popup/Download/DownloadPopup";

		public static DownloadPopup Create(bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public void SetText(long baseByte, string text = "", bool isNeedAddToPlay = false)
		{
		}
	}
}
