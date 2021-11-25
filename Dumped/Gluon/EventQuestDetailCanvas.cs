using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestDetailCanvas : AnimationUICanvas
	{
		[SerializeField]
		private EventQuestDetailHeader eventDetailBanner;

		[SerializeField]
		private Image questBg;

		[SerializeField]
		private float questBgFadeinTime;

		[SerializeField]
		private float questBgFadeoutTime;

		private void Start()
		{
		}

		public void ShowScreenshotBackImage()
		{
		}

		public void HideScreenshotBackImage()
		{
		}

		public void SetQuestEventGroup(int eventId, Clb01EventLocationElement location, Action onCompleted)
		{
		}

		private IEnumerator SetQuestEventCoroutine(int eventId, Clb01EventLocationElement location, Action onCompleted)
		{
			return null;
		}

		public void SetQuestEventGroup(int eventId, CombatEventLocationElement location, Action onCompleted)
		{
		}

		private IEnumerator SetQuestEventCoroutine(int eventId, CombatEventLocationElement location, Action onCompleted)
		{
			return null;
		}

		public void SetQuestBanner(int eventId, int topImageId)
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void OnSupportPageActive()
		{
		}

		public void OnSupportPageExitAnimation()
		{
		}

		public void BackButtonPressed()
		{
		}
	}
}
