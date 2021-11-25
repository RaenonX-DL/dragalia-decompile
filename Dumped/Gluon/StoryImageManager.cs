using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.PostEffectParams;
using SPFX;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryImageManager : SingletonMonoBehaviour<StoryImageManager>
	{
		public enum Camera2DType
		{
			Background,
			Character,
			Common2,
			Max
		}

		public enum ShakePhase
		{
			Stop = -1,
			BaseToPlus,
			PlusToMinus,
			MinusToPlus
		}

		public enum SlideDirection
		{
			Right,
			Left,
			Down,
			Up
		}

		public enum StrongType
		{
			Weak,
			Strong,
			WeakFixed,
			StrongFixed
		}

		public enum CharacterPosition
		{
			Left,
			Center,
			Right,
			Max
		}

		public struct OutlineAdder
		{
			public string str;

			public string ruby;
		}

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

		public Text telopMainText;

		public Text telopSubText;

		public Text telopMainRubyText;

		public Text telopSubRubyText;

		public Canvas uiCanvas;

		public bool isForceTouchDisable;

		public bool completeForceTouchDisable;

		public StoryImage topic;

		public RectTransform choiceButtonsParent;

		public StoryImage choice;

		public Text[] choiceTexts;

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

		public void SetDefault()
		{
		}

		public void OnPressedCanvas()
		{
		}

		public IEnumerator CancelPressedCanvas()
		{
			return null;
		}

		public void CompleteFunction(StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle)
		{
		}

		public Tweener SetFadeColorBackground(bool isFadein, Color color, float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle, Ease ease = Ease.Linear)
		{
			return null;
		}

		public Tweener SetFadeColorBackground(StoryImage storyImage, Color color, float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle, Ease ease = Ease.Linear)
		{
			return null;
		}

		public void SetFadeVisibleWindow(bool visible, float fadeTime, bool isForceWithAnimation = false)
		{
		}

		public void SetFadeVisibleFrame(bool visible, float fadeTime)
		{
		}

		public void SetFadeVisibleChapterIntroFrame(bool visible, float fadeTime)
		{
		}

		public void SetShakeWindow()
		{
		}

		public void ShowTelop(string mainString, string subString, string mainRubyString, string subRubyString)
		{
		}

		public Tweener SetFadeVisibleTopic(bool visible, float fadeTime, string fileName = "")
		{
			return null;
		}

		public void ShowChoice(int choiceNum, string[] titleStrings, string[] functionStrings)
		{
		}

		public void HideChoice(string function)
		{
		}

		public void SetTouchEnable(bool enable)
		{
		}

		public bool GetTouchUp()
		{
			return default(bool);
		}

		public void SetFadeButtons(bool visible, float fadeSec = 0f)
		{
		}

		public void SetOutlineDefault()
		{
		}

		public void SetOutline(string nextFunction)
		{
		}

		public void StopCurrentVoice()
		{
		}

		public void OnPressedVoiceButton(string voiceId)
		{
		}

		public void StopVoiceButtonTween()
		{
		}

		public void SetAutoWaitTime(float waitTime)
		{
		}

		public void OnPressedAutoButton(bool isUpdate = true)
		{
		}

		public void SetStopAuto(bool isStop)
		{
		}

		public bool GetStopAuto()
		{
			return default(bool);
		}

		public bool IsPopupOpened()
		{
			return default(bool);
		}

		public void SetPopupOpened(bool enable)
		{
		}

		private void CorrectBottomButtonEnable()
		{
		}

		public void CreateNameEntryPopup()
		{
		}

		private void UpdateCharacterPriority(int updateCharaNum)
		{
		}

		public StoryCharacter GetCharacterData(string characterId, bool isReset = false)
		{
			return null;
		}

		public bool isValidCharaId(string charaId, string targetCommand)
		{
			return default(bool);
		}

		public Tweener SetScreenTransVisible(bool visible, SlideDirection direction, float sec)
		{
			return null;
		}

		public void SetCharacterIntroduction(string resId, string name, string anotherName, string anotherNameRuby, string affiliation, string affiliationRuby, string emblemName)
		{
		}

		public void SetCharacterIntroductionEnd()
		{
		}

		public void SetChapterIntroduction(string chapterName)
		{
		}

		public void SetMotionPlayChapterIntroduction(string label)
		{
		}

		public void SetNextVisible(bool visible)
		{
		}

		public void SetFinVisible(bool visible, Vector3 offset)
		{
		}

		public Tweener SetShakeEffect(bool isWithBg, float value, float peekSec, float stopSec, Ease ease = Ease.Linear)
		{
			return null;
		}

		private void InitSettingFilterGaussBloom(PostEffect postEffect)
		{
		}

		private void SetCorrectFilterType(PostEffect postEffect)
		{
		}

		public void SetFadeBlur(float fadeSec, float size, float power, PostEffect postEffect)
		{
		}

		public void SetFadeBloom(float fadeSec, float resolutionScale, float weight, float threshold, float intensity, PostEffect postEffect)
		{
		}

		public void SetFadeColorAdjustment(float fadeSec, float bright, float saturation, float contrast, PostEffect postEffect)
		{
		}

		public void SetFadePostFilm(float fadeSec, PostFilmMode postFilmMode, float fromPower, float toPower, Color color, PostEffect postEffect)
		{
		}

		public void SetWait(float sec, StoryScriptFunctionManager.State nextState = StoryScriptFunctionManager.State.Idle)
		{
		}

		public void SetBackground(string[] backgroundIds)
		{
		}
	}
}
