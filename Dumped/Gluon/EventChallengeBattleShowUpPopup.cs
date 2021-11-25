using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventChallengeBattleShowUpPopup : PopupBase
	{
		[SerializeField]
		private Image bannerImage;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text infoText;

		private const string popupPath = "Prefabs/OutGame/EventQuest/EventChallengeBattleShowUpPopup";

		public static EventChallengeBattleShowUpPopup Create(QuestEventMenuElement menuElement)
		{
			return null;
		}

		public void SetContent(QuestEventMenuElement menuElement)
		{
		}
	}
}
