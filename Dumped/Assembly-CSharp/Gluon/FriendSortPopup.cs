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
	public class FriendSortPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public Image filterAllElementalCheckImage;
		public FriendSortSettingToggle[] filterEachElementToggleList;
		[Header]
		[SerializeField]
		public GameObject weaponTypeLine;
		public Image filterAllWeaponTypeCheckImage;
		public FriendSortSettingToggle[] filterEachWeaponTypeToggleList;
		[Header]
		[SerializeField]
		public FriendSortSettingToggle[] sortTypeToggleList;
		public ToggleGroup sortTypeToggleGroup;
		[Header]
		[SerializeField]
		public FriendSortSettingToggle sortOrderAscendingToggle;
		public FriendSortSettingToggle sortOrderDescendingToggle;
		public ToggleGroup sortOrderToggleGroup;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text countText;
		public UnityEngine.UI.Text preCountText;
		[SerializeField]
		protected Button closeButton;
		private readonly FriendSortModel.Condition.SortCondition.SortType[] sortTypeListForFriend;
		private FriendSortModel.Condition editingCondition;
		private FriendListController controller;
		private bool shouldIgnoreNoElement;
		private List<FriendListCellData> cellDataList;
		private const string prefabPath = "Prefabs/OutGame/Friend/Popup/FriendSortPopup";
	
		// Constructors
		public FriendSortPopup();
	
		// Methods
		public static FriendSortPopup Create(FriendListController controller, List<FriendListCellData> cellDataList, bool shouldClearFilter = false);
		protected override void Start();
		public void SetupByControllerAndType(FriendListController controller, List<FriendListCellData> cellDataList, bool shouldClearFilter = false);
		private void SetUIByCondition();
		public void SetCountText(int countNow, int countMax = -1);
		public void OnAllElementalFilterButtonPressed();
		public void OnElementalFilterToggled(bool isOn, ElementalType elem);
		public void OnAllWeaponTypeFilterButtonPressed();
		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType);
		public void OnFilterConditionChanged();
		public void OnSortTypeToggled(FriendSortModel.Condition.SortCondition.SortType type);
		public void OnSortOrderToggled(FriendSortModel.Condition.SortCondition.SortOrder order);
		public void OnOkButtonPressed();
	}
}
