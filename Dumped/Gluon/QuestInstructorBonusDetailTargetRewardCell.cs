using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestInstructorBonusDetailTargetRewardCell : TableViewCell<QuestInstructorBonusDetailTargetReward>
	{
		[SerializeField]
		private Text questName;

		[SerializeField]
		private Text questLastCount;

		[SerializeField]
		private GameObject[] stampBox;

		[SerializeField]
		private Image[] stampImage;

		public override void UpdateContent(QuestInstructorBonusDetailTargetReward data)
		{
		}
	}
}
