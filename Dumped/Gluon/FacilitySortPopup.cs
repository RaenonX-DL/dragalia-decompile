using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilitySortPopup : PopupBase
	{
		[SerializeField]
		[Header("Tabs")]
		private TabBase tabController;

		[SerializeField]
		[Header("Filter Elemental")]
		private GameObject filterElementalParent;

		[SerializeField]
		private Image filterAllElementalCheckImage;

		[SerializeField]
		private List<FacilitySortSettingToggle> filterEachElementalToggleList;

		[SerializeField]
		[Header("Filter WeaponType")]
		private GameObject filterWeaponTypeParent;

		[SerializeField]
		private List<FacilitySortSettingToggle> filterEachWeaponTypeToggleList;

		[SerializeField]
		[Header("Filter FacilityState")]
		private GameObject facilityStateFilterParent;

		[SerializeField]
		private List<FacilitySortSettingToggle> facilityStateFilterList;

		[SerializeField]
		[Header("Sort Type")]
		private List<FacilitySortSettingToggle> sortTypeToggleList;

		[SerializeField]
		private ToggleGroup sortTypeToggleGroup;

		[SerializeField]
		[Header("Sort Order")]
		private FacilitySortSettingToggle sortOrderAscendingToggle;

		[SerializeField]
		private FacilitySortSettingToggle sortOrderDescendingToggle;

		[SerializeField]
		private ToggleGroup sortOrderToggleGroup;

		[SerializeField]
		[Header("Text")]
		private Text preCountText;

		[SerializeField]
		private Text countText;

		[SerializeField]
		[Header("Buttons")]
		private Button closeButton;

		[SerializeField]
		private Button okButton;

		private FacilitySortModel.Condition editingCondition;

		private List<ManagedFacilityModel.ManagedFacility> managedFacilityList;

		private FacilitySortModel.Preset preset;

		private bool shouldIgnoreNoElement;

		private Action onSortSettingAppliedCallback;

		private const string prefabPath = "Prefabs/OutGame/Fort/Layout/2D/Dialog/FacilitySortPopup";

		private readonly FacilitySortModel.Condition.SortCondition.SortType[] sortTypeListForProduce;

		private readonly FacilitySortModel.Condition.SortCondition.SortType[] sortTypeListForCharaBoost;

		private readonly FacilitySortModel.Condition.SortCondition.SortType[] sortTypeListForDragonBoost;

		private readonly FacilitySortModel.Condition.SortCondition.SortType[] sortTypeListForDecoration;

		private readonly FacilitySortModel.Condition.SortCondition.SortType[] sortTypeListForOther;

		public static FacilitySortPopup Create(FacilitySortModel.Preset preset, List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void Setup(FacilitySortModel.Preset preset, List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
		{
		}

		private void SetUIByCondition()
		{
		}

		private void SetFilterUI()
		{
		}

		private void SetCountText(int countNow, int countMax = -1)
		{
		}

		public void OnAllElementalFilterButtonPressed()
		{
		}

		public void OnElementalFilterToggled(bool isOn, ElementalType elementalType)
		{
		}

		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType)
		{
		}

		public void OnFacilityStateFilterToggled(bool isOn, FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState state)
		{
		}

		public void OnFilterConditionChanged()
		{
		}

		public void OnSortTypeToggled(FacilitySortModel.Condition.SortCondition.SortType type)
		{
		}

		public void OnSortOrderToggled(FacilitySortModel.Condition.SortCondition.SortOrder order)
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void SetSortSettingAppliedCallback(Action onAppliedCallback)
		{
		}
	}
}
