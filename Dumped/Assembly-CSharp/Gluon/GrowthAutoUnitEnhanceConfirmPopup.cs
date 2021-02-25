/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthAutoUnitEnhanceConfirmPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text topMessageText;
		public UnityEngine.UI.Text beforeHpText;
		public UnityEngine.UI.Text afterHpText;
		public GameObject hpTextUIBase;
		public UnityEngine.UI.Text beforeAtkText;
		public UnityEngine.UI.Text afterAtkText;
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
		public GameObject originCell;
		public Transform cellParentTransform;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public GameObject[] crestEnhanceDisabelUIObjects;
		public UnityEngine.UI.Text popHeadText;
		[CompilerGenerated]
		private int _totalReleaseCount_k__BackingField;
		[CompilerGenerated]
		private int _canReleaseBuildupCount_k__BackingField;
		[CompilerGenerated]
		private int[] _canReleasePassiveAilityIds_k__BackingField;
		[CompilerGenerated]
		private int _canReleaseSlotType1_k__BackingField;
		[CompilerGenerated]
		private int _canReleaseSlotType2_k__BackingField;
		[CompilerGenerated]
		private int _canReleaseSlotType3_k__BackingField;
		[CompilerGenerated]
		private int _canReleaseWeaponBonusCount_k__BackingField;
		private GrowthUnitEnhanceModel model;
		private int totalNeedRupi;
		private Dictionary<int, int> useMaterialDict;
		private readonly Color positiveColor;
		private readonly Color normalColor;
	
		// Properties
		public int totalReleaseCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int canReleaseBuildupCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int[] canReleasePassiveAilityIds { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int canReleaseSlotType1 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int canReleaseSlotType2 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int canReleaseSlotType3 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int canReleaseWeaponBonusCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public GrowthAutoUnitEnhanceConfirmPopup();
	
		// Methods
		public static GrowthAutoUnitEnhanceConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		private void SteupStatusParam();
		private void SetupWeaponPassiveAbility();
		private void SetupSlotCount();
		private void SetupWeaponBonus();
		private void SetupMaterialCell();
		private void SetupRupi();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
	}
}
