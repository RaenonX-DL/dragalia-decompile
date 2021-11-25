using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallTotalRewardPickupCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Text conditionText;

		[SerializeField]
		private Image haveReceivedImage;

		public void SetContents(QuestWallMonthlyRewardElement data, bool isReceived)
		{
		}
	}
}
