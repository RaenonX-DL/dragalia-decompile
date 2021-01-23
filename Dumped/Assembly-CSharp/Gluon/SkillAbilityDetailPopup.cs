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
	public class SkillAbilityDetailPopup : PopupBase
	{
		// Fields
		public Image iconImage;
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text detailText;
		public Transform iconDecoNode;
		public UnityEngine.UI.Text conditionMessage;
		public UnityEngine.UI.Text titleText;
		public GameObject weaponElementalUnmatchedNode;
		[HideInInspector]
		public string abilityConditionMessage;
		private CommonIconListSortDeco iconDeco;
		private const string prefabPath = "Prefabs/OutGame/UnitDetail/SkillAbilityDetailPopup";
		private int id;
		private int level;
		private int maxLevel;
		private PopupType popupType;
		private bool displayObtainingMessage;
		private bool displayWeaponElementalUnmatchedMessage;
		private ElementalType elementalType;
		private List<int> duplicationAbilityIds;
		private AbilityConst.UnitType giftType;
		private bool isFirstExAbility;
	
		// Nested types
		public enum PopupType
		{
			None = 0,
			Skill = 1,
			Ability = 2,
			ExAbility = 3,
			RaidBoost = 4,
			WeaponAbility = 5
		}
	
		// Constructors
		public SkillAbilityDetailPopup();
	
		// Methods
		public static SkillAbilityDetailPopup CreateSkillDetailPopup(int skillId, int level, int maxLevel, bool displayWeaponElementalUnmatchedMessage = false, bool isUnopenSkill = true);
		public static SkillAbilityDetailPopup CreateAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage);
		public static SkillAbilityDetailPopup CreateWeaponAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage);
		public static SkillAbilityDetailPopup CreateAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage, List<int> duplicationAbilityIds, AbilityConst.UnitType abilityGiftType);
		public static SkillAbilityDetailPopup CreateExAbilityDetailPopup(int exAbilityId, bool displayObtainingMessage, bool isFirstAbility = false);
		public static SkillAbilityDetailPopup CreateRaidBoostDetailPopup(RaidBoostPopup.RaidBoostModel.CellData data);
		private void SetupWithRaidBoostData(RaidBoostPopup.RaidBoostModel.CellData data);
		protected override void Start();
		private void SetIconImage(PopupType type, string iconPath);
		private void SetNameText(string name, ElementalType type = ElementalType.NONE);
		private void SetDetailText(string detail, ElementalType type = ElementalType.NONE);
		private void SetLevelText(int level, bool isMax = false);
		private void SetConditionMessage(bool show);
	}
}
