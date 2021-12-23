using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class OptionPopup : PopupBase
	{
		private enum ReloadSceneType
		{
			None,
			MyPage,
			Manacircle,
			DragonStroke
		}

		public enum TabIndex
		{
			Sound,
			Game,
			System,
			Notification
		}

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
		public CommonSliderSelection graphicQualitySlider;

		public TabBase fpsTab;

		public CommonSliderSelection resolutionSlider;

		public TabBase antiAliasingTab;

		public GameObject antiAliasingRoot;

		public TabBase otherCharaEffectTab;

		public TabBase cameraShakeTab;

		public TabBase autoZoomTab;

		public TabBase skillCameraMoveTab;

		public TabBase buttonLayoutTab;

		public TabBase leftHandedTab;

		public TabBase skillCutinTab;

		public CommonSliderSelection flickSensitivitySlider;

		public TabBase quickTurn180Tab;

		public TabBase quickTurn90Tab;

		public TabBase autoUkemiTab;

		public TabBase confirmElementTab;

		public TabBase skinWeaponTab;

		[SerializeField]
		[Header("SystemPage")]
		public TabBase myPageBGModeTab;

		public TabBase manacircleViewModeTab;

		public Text myPageBgm;

		public TabBase settingDragonStrokeViewModeTab;

		public TabBase pettingGyroTab;

		public GameObject pettingGyroNotSupportedCommentGO;

		public TabBase autoProtectionTab;

		public Toggle dragonSRProtectionToggle;

		public Toggle dragonSSRProtectionToggle;

		public TabBase autoSkipReadTab;

		public TabBase textDisplaySpeedTab;

		public Text currentVoiceLanguageText;

		public GameObject[] androidSpecificSettingGOs;

		public Text androidSpecificSettingCurrentStatus;

		public Text performanceModeSettingText;

		public CanvasGroup autoProtectionToggleCanvasGroup;

		public CanvasGroup gyroToggleCanvasGroup;

		[SerializeField]
		[Header("NotificationPage")]
		public TabBase singleStaminaNotificationTab;

		public TabBase multiStaminaNotificationTab;

		public TabBase dragonSmithNotificationTab;

		public TabBase buildDoneNotificationTab;

		public TabBase goldFarmNotificationTab;

		public TabBase dragonTreeNotificationTab;

		public TabBase honeyDrinkNotificationTab;

		public TabBase dmodeExpeditionEndNotificationTab;

		public TabBase sleepTimeTab;

		public CanvasGroup[] allNotificationCanvasGroups;

		public CanvasGroup sleepTimeCanvasGroup;

		public InputField sleepTimeStartHourInput;

		public InputField sleepTimeEndHourInput;

		public InputField sleepTimeStartMinInput;

		public InputField sleepTimeEndMinInput;

		public Text sleepTimeStartText;

		public Text sleepTimeEndText;

		public Button sleepTimeStartButton;

		public Button sleepTimeEndButton;

		private bool openMenuOnClose;

		private const string muteText = "MUTE";

		private const float invalidAlphaValue = 0.5f;

		private OptionModel.Setting.SystemSetting.AutoLockSetting oldAutoLockSetting;

		private OptionModel.Setting.NotificationSetting oldNotificationSetting;

		private OptionModel.Setting.GameSetting.GraphicSetting.QualityType oldGraphicType;

		private OptionModel.Setting.GameSetting.GraphicSetting.ResolutionType oldResolutionType;

		private bool oldAntiAliasing;

		private int oldFPS;

		private OptionModel.Setting.SystemSetting.MyPageBGMode oldMyPageBGMode;

		private OptionModel.Setting.SystemSetting.ManacircleViewMode oldManacircleViewMode;

		private OptionModel.Setting.SystemSetting.DragonStrokeViewMode oldDragonStrokeViewMode;

		private bool[] pageEventBinded;

		private float prevSEVal;

		private float prevVocalVal;

		public static void Create(bool openMenuOnClose = true, [Optional] Action<OptionPopup> onCreated)
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

		private void RequestAutoLockOptionChanged(Action onFinished)
		{
		}

		private void RefineLocalPushByOption()
		{
		}

		public void OnAppliedAnyAction()
		{
		}

		public void OnAppliedAnyLanguageAction()
		{
		}

		protected override void Start()
		{
		}

		private void BindEvent(int index)
		{
		}

		private char OnValidateHourInput(string text, int charIndex, char addedChar)
		{
			return default(char);
		}

		private char OnValidateMinuteInput(string text, int charIndex, char addedChar)
		{
			return default(char);
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

		private void ApplyUIByOptionSetting(TabIndex tabIndex)
		{
		}

		private void UpdateAntiAliasingTab()
		{
		}

		private void UpdateOtherCharaEffectTab()
		{
		}

		private void AfterApplyUIByOptionSetting(TabIndex index)
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

		private IEnumerator CheckNonStoryVoiceDownload(UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled)
		{
			return null;
		}

		private void OpenNonStoryVoicePopup(DownloadOperation downloadOperation, UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled)
		{
		}

		private void DownloadNonStoryVoiceCompleteCallback()
		{
		}

		private void NonStoryVoiceCompleteCallbackWithoutDownloading()
		{
		}

		private void DownloadNonStoryVoiceCancelCallback()
		{
		}

		private CommonPopup CreateNonStoryVoiceDeleteComfirmPopup()
		{
			return null;
		}

		private IEnumerator DeleteNonStoryVoice(HashSet<string> targetAssets)
		{
			return null;
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

		public void OnAntiAliasingToggled(bool value)
		{
		}

		public void OnOtherCharaEffectToggled(bool value)
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

		public void OnLeftHandedToggled(bool value)
		{
		}

		public void OnShowSkillCutinToggled(bool value)
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

		public void OnAutoUkemiToggled(bool value)
		{
		}

		public void OnConfirmElementToggled(bool value)
		{
		}

		public void OnSkinWeaponToggled(bool value)
		{
		}

		private void ReflectMypageModeToggled(bool value)
		{
		}

		public void OnMyPageModeToggled(bool value)
		{
		}

		private IEnumerator CheckTargetDataDownload(int[] targetGroups, UnityAction onCompleted, UnityAction onCanceled)
		{
			return null;
		}

		private void DownloadMyPage3dCompleteCallback()
		{
		}

		private void DownloadMyPage3dCancelCallback()
		{
		}

		public void OnManacircleViewModeToggled(bool value)
		{
		}

		public void OnDragonDardenViewModeToggled(bool value)
		{
		}

		public void OnPettingGyroToggled(bool value)
		{
		}

		public void OnAutoProtectionToggled(bool value)
		{
		}

		public void OnProtectDragonSRToggled(bool value)
		{
		}

		public void OnProtectDragonSSRToggled(bool value)
		{
		}

		public void OnAutoSkipReadToggled(bool value)
		{
		}

		public void OnTextDisplaySpeedToggled(bool value)
		{
		}

		public void OnChangeLanguageButtonPressed()
		{
		}

		private void SetVoiceLanguageDisplay()
		{
		}

		public void OnFullDownloadButtonPressed()
		{
		}

		public void OnQuestDataDeleteButtonPressed()
		{
		}

		public void OnAllNotificationToggled(bool value)
		{
		}

		public void OnOfficialNotificationToggled(bool value)
		{
		}

		public void OnDragonSmithNotificationToggled(bool value)
		{
		}

		public void OnSingleStaminaNotificationToggled(bool value)
		{
		}

		public void OnMultiStaminaNotificationToggled(bool value)
		{
		}

		public void OnBuildDoneNotificationToggled(bool value)
		{
		}

		public void OnGoldFarmNotificationToggled(bool value)
		{
		}

		public void OnDragonTreeNotificationToggled(bool value)
		{
		}

		public void OnHoneyDrinkNotificationToggled(bool value)
		{
		}

		public void OnDmodeExpeditionEndNotificationToggled(bool value)
		{
		}

		public void OnSleepTimeToggled(bool value)
		{
		}

		public void OnSleepStartHourTimeSet(int hour)
		{
		}

		public void OnSleepStartMinTimeSet(int min)
		{
		}

		public void OnSleepEndHourTimeSet(int hour)
		{
		}

		public void OnSleepEndMinTimeSet(int min)
		{
		}

		public void RefreshNotificationSleepTimeDisplay()
		{
		}

		public void OnSleepStartTimeButtonPressed()
		{
		}

		public void OnSleepEndTimeButtonPressed()
		{
		}

		public void OnResetSoundSetting()
		{
		}

		private void DownloadNonStoryVoiceCompleteCallbackOnResetSoundSetting()
		{
		}

		private void NonStoryVoiceCompleteCallbackWithoutDownloadingOnResetSoundSetting()
		{
		}

		public void OnResetGameSetting()
		{
		}

		public void OnResetSystemSetting()
		{
		}

		private void DownloadMyPage3dCompleteCallbackOnResetSystemSetting()
		{
		}

		private void ReturnToTitle()
		{
		}

		public void OnSwitchPerformanceModeButtonPressed()
		{
		}

		public void OnResetNotificationSetting()
		{
		}

		public void OnChangeAndoirdSettingPressed()
		{
		}

		public static bool IsAndroidSystemUiEditSupported()
		{
			return default(bool);
		}

		private string GetAndroidSpecificSettingCurrentStatusText()
		{
			return null;
		}

		public void OnChangeMyPageBgmPressed()
		{
		}

		private void OnBgmChangeAction(int bgmId)
		{
		}

		private bool IsCurrentScenePartyTop()
		{
			return default(bool);
		}

		private string GetCurrentMyPageBgmTitle()
		{
			return null;
		}
	}
}
