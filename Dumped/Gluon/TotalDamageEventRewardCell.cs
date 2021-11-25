using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TotalDamageEventRewardCell : TableViewCell<EventRewardCellData>
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text conditionText;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Image pickupImage;

		[SerializeField]
		private Image haveReceivedImage;

		private int rewardId;

		private EventRewardCellData data;

		public override void UpdateContent(EventRewardCellData itemData)
		{
		}

		private void UpdateCanReceiveInformation()
		{
		}

		private void SetGotState(bool hadGot)
		{
		}
	}
}
