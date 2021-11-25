using DG.Tweening;
using Gluon.Master;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillDetailUIFadeParts : MonoBehaviour
	{
		[SerializeField]
		private Image missionIcon;

		[SerializeField]
		private Text missionTitleText;

		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private MissionWidgetAchievement achievementWidget;

		[SerializeField]
		private GameObject missionContentRoot;

		[SerializeField]
		private GameObject missionBackground;

		[SerializeField]
		private GameObject completeBackground;

		[SerializeField]
		private GameObject allCompleteBackground;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private MissionTableViewData missionTableViewData;

		private MissionDrillDataElement missionDrillData;

		private MissionDrillGroupElement missionDrillGroup;

		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, float alpha)
		{
		}

		public void OnDetailButtonClicked()
		{
		}

		public void OnChallangeButtonClicked()
		{
		}

		public void OnRewardIconClicked()
		{
		}

		public void PlayFadeInAnimation(Sequence sequence, float duration)
		{
		}
	}
}
