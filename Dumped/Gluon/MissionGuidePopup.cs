using UnityEngine;

namespace Gluon
{
	public class MissionGuidePopup : CommonPopup
	{
		[SerializeField]
		private MissionGuideListController missionGuideListController;

		[SerializeField]
		private MaintenanceButtonController maintenanceCtrl;

		public static MissionGuidePopup Create()
		{
			return null;
		}

		public void InitPopup()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		private void GoNowPlayChapter()
		{
		}

		private bool isContentClear(QuestType questType, int contentId)
		{
			return default(bool);
		}
	}
}
