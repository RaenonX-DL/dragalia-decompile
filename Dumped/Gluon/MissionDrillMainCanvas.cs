using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using Gluon.Mission.ListView;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillMainCanvas : AnimationUICanvas
	{
		[SerializeField]
		private MissionDrillDetailUI detail;

		[SerializeField]
		private MissionDrillStepProgressUI stepProgress;

		[SerializeField]
		private MissionDrillStepButton stepButton;

		[SerializeField]
		private ButtonWithSelectedImage receiveButtonSelectedImage;

		[SerializeField]
		private Badge receiveButtonBadge;

		[SerializeField]
		private Button receiveButton;

		[SerializeField]
		private GameObject nhaamSmallRoot;

		[SerializeField]
		private Text nhaamTalkText;

		[SerializeField]
		private float animationStartDelay;

		[SerializeField]
		private AnimationUITalkWindow talkWindowAnimation;

		private List<MissionTableViewData> missionTableViewDataList;

		private SkeletonGraphic nhaamSmallSkeletonGraphic;

		private DrillTalkElement currentTalk;

		private Action<DrillTalkElement> onPlayCompleteDirection;

		private const string nhaamSmallAnimationPath = "Prefabs/OutGame/MissionDrill/pf_TeacherNhaamSmall";

		private const string prefsKeyCompleteDirectionShown = "MissionDrillMainCanvas/CompleteDirectionShown_{0}";

		private const string prefsKeyMissionCompleteDirectionShown = "MissionDrillMainCanvas/LastDirectionShownMissionId_{0}";

		private const string prefsKeyStepUnlockDirectionShown = "MissionDrillMainCanvas/StepUnlockDirectionShown_{0}";

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void StartAnimation()
		{
		}

		private IEnumerator MissionCompleteAnimationCoroutine()
		{
			return null;
		}

		private IEnumerator StartMissionCompleteDirection()
		{
			return null;
		}

		private IEnumerator StartStepUnlockDirection()
		{
			return null;
		}

		private IEnumerator StartNextStepDirection()
		{
			return null;
		}

		private void ShowNhaam()
		{
		}

		private bool IsNhaamCompleteDirectionRequired()
		{
			return default(bool);
		}

		private void ShownNhaamCompleteDirection()
		{
		}

		public void OnCompleteDirectionFinished()
		{
		}

		public void Initialize(Action<DrillTalkElement> onPlayComplete)
		{
		}

		public void Setup()
		{
		}

		private void UpdateReceiveButton()
		{
		}

		private int GetMissionCompleteDirectionShownMissionId(int groupId)
		{
			return default(int);
		}

		private void SetMissionCompleteDirectionShownMissionId(int groupId, int missionId)
		{
		}

		private bool IsMissionCompleteDirectionRequired()
		{
			return default(bool);
		}

		private bool IsStepUnlockDirectionRequired()
		{
			return default(bool);
		}

		private void ShownStepUnlockDirection()
		{
		}

		private void PlayCompleteDirection(DrillTalkElement playTalk)
		{
		}

		public void PlayNhaamSmallTalk(bool isPlayEnter)
		{
		}

		private void PlayNhaamSmallTalk(DrillTalkElement playTalk, bool isPlayEnter)
		{
		}

		private void PlayNhaamSmallEnterAnimation(DrillTalkElement playTalk, bool isPlayEnter)
		{
		}

		private void PlayNhaamSmallEnterAnimation([Optional] Action onComplete)
		{
		}

		public void PlayNhaamSmallExitAnimation([Optional] Action onComplete)
		{
		}

		private List<MissionTableViewData> GetReceivableMissionDataList()
		{
			return null;
		}

		public void OnMissionListButtonPressed()
		{
		}

		public void OnStepButtonClicked()
		{
		}

		public void OnDorahaziButtonClicked()
		{
		}

		public void OnAllReceiveButtonClicked()
		{
		}

		private void StartTutorialCheck(Action onCheckEnd)
		{
		}

		private IEnumerator DrillTutorialCoroutine(Action onCheckEnd)
		{
			return null;
		}

		private void PlayTalkWindowEnterAnimation()
		{
		}

		private void PlayTalkWindowExitAnimation()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void EnableDebugMenu(bool enable)
		{
		}
	}
}
