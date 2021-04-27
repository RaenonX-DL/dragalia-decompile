/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSortPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		private CommonSortFilterUI[] commonSortFilters;
		[Header]
		[SerializeField]
		private TabBase obtainedItemTypeTab;
		[Header]
		[SerializeField]
		public Image filterAllElementalCheckImage;
		public CommonSortSettingToggle[] filterEachElementToggleList;
		[Header]
		[SerializeField]
		public Image filterAllWeaponTypeCheckImage;
		public CommonSortSettingToggle[] filterEachWeaponTypeToggleList;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle filterWeaponUpgradableToggle;
		public CommonSortSettingToggle filterInvertWeaponUpgradableToggle;
		[Header]
		[SerializeField]
		public Image filterAllUnionAbilityCheckImage;
		public CommonSortSettingToggle[] filterEachUnionAbilityToggleList;
		[Header]
		[SerializeField]
		private CommonSortSettingToggle[] filterAbilityToggleList;
		[Header]
		[SerializeField]
		private CommonSortFilterUI[] abilitySortFilters;
		[SerializeField]
		private CommonSortFilterUI[] needSetupAbilities;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle[] filterExAbilityToggleList;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle[] filterCharaSkillToggleList;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle[] filterHpPlusParamToggleList;
		public CommonSortSettingToggle[] filterAtkPlusParamToggleList;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle[] sortTypeToggleList;
		public ToggleGroup sortTypeToggleGroup;
		public CommonSortFilterUI plusSortLine;
		public CommonSortFilterUI priorMatchElementLine;
		public CommonSortSettingToggle priorMatchElementToggle;
		public CommonSortFilterUI priorFavoriteLine;
		public CommonSortSettingToggle priorFavoriteToggle;
		[Header]
		[SerializeField]
		public CommonSortSettingToggle sortOrderAscendingToggle;
		public CommonSortSettingToggle sortOrderDescendingToggle;
		public ToggleGroup sortOrderToggleGroup;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text countText;
		public UnityEngine.UI.Text preCountText;
		public Button okButton;
		[SerializeField]
		protected Button closeButton;
		private bool isShowObtainedItem;
		private bool useSelfSortAndFilter;
		private List<WeaponType> limitedWeaponTypeList;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForCharacter;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDragon;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForWeapon;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAmulet;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDragonPetting;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDreamSelect;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDreamSelectDragon;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForSkinWeapon;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForCharaSkill;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAlbum;
		private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAlbumDragon;
		private CommonSortModel.Condition editingCondition;
		private CommonIconListController controller;
		private GiftType giftType;
		private bool shouldIgnoreNoElement;
		private ulong[] originalKeyIds;
		private CommonSortModel.Preset preset;
		private Action onSortSettingApplied;
		private Func<List<ulong>, List<ulong>> filteredListCustomizeAction;
		private const string prefabPath = "Prefabs/OutGame/Common/CommonSortPopup";
	
		// Properties
		public CommonSortFilterUI ObtainedItemTypeLine { get; }
		public CommonSortFilterUI elementalTypeLine { get; }
		public CommonSortFilterUI weaponTypeLine { get; }
		public CommonSortFilterUI weaponUpgradableLine { get; }
		public CommonSortFilterUI unionAbilityLine { get; }
		public CommonSortFilterUI filterAbilityLine { get; }
		public CommonSortFilterUI eventSpecificAbilityLine { get; }
		public CommonSortFilterUI eventSpecificToggleGO { get; }
		public CommonSortFilterUI memoryEventSpecificToggleGO { get; }
		public CommonSortFilterUI buffDebuffAbilityLine { get; }
		public CommonSortFilterUI filterExAbilityLine { get; }
		public CommonSortFilterUI filterCharaSkillLine { get; }
		public CommonSortFilterUI plusParamLine { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_0
		{
			// Fields
			public CommonSortSettingToggle sortToggle;
	
			// Constructors
			public __c__DisplayClass109_0();
	
			// Methods
			internal bool _ToogleLockDelay_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _ToogleLockDelay_d__109 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CommonSortSettingToggle sortToggle;
			private __c__DisplayClass109_0 __8__1;
			public bool isLock;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ToogleLockDelay_d__109(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CommonSortPopup();
	
		// Methods
		public static CommonSortPopup Create(CommonIconListController controller, GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset = CommonSortModel.Preset.AutoCommon, bool shouldClearFilter = false, ElementalType charaElement = ElementalType.NONE, Func<List<ulong>, List<ulong>> filteredListCustomizeAction = null);
		public static CommonSortPopup CreateWithData(GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset = CommonSortModel.Preset.AutoCommon, bool shouldClearFilter = false, bool showObtainedItem = true);
		protected override void Start();
		public void SetupByControllerAndType(CommonIconListController controller, GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset, bool shouldClearFilter, ElementalType charaElement, Func<List<ulong>, List<ulong>> filteredListCustomizeAction);
		private void SetUIByCondition();
		public void SetCountText(int countNow, int countMax = -1);
		private void OnObtainedItemFilterChanged(int index, bool calledFromUI);
		public void OnAllElementalFilterButtonPressed();
		public void OnElementalFilterToggled(bool isOn, ElementalType elem);
		public void OnAllWeaponTypeFilterButtonPressed();
		public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType);
		public void OnWeaponUpgradeFilterToggled(bool isOn);
		public void OnAllUnionAbilityFilterButtonPressed();
		public void OnUnionAbilityFilterToggled(bool isOn, int unionAbilityId);
		public void OnAbilityTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.AbilityTypeFilter.AbilityTypeForFilter type);
		public void OnExAbilityTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.ExAbilityTypeFilter.ExAbilityTypeForFilter type);
		public void OnCharaSkillTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.CharaSkillTypeFilter.CharaSkillTypeForFilter type);
		public void OnHpPlusFilterToggled(bool isOn, CommonSortSettingToggle.SortPlusParamType sortPlusParamType);
		public void OnAtkPlusFilterToggled(bool isOn, CommonSortSettingToggle.SortPlusParamType sortPlusParamType);
		public void OnPriorMatchElementToggled(bool isOn);
		public void OnPriorFavoriteToggled(bool isOn);
		public void OnFilterConditionChanged();
		public void OnSortTypeToggled(CommonSortModel.Condition.SortCondition.SortType type);
		private void UpdateSortOrderLockStatus();
		public void OnSortOrderToggled(CommonSortModel.Condition.SortCondition.SortOrder order);
		public void OnOkButtonPressed();
		public void SetOnSortSettingAppliedCallback(Action onApplied);
		[IteratorStateMachine]
		public IEnumerator ToogleLockDelay(CommonSortSettingToggle sortToggle, bool isLock);
		public bool IsWeaponFilterAllOn();
	}
}
