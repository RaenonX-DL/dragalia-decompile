/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestRepeatPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private TabBase repeautoPlayToggle;
		[SerializeField]
		private TabBase autoTransformToggle;
		[SerializeField]
		private CommonSliderSelection gameSpeedSlider;
		[SerializeField]
		private CommonSettingToggleBase repeatOffToggle;
		[SerializeField]
		private CommonSettingToggleBase useAllStaminaToggle;
		[SerializeField]
		private CommonSettingToggleBase repeatSettingCountToggle;
		[SerializeField]
		private CommonSliderSelection repeatNumSlider;
		[SerializeField]
		private UnityEngine.UI.Text consumeStaminaText;
		[SerializeField]
		private Transform RecoverItemIconParent;
		private UnityAction onOkButtonPressed;
		private QuestRepeatSettingModel tmpModel;
		private float speedSliderValue;
		private bool isEnableTransformToggle;
		private const int sliderMaxValue = 99;
		private const int sliderMinValue = 1;
		private const int sliderInitialValue = 5;
		private const string popupPath = "Prefabs/OutGame/QuestPrepare/QuestRepeatPopup";
		private const string iconPath = "Prefabs/OutGame/QuestPrepare/RepeatItemIcon";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ItemList, int> __9__28_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _InitRecoverStaminaItemIcon_b__28_1(ItemList x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public int id;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal bool _OnOkButtonPressed_b__0(ItemList x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public CommonPopup popup;
			public QuestRepeatPopup __4__this;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _CreateWarningShortStaminaPopup_b__0();
			internal void _CreateWarningShortStaminaPopup_b__1();
		}
	
		// Constructors
		public QuestRepeatPopup();
	
		// Methods
		protected override void Start();
		public static QuestRepeatPopup Create(UnityAction onOkButtonPressed, bool isEnableTransformToggle);
		private void SetAutoPlayToggle();
		private void SaveAutoPlayToggle();
		private void SetAutoTransformToggle();
		private void SaveAutoTransformToggle();
		private void SetSliderValue();
		private void SetSliderText(float value);
		public void GameSpeedSliderValueChanged(float value);
		private void SaveGameSpeedt();
		private void InitRecoverStaminaItemIcon();
		public override void OnOkButtonPressed();
		public void SetUseItem(ItemList item, bool toEnable);
		private int GetConsumeStamina();
		private void CreateWarningShortStaminaPopup();
		public void OnValueChanged(bool value);
		public void OnRepeatOffPressed();
		public void OnUseAllStaminaPressed();
		public void OnRepeatSettingCountPressed();
		public void RepeatNumSliderValueChanged(float value);
		private void UpdateToggleState(QuestRepeatSettingModel.RepeatSetting newState);
		private void ToggleSetValue(QuestRepeatSettingModel.RepeatSetting newState);
		public void OnAutoPlayToggleChanged(int index, bool isFromUI);
		[CompilerGenerated]
		private void _Start_b__18_0();
		[CompilerGenerated]
		private void _Start_b__18_1();
		[CompilerGenerated]
		private void _Start_b__18_2();
		[CompilerGenerated]
		private void _InitRecoverStaminaItemIcon_b__28_0(ItemGetListResponse itemRes);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0();
	}
}
