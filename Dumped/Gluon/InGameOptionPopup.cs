using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameOptionPopup : PopupBase
	{
		[SerializeField]
		[Header("Tabs")]
		public TabBase tabController;

		public OptionPage[] pages;

		[SerializeField]
		[Header("SoundPage")]
		public CommonSliderSelection bgmSlider;

		public CommonSliderSelection seSlider;

		public CommonSliderSelection voiceSlider;

		public TabBase vocalTab;

		public Toggle bgmToggle;

		public Toggle seToggle;

		public Toggle voiceToggle;

		[SerializeField]
		[Header("GamePage")]
		public TabBase cameraShakeTab;

		public TabBase autoZoomTab;

		public TabBase skillCameraMoveTab;

		public TabBase buttonLayoutTab;

		public CommonSliderSelection flickSensitivitySlider;

		public TabBase quickTurn180Tab;

		public TabBase quickTurn90Tab;

		private bool openMenuOnClose;

		private const string muteText = "MUTE";

		private OptionModel.Setting.GameSetting.GraphicSetting.QualityType oldGraphicType;

		private OptionModel.Setting.GameSetting.GraphicSetting.ResolutionType oldResolutionType;

		private int oldFPS;

		private bool[] pageEventBinded;

		private float prevSEVal;

		private float prevVocalVal;

		[SerializeField]
		[Header("TouchEffect")]
		private RectTransform touchUI;

		public static void Create(bool openMenuOnClose = true, [Optional] Action<InGameOptionPopup> onCreated)
		{
		}

		public static InGameOptionPopup CreateInGameOptionPopup(string path, Transform parentTransform)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void InvokeChangeEvents()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnAppliedAnyAction()
		{
		}

		protected override void Start()
		{
		}

		private void initializeCamera()
		{
		}

		private void BindEvent(int index)
		{
		}

		private void SliderCallbackToInt(CommonSliderSelection slider, Action<int> sliderCallback)
		{
		}

		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback)
		{
		}

		private void InputFieldToInt(InputField inputField, Action<int> inputCallback, Func<int> originalValueGetter)
		{
		}

		private int GetEnumMaxValue<T>() where T : struct, IConvertible
		{
			return default(int);
		}

		private void ApplyUIByOptionSetting(OptionPopup.TabIndex index)
		{
		}

		private void AfterApplyUIByOptionSetting(OptionPopup.TabIndex index)
		{
		}

		public void OnPlaySampleSE()
		{
		}

		public void OnPlaySampleVoice()
		{
		}

		public void OnVocalSettingChanged(int index, bool isFromUI)
		{
		}

		public void OnBGMValueChanged(float val)
		{
		}

		public void OnSEValueChanged(float val)
		{
		}

		public void OnVoiceValueChanged(float val)
		{
		}

		public void OnBGMToggled(bool value)
		{
		}

		public void OnSEToggled(bool value)
		{
		}

		private void ReflectVoiceToggled(bool value)
		{
		}

		public void OnVoiceToggled(bool value)
		{
		}

		private IEnumerator CheckNonStoryVoiceIsDownloaded()
		{
			return null;
		}

		private void OpenNonStoryVoiceWarningPopup(DownloadOperation downloadOperation)
		{
		}

		private void NonStoryVoiceWithoutWarningCompleteCallback()
		{
		}

		private void NonStoryVoiceWarningCompleteCallback()
		{
		}

		public void OnGraphicQualityChanged(int value)
		{
		}

		public void OnFPSToggled(bool value)
		{
		}

		public void OnResolutionChanged(int value)
		{
		}

		public void OnCameraShakeToggled(bool value)
		{
		}

		public void OnAutoZoomToggled(bool value)
		{
		}

		public void OnShowSkillCameraMoveToggled(bool value)
		{
		}

		public void OnSwapCharacterAndSkillToggled(bool value)
		{
		}

		public void OnFlickSensibilityChanged(int value)
		{
		}

		public void OnQuickTurn180Toggled(bool value)
		{
		}

		public void OnQuickTurn90Toggled(bool value)
		{
		}

		public void OnResetSoundSetting()
		{
		}

		public void OnResetGameSetting()
		{
		}
	}
}
