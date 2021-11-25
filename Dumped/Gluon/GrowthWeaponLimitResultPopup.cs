using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponLimitResultPopup : CommonPopup
	{
		public Text messageText;

		public CommonUnitIcon unitIcon;

		public GameObject limitBreakParamBase;

		public GameObject limitOverParamBase;

		public Text beforeLimitBreakText;

		public Text afterLimitBreakText;

		public Text beforeLimitOverText;

		public Text afterLimitOverText;

		public Action popAnimationEndedCallBack;

		private GrowthUnitEnhanceModel model;

		public static GrowthWeaponLimitResultPopup Create()
		{
			return null;
		}

		public void InitPopup(BuildupPieceType type, GrowthUnitEnhanceModel model, int beforeParam)
		{
		}

		private void SetLimitBreakResult(int beforeParam)
		{
		}

		private void SetLimitOverResult(int beforeParam)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
