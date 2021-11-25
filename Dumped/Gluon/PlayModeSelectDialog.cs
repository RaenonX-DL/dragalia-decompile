using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PlayModeSelectDialog : CommonPopup
	{
		public Button soloPlayButton;

		public Button multiPlayButton;

		public UnityEvent soloButtonCallBack;

		public UnityEvent multiButtonCallBack;

		public static PlayModeSelectDialog Create([Optional] UnityAction OnOKCallback, bool showBlackLayer = true)
		{
			return null;
		}

		public void SetMessageText(string message)
		{
		}

		public void SoloButtonPressed()
		{
		}

		public void MultiButtonPressed()
		{
		}
	}
}
