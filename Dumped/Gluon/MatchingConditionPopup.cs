using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingConditionPopup : PopupBase
	{
		public enum PopupType
		{
			CreateRoom,
			ChangeSetting,
			SearchFilter
		}

		public class FilterSetting
		{
			public List<ElementalType> enableElementals;

			public List<WeaponType> enableWeaponTypes;

			public int requiredPower;

			public List<int> enablePurpose;

			internal bool IsFilterEnable()
			{
				return default(bool);
			}

			internal bool IsFilterEnable(RoomListData room)
			{
				return default(bool);
			}
		}

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text okButtonText;

		[SerializeField]
		[Header("Filter Elemental")]
		private GameObject elementalTypeLine;

		[SerializeField]
		private GameObject elementalTypeToggleLine;

		[SerializeField]
		private Graphic limitedElementalTypeImage;

		[SerializeField]
		private Text limitedElementalTypeText;

		[SerializeField]
		private CommonSettingToggleBase[] filterEachElementToggleList;

		[SerializeField]
		private Image allElementOnImage;

		[SerializeField]
		[Header("Filter Weapon Type")]
		private GameObject weaponTypeLine;

		[SerializeField]
		private CommonSettingToggleBase[] filterEachWeaponTypeToggleList;

		[SerializeField]
		private Image allWeaponTypeOnImage;

		[SerializeField]
		[Header("others")]
		private CommonSliderSelection powerSlider;

		[SerializeField]
		private Text powerTitle;

		[SerializeField]
		private Text powerExplain;

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

		public static MatchingConditionPopup Create()
		{
			return null;
		}

		public void InitializeForFilter(bool isRaidBattle, int questId, FilterSetting filterSetting, UnityAction okPressedAction, UnityAction closePressedAction)
		{
		}

		public void InitializeForSetting(PopupType popupType, bool isRaidBattle, int questId, RoomEntryCondition roomCondition, UnityAction okPressedAction, UnityAction closePressedAction)
		{
		}

		public RoomEntryCondition CreateRoomConditioon()
		{
			return null;
		}

		public FilterSetting CreateFilterSetting()
		{
			return null;
		}

		private void UpdateAllElement()
		{
		}

		private void UpdateAllWeaponType()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnElementToggleValueChanged(bool value, bool isSettingBySystem)
		{
		}

		public void OnAllElementPressed()
		{
		}

		public void OnWeaponToggleValueChanged(bool value, bool isSettingBySystem)
		{
		}

		public void OnAllWeaponTypePressed()
		{
		}

		private int GetRoomPurposeId()
		{
			return default(int);
		}

		private List<int> GetRoomPurposeIdFilter()
		{
			return null;
		}

		public static int GetConditionMaxPower(int maxPower, bool isRaidBattle)
		{
			return default(int);
		}

		public static int GetMyPower(int questId)
		{
			return default(int);
		}

		public static int GetMyPower(bool isRaidBattle)
		{
			return default(int);
		}

		private List<ElementalType> GetCheckElementList(RoomEntryCondition roomCondition)
		{
			return null;
		}

		private List<WeaponType> GetCheckWeaponTypeList(RoomEntryCondition roomCondition)
		{
			return null;
		}

		private void SetTitleAndDecideText(PopupType popupType)
		{
		}

		private void SetLlimitedElementalType(ElementalType limitedElementalType)
		{
		}

		private void SetElementalToggle(List<ElementalType> checkElements)
		{
		}

		private void SetWeaponToggle(bool isRaidBattle, List<WeaponType> weaponTypes)
		{
		}

		private void SetPowerSlider(bool isRaidBattle, int requiredPower, int questId)
		{
		}

		private void SetRoomPurposeForSetting(int roomPurpose, int questId)
		{
		}

		private void SetRoomPurposeForFilter(bool isSearchFilter, List<int> enablePurpose)
		{
		}

		private void OnRoomPurposeToggleValueChanged(bool isOn, bool isBySystem)
		{
		}

		private void SetCommon(UnityAction okPressedAction, UnityAction closePressedAction)
		{
		}
	}
}
