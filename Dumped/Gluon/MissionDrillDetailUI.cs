using DG.Tweening;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillDetailUI : MonoBehaviour
	{
		[SerializeField]
		private Text missionGroupTitleText;

		[SerializeField]
		private MissionDrillDetailUIFadeParts currentParts;

		[SerializeField]
		private MissionDrillDetailUIFadeParts nextParts;

		[SerializeField]
		private Image challengeButtonImage;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		private CanvasGroup stampFlashParentCanvasGroup;

		private MissionDrillDetailUIFadeParts activeParts;

		private FlashPlayer stampFlash;

		private const string stampFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillStamp";

		private UIAnimationBase uiAnimation;

		private void Start()
		{
		}

		public void Setup(MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData)
		{
		}

		private void Setup(MissionDrillDetailUIFadeParts parts, MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData, float alpha)
		{
		}

		private void PrepareFlash()
		{
		}

		public void PlayMissionCompleteAnimation(Sequence sequence, MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData)
		{
		}

		public void OnChallangeButtonClicked()
		{
		}

		public void PlayEnterAnimation()
		{
		}

		public void PlayExitAnimation()
		{
		}

		public bool IsAnimationRunning()
		{
			return default(bool);
		}
	}
}
