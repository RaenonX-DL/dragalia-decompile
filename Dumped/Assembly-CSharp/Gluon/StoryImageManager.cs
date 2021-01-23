/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.PostEffectParams;
using SPFX;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryImageManager : SingletonMonoBehaviour<Gluon.StoryImageManager>
	{
		// Fields
		public float autoWaitTime;
		public float autoWaitTimeForVoice;
		public float autoWaitTimeForNextPage;
		public float[] addAutoWaitTimeByLineCount;
		public float windowFadeinTimeForPrintCommand;
		public float windowFadeTimeWithAnimation;
		public MainCameraCtrl mainCameraCtrl;
		public Camera uiCamera;
		public Camera[] camera2D;
		public PostEffect[] postEffect2D;
		public SPFXCameraDistortion[] cameraDistortion2D;
		public Vector3[] basePosCamera2D;
		public StoryBackgroundBillboard[] backgrounds;
		public EffectObject[] backgroundEffects;
		public StoryImage backgroundFrame;
		public StoryImage chapterIntroFrame;
		public StoryImage backgroundLayer;
		public StoryImage backgroundSubLayer;
		public StoryImage characterFrontLayer;
		public StoryImage telop;
		public UnityEngine.UI.Text telopMainText;
		public UnityEngine.UI.Text telopSubText;
		public UnityEngine.UI.Text telopMainRubyText;
		public UnityEngine.UI.Text telopSubRubyText;
		public Canvas uiCanvas;
		public bool isForceTouchDisable;
		public bool completeForceTouchDisable;
		public StoryImage topic;
		public RectTransform choiceButtonsParent;
		public StoryImage choice;
		public UnityEngine.UI.Text[] choiceTexts;
		public Button[] choiceButtons;
		public CanvasGroup[] choiceGroups;
		public Button skipButton;
		public PointerEventHandler skipButtonEventHandler;
		public UnityAction skipButtonCallback;
		public string outlineTitle;
		public string nextFunction;
		public TextAnchor outlineAlignment;
		public List<OutlineAdder> outlineAdders;
		public bool isOutlineSetting;
		public bool isLipSynch;
		public Button logButton;
		public Tweener logVoiceButtonTween;
		public GameObject[] logVoiceButtonIcons;
		public AudioPlayback currentVoice;
		public MoviePlayerHandle currentMovie;
		public Button autoButton;
		public StoryImage autoIcon;
		public bool isAuto;
		public float autoCount;
		public StoryImage bottomButtons;
		public bool buttonAutoVisibleFlag;
		public RectTransform characterParent;
		public StoryImage characterParentData;
		public Vector2[] characterPositionVector;
		public StoryCharacter[] characters;
		public List<int> characterPriority;
		public GameObject transEffect;
		public GameObject charaIntro;
		public GameObject textIntro;
		public GameObject nextRootObj;
		public GameObject nextEffect;
		public GameObject chapterIntro;
		public FlRoot chapterIntroFlRoot;
		public GameObject finEffect;
		public FlMotion nextMotion;
		public Tweener shakeTween;
		public bool isShakeLoop;
		public Tweener waitTween;
		public StoryOutlinePopup outlinePopup;
		public StoryLogPopup logPopup;
		private bool isOnPressedCanvas;
		private bool isTouchEnable;
		private Coroutine cancelPressedCanvasCoroutine;
		private bool isStopAuto;
		private float currentAutoWaitTime;
		private bool isFirstShowedWindow;
		private bool isPopupOpened;
		public const float standardLength = 1024f;
		public const float standardCameraSize = 568f;
		public const int backgroundMax = 6;
		public const int choiceButtonMax = 4;
		public const float judgeLipSynchRatio = 0.0007f;
		public const float buttonsFadeTime = 0.4f;
		public const int showCharacterMax = 3;
		public const float defaultScale = 1f;
		public static readonly Color defaultColor;
		public const float effectShakeSeconds = 6f;
		public const float shakeMoveValueHalfWeak = 5f;
		public const float shakeMoveValueHalfStrong = 20f;
		public const float MomentWait = 0.01f;
		public const float priorityDepth = -10f;
		private const float chapterIntroFrameHeight = 400f;
		private const float shakeMoveWindow = 20f;
		private const float shakeWindowSeconds = 0.3f;
		private const float telopFadeSeconds = 1f;
		private const float telopDelaySeconds = 1f;
		private const float choiceFadeSeconds = 0.4f;
		private const float choiceBackgroundDefaultHeight = 150f;
		private const float pressEnableAlpha = 0.5f;
		private const float textIntroCenteringValueForCharaName = 47f;
		private const float textIntroCenteringValueForNoRubyAnotherName = 12f;
		private const float textIntroCenteringValueForNoRubyAffiliation = 8f;
		private const float adjustTelopSubTextPos = -28f;
		private const float adjustTelopSubTextPosByExistRuby = -50f;
		private const string StroyAutoPlayStatusKey = "StroyAutoPlayStatusKey";
	
		// Nested types
		public enum Camera2DType
		{
			Background = 0,
			Character = 1,
			Common2 = 2,
			Max = 3
		}
	
		public enum ShakePhase
		{
			Stop = -1,
			BaseToPlus = 0,
			PlusToMinus = 1,
			MinusToPlus = 2
		}
	
		public enum SlideDirection
		{
			Right = 0,
			Left = 1,
			Down = 2,
			Up = 3
		}
	
		public enum StrongType
		{
			Weak = 0,
			Strong = 1,
			WeakFixed = 2,
			StrongFixed = 3
		}
	
		public enum CharacterPosition
		{
			Left = 0,
			Center = 1,
			Right = 2,
			Max = 3
		}
	
		public struct OutlineAdder
		{
			// Fields
			public string str;
			public string ruby;
		}
	
		[CompilerGenerated]
		private sealed class _CancelPressedCanvas_d__115 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryImageManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CancelPressedCanvas_d__115(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public StoryImage window;
			public bool visible;
			public StoryImageManager __4__this;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _SetFadeVisibleWindow_b__1();
			internal void _SetFadeVisibleWindow_b__2(float value);
			internal void _SetFadeVisibleWindow_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_1
		{
			// Fields
			public Vector2 fromPos;
			public Vector2 toPos;
			public __c__DisplayClass119_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass119_1();
	
			// Methods
			internal void _SetFadeVisibleWindow_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_0
		{
			// Fields
			public StoryImageManager __4__this;
			public bool visible;
			public Vector2 fromPos;
			public Vector2 toPos;
	
			// Constructors
			public __c__DisplayClass121_0();
	
			// Methods
			internal void _SetFadeVisibleChapterIntroFrame_b__0(float value);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<float> __9__122_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetShakeWindow_b__122_0(float fade);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass125_0
		{
			// Fields
			public StoryImageManager __4__this;
			public int choiceNum;
	
			// Constructors
			public __c__DisplayClass125_0();
	
			// Methods
			internal void _ShowChoice_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass125_1
		{
			// Fields
			public string title;
			public string function;
			public __c__DisplayClass125_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass125_1();
	
			// Methods
			internal void _ShowChoice_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0
		{
			// Fields
			public StoryImageManager __4__this;
			public string function;
	
			// Constructors
			public __c__DisplayClass126_0();
	
			// Methods
			internal void _HideChoice_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass153_0
		{
			// Fields
			public Vector2 shakeAddMove;
			public bool isWithBg;
			public StoryImageManager __4__this;
			public float peekSec;
			public Ease ease;
			public float stopSec;
			public Action<float> __9__4;
	
			// Constructors
			public __c__DisplayClass153_0();
	
			// Methods
			internal void _SetShakeEffect_b__0(float fade);
			internal void _SetShakeEffect_b__1();
			internal void _SetShakeEffect_b__4(float fade);
			internal void _SetShakeEffect_b__2(float fade);
			internal void _SetShakeEffect_b__3(float sec);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass156_0
		{
			// Fields
			public PostEffect postEffect;
			public float baseSize;
			public float size;
			public float basePower;
			public float power;
			public StoryImageManager __4__this;
	
			// Constructors
			public __c__DisplayClass156_0();
	
			// Methods
			internal void _SetFadeBlur_b__0(float fade);
			internal void _SetFadeBlur_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass157_0
		{
			// Fields
			public PostEffect postEffect;
			public float baseResolutionScale;
			public float resolutionScale;
			public float baseWeight;
			public float weight;
			public float baseThreshold;
			public float threshold;
			public float baseIntensity;
			public float intensity;
			public StoryImageManager __4__this;
	
			// Constructors
			public __c__DisplayClass157_0();
	
			// Methods
			internal void _SetFadeBloom_b__0(float fade);
			internal void _SetFadeBloom_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass158_0
		{
			// Fields
			public PostEffect postEffect;
			public float baseBright;
			public float bright;
			public float baseSatulation;
			public float saturation;
			public float baseContrast;
			public float contrast;
			public StoryImageManager __4__this;
	
			// Constructors
			public __c__DisplayClass158_0();
	
			// Methods
			internal void _SetFadeColorAdjustment_b__0(float fade);
			internal void _SetFadeColorAdjustment_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass159_0
		{
			// Fields
			public PostEffect postEffect;
			public float fromPower;
			public float toPower;
			public Color baseColor;
			public Color color;
			public StoryImageManager __4__this;
	
			// Constructors
			public __c__DisplayClass159_0();
	
			// Methods
			internal void _SetFadePostFilm_b__0(float fade);
			internal void _SetFadePostFilm_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass160_0
		{
			// Fields
			public StoryImageManager __4__this;
			public StoryScriptFunctionManager.State nextState;
	
			// Constructors
			public __c__DisplayClass160_0();
	
			// Methods
			internal void _SetWait_b__0();
		}
	
		// Constructors
		public StoryImageManager();
		static StoryImageManager();
	
		// Methods
		public void SetDefault();
		public void OnPressedCanvas();
		[IteratorStateMachine]
		public IEnumerator CancelPressedCanvas();
		public void CompleteFunction(StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle);
		public Tweener SetFadeColorBackground(bool isFadein, Color color, float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle, Ease ease = Ease.Linear);
		public Tweener SetFadeColorBackground(StoryImage storyImage, Color color, float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle, Ease ease = Ease.Linear);
		public void SetFadeVisibleWindow(bool visible, float fadeTime, bool isForceWithAnimation = false);
		public void SetFadeVisibleFrame(bool visible, float fadeTime);
		public void SetFadeVisibleChapterIntroFrame(bool visible, float fadeTime);
		public void SetShakeWindow();
		public void ShowTelop(string mainString, string subString, string mainRubyString, string subRubyString);
		public Tweener SetFadeVisibleTopic(bool visible, float fadeTime, string fileName = "");
		public void ShowChoice(int choiceNum, string[] titleStrings, string[] functionStrings);
		public void HideChoice(string function);
		public void SetTouchEnable(bool enable);
		public bool GetTouchUp();
		public void SetFadeButtons(bool visible, float fadeSec = 0f);
		public void SetOutlineDefault();
		public void SetOutline(string nextFunction);
		public void StopCurrentVoice();
		public void OnPressedVoiceButton(string voiceId);
		public void StopVoiceButtonTween();
		public void SetAutoWaitTime(float waitTime);
		public void OnPressedAutoButton(bool isUpdate = true);
		public void SetStopAuto(bool isStop);
		public bool GetStopAuto();
		public bool IsPopupOpened();
		public void SetPopupOpened(bool enable);
		private void CorrectBottomButtonEnable();
		public void CreateNameEntryPopup();
		private void UpdateCharacterPriority(int updateCharaNum);
		public StoryCharacter GetCharacterData(string characterId, bool isReset = false);
		public bool isValidCharaId(string charaId, string targetCommand);
		public Tweener SetScreenTransVisible(bool visible, SlideDirection direction, float sec);
		public void SetCharacterIntroduction(string resId, string name, string anotherName, string anotherNameRuby, string affiliation, string affiliationRuby, string emblemName);
		public void SetCharacterIntroductionEnd();
		public void SetChapterIntroduction(string chapterName);
		public void SetMotionPlayChapterIntroduction(string label);
		public void SetNextVisible(bool visible);
		public void SetFinVisible(bool visible, Vector3 offset);
		public Tweener SetShakeEffect(bool isWithBg, float value, float peekSec, float stopSec, Ease ease = Ease.Linear);
		private void InitSettingFilterGaussBloom(PostEffect postEffect);
		private void SetCorrectFilterType(PostEffect postEffect);
		public void SetFadeBlur(float fadeSec, float size, float power, PostEffect postEffect);
		public void SetFadeBloom(float fadeSec, float resolutionScale, float weight, float threshold, float intensity, PostEffect postEffect);
		public void SetFadeColorAdjustment(float fadeSec, float bright, float saturation, float contrast, PostEffect postEffect);
		public void SetFadePostFilm(float fadeSec, PostFilmMode postFilmMode, float fromPower, float toPower, Color color, PostEffect postEffect);
		public void SetWait(float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle);
		public void SetBackground(string[] backgroundIds);
		[CompilerGenerated]
		private void _SetFadeColorBackground_b__118_0();
		[CompilerGenerated]
		private void _SetFadeVisibleFrame_b__120_0(float value);
		[CompilerGenerated]
		private void _ShowTelop_b__123_0();
		[CompilerGenerated]
		private void _ShowTelop_b__123_1();
		[CompilerGenerated]
		private void _SetFadeButtons_b__129_0(float fade);
		[CompilerGenerated]
		private void _SetOutline_b__131_0();
		[CompilerGenerated]
		private void _SetNextVisible_b__151_0(object obj);
	}
}
