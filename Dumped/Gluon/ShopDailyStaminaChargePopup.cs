using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopDailyStaminaChargePopup : PopupBase
	{
		[SerializeField]
		public Text singleStaminaChargeStatusText;

		public Text multiStaminaChargeStatusText;

		public Button chargeButton;

		private Action onChargeDone;

		public static ShopDailyStaminaChargePopup Create(Action onChargeDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnChargeButtonPressed()
		{
		}
	}
}
