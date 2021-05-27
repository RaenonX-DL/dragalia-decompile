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
	public class FacilitySortPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private TabBase tabController;
		[Header]
		[SerializeField]
		private GameObject filterElementalParent;
		[SerializeField]
		private Image filterAllElementalCheckImage;
		[SerializeField]
		private List<FacilitySortSettingToggle> filterEachElementalToggleList;
		[Header]
		[SerializeField]
		private GameObject filterWeaponTypeParent;
		[SerializeField]
		private List<FacilitySortSettingToggle> filterEachWeaponTypeToggleList;
		[Header]
		[SerializeField]
		private GameObject facilityStateFilterParent;
		[SerializeField]
		private List<FacilitySortSettingToggle> facilityStateFilterList;
		[Header]
		[SerializeField]
		private List<FacilitySortSettingToggle> sortTypeToggleList;
		[SerializeField]
		private ToggleGroup sortTypeToggleGroup;
		[Header]
		[SerializeField]
		private FacilitySortSettingToggle sortOrderAscendingToggle;
		[SerializeField]
		private FacilitySortSettingToggle sortOrderDescendingToggle;
		[SerializeField]
		private ToggleGroup sortOrderToggleGroup;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text preCountText;
		[SerializeField]
		private UnityEngine.UI.Text countText;
		[Header]
		[SerializeField]
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
	
		// Constructors
		public FacilitySortPopup();
	
		// Methods
		public static FacilitySortPopup Create(FacilitySortModel.Preset preset, List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
		protected override void Start();
		public void Setup(FacilitySortModel.Preset preset, List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
		private void SetUIByCondition();
		private void SetFilterUI();
		private void SetCountText(int countNow, int countMax = -1);
		public void OnAllElementalFilterButtonPressed();
		public void OnElementalFilterToggled(bool isOn, ElementalType elementalType);
		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType);
		public void OnFacilityStateFilterToggled(bool isOn, FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState state);
		public void OnFilterConditionChanged();
		public void OnSortTypeToggled(FacilitySortModel.Condition.SortCondition.SortType type);
		public void OnSortOrderToggled(FacilitySortModel.Condition.SortCondition.SortOrder order);
		public void OnOkButtonPressed();
		public void SetSortSettingAppliedCallback(Action onAppliedCallback);
	}
}
