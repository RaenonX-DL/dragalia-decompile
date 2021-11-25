using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AutoPartySelectDialog : CommonPopup
	{
		public enum AutoSelectTarget
		{
			Chara,
			Dragon,
			Weapon,
			Amulet
		}

		public enum SceneType
		{
			PartyEdit,
			EquipEdit
		}

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

		public Text[] priorityText;

		public Toggle allTargetToggle;

		public Text allTargetText;

		public GameObject partyLayout;

		public Toggle charaTargetToggle1;

		public Toggle dragonTargetToggle1;

		public Toggle weaponTargetToggle1;

		public Toggle amuletTargetToggle1;

		public Text charaTargetText1;

		public Text dragonTargetText1;

		public Text weaponTargetText1;

		public Text amuletTargetText1;

		public GameObject equipLayout;

		public Toggle weaponTargetToggle2;

		public Toggle dragonTargetToggle2;

		public Toggle amuletTargetToggle2;

		public Text weaponTargetText2;

		public Text dragonTargetText2;

		public Text amuletTargetText2;

		public Text[] subTitleText;

		[SerializeField]
		private GameObject questElementPanel;

		public Text selectElementText;

		public Image questElementIcon;

		public Text questElementText;

		[SerializeField]
		private GameObject explainTextSpaceObj;

		[SerializeField]
		private GameObject limitedWeaponTypePanel;

		[SerializeField]
		private GameObject limitedWeaponTypeIconPanel;

		[SerializeField]
		private Image limitedWeaponTypeBaseIcon;

		[SerializeField]
		private Text limitedWeaponTypeText;

		[SerializeField]
		private LocalizeTextLayoutPadding limitedWeaponTypeLayoutPadding;

		[SerializeField]
		private Text limitedWeaponTypeForCalcText;

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

		public static AutoPartySelectDialog Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void SetupAutoPartyDialog(SceneType sceneType)
		{
		}

		public void ElementButtonPressed(int tag)
		{
		}

		public void PriorityButtonPressed(int tag)
		{
		}

		public void TargetButtonPressed(int tag, bool isOn)
		{
		}

		private void UpdateAllTargetToggle(bool isOn)
		{
		}

		public AutoPartyConfigData GetSelectData()
		{
			return null;
		}

		public static void ClearConfigSaveData()
		{
		}

		public void SetQuestElement(ElementalType element)
		{
		}

		public void SetQuestLimitedElement(ElementalType element)
		{
		}

		public void SetQuestLimitedWeaponType(List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void SaveAutoSelectConfigData()
		{
		}

		private void GetAutoSelectConfigData()
		{
		}

		private void UpdateDialogButtonState()
		{
		}

		private void SetupTargetToggle(SceneType sceneType)
		{
		}
	}
}
