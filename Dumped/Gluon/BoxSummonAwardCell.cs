using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonAwardCell : TableViewCell<EventRewardCellData>
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

		private EventRewardCellData data;

		public override void UpdateContent(EventRewardCellData itemData)
		{
		}

		public void OnReceipButtonTouched()
		{
		}

		public void UpdateCanReceiveInformation()
		{
		}

		private void SetGotState(bool hadGot)
		{
		}
	}
}
