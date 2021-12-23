using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeTopPage : DmodePageBase
	{
		[SerializeField]
		private Image logo;

		[SerializeField]
		private Button dungeonStartButton;

		[SerializeField]
		private Button dungeonRestartButton;

		[SerializeField]
		private Text dungeonRestartText;

		[SerializeField]
		private ButtonWithSelectedImage dungeonRestartButtonWithSelectedImage;

		[SerializeField]
		private Button expeditionButton;

		[SerializeField]
		private Badge expeditionButtonBadge;

		[SerializeField]
		private GameObject expeditionRemainParent;

		[SerializeField]
		private Text expeditionRemainTimeText;

		[SerializeField]
		private GameObject expeditionRemainBg;

		[SerializeField]
		private GameObject expeditionRemainBg2Line;

		[SerializeField]
		private Button expeditionLockButton;

		[SerializeField]
		private ButtonWithSelectedImage expeditionButtonWithSelectedImage;

		[SerializeField]
		private ButtonWithSelectedImage missionButtonWithSelectedImage;

		[SerializeField]
		private Badge missionButtonBadge;

		[SerializeField]
		private Image pickupMissionBadge;

		[SerializeField]
		private Badge exchangeButtonBadge;

		[SerializeField]
		private Badge storyButtonBadge;

		private Coroutine expeditionTimerCoroutine;

		private static readonly string dmodeBgmName;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		protected virtual IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern)
		{
			return null;
		}

		public void SetExpeditionTimer()
		{
		}

		public void StopExpeditionTimer()
		{
		}

		private IEnumerator UpdateReBattle()
		{
			return null;
		}

		public static int GetExpeditionRemainSeconds()
		{
			return default(int);
		}

		private void OnBackButtonTouched()
		{
		}

		public void OnQuestPrepareButton()
		{
		}

		private IEnumerator GoToQuestPreparePage()
		{
			return null;
		}

		public void OnQuestRestartButton()
		{
		}

		private void OnRestartComfirm()
		{
		}

		private void OnSuspensionComfirm(bool isRestart)
		{
		}

		private void GoToResult(bool isGameOver)
		{
		}

		public void OnFafnirGrowthButton()
		{
		}

		public void OnExpeditionButton()
		{
		}

		public void OnExpeditionLockButton()
		{
		}

		private void FinishExpedition(bool bForce)
		{
		}

		private static Task SendExpeditionFinish()
		{
			return null;
		}

		private static Task SendExpeditionForceFinish()
		{
			return null;
		}

		private void ShowReturnFromExpeditionConfirmPopup(Action onOK, Action onCancel)
		{
		}

		private void GotoExpeditionPreparePage()
		{
		}

		public void OnExchangeButton()
		{
		}

		public void OnMissionButton()
		{
		}

		public void OnHolyTreeMemoryButton()
		{
		}

		private void UpdateDungeonButton()
		{
		}

		private void CheckBadge()
		{
		}

		private void UpdateExpeditionButtonBadge()
		{
		}

		private void UpdateExchangeButtonBadge()
		{
		}

		private void UpdateMissionBadge()
		{
		}

		private void UpdateStoryButtonBadge()
		{
		}
	}
}
