using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonPage : EventQuestPageBase
	{
		public const int ResetItemSequence = 5;

		[SerializeField]
		private Transform edgeToEdgeTrans;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Button summonButton;

		[SerializeField]
		private GameObject eventSummonReward;

		[SerializeField]
		private Image eventSummonRewardImage2;

		[SerializeField]
		private RectTransform eventSummonRewardMover;

		[SerializeField]
		private Image eventSummonPickup2;

		[SerializeField]
		private Image eventSummonPickup1Bg;

		[SerializeField]
		private Image eventSummonPickup1Text;

		[SerializeField]
		private Image eventSummonPickup1Duration;

		[SerializeField]
		private GameObject rewardItemTemplate;

		[SerializeField]
		private Text durationText;

		[SerializeField]
		private Text pointRemain;

		[SerializeField]
		private Text pointCost;

		[SerializeField]
		private BoxSummonItem[] summonItems;

		private bool isSetupContents;

		protected override void Awake()
		{
		}

		public static bool IsLongLayout()
		{
			return default(bool);
		}

		private void Start()
		{
		}

		public override void ResetSummonData()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		private void SetupContents()
		{
		}

		private void SetupEventSummonMainReward()
		{
		}

		private void SetupSummonData()
		{
		}

		private void SetupEventPeriod()
		{
		}

		private void SetupPointReamin()
		{
		}

		private void SetupPointCost()
		{
		}

		private void ResetSummonButton()
		{
		}

		public void OnContentButtonTouched()
		{
		}

		public void OnSummonButtonTouched()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitForSetupContents(AnimationPattern animationPattern, Action onAnimationDone, [Optional] Action onCutOff)
		{
			return null;
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		protected override int GetMaxExecCount()
		{
			return default(int);
		}
	}
}
