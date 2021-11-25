using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestStoryPopup : CommonPopup
	{
		[SerializeField]
		public Text uiTitle;

		public Text uiMainText;

		public Text downloadText;

		public Text wifiText;

		public Text helpText;

		public static QuestStoryPopup Create(int questID, QuestGroupType groupType, UnityAction<int, QuestGroupType> OnOkCallback, UnityAction OnCancelCallback, bool showBlackLayer = true)
		{
			return null;
		}

		public void ReflectParam(int questID)
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		public void SetDownloadText(long baseByte)
		{
		}
	}
}
