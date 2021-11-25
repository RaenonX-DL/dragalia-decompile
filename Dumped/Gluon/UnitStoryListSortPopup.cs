using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitStoryListSortPopup : PopupBase
	{
		[SerializeField]
		[Header("Tabs")]
		public TabBase tabController;

		[SerializeField]
		[Header("Filter Elemental")]
		public Image filterAllElementalCheckImage;

		public UnitStoryListSortSettingToggle[] filterEachElementToggleList;

		[SerializeField]
		[Header("Filter Weapon Type")]
		public GameObject weaponTypeLine;

		public Image filterAllWeaponTypeCheckImage;

		public UnitStoryListSortSettingToggle[] filterEachWeaponTypeToggleList;

		[SerializeField]
		[Header("Sort Type")]
		public UnitStoryListSortSettingToggle[] sortTypeToggleList;

		public ToggleGroup sortTypeToggleGroup;

		[SerializeField]
		[Header("Sort Order")]
		public UnitStoryListSortSettingToggle sortOrderAscendingToggle;

		public UnitStoryListSortSettingToggle sortOrderDescendingToggle;

		public ToggleGroup sortOrderToggleGroup;

		[SerializeField]
		[Header("Count")]
		public Text countText;

		public Text preCountText;

		[SerializeField]
		protected Button closeButton;

		private readonly UnitStoryListSortModel.Condition.SortCondition.SortType[] sortTypeListForUnitStory;

		private UnitStoryListSortModel.Condition editingCondition;

		private UnitStoryListController controller;

		private bool shouldIgnoreNoElement;

		private List<UnitStoryListCellData> cellDataList;

		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/UnitStoryListSortPopup";

		public static UnitStoryListSortPopup Create(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, bool shouldClearFilter = false)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void SetupByControllerAndType(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, bool shouldClearFilter = false)
		{
		}

		private void SetUIByCondition()
		{
		}

		public void SetCountText(int countNow, int countMax = -1)
		{
		}

		public void OnAllElementalFilterButtonPressed()
		{
		}

		public void OnElementalFilterToggled(bool isOn, ElementalType elem)
		{
		}

		public void OnAllWeaponTypeFilterButtonPressed()
		{
		}

		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType)
		{
		}

		public void OnFilterConditionChanged()
		{
		}

		public void OnSortTypeToggled(UnitStoryListSortModel.Condition.SortCondition.SortType type)
		{
		}

		public void OnSortOrderToggled(UnitStoryListSortModel.Condition.SortCondition.SortOrder order)
		{
		}

		public void OnOkButtonPressed()
		{
		}
	}
}
