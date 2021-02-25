/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthAutoUnitEnhanceResultPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text topMessageText;
		public UnityEngine.UI.Text beforeHpText;
		public UnityEngine.UI.Text afterHpText;
		public UnityEngine.UI.Text beforeAtkText;
		public UnityEngine.UI.Text afterAtkText;
		public GameObject hpTextUIBase;
		public GameObject atkTextUIBase;
		public UnityEngine.UI.Text beforeWeaponAbilityCount;
		public UnityEngine.UI.Text afterWeaponAbilityCount;
		public GameObject WeaponAbilityUIBase;
		public Image breforeType1SlotImage;
		public UnityEngine.UI.Text breforeType1SlotText;
		public Image breforeType2SlotImage;
		public UnityEngine.UI.Text breforeType2SlotText;
		public Image breforeType3SlotImage;
		public UnityEngine.UI.Text breforeType3SlotText;
		public Image afterType1SlotImage;
		public UnityEngine.UI.Text afterType1SlotText;
		public Image afterType2SlotImage;
		public UnityEngine.UI.Text afterType2SlotText;
		public Image afterType3SlotImage;
		public UnityEngine.UI.Text afterType3SlotText;
		public GameObject WeaponSlotTypeUIBase;
		public UnityEngine.UI.Text beforeWeaponBonusHpText;
		public UnityEngine.UI.Text afterWeaponBonusHpText;
		public UnityEngine.UI.Text beforeWeaponBonusAtkText;
		public UnityEngine.UI.Text afterWeaponBonusAtkText;
		public GameObject WeaponBonusHpUIBase;
		public GameObject WeaponBonusAtkUIBase;
		public GameObject[] crestEnhanceDisabelUIObjects;
		public UnityEngine.UI.Text popHeadText;
		public Action popAnimationEndedCallBack;
		private GrowthUnitEnhanceModel model;
		private readonly Color positiveColor;
		private readonly Color normalColor;
	
		// Constructors
		public GrowthAutoUnitEnhanceResultPopup();
	
		// Methods
		public static GrowthAutoUnitEnhanceResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, int totalReleaseCount, int beforeBuildup, int beforePassiveAbilityCount = 0, int beforeType1Slot = 0, int beforeType2Slot = 0, int beforeType3Slot = 0, float beforeBonusHpParam = 0f, float beforeBonusAtkParam = 0f);
		private void SetupStatusResult(int beforeBuildup);
		private void SetupSlotCount(int beforeType1Slot, int beforeType2Slot, int beforeType3Slot);
		private void SetupBonusParam(float beforeBonusHpParam, float beforeBonusAtkParam);
		private void SetText(UnityEngine.UI.Text beforeText, UnityEngine.UI.Text afterText, int before, int after);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__41_0();
	}
}
