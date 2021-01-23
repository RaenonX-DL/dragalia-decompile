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
	public class UnitStoryListSortPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public Image filterAllElementalCheckImage;
		public UnitStoryListSortSettingToggle[] filterEachElementToggleList;
		[Header]
		[SerializeField]
		public GameObject weaponTypeLine;
		public Image filterAllWeaponTypeCheckImage;
		public UnitStoryListSortSettingToggle[] filterEachWeaponTypeToggleList;
		[Header]
		[SerializeField]
		public UnitStoryListSortSettingToggle[] sortTypeToggleList;
		public ToggleGroup sortTypeToggleGroup;
		[Header]
		[SerializeField]
		public UnitStoryListSortSettingToggle sortOrderAscendingToggle;
		public UnitStoryListSortSettingToggle sortOrderDescendingToggle;
		public ToggleGroup sortOrderToggleGroup;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text countText;
		public UnityEngine.UI.Text preCountText;
		[SerializeField]
		protected Button closeButton;
		private readonly UnitStoryListSortModel.Condition.SortCondition.SortType[] sortTypeListForUnitStory;
		private UnitStoryListSortModel.Condition editingCondition;
		private UnitStoryListController controller;
		private bool shouldIgnoreNoElement;
		private List<UnitStoryListCellData> cellDataList;
		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/UnitStoryListSortPopup";
	
		// Constructors
		public UnitStoryListSortPopup();
	
		// Methods
		public static UnitStoryListSortPopup Create(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, bool shouldClearFilter = false);
		protected override void Start();
		public void SetupByControllerAndType(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, bool shouldClearFilter = false);
		private void SetUIByCondition();
		public void SetCountText(int countNow, int countMax = -1);
		public void OnAllElementalFilterButtonPressed();
		public void OnElementalFilterToggled(bool isOn, ElementalType elem);
		public void OnAllWeaponTypeFilterButtonPressed();
		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType);
		public void OnFilterConditionChanged();
		public void OnSortTypeToggled(UnitStoryListSortModel.Condition.SortCondition.SortType type);
		public void OnSortOrderToggled(UnitStoryListSortModel.Condition.SortCondition.SortOrder order);
		public void OnOkButtonPressed();
	}
}
