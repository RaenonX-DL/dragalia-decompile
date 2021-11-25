using System.Text;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestConditionPopup : CommonPopup
	{
		[SerializeField]
		public Text uiTitle;

		public Text uiConditionTitle;

		public Text uiConditionText;

		public static EventQuestConditionPopup Create(int questId, StringBuilder requiredConditionText, UnityAction onCloseCallback, bool showBlackLayer = true)
		{
			return null;
		}

		private void ReflectParam(QuestDataElement qde, StringBuilder requiredConditionText)
		{
		}
	}
}
