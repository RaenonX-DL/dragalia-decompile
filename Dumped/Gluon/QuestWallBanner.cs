using System;
using Cute.Http;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallBanner : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon rewardIcon;

		[SerializeField]
		private Text totalLevel;

		[SerializeField]
		private Image logo;

		[SerializeField]
		private ButtonWithSelectedImage rewardButtonWithSelectedImage;

		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;

		[SerializeField]
		private ButtonWithSelectedImage questWallHowToReset;

		[SerializeField]
		private Text rewardDestriptionText;

		[SerializeField]
		private GameObject pickupImage;

		[SerializeField]
		private GameObject nextPickupParent;

		[SerializeField]
		private AnimationUIAutoPublisher animationPublisher;

		private int groupId;

		private FlRoot effectFlash;

		private GameObject flashEffect;

		private const int detailId = 20000;

		public void SetContents(int groupId)
		{
		}

		public void SetMotionPause()
		{
		}

		public void SetMotionPlay()
		{
		}

		public void OnRewardButtonClick()
		{
		}

		public void OnQuestDetail()
		{
		}

		public void OnHowToButtonTouched()
		{
		}

		private void WallGetMonthlyRewardRequest()
		{
		}

		private void RewardButtonResetPressedState()
		{
		}

		private void OnError(ErrorType errorType, int resultCode)
		{
		}

		public void PlayEnterAnimation(Action onFinished)
		{
		}

		public void PlayExitAnimation(Action onFinished)
		{
		}
	}
}
