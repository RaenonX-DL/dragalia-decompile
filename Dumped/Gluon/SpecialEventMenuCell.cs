using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SpecialEventMenuCell : EventMenuCell
	{
		private enum QuestRibbonImageType
		{
			None = 0,
			Raid = 20401,
			Build = 20801,
			Story = 21301,
			Combat = 22201,
			Defence = 22202,
			Arena = 22203,
			Earn = 22901,
			Training = 31001
		}

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
