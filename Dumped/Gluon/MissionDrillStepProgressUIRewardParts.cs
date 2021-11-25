using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillStepProgressUIRewardParts : MonoBehaviour
	{
		[SerializeField]
		private GameObject pickupLabel;

		[SerializeField]
		private GameObject completeLabel;

		[SerializeField]
		private GameObject rewardContentRoot;

		[SerializeField]
		private GameObject stepCompleteContentRoot;

		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private Text nextPickupRewardText;

		private MissionTableViewData missionData;

		public void SetupPickupReward(string text, MissionTableViewData missionData)
		{
		}

		public void SetupCompleteReward(string text, MissionTableViewData missionData)
		{
		}

		public void SetupStepComplete()
		{
		}

		private void Setup(string text, MissionTableViewData missionData)
		{
		}

		public void OnRewardIconClicked()
		{
		}
	}
}
