/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingConditionPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text okButtonText;
		[Header]
		[SerializeField]
		private GameObject elementalTypeLine;
		[SerializeField]
		private GameObject elementalTypeToggleLine;
		[SerializeField]
		private Graphic limitedElementalTypeImage;
		[SerializeField]
		private UnityEngine.UI.Text limitedElementalTypeText;
		[SerializeField]
		private CommonSettingToggleBase[] filterEachElementToggleList;
		[SerializeField]
		private Image allElementOnImage;
		[Header]
		[SerializeField]
		private GameObject weaponTypeLine;
		[SerializeField]
		private CommonSettingToggleBase[] filterEachWeaponTypeToggleList;
		[SerializeField]
		private Image allWeaponTypeOnImage;
		[Header]
		[SerializeField]
		private CommonSliderSelection powerSlider;
		[SerializeField]
		private UnityEngine.UI.Text powerTitle;
		[SerializeField]
		private UnityEngine.UI.Text powerExplain;
		[SerializeField]
		private GameObject roomPurposeToggleRoot;
		[SerializeField]
		private CommonSettingToggleBase[] roomPurposeToggles;
		[SerializeField]
		private GameObject roomFilterToggleRoot;
		[SerializeField]
		private Toggle[] roomFilterToggles;
		[SerializeField]
		private GameObject roomPurposeWarningRoot;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private Button closeButton;
		[SerializeField]
		private Button centerCloseButton;
		private List<WeaponType> limitedWeaponTypeList;
		public static readonly Localize.TextId[] roomPurposeTextIds;
		private UnityEvent okPressedEvent;
		private const string prefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingConditionPopup";
	
		// Nested types
		public enum PopupType
		{
			CreateRoom = 0,
			ChangeSetting = 1,
			SearchFilter = 2
		}
	
		public class FilterSetting
		{
			// Fields
			public List<ElementalType> enableElementals;
			public List<WeaponType> enableWeaponTypes;
			public int requiredPower;
			public List<int> enablePurpose;
	
			// Constructors
			public FilterSetting();
	
			// Methods
			internal bool IsFilterEnable();
			internal bool IsFilterEnable(RoomListData room);
		}
	
		// Constructors
		public MatchingConditionPopup();
		static MatchingConditionPopup();
	
		// Methods
		public static MatchingConditionPopup Create();
		public void InitializeForFilter(bool isRaidBattle, int questId, FilterSetting filterSetting, UnityAction okPressedAction, UnityAction closePressedAction);
		public void InitializeForSetting(PopupType popupType, bool isRaidBattle, int questId, RoomEntryCondition roomCondition, UnityAction okPressedAction, UnityAction closePressedAction);
		public RoomEntryCondition CreateRoomConditioon();
		public FilterSetting CreateFilterSetting();
		private void UpdateAllElement();
		private void UpdateAllWeaponType();
		public void OnOkButtonPressed();
		public void OnElementToggleValueChanged(bool value, bool isSettingBySystem);
		public void OnAllElementPressed();
		public void OnWeaponToggleValueChanged(bool value, bool isSettingBySystem);
		public void OnAllWeaponTypePressed();
		private int GetRoomPurposeId();
		private List<int> GetRoomPurposeIdFilter();
		public static int GetConditionMaxPower(int maxPower, bool isRaidBattle);
		public static int GetMyPower(int questId);
		public static int GetMyPower(bool isRaidBattle);
		private List<ElementalType> GetCheckElementList(RoomEntryCondition roomCondition);
		private List<WeaponType> GetCheckWeaponTypeList(RoomEntryCondition roomCondition);
		private void SetTitleAndDecideText(PopupType popupType);
		private void SetLlimitedElementalType(ElementalType limitedElementalType);
		private void SetElementalToggle(List<ElementalType> checkElements);
		private void SetWeaponToggle(bool isRaidBattle, List<WeaponType> weaponTypes);
		private void SetPowerSlider(bool isRaidBattle, int requiredPower, int questId);
		private void SetRoomPurposeForSetting(int roomPurpose, int questId);
		private void SetRoomPurposeForFilter(bool isSearchFilter, List<int> enablePurpose);
		private void OnRoomPurposeToggleValueChanged(bool isOn, bool isBySystem);
		private void SetCommon(UnityAction okPressedAction, UnityAction closePressedAction);
	}
}
