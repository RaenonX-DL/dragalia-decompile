using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QREventRewardCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text nameText;

		public void SetContent(MazeEventRewardElement reward)
		{
		}

		public void SetContent(BuildEventRewardElement reward)
		{
		}

		public void SetContent(GiftType rewardEntityType, int rewardEntityId, int rewardEntityQuantity)
		{
		}
	}
}
