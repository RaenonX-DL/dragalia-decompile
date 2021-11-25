using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventExchangePage : EventQuestPageBase
	{
		[SerializeField]
		private Transform exchangeTrans;

		[SerializeField]
		private Image logoImage;

		[SerializeField]
		private float topMargin;

		[SerializeField]
		private Text durationText;

		public Transform edgeToEdgeTransform;

		private ShopTradeEventTradeShopView tradeShop;

		private int defaultSelectTabIndex;

		private void Start()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitforLoadShopTradeEventTradeShopView(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
			return null;
		}

		public void OnBackButtonTouched()
		{
		}
	}
}
