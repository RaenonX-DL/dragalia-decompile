/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSortSettingToggle : CommonSettingToggleBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject layoutParentGameObject;
		public UnityEngine.UI.Text title;
		[Header]
		[SerializeField]
		public ElementalType elemental;
		public WeaponType weaponType;
		public int unionAbility;
		public CommonSortModel.Condition.FilterCondition.AbilityTypeFilter.AbilityTypeForFilter abilityType;
		public CommonSortModel.Condition.FilterCondition.ExAbilityTypeFilter.ExAbilityTypeForFilter exAbilityType;
		public CommonSortModel.Condition.FilterCondition.CharaSkillTypeFilter.CharaSkillTypeForFilter charaSkillType;
		public bool isWeaponUpgradeItem;
		public bool isInvertWeaponUpgradeItem;
		public SortPlusParamType sortHpPlusParamType;
		public SortPlusParamType sortAtkPlusParamType;
		[Header]
		[SerializeField]
		public CommonSortModel.Condition.SortCondition.SortType sortType;
		public CommonSortModel.Condition.SortCondition.SortOrder sortOrder;
		private CommonSortPopup popup;
	
		// Nested types
		public enum SortPlusParamType
		{
			None = 0,
			AttachedPlusParam = 1,
			NoAttachedPlusParam = 2,
			All = 3
		}
	
		// Constructors
		public CommonSortSettingToggle();
	
		// Methods
		public void SetupByCondition(CommonSortModel.Condition condition, CommonSortPopup popup);
		public override void OnToggleValueChanged(bool value);
		public void ResetInitValueBySortType(CommonSortModel.Condition.SortCondition.SortType sortType);
	}
}
