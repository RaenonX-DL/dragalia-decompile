using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QREventRewardPopup : PopupBase
	{
		[SerializeField]
		private Transform cellTransform;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text randomInfoText;

		[SerializeField]
		private Text buildInfoText;

		protected override void Start()
		{
		}

		public void SetText(string title, string text)
		{
		}

		public void SetContent(List<MazeEventRewardElement> gotRewards)
		{
		}

		public void SetContent(int eventId, List<BuildEventRewardElement> gotRewards)
		{
		}

		public void SetContent(List<QuestResultModel.QuestBonus.QuestBonusInfo> rewardList)
		{
		}

		public static string GetEventItemName()
		{
			return null;
		}
	}
}
