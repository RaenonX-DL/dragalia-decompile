/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AutoPartySelectDialog : CommonPopup
	{
		// Fields
		public const string partyEditConfigElementKey = "PartyEditConfigElementKey";
		public const string partyEditConfigPriorityKey = "PartyEditConfigPriorityKey";
		public const string partyEditConfigTargetKey = "PartyEditConfigTargetKey";
		public const string charaEditConfigElementKey = "CharaEditConfigElementKey";
		public const string charaEditConfigPriorityKey = "CharaEditConfigPriorityKey";
		public const string charaEditConfigTargetKey = "CharaEditConfigTargetKey";
		public const string equipEditConfigElementKey = "EquipEditConfigElementKey";
		public const string equipEditConfigPriorityKey = "EquipEditConfigPriorityKey";
		public const string equipEditConfigTargetKey = "EquipEditConfigTargetKey";
		public Button[] elementButtons;
		public Image[] elementSelectImage;
		public Button[] priorityButtons;
		public Image[] prioritySelectImage;
		public Sprite priorityButtonCheckSprite;
		public Sprite priorityButtonCheckOutSprite;
		public UnityEngine.UI.Text[] priorityText;
		public Toggle allTargetToggle;
		public UnityEngine.UI.Text allTargetText;
		public GameObject partyLayout;
		public Toggle charaTargetToggle1;
		public Toggle dragonTargetToggle1;
		public Toggle weaponTargetToggle1;
		public Toggle amuletTargetToggle1;
		public UnityEngine.UI.Text charaTargetText1;
		public UnityEngine.UI.Text dragonTargetText1;
		public UnityEngine.UI.Text weaponTargetText1;
		public UnityEngine.UI.Text amuletTargetText1;
		public GameObject equipLayout;
		public Toggle weaponTargetToggle2;
		public Toggle dragonTargetToggle2;
		public Toggle amuletTargetToggle2;
		public UnityEngine.UI.Text weaponTargetText2;
		public UnityEngine.UI.Text dragonTargetText2;
		public UnityEngine.UI.Text amuletTargetText2;
		public UnityEngine.UI.Text[] subTitleText;
		[SerializeField]
		private GameObject questElementPanel;
		public UnityEngine.UI.Text selectElementText;
		public Image questElementIcon;
		public UnityEngine.UI.Text questElementText;
		[SerializeField]
		private GameObject explainTextSpaceObj;
		[SerializeField]
		private GameObject limitedWeaponTypePanel;
		[SerializeField]
		private GameObject limitedWeaponTypeIconPanel;
		[SerializeField]
		private Image limitedWeaponTypeBaseIcon;
		[SerializeField]
		private UnityEngine.UI.Text limitedWeaponTypeText;
		[SerializeField]
		private LocalizeTextLayoutPadding limitedWeaponTypeLayoutPadding;
		[SerializeField]
		private UnityEngine.UI.Text limitedWeaponTypeForCalcText;
		[SerializeField]
		private GameObject SelectElementTypeObject;
		[NonSerialized]
		public Toggle charaTargetToggle;
		[NonSerialized]
		public Toggle dragonTargetToggle;
		[NonSerialized]
		public Toggle weaponTargetToggle;
		[NonSerialized]
		public Toggle amuletTargetToggle;
		private AutoPartyConfigData selectData;
		private string saveElementKey;
		private string savePriorityKey;
		private string saveTargetKey;
	
		// Nested types
		public enum AutoSelectTarget
		{
			Chara = 0,
			Dragon = 1,
			Weapon = 2,
			Amulet = 3
		}
	
		public enum SceneType
		{
			PartyEdit = 0,
			EquipEdit = 1
		}
	
		// Constructors
		public AutoPartySelectDialog();
	
		// Methods
		public static AutoPartySelectDialog Create(bool showBlackLayer = true);
		public void SetupAutoPartyDialog(SceneType sceneType);
		public void ElementButtonPressed(int tag);
		public void PriorityButtonPressed(int tag);
		public void TargetButtonPressed(int tag, bool isOn);
		private void UpdateAllTargetToggle(bool isOn);
		public AutoPartyConfigData GetSelectData();
		public static void ClearConfigSaveData();
		public void SetQuestElement(ElementalType element);
		public void SetQuestLimitedElement(ElementalType element);
		public void SetQuestLimitedWeaponType(List<WeaponType> limitedWeaponTypeList);
		private void SaveAutoSelectConfigData();
		private void GetAutoSelectConfigData();
		private void UpdateDialogButtonState();
		private void SetupTargetToggle(SceneType sceneType);
		[CompilerGenerated]
		private void _SetupTargetToggle_b__71_0(bool isOn);
		[CompilerGenerated]
		private void _SetupTargetToggle_b__71_1(bool isOn);
		[CompilerGenerated]
		private void _SetupTargetToggle_b__71_2(bool isOn);
		[CompilerGenerated]
		private void _SetupTargetToggle_b__71_3(bool isOn);
		[CompilerGenerated]
		private void _SetupTargetToggle_b__71_4(bool isOn);
	}
}
