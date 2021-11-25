using System;
using System.Collections.Generic;
using DG.Tweening;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillStepProgressUI : MonoBehaviour
	{
		[SerializeField]
		private MissionDrillTreasure originalTreasure;

		[SerializeField]
		private RectTransform treasureParent;

		[SerializeField]
		private MissionDrillTreasure completeTreasure;

		[SerializeField]
		private Image progressBarIcon;

		[SerializeField]
		private Image progressBarImage;

		[SerializeField]
		private Text progressText;

		[SerializeField]
		private bool isShowCompleteRewardOnly;

		[SerializeField]
		private MissionDrillStepProgressUIRewardParts rewardParts;

		[SerializeField]
		private float progressAnimationDuration;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		private int lastMissionPositionOffset;

		private FlashPlayer fadeFlashPlayer;

		[SerializeField]
		private Transform fadeFlashParent;

		private const string fadeFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillRewardChange";

		private Stack<MissionDrillTreasure> treasurePool;

		private List<MissionDrillTreasure> treasures;

		private bool isCompleteReward;

		private List<MissionTableViewData> missionTableViewDataList;

		private MissionDrillDataElement missionDrillData;

		private MissionDrillGroupElement missionDrillGroup;

		private string nextPickupRewardTextFormat;

		private UIAnimationBase uiAnimation;

		private string progressTextFormat;

		private Action onRewardReceived;

		private void Start()
		{
		}

		public void Setup(List<MissionTableViewData> missionTableViewDataList, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement currentMissionDrillData, string progressTextFormat, string nextPickupRewardTextFormat, bool isUnlockedGroup, Action onRewardReceived)
		{
		}

		private void SetupTreasure(List<MissionTableViewData> missionTableViewDataList, int totalMissionNum)
		{
		}

		private float GetProgressRatio(List<MissionTableViewData> missionTableViewDataList, int currentMissionStep)
		{
			return default(float);
		}

		private void SetupProgressBar(List<MissionTableViewData> missionTableViewDataList, int currentMissionStep)
		{
		}

		private void UpdateProgress(float progress)
		{
		}

		private void SetupReward(MissionDrillStepProgressUIRewardParts targetParts, List<MissionTableViewData> missionTableViewDataList, MissionTableViewData completeMissionData, int currentMissionStep, bool isUnlockedGroup)
		{
		}

		private void CreateTreasure(MissionTableViewData missionTableViewData, float ratio, MissionTableViewData.State state)
		{
		}

		private Vector3 GetPositionOnProgressBar(float ratio)
		{
			return default(Vector3);
		}

		private void PrepareFlash()
		{
		}

		public void PlayMissionCompleteAnimation(Sequence sequence, List<MissionTableViewData> nextMissionTableViewDataList, MissionDrillDataElement nextMissionDrillData)
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
