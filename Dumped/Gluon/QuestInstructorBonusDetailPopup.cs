using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestInstructorBonusDetailPopup : PopupBase
	{
		[SerializeField]
		private Text charaNameText;

		[SerializeField]
		private Text charaText;

		[SerializeField]
		private QuestInstructorBonusDetailTargetRewardTableViewController tableView;

		[SerializeField]
		private ButtonWithSelectedImage howtoButtonWithSelectedImage;

		private const int eventPopId = 21099;

		private const int eventPopCount = 2;

		private static readonly string EventPrologueName;

		public static QuestInstructorBonusDetailPopup Create()
		{
			return null;
		}

		public void SetContent()
		{
		}

		public static bool IsQuestCarryQuestData(int eventId)
		{
			return default(bool);
		}

		public void OnClickEventInfo()
		{
		}
	}
}
