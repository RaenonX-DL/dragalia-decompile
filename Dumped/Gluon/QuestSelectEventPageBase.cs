using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectEventPageBase : PageBase
	{
		[SerializeField]
		protected PageViewBase pageView;

		[SerializeField]
		protected Transform contentTransform;

		[SerializeField]
		protected RectTransform maskRectTransform;

		[SerializeField]
		public AnimationListOneCol listAnimation;

		[SerializeField]
		protected float duration;

		private Vector2 maskDefaultSize;

		[SerializeField]
		private float autoMovePageInterval;

		private float totalTime;

		protected bool canAutoMovePage;

		protected bool isAnimating;

		protected bool isEnableTouchGuardOnAnimation;

		private bool _initialized;

		protected NormalEventSelectScene questSelectScene;

		public bool initialized
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		protected void InitPageView(List<QuestSelectInstance.QuestEventData> recommendEventsData)
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitForPageViewInited()
		{
			return null;
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private void Update()
		{
		}
	}
}
