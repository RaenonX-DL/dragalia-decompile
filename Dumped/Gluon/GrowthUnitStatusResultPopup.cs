using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitStatusResultPopup : CommonPopup
	{
		public CommonUnitIcon unitIcon;

		public Text beforeHpText;

		public Text beforeHpPlusText;

		public Text afterHpText;

		public Text afterHpPlusText;

		public Text beforeAtkText;

		public Text beforeAtkPlusText;

		public Text afterAtkText;

		public Text afterAtkPlusText;

		public Text beforePowerText;

		public Text beforeTotalPlusText;

		public Text afterPowerText;

		public Text afterTotalPlusText;

		public Action popAnimationEndedCallBack;

		private GrowthUnitEnhanceModel model;

		private static readonly Color positiveColor;

		private static readonly Color normalColor;

		public static GrowthUnitStatusResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int beforeBuildup, int beforePower)
		{
		}

		private void SetupWeaponStatus(int beforeBuildup, int beforePower)
		{
		}

		private void SetupCrestStatus(int beforeBuildup, int beforePower)
		{
		}

		private void SetText(Text beforeText, Text beforePlusText, Text afterText, Text afterPlusText, int before, int after, int plus)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
