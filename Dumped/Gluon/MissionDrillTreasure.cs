using System;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillTreasure : MonoBehaviour
	{
		[SerializeField]
		private Image openedImage;

		[SerializeField]
		private Image closedImage;

		[SerializeField]
		private Image receivableImage;

		[SerializeField]
		private Button button;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		private string popupTitle;

		private MissionTableViewData missionTableViewData;

		private MissionDrillGroupElement missionDrillGroup;

		private Action onRewardReceived;

		private FlashPlayer flashPlayer;

		private const string pickupTreasureFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillTreasureBox";

		private const string completeTreasureFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillTreasureBoxComplete";

		private void PrepareFlash(bool isCompleteReward)
		{
		}

		private void ResetFlash()
		{
		}

		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, string popupTitle, MissionTableViewData.State state, bool isCompleteReward, Action onRewardReceived)
		{
		}

		public void SetState(MissionTableViewData.State state)
		{
		}

		public void PlayEffect(MissionTableViewData.State state)
		{
		}

		public void SetMissionTableViewData(MissionTableViewData missionTableViewData)
		{
		}

		public MissionTableViewData GetMissionTableViewData()
		{
			return null;
		}

		public void OnClicked()
		{
		}
	}
}
