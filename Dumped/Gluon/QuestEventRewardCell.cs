using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventRewardCell : TableViewCell<QuestEventRewardCellData>
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text conditionText;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Button receiptButton;

		[SerializeField]
		private Image pickupImage;

		[SerializeField]
		private Image haveReceivedImage;

		private int rewardId;

		private QuestEventRewardCellData data;

		public override void UpdateContent(QuestEventRewardCellData itemData)
		{
		}
	}
}
