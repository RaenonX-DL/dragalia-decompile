using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QRBonusRewardTableViewCell : TableViewCell<QuestResultModel.QuestBonus.QuestBonusInfo>
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text itemName;

		[SerializeField]
		private UnityEvent<int> buttonPressed;

		public override void UpdateContent(QuestResultModel.QuestBonus.QuestBonusInfo data)
		{
		}
	}
}
