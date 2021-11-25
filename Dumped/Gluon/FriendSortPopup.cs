using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendSortPopup : PopupBase
	{
		[SerializeField]
		[Header("Tabs")]
		public TabBase tabController;

		[SerializeField]
		[Header("Filter Elemental")]
		public Image filterAllElementalCheckImage;

		public FriendSortSettingToggle[] filterEachElementToggleList;

		[SerializeField]
		[Header("Filter Weapon Type")]
		public GameObject weaponTypeLine;

		public Image filterAllWeaponTypeCheckImage;

		public FriendSortSettingToggle[] filterEachWeaponTypeToggleList;

		[SerializeField]
		[Header("Sort Type")]
		public FriendSortSettingToggle[] sortTypeToggleList;

		public ToggleGroup sortTypeToggleGroup;

		[SerializeField]
		[Header("Sort Order")]
		public FriendSortSettingToggle sortOrderAscendingToggle;

		public FriendSortSettingToggle sortOrderDescendingToggle;

		public ToggleGroup sortOrderToggleGroup;

		[SerializeField]
		[Header("Count")]
		public Text countText;

		public Text preCountText;

		[SerializeField]
		protected Button closeButton;

		private readonly FriendSortModel.Condition.SortCondition.SortType[] sortTypeListForFriend;

		private FriendSortModel.Condition editingCondition;

		private FriendListController controller;

		private bool shouldIgnoreNoElement;

		private List<FriendListCellData> cellDataList;

		private const string prefabPath = "Prefabs/OutGame/Friend/Popup/FriendSortPopup";

		public static FriendSortPopup Create(FriendListController controller, List<FriendListCellData> cellDataList, bool shouldClearFilter = false)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void SetupByControllerAndType(FriendListController controller, List<FriendListCellData> cellDataList, bool shouldClearFilter = false)
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

		public void OnSortTypeToggled(FriendSortModel.Condition.SortCondition.SortType type)
		{
		}

		public void OnSortOrderToggled(FriendSortModel.Condition.SortCondition.SortOrder order)
		{
		}

		public void OnOkButtonPressed()
		{
		}
	}
}
