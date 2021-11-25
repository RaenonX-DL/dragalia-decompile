using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventRewardPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/EventQuest/TimeAttack/QuestEventRewardPopup";

		[SerializeField]
		private Text popupTitleText;

		[SerializeField]
		private Image logoImage;

		[SerializeField]
		private QuestEventRewardCtrl rewardCtrl;

		[SerializeField]
		private GameObject rankingInfo;

		[SerializeField]
		private Text tierRankingText;

		[SerializeField]
		private Text myBestTimeSoloText;

		public static QuestEventRewardPopup Create(QuestEventElement qee)
		{
			return null;
		}

		public void UpdateReceiveButtonInformation()
		{
		}

		public void SetContent(QuestEventElement qee)
		{
		}
	}
}
