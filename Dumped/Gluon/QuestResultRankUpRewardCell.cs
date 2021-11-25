using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRankUpRewardCell : TableViewCell<QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo>
	{
		[SerializeField]
		public Image icon;

		public Text title;

		[SerializeField]
		private Image gridImage;

		[SerializeField]
		private QuestStateIcon newIcon;

		[SerializeField]
		private QuestResultRankUpReward firstReward;

		[SerializeField]
		private QuestResultRankUpReward secondReward;

		public override void UpdateContent(QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo data)
		{
		}
	}
}
