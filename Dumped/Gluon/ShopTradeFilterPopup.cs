using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeFilterPopup : PopupBase
	{
		[SerializeField]
		[Header("Affordability")]
		public CommonSettingToggleBase allItemsToggle;

		public CommonSettingToggleBase affordableItemsToggle;

		[SerializeField]
		[Header("GiftType")]
		public CommonSettingToggleBase allGiftTypeToggle;

		public CommonSettingToggleBase weaponOnlyToggle;

		public CommonSettingToggleBase amuletOnlyToggle;

		public CommonSettingToggleBase dragonOnlyToggle;

		public CommonSettingToggleBase consumeItemOnlyToggle;

		public CommonSettingToggleBase materialItemOnlyToggle;

		public CommonSettingToggleBase facilityOnlyToggle;

		public CommonSettingToggleBase otherToggle;

		[SerializeField]
		[Header("Elemental")]
		public CommonSettingToggleBase[] elementalToggles;

		private CommonSettingToggleBase fireToggle;

		private CommonSettingToggleBase waterToggle;

		private CommonSettingToggleBase windToggle;

		private CommonSettingToggleBase lightToggle;

		private CommonSettingToggleBase darkToggle;

		private CommonSettingToggleBase noElementToggle;

		public Button allElementButton;

		public Image allElementSelectedImage;

		[SerializeField]
		[Header("OnOff")]
		public GameObject elementalLineGO;

		public GameObject noElementItemGO;

		private ShopTradeModel.FilterCondition condition;

		private Action<ShopTradeModel.FilterCondition> onApply;

		private List<CommonSettingToggleBase> affordabilityToggleGroup;

		private List<CommonSettingToggleBase> giftTypeToggleGroup;

		public static ShopTradeFilterPopup Create(ShopTradeModel.FilterCondition condition, Action<ShopTradeModel.FilterCondition> onApply)
		{
			return null;
		}

		public void Setup(ShopTradeModel.FilterCondition condition, Action<ShopTradeModel.FilterCondition> onApply)
		{
		}

		protected override void Start()
		{
		}

		private void SetToggleValueChanged(int index)
		{
		}

		public void OnElementalToggled(ElementalType elementalType, bool isOn)
		{
		}

		private void EnableGameObjectAndResetGridLayoutGroup(GameObject go)
		{
		}

		public void OnFilterTargetToggled(bool shouldTurnOffNoElement)
		{
		}

		public void SelectAllElements()
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
