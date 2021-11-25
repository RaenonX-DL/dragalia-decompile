using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestRepeatPopup : CommonPopup
	{
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
		private Text consumeStaminaText;

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

		protected override void Start()
		{
		}

		public static QuestRepeatPopup Create(UnityAction onOkButtonPressed, bool isEnableTransformToggle)
		{
			return null;
		}

		private void SetAutoPlayToggle()
		{
		}

		private void SaveAutoPlayToggle()
		{
		}

		private void SetAutoTransformToggle()
		{
		}

		private void SaveAutoTransformToggle()
		{
		}

		private void SetSliderValue()
		{
		}

		private void SetSliderText(float value)
		{
		}

		public void GameSpeedSliderValueChanged(float value)
		{
		}

		private void SaveGameSpeedt()
		{
		}

		private void InitRecoverStaminaItemIcon()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public void SetUseItem(ItemList item, bool toEnable)
		{
		}

		private int GetConsumeStamina()
		{
			return default(int);
		}

		private void CreateWarningShortStaminaPopup()
		{
		}

		public void OnValueChanged(bool value)
		{
		}

		public void OnRepeatOffPressed()
		{
		}

		public void OnUseAllStaminaPressed()
		{
		}

		public void OnRepeatSettingCountPressed()
		{
		}

		public void RepeatNumSliderValueChanged(float value)
		{
		}

		private void UpdateToggleState(QuestRepeatSettingModel.RepeatSetting newState)
		{
		}

		private void ToggleSetValue(QuestRepeatSettingModel.RepeatSetting newState)
		{
		}

		public void OnAutoPlayToggleChanged(int index, bool isFromUI)
		{
		}
	}
}
