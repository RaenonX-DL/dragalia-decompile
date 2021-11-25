using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SpecialEventMenuCell : EventMenuCell
	{
		[SerializeField]
		private Image ribbonRaidImage;

		[SerializeField]
		private Image ribbonSpecialRaidImage;

		[SerializeField]
		private Image ribbonBuildImage;

		[SerializeField]
		private Image ribbonStoryImage;

		[SerializeField]
		private Image ribbonCombatImage;

		[SerializeField]
		private Image ribbonDefenceImage;

		[SerializeField]
		private Image ribbonArenaImage;

		[SerializeField]
		private Image ribbonTrainingImage;

		[SerializeField]
		private Image battleRoyalAvailableImage;

		[SerializeField]
		private Image ribbonEarnImage;

		public override void SetContent(QuestSelectInstance.QuestEventData eventData, bool isShowArrow, FlashPlayerManager flashPlayerManager)
		{
		}

		public override void OnCellTouched()
		{
		}
	}
}
