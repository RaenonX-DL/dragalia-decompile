using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallGetRewardCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private Text rewardText;

		public void SetContents(QuestWallModel.QuestWallRewardData rewardData)
		{
		}
	}
}
