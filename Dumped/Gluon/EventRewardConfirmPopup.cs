using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRewardConfirmPopup : PopupBase
	{
		[SerializeField]
		private Text title;

		[SerializeField]
		private GameObject rewardObj;

		[SerializeField]
		private GameObject allRewardText;

		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private Text rewardText;

		public void Init(bool isAllReward, GiftType giftType = GiftType.NONE, int itemId = 0)
		{
		}
	}
}
