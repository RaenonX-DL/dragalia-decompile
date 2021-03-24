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
	public class ShopTradeFilterPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonSettingToggleBase allItemsToggle;
		public CommonSettingToggleBase affordableItemsToggle;
		[Header]
		[SerializeField]
		public CommonSettingToggleBase allGiftTypeToggle;
		public CommonSettingToggleBase weaponOnlyToggle;
		public CommonSettingToggleBase amuletOnlyToggle;
		public CommonSettingToggleBase dragonOnlyToggle;
		public CommonSettingToggleBase consumeItemOnlyToggle;
		public CommonSettingToggleBase materialItemOnlyToggle;
		public CommonSettingToggleBase facilityOnlyToggle;
		public CommonSettingToggleBase otherToggle;
		[Header]
		[SerializeField]
		public CommonSettingToggleBase[] elementalToggles;
		private CommonSettingToggleBase fireToggle;
		private CommonSettingToggleBase waterToggle;
		private CommonSettingToggleBase windToggle;
		private CommonSettingToggleBase lightToggle;
		private CommonSettingToggleBase darkToggle;
		private CommonSettingToggleBase noElementToggle;
		public Button allElementButton;
		public Image allElementSelectedImage;
		[Header]
		[SerializeField]
		public GameObject elementalLineGO;
		public GameObject noElementItemGO;
		private ShopTradeModel.FilterCondition condition;
		private Action<ShopTradeModel.FilterCondition> onApply;
		private List<CommonSettingToggleBase> affordabilityToggleGroup;
		private List<CommonSettingToggleBase> giftTypeToggleGroup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public int index;
			public ShopTradeFilterPopup __4__this;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _SetToggleValueChanged_b__0(bool isOn, bool isBySystem);
		}
	
		// Constructors
		public ShopTradeFilterPopup();
	
		// Methods
		public static ShopTradeFilterPopup Create(ShopTradeModel.FilterCondition condition, Action<ShopTradeModel.FilterCondition> onApply);
		public void Setup(ShopTradeModel.FilterCondition condition, Action<ShopTradeModel.FilterCondition> onApply);
		protected override void Start();
		private void SetToggleValueChanged(int index);
		public void OnElementalToggled(ElementalType elementalType, bool isOn);
		private void EnableGameObjectAndResetGridLayoutGroup(GameObject go);
		public void OnFilterTargetToggled(bool shouldTurnOffNoElement);
		public void SelectAllElements();
		public void OnOKButtonPressed();
		[CompilerGenerated]
		private void _Start_b__27_0(bool isOn, bool isBySystem);
		[CompilerGenerated]
		private void _Start_b__27_1(bool isOn, bool isBySystem);
		[CompilerGenerated]
		private void _Start_b__27_2(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_3(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_4(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_5(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_6(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_7(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_8(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_9(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_10(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_11(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_12(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_13(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_14(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_15(bool isOn);
		[CompilerGenerated]
		private void _Start_b__27_16();
	}
}
