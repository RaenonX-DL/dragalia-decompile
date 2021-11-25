using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class TutorialSummonPage : TutorialSummonPageBase
	{
		[SerializeField]
		private Transform edgeToEdgeTrans;

		private bool isSetupContents;

		protected override void Awake()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		private void SetupContents()
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

		public void OnOddsButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		private void CreateDetailPopup()
		{
		}

		public void OnSummonButtonPressed()
		{
		}
	}
}
