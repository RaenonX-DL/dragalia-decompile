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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameOptionPopup : PopupBase
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
		public TabBase cameraShakeTab;
		public TabBase autoZoomTab;
		public TabBase skillCameraMoveTab;
		public TabBase buttonLayoutTab;
		public CommonSliderSelection flickSensitivitySlider;
		public TabBase quickTurn180Tab;
		public TabBase quickTurn90Tab;
		public TabBase battleLogTab;
		public TabBase battleLogEnemyTab;
		public TabBase battleLogPlayerTab;
		public TabBase battleLogPartyTab;
		public CommonSliderSelection battleLogWaitTimeScaleSlider;
		private bool openMenuOnClose;
		private const string muteText = "MUTE";
		private OptionModel.Setting.GameSetting.GraphicSetting.QualityType oldGraphicType;
		private OptionModel.Setting.GameSetting.GraphicSetting.ResolutionType oldResolutionType;
		private int oldFPS;
		private bool[] pageEventBinded;
		private float prevSEVal;
		private float prevVocalVal;
		[Header]
		[SerializeField]
		private RectTransform touchUI;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public bool openMenuOnClose;
			public Action<InGameOptionPopup> onCreated;
			public Action createPopupAction;
	
			// Constructors
			public __c__DisplayClass30_0();
	
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
			public static UnityAction __9__38_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnCloseButtonPressed_b__38_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public Action<int> sliderCallback;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _SliderCallbackToInt_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public Action<bool> toggleCallback;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _TabCallbackToToggle_b__0(int index, bool isFromUI);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public Func<int> originalValueGetter;
			public Action<int> inputCallback;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _InputFieldToInt_b__0(string text);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public int[] localizedVoiceGroups;
			public HashSet<string> hashSet;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _CheckNonStoryVoiceIsDownloaded_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CheckNonStoryVoiceIsDownloaded_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public InGameOptionPopup __4__this;
			private __c__DisplayClass59_0 __8__1;
			private TouchGuardObject _touchGuard_5__2;
			private ParallelJob _job_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckNonStoryVoiceIsDownloaded_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public InGameOptionPopup();
	
		// Methods
		public static void Create(bool openMenuOnClose = true, Action<InGameOptionPopup> onCreated = null);
		public static InGameOptionPopup CreateInGameOptionPopup(string path, Transform parentTransform);
		private void Initialize();
		private void OnEnable();
		private void Awake();
		private void LateUpdate();
		protected override void OnDestroy();
		private void InvokeChangeEvents();
		public void OnCloseButtonPressed();
		public void OnAppliedAnyAction();
		protected override void Start();
		private void initializeCamera();
		private void BindEvent(int index);
		private void SliderCallbackToInt(CommonSliderSelection slider, Action<int> sliderCallback);
		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback);
		private void InputFieldToInt(InputField inputField, Action<int> inputCallback, Func<int> originalValueGetter);
		private int GetEnumMaxValue<T>()
			where T : struct, IConvertible;
		private void ApplyUIByOptionSetting(OptionPopup.TabIndex index);
		private void AfterApplyUIByOptionSetting(OptionPopup.TabIndex index);
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
		private IEnumerator CheckNonStoryVoiceIsDownloaded();
		private void OpenNonStoryVoiceWarningPopup(DownloadOperation downloadOperation);
		private void NonStoryVoiceWithoutWarningCompleteCallback();
		private void NonStoryVoiceWarningCompleteCallback();
		public void OnGraphicQualityChanged(int value);
		public void OnFPSToggled(bool value);
		public void OnResolutionChanged(int value);
		public void OnCameraShakeToggled(bool value);
		public void OnAutoZoomToggled(bool value);
		public void OnShowSkillCameraMoveToggled(bool value);
		public void OnSwapCharacterAndSkillToggled(bool value);
		public void OnFlickSensibilityChanged(int value);
		public void OnQuickTurn180Toggled(bool value);
		public void OnQuickTurn90Toggled(bool value);
		public void OnBattleLogEnableToggled(bool value);
		public void OnBattleLogEnemyEnableToggled(bool value);
		public void OnBattleLogPlayerEnableToggled(bool value);
		public void OnBattleLogPartyEnableToggled(bool value);
		public void UpdateSelectTab(ref TabBase tab, bool enable);
		private void CheckBattleLogEnable();
		public void OnBattleLogWaitTimeScaleChanged(int value);
		public void OnResetSoundSetting();
		public void OnResetGameSetting();
		[CompilerGenerated]
		private void _OnEnable_b__33_0(int index);
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__38_0();
		[CompilerGenerated]
		private void _BindEvent_b__42_0(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__42_1(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__42_2(PointerEventData x);
		[CompilerGenerated]
		private void _BindEvent_b__42_3(PointerEventData x);
	}
}
