using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LotteryLetterMain : PageBase
	{
		public Button skipButton;

		[SerializeField]
		private GameObject tapToNextItem;

		private Action onSkipButtonPlessed;

		public void TapToNextItemEnable(bool isActive)
		{
		}

		public void SetSkipButtonAction(Action onSkip)
		{
		}

		public void OnSkipButtonPlessed()
		{
		}
	}
}
