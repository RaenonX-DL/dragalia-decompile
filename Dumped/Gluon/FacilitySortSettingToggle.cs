using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilitySortSettingToggle : CommonSettingToggleBase
	{
		[SerializeField]
		[Header("Components")]
		private GameObject layoutParentGameObject;

		[SerializeField]
		private Text title;

		[SerializeField]
		[Header("Filter Setting")]
		private ElementalType elementalType;

		[SerializeField]
		private WeaponType weaponType;

		[SerializeField]
		private FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState facilityStateType;

		[SerializeField]
		[Header("Sort Setting")]
		private FacilitySortModel.Condition.SortCondition.SortType sortType;

		[SerializeField]
		private FacilitySortModel.Condition.SortCondition.SortOrder sortOrder;

		private FacilitySortPopup popup;

		public FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState GetFacilityStateType()
		{
			return default(FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState);
		}

		public void SetupByCondition(FacilitySortModel.Condition condition, FacilitySortPopup popup)
		{
		}

		public override void OnToggleValueChanged(bool value)
		{
		}

		private void SetSortToggleText()
		{
		}

		public void ResetInitValueBySortType(FacilitySortModel.Condition.SortCondition.SortType sortType)
		{
		}
	}
}
