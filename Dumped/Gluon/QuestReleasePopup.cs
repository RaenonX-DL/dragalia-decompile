using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestReleasePopup : CommonPopup
	{
		[SerializeField]
		public Text uiTitle;

		public Text uiMainText;

		public static QuestReleasePopup Create(string title, string msg, bool showBlackLayer = true, [Optional] UnityAction OnCloseCallback)
		{
			return null;
		}
	}
}
