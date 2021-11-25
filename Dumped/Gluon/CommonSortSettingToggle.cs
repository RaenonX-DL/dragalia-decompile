using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonSortSettingToggle : CommonSettingToggleBase
	{
		public enum SortPlusParamType
		{
			None,
			AttachedPlusParam,
			NoAttachedPlusParam,
			All
		}

		[SerializeField]
		[Header("Components")]
		public GameObject layoutParentGameObject;

		public Text title;

		[SerializeField]
		[Header("Filter Setting")]
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

		[SerializeField]
		[Header("Sort Setting")]
		public CommonSortModel.Condition.SortCondition.SortType sortType;

		public CommonSortModel.Condition.SortCondition.SortOrder sortOrder;

		private CommonSortPopup popup;

		public void SetupByCondition(CommonSortModel.Condition condition, CommonSortPopup popup)
		{
		}

		public override void OnToggleValueChanged(bool value)
		{
		}

		public void ResetInitValueBySortType(CommonSortModel.Condition.SortCondition.SortType sortType)
		{
		}
	}
}
