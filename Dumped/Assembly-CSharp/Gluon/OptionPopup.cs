/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Core;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		public OptionPage[] pages;
		[Header]
		[SerializeField]
		public CommonSliderSelection bgmSlider;
		public CommonSliderSelection seSlider;
		public CommonSliderSelection voiceSlider;
		public TabBase vocalTab;
		public Toggle bgmToggle;
		public Toggle seToggle;
		public Toggle voiceToggle;
		[Header]
		[SerializeField]
		public CommonSliderSelection graphicQualitySlider;
		public TabBase fpsTab;
		public CommonSliderSelection resolutionSlider;
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
		[Header]
		[SerializeField]
		public TabBase myPageBGModeTab;
		public TabBase manacircleViewModeTab;
		public UnityEngine.UI.Text myPageBgm;
		public TabBase settingDragonStrokeViewModeTab;
		public TabBase pettingGyroTab;
		public GameObject pettingGyroNotSupportedCommentGO;
		public TabBase autoProtectionTab;
		public Toggle dragonSRProtectionToggle;
		public Toggle dragonSSRProtectionToggle;
		public TabBase autoSkipReadTab;
		public TabBase textDisplaySpeedTab;
		public UnityEngine.UI.Text currentVoiceLanguageText;
		public GameObject[] androidSpecificSettingGOs;
		public UnityEngine.UI.Text androidSpecificSettingCurrentStatus;
		public UnityEngine.UI.Text performanceModeSettingText;
		public CanvasGroup autoProtectionToggleCanvasGroup;
		public CanvasGroup gyroToggleCanvasGroup;
		[Header]
		[SerializeField]
		public TabBase singleStaminaNotificationTab;
		public TabBase multiStaminaNotificationTab;
		public TabBase dragonSmithNotificationTab;
		public TabBase buildDoneNotificationTab;
		public TabBase goldFarmNotificationTab;
		public TabBase dragonTreeNotificationTab;
		public TabBase honeyDrinkNotificationTab;
		public TabBase sleepTimeTab;
		public CanvasGroup[] allNotificationCanvasGroups;
		public CanvasGroup sleepTimeCanvasGroup;
		public InputField sleepTimeStartHourInput;
		public InputField sleepTimeEndHourInput;
		public InputField sleepTimeStartMinInput;
		public InputField sleepTimeEndMinInput;
		public UnityEngine.UI.Text sleepTimeStartText;
		public UnityEngine.UI.Text sleepTimeEndText;
		public Button sleepTimeStartButton;
		public Button sleepTimeEndButton;
		private bool openMenuOnClose;
		private const string muteText = "MUTE";
		private const float invalidAlphaValue = 0.5f;
		private OptionModel.Setting.SystemSetting.AutoLockSetting oldAutoLockSetting;
		private OptionModel.Setting.NotificationSetting oldNotificationSetting;
		private OptionModel.Setting.GameSetting.GraphicSetting.QualityType oldGraphicType;
		private OptionModel.Setting.GameSetting.GraphicSetting.ResolutionType oldResolutionType;
		private int oldFPS;
		private OptionModel.Setting.SystemSetting.MyPageBGMode oldMyPageBGMode;
		private OptionModel.Setting.SystemSetting.ManacircleViewMode oldManacircleViewMode;
		private OptionModel.Setting.SystemSetting.DragonStrokeViewMode oldDragonStrokeViewMode;
		private bool[] pageEventBinded;
		private float prevSEVal;
		private float prevVocalVal;
	
		// Nested types
		private enum ReloadSceneType
		{
			None = 0,
			MyPage = 1,
			Manacircle = 2,
			DragonStroke = 3
		}
	
		public enum TabIndex
		{
			Sound = 0,
			Game = 1,
			System = 2,
			Notification = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public bool openMenuOnClose;
			public Action<OptionPopup> onCreated;
			public Action createPopupAction;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _Create_b__0();
			internal void _Create_b__1(OptionGetOptionResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__81_0;
			public static UnityAction __9__82_1;
			public static Func<bool> __9__114_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InvokeChangeEvents_b__81_0();
			internal void _OnCloseButtonPressed_b__82_1();
			internal bool _DeleteNonStoryVoice_b__114_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _RequestAutoLockOptionChanged_b__0(OptionSetOptionResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0
		{
			// Fields
			public Action<int> sliderCallback;
	
			// Constructors
			public __c__DisplayClass91_0();
	
			// Methods
			internal void _SliderCallbackToInt_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public Action<bool> toggleCallback;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _TabCallbackToToggle_b__0(int index, bool isFromUI);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public Func<int> originalValueGetter;
			public Action<int> inputCallback;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _InputFieldToInt_b__0(string text);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public int[] localizedVoiceGroups;
			public HashSet<string> hashSet;
	
			// Constructors
			public __c__DisplayClass108_0();
	
			// Methods
			internal void _CheckNonStoryVoiceDownload_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CheckNonStoryVoiceDownload_d__108 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OptionPopup __4__this;
			private __c__DisplayClass108_0 __8__1;
			public UnityAction onCompleted;
			public UnityAction onCompletedWithoutDownloading;
			public UnityAction onCanceled;
			private TouchGuardObject _touchGuard_5__2;
			private ParallelJob _job_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckNonStoryVoiceDownload_d__108(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass113_0
		{
			// Fields
			public CommonPopup popup;
			public OptionPopup __4__this;
			public HashSet<string> targetAssets;
	
			// Constructors
			public __c__DisplayClass113_0();
	
			// Methods
			internal void _CreateNonStoryVoiceDeleteComfirmPopup_b__0();
			internal void _CreateNonStoryVoiceDeleteComfirmPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass114_0
		{
			// Fields
			public HashSet<string> targetAssets;
			public CommonPopup popup;
			public OptionPopup __4__this;
	
			// Nested types
			private struct __DeleteNonStoryVoice_b__1_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass114_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass114_0();
	
			// Methods
			internal void _DeleteNonStoryVoice_b__0();
			internal async void _DeleteNonStoryVoice_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _DeleteNonStoryVoice_d__114 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HashSet<string> targetAssets;
			public OptionPopup __4__this;
			private __c__DisplayClass114_0 __8__1;
			private ParallelJob _job_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DeleteNonStoryVoice_d__114(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass133_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public int[] targetGroups;
			public HashSet<string> hashSet;
	
			// Constructors
			public __c__DisplayClass133_0();
	
			// Methods
			internal void _CheckTargetDataDownload_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CheckTargetDataDownload_d__133 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int[] targetGroups;
			private __c__DisplayClass133_0 __8__1;
			public UnityAction onCompleted;
			public UnityAction onCanceled;
			private TouchGuardObject _touchGuard_5__2;
			private ParallelJob _job_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckTargetDataDownload_d__133(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass144_0
		{
			// Fields
			public OptionPopup __4__this;
			public Localize.Language savedLanguage;
			public bool isVoiceOn;
			public Localize.Language savedVoiceLanguage;
			public Action<PushNotificationUpdateSettingResponse> __9__1;
	
			// Constructors
			public __c__DisplayClass144_0();
	
			// Methods
			internal void _OnChangeLanguageButtonPressed_b__0(Localize.Language toDisplayLanguage, Localize.Language toVoiceLanguage);
			internal void _OnChangeLanguageButtonPressed_b__1(PushNotificationUpdateSettingResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass146_0
		{
			// Fields
			public FullDownloadPopup popup;
	
			// Constructors
			public __c__DisplayClass146_0();
	
			// Methods
			internal void _OnFullDownloadButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0
		{
			// Fields
			public QuestDataDeletePopup popup;
	
			// Constructors
			public __c__DisplayClass147_0();
	
			// Methods
			internal void _OnQuestDataDeleteButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass165_0
		{
			// Fields
			public OptionPopup __4__this;
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass165_0();
	
			// Methods
			internal void _OnResetSoundSetting_b__0();
			internal void _OnResetSoundSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass168_0
		{
			// Fields
			public OptionPopup __4__this;
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass168_0();
	
			// Methods
			internal void _OnResetGameSetting_b__0();
			internal void _OnResetGameSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass169_0
		{
			// Fields
			public OptionPopup __4__this;
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass169_0();
	
			// Methods
			internal void _OnResetSystemSetting_b__0();
			internal void _OnResetSystemSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass172_0
		{
			// Fields
			public CommonPopup popup;
			public OptionPopup __4__this;
	
			// Constructors
			public __c__DisplayClass172_0();
	
			// Methods
			internal void _OnSwitchPerformanceModeButtonPressed_b__0();
			internal void _OnSwitchPerformanceModeButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass172_1
		{
			// Fields
			public CommonPopup popup;
			public OptionPopup __4__this;
	
			// Constructors
			public __c__DisplayClass172_1();
	
			// Methods
			internal void _OnSwitchPerformanceModeButtonPressed_b__2();
			internal void _OnSwitchPerformanceModeButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass173_0
		{
			// Fields
			public OptionPopup __4__this;
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass173_0();
	
			// Methods
			internal void _OnResetNotificationSetting_b__0();
			internal void _OnResetNotificationSetting_b__1();
		}
	
		// Constructors
		public OptionPopup();
	
		// Methods
		public static void Create(bool openMenuOnClose = true, Action<OptionPopup> onCreated = null);
		private void OnEnable();
		private void Awake();
		private void LateUpdate();
		protected override void OnDestroy();
		private void InvokeChangeEvents();
		public void OnCloseButtonPressed();
		private void RequestAutoLockOptionChanged(Action onFinished);
		private void RefineLocalPushByOption();
		public void OnAppliedAnyAction();
		public void OnAppliedAnyLanguageAction();
		protected override void Start();
		private void BindEvent(int index);
		private char OnValidateHourInput(string text, int charIndex, char addedChar);
		private char OnValidateMinuteInput(string text, int charIndex, char addedChar);
		private void SliderCallbackToInt(CommonSliderSelection slider, Action<int> sliderCallback);
		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback);
		private void InputFieldToInt(InputField inputField, Action<int> inputCallback, Func<int> originalValueGetter);
		private int GetEnumMaxValue<T>()
			where T : struct, IConvertible;
		private void ApplyUIByOptionSetting(TabIndex tabIndex);
		private void UpdateOtherCharaEffectTab();
		private void AfterApplyUIByOptionSetting(TabIndex index);
		public void OnPlaySampleSE();
		public void OnPlaySampleVoice();
		public void OnVocalSettingChanged(int index, bool isFromUI);
		public void OnBGMValueChanged(float val);
		public void OnSEValueChanged(float val);
		public void OnVoiceValueChanged(float val);
		public void OnBGMToggled(bool value);
		public void OnSEToggled(bool value);
		private void ReflectVoiceToggled(bool value);
		public void OnVoiceToggled(bool value);
		[IteratorStateMachine]
		private IEnumerator CheckNonStoryVoiceDownload(UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled);
		private void OpenNonStoryVoicePopup(DownloadOperation downloadOperation, UnityAction onCompleted, UnityAction onCompletedWithoutDownloading, UnityAction onCanceled);
		private void DownloadNonStoryVoiceCompleteCallback();
		private void NonStoryVoiceCompleteCallbackWithoutDownloading();
		private void DownloadNonStoryVoiceCancelCallback();
		private CommonPopup CreateNonStoryVoiceDeleteComfirmPopup();
		[IteratorStateMachine]
		private IEnumerator DeleteNonStoryVoice(HashSet<string> targetAssets);
		public void OnGraphicQualityChanged(int value);
		public void OnFPSToggled(bool value);
		public void OnResolutionChanged(int value);
		public void OnOtherCharaEffectToggled(bool value);
		public void OnCameraShakeToggled(bool value);
		public void OnAutoZoomToggled(bool value);
		public void OnShowSkillCameraMoveToggled(bool value);
		public void OnSwapCharacterAndSkillToggled(bool value);
		public void OnLeftHandedToggled(bool value);
		public void OnShowSkillCutinToggled(bool value);
		public void OnFlickSensibilityChanged(int value);
		public void OnQuickTurn180Toggled(bool value);
		public void OnQuickTurn90Toggled(bool value);
		public void OnAutoUkemiToggled(bool value);
		public void OnConfirmElementToggled(bool value);
		public void OnSkinWeaponToggled(bool value);
		private void ReflectMypageModeToggled(bool value);
		public void OnMyPageModeToggled(bool value);
		[IteratorStateMachine]
		private IEnumerator CheckTargetDataDownload(int[] targetGroups, UnityAction onCompleted, UnityAction onCanceled);
		private void DownloadMyPage3dCompleteCallback();
		private void DownloadMyPage3dCancelCallback();
		public void OnManacircleViewModeToggled(bool value);
		public void OnDragonDardenViewModeToggled(bool value);
		public void OnPettingGyroToggled(bool value);
		public void OnAutoProtectionToggled(bool value);
		public void OnProtectDragonSRToggled(bool value);
		public void OnProtectDragonSSRToggled(bool value);
		public void OnAutoSkipReadToggled(bool value);
		public void OnTextDisplaySpeedToggled(bool value);
		public void OnChangeLanguageButtonPressed();
		private void SetVoiceLanguageDisplay();
		public void OnFullDownloadButtonPressed();
		public void OnQuestDataDeleteButtonPressed();
		public void OnAllNotificationToggled(bool value);
		public void OnOfficialNotificationToggled(bool value);
		public void OnDragonSmithNotificationToggled(bool value);
		public void OnSingleStaminaNotificationToggled(bool value);
		public void OnMultiStaminaNotificationToggled(bool value);
		public void OnBuildDoneNotificationToggled(bool value);
		public void OnGoldFarmNotificationToggled(bool value);
		public void OnDragonTreeNotificationToggled(bool value);
		public void OnHoneyDrinkNotificationToggled(bool value);
		public void OnSleepTimeToggled(bool value);
		public void OnSleepStartHourTimeSet(int hour);
		public void OnSleepStartMinTimeSet(int min);
		public void OnSleepEndHourTimeSet(int hour);
		public void OnSleepEndMinTimeSet(int min);
		public void RefreshNotificationSleepTimeDisplay();
		public void OnSleepStartTimeButtonPressed();
		public void OnSleepEndTimeButtonPressed();
		public void OnResetSoundSetting();
		private void DownloadNonStoryVoiceCompleteCallbackOnResetSoundSetting();
		private void NonStoryVoiceCompleteCallbackWithoutDownloadingOnResetSoundSetting();
		public void OnResetGameSetting();
		public void OnResetSystemSetting();
		private void DownloadMyPage3dCompleteCallbackOnResetSystemSetting();
		private void ReturnToTitle();
		public void OnSwitchPerformanceModeButtonPressed();
		public void OnResetNotificationSetting();
		public void OnChangeAndoirdSettingPressed();
		public static bool IsAndroidSystemUiEditSupported();
		private string GetAndroidSpecificSettingCurrentStatusText();
		public void OnChangeMyPageBgmPressed();
		private void OnBgmChangeAction(int bgmId);
		private bool IsCurrentScenePartyTop();
		private string GetCurrentMyPageBgmTitle();
		[CompilerGenerated]
		private void _OnEnable_b__77_0(int index);
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__82_0();
		[CompilerGenerated]
		private void _BindEvent_b__88_0(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__88_1(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__88_2(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__88_3(PointerEventData x);
		[CompilerGenerated]
		private void _OnSleepStartTimeButtonPressed_b__163_0(int hour, int min);
		[CompilerGenerated]
		private void _OnSleepEndTimeButtonPressed_b__164_0(int hour, int min);
		[CompilerGenerated]
		private void _OnChangeAndoirdSettingPressed_b__174_0();
		[CompilerGenerated]
		private void _OnChangeMyPageBgmPressed_b__177_0(int bgmId);
	}
}
