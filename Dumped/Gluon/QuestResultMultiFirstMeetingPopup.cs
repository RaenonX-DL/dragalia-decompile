using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultMultiFirstMeetingPopup : PopupBase
	{
		[SerializeField]
		private Transform commonIconTrans;

		[SerializeField]
		private Text itemName;

		[SerializeField]
		private Text firstMeetingText;

		protected override void Start()
		{
		}
	}
}
