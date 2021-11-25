using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthAutoUnitEnhanceResultPopup : CommonPopup
	{
		public Text topMessageText;

		public Text beforeHpText;

		public Text afterHpText;

		public Text beforeAtkText;

		public Text afterAtkText;

		public GameObject hpTextUIBase;

		public GameObject atkTextUIBase;

		public Text beforeWeaponAbilityCount;

		public Text afterWeaponAbilityCount;

		public GameObject WeaponAbilityUIBase;

		public Image breforeType1SlotImage;

		public Text breforeType1SlotText;

		public Image breforeType2SlotImage;

		public Text breforeType2SlotText;

		public Image breforeType3SlotImage;

		public Text breforeType3SlotText;

		public Image afterType1SlotImage;

		public Text afterType1SlotText;

		public Image afterType2SlotImage;

		public Text afterType2SlotText;

		public Image afterType3SlotImage;

		public Text afterType3SlotText;

		public GameObject WeaponSlotTypeUIBase;

		public Text beforeWeaponBonusHpText;

		public Text afterWeaponBonusHpText;

		public Text beforeWeaponBonusAtkText;

		public Text afterWeaponBonusAtkText;

		public GameObject WeaponBonusHpUIBase;

		public GameObject WeaponBonusAtkUIBase;

		public GameObject[] crestEnhanceDisabelUIObjects;

		public Text popHeadText;

		public Action popAnimationEndedCallBack;

		private GrowthUnitEnhanceModel model;

		private readonly Color positiveColor;

		private readonly Color normalColor;

		public static GrowthAutoUnitEnhanceResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int totalReleaseCount, int beforeBuildup, int beforePassiveAbilityCount = 0, int beforeType1Slot = 0, int beforeType2Slot = 0, int beforeType3Slot = 0, float beforeBonusHpParam = 0f, float beforeBonusAtkParam = 0f)
		{
		}

		private void SetupStatusResult(int beforeBuildup)
		{
		}

		private void SetupSlotCount(int beforeType1Slot, int beforeType2Slot, int beforeType3Slot)
		{
		}

		private void SetupBonusParam(float beforeBonusHpParam, float beforeBonusAtkParam)
		{
		}

		private void SetText(Text beforeText, Text afterText, int before, int after)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
