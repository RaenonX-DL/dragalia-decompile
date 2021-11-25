using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestAutoSpeedSettingPopup : CommonPopup
	{
		[SerializeField]
		private TabBase repeautoPlayToggle;

		[SerializeField]
		private TabBase autoTransformToggle;

		[SerializeField]
		private CommonSliderSelection gameSpeedSlider;

		[SerializeField]
		private Text disableRepeatText;

		private UnityAction onOkButtonPressed;

		private const string popupPath = "Prefabs/OutGame/QuestPrepare/QuestAutoSpeedSettingPopup";

		private float speedSliderValue;

		private bool isEnableTransformToggle;

		protected override void Start()
		{
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

		public void SliderValueChanged(float value)
		{
		}

		private void SaveGameSpeedt()
		{
		}

		public static QuestAutoSpeedSettingPopup Create(UnityAction onOkButtonPressed, bool isEnableRepeatQuest, bool isEnableTransformToggle)
		{
			return null;
		}

		public override void OnOkButtonPressed()
		{
		}

		public void OnAutoPlayToggleChanged(int index, bool isFromUI)
		{
		}
	}
}
