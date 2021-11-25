using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class EventQuestListPageBase : EventQuestPageBase, ICustomMessage
	{
		public EventListCtrl eventListCtrl;

		[SerializeField]
		private float statusDelayTime;

		[SerializeField]
		private float statusExitDelayTime;

		[SerializeField]
		private GameObject buttonsParent;

		[SerializeField]
		private GameObject buttonsParent4;

		[SerializeField]
		[Header("ButtonCtrl")]
		private EventCommonButtonCtrl commonButtonCtrl;

		[SerializeField]
		private EventCommonButtonCtrl commonButtonCtrl4;

		[SerializeField]
		[Header("SubPage")]
		private Transform subPageContent;

		[SerializeField]
		private GameObject subPage;

		[SerializeField]
		private GameObject mainPage;

		[SerializeField]
		private UIAnimationPublisher subPageSwitchPublisher;

		[SerializeField]
		private UIAnimationPublisher mainPageSwitchPublisher;

		[SerializeField]
		private AnimationListOneCol subPageListAnimation;

		private const float waitSubPageChangeTime = 0.3f;

		private bool isInSubPage;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public void ReturnToMainPage()
		{
		}

		private IEnumerator ReturnToMainPageCoroutine()
		{
			return null;
		}

		public void GoSubPage(List<QuestEventMenuElement> cellData)
		{
		}

		private IEnumerator GoSubPageCoroutine(List<QuestEventMenuElement> cellData)
		{
			return null;
		}

		public void StartSubPageEnterAnimation(float delayTime = 0f)
		{
		}

		public void StartSubPageExitAnimation(float delayTime = 0f)
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		public void OnBackButtonTouched()
		{
		}

		private IEnumerator WaitForHideButtons(float delay)
		{
			return null;
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
