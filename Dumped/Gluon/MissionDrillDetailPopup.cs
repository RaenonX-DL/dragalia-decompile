using System;
using Gluon.Master;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillDetailPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/MissionDrill/MissionDrillDetailPopup";

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Image missionIcon;

		[SerializeField]
		private Text descriptionText;

		[SerializeField]
		private MissionWidgetAchievement achievementWidget;

		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private Text rewardNameText;

		[SerializeField]
		private Text rubyText;

		private MissionTableViewData missionTableViewData;

		private Action onRewardReceivedCallback;

		private Action onChallengeButtonPressed;

		public static MissionDrillDetailPopup Create(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, UnityAction onClose, Action onChallengeButtonPressed, Action onRewardReceivedCallback)
		{
			return null;
		}

		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, Action onChallengeButtonPressed, Action onRewardReceivedCallback)
		{
		}

		public void OnCloseButtonClicked()
		{
		}

		public void OnOkButtonClicked()
		{
		}

		private void CreateConfirmPopup()
		{
		}
	}
}
