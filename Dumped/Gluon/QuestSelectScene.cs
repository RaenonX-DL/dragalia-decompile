using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using DG.Tweening;
using Gluon.PostEffectParams;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectScene : SceneBase, ICustomMessage
	{
		[Serializable]
		public struct AreaSelectRootSettingByRenderMode
		{
			public float screenSpaceOverlayZ;

			public float screenSpaceCameraZ;
		}

		public enum QSMode
		{
			ChapterSelect,
			AreaSelect,
			Max
		}

		private enum FadeMode
		{
			None,
			In,
			Out,
			First
		}

		public enum Difficulty
		{
			Normal = 1,
			Hard,
			VeryHard,
			MAX
		}

		public enum QuestState
		{
			New = 0,
			Enter = 2,
			Clear = 3,
			MissionClear = 4,
			MAX = 5
		}

		public enum QuestSelectSceneType
		{
			chapter,
			area,
			questSelect,
			questSelectDetail,
			supportSelect,
			none
		}

		public enum TouchGuardType
		{
			touchGuardNewChapter,
			touchGuardPoint,
			touchGuardNewEnrollment,
			touchGuardChangeChapter,
			touchGuardTutorial
		}

		private enum QuestSelectUiType
		{
			Canvas,
			AreaMap,
			ChapterMap,
			Num
		}

		private enum StateType
		{
			Initialized,
			CreatingRoom,
			Matching
		}

		[SerializeField]
		public Camera mainCamera;

		[SerializeField]
		public Camera uiCamera;

		[SerializeField]
		public Camera flashCamera;

		[SerializeField]
		public AreaSelectRootSettingByRenderMode areaSelectRootSetting;

		[SerializeField]
		private FlashPlayerManager _flashMgr;

		[SerializeField]
		private FlashPlayerManager _flashLandmarkMgr;

		[SerializeField]
		[Header("QuestSceneã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³æ\u0099\u0082ã\u0081®inã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int FadeInDragonDelay;

		[SerializeField]
		[Header("ã\u0082«ã\u0083«ã\u0083¼ã\u0082»ã\u0083«UIã\u0081®ã\u0083\u0088ã\u0083\u0083ã\u0083\u0097ã\u0081\u008cå¤\u0089æ\u009b\u00b4ã\u0081\u0095ã\u0082\u008cã\u0081\u009fæ\u0099\u0082ã\u0081®s1ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int CarouselChangeDragonDeley;

		[SerializeField]
		[Header("ã\u0082\u00a8ã\u0083ªã\u0082¢ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081«é\u0081·ç§»ã\u0081\u0099ã\u0082\u008bé\u009a\u009bã\u0081®s2ã\u0083©ã\u0083\u0099ã\u0083«ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int AreaMapOutDragonDelay;

		[SerializeField]
		[Header("ã\u0082\u00a8ã\u0083ªã\u0082¢ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081\u008bã\u0082\u0089ã\u0083\u0081ã\u0083£ã\u0083\u0097ã\u0082¿ã\u0083¼ã\u0082»ã\u0083¬ã\u0082\u00afã\u0083\u0088ç\u0094»é\u009d¢ã\u0081«é\u0081·ç§»ã\u0081\u0097ã\u0081\u009fé\u009a\u009bã\u0081®inã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int ChapterModeInDragonDeley;

		[SerializeField]
		private AnimationCurve fullScreenBlurPowerCurve;

		[SerializeField]
		private AnimationCurve fullScreenDiffusionBlurSizeCurve;

		[HideInInspector]
		public QuestSelectChapterMap chapterMap;

		[HideInInspector]
		public QuestSelectAreaCanvas areaMap;

		[HideInInspector]
		public QuestSelectUiCanvas uiCanvas;

		public Dictionary<string, GameObject> questSelectResourceDic;

		public readonly string landmarkPrefabName;

		private bool isTryingAreaMapCapture;

		private FadeMode fadeMode;

		private GameObject guardCanvasPrefab;

		private GameObject guardCanvas;

		private Sequence fullScreenBlurPowerSequence;

		private Sequence fullScreenDiffusionBlurSizeSequence;

		public PostEffect camPostEffect;

		private PostFilmMode camPostEffectFilmMode;

		private bool camPostEffectIsEnableBloom;

		private TouchGuardObject startTouchGuardObject;

		private bool _hardEnable;

		private List<QSChapterElement> nchlist;

		public bool isStartQuestSelect;

		public bool isStartQuestSelect2;

		public static readonly Color backGroundLerpColor;

		public bool isCanvasBgFadingOut;

		private TouchGuardObject matchingTouchGuard;

		private Dictionary<int, GameObject> loadedCommonObjects;

		private readonly SceneNameDefine.PageName[] LoadPageList;

		private bool _isNewChapterEffect;

		[SerializeField]
		private RectTransform canvasBg;

		[SerializeField]
		private Image questBg;

		[SerializeField]
		private Image screenShotBlackPanel;

		[SerializeField]
		private CanvasGroup screenShotCanvasGroup;

		[SerializeField]
		private float areamapBlurSizeModulus;

		public AudioPlayback bgm;

		private static QuestSelectInstance _questSelectInstance;

		private static SceneNameDefine.PageName _firstPageName;

		public Dictionary<TouchGuardType, TouchGuardObject> touchGuardObjDic;

		private StateType state;

		public bool IsTryingAreaMapCapture => default(bool);

		public bool hardEnable => default(bool);

		public List<QSChapterElement> qSChapterElementList => null;

		public FlashPlayerManager flashPlayerManager
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public FlashPlayerManager flashLandmarkManager
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public QuestSelectRouteArranger areaMapRouteArranger
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int chapterNumber => default(int);

		public bool isTutorialRequired
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isTutorialRequiredAfterNewChapterEffect
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isOnEnterScene
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isNewChapterEffect
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Image QuestBg => null;

		public CanvasGroup ScreenShotCanvasGroup => null;

		public static QuestSelectInstance questSelectInstance => null;

		public static SceneNameDefine.PageName firstPageName
		{
			get
			{
				return default(SceneNameDefine.PageName);
			}
			set
			{
			}
		}

		public bool isCloudAnimationEnded
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isCheckStoryClearReward
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static void ResetQuestSelectInstance()
		{
		}

		public Difficulty GetDifficulty()
		{
			return default(Difficulty);
		}

		public void SetDifficulty(Difficulty a_difficulty)
		{
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private static SceneNameDefine.PageName SetFirstPageName(bool isFirst, QuestType questType, QuestSelectInstance.QuestFirstOpenType questFirstOpenType, bool isShortCuttingQuestSelect)
		{
			return default(SceneNameDefine.PageName);
		}

		private bool IsReward()
		{
			return default(bool);
		}

		public void PlayBgm()
		{
		}

		public void SetScreenShotBlackPanelEnable(bool value)
		{
		}

		private bool IsEventEnable()
		{
			return default(bool);
		}

		private void OnEnterScene()
		{
		}

		public override void StartExitAnimation()
		{
		}

		private bool IsAreaMapExitAnimationNeeded()
		{
			return default(bool);
		}

		private IEnumerator LoadCommonObjects()
		{
			return null;
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void OnCompleteScreenShotFadeOut()
		{
		}

		private void AfterQuestEnterCloud()
		{
		}

		public void SetAllButtonsEnabled(bool enable)
		{
		}

		public void PlayFullScreenBlur(bool isPlayForward, bool isDisableOnComplete = false, bool isAreamapBlur = false)
		{
		}

		public void ResetPostEffect()
		{
		}

		private void OnSupportPageActive()
		{
		}

		private void OnSupportPageStartAnimation(bool isFromQuestPrepare)
		{
		}

		private void OnSupportPageExitAnimation()
		{
		}

		private void OnPageEnterAnimationEnded()
		{
		}

		public void OnSupportPageBackButtonPressed()
		{
		}

		public void ReflectData()
		{
		}

		private void Update()
		{
		}

		public void OnClickDifficulty()
		{
		}

		public void OnClickEventQuest()
		{
		}

		public IEnumerator CaptureMapImage()
		{
			return null;
		}

		public IEnumerator WaitForFullPostEffectAndCaptureAreamapCoroutine([Optional] UnityAction onCaptureDoneCallback)
		{
			return null;
		}

		public void OnClickMainQuestChapter(int a_chapterNumber, QuestSelectWheelElement a_qswheel)
		{
		}

		public void BackToMyPage()
		{
		}

		public int CheckNewChapter(out QSChapterElement element)
		{
			return default(int);
		}

		public int CheckNewDifficulty()
		{
			return default(int);
		}

		public void ClearNewChapter(QSChapterElement element)
		{
		}

		public int GetCurrentMaxChapter(Difficulty difficulty)
		{
			return default(int);
		}

		public void SetGuardCanvasForScreenSpaceCamera(bool value, bool isOverHeader = false, float canvasAlpha = 1f)
		{
		}

		private void SetupTutorialState()
		{
		}

		public string GetCaptionText()
		{
			return null;
		}

		public CaptionCanvas.IconType GetCaptionIconType()
		{
			return default(CaptionCanvas.IconType);
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnFooterPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		public void OnFooterLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		public void StartTutorial()
		{
		}

		private void Tutorial_1_1()
		{
		}

		private void Tutorial_2_6_2()
		{
		}

		private IEnumerator Tutorial_2_6_2_Coroutine()
		{
			return null;
		}

		private void Tutorial_3_1()
		{
		}

		private IEnumerator Tutorial_3_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_5_1()
		{
		}

		private IEnumerator Tutorial_5_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_6_1()
		{
		}

		private IEnumerator Tutorial_6_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_ReleaseTruthDragonBattle()
		{
		}

		private IEnumerator Tutorial_ReleaseTruthDragonBattle_Coroutine()
		{
			return null;
		}

		private void Tutorial_ReleaseAgito()
		{
		}

		private IEnumerator Tutorial_ReleaseAgito_Coroutine()
		{
			return null;
		}

		public void Tutorial_7_1()
		{
		}

		private IEnumerator Tutorial_7_1_Coroutine()
		{
			return null;
		}

		private IEnumerator Tutorial_7_1_ShowDualWindow_Coroutine()
		{
			return null;
		}

		private void Tutorial_9_1()
		{
		}

		private IEnumerator Tutorial_9_1_Coroutine()
		{
			return null;
		}

		private IEnumerator Tutorial_9_1_ShowDualWindow_Coroutine()
		{
			return null;
		}

		private void Tutorial_10_1()
		{
		}

		private IEnumerator Tutorial_10_1_Coroutine()
		{
			return null;
		}

		public void TutorialAstralRaid()
		{
		}

		private IEnumerator TutorialAstralRaidCoroutine()
		{
			return null;
		}

		private void TutorialReleaseDiabolos()
		{
		}

		private IEnumerator TutorialReleaseDiabolosCoroutine()
		{
			return null;
		}

		private void TutorialReleaseSaga()
		{
		}

		private IEnumerator TutorialReleaseSagaCoroutine()
		{
			return null;
		}

		public void SetQuestSelectUiData(QuestSelectSceneType type, [Optional] UnityAction backButtonAction, [Optional] UnityAction mainQuestButtonAction, [Optional] UnityAction eventQuestButtonAction, [Optional] UnityAction difficultAction)
		{
		}

		public void SetClickRightArrow(UnityAction action)
		{
		}

		public void SetClickLeftArrow(UnityAction action)
		{
		}

		public void SetClickToChapter(UnityAction action)
		{
		}

		public void SetChapter(int index)
		{
		}

		public void SetUiChangeStatus(QuestSelectSceneType type)
		{
		}

		public void ChangeDifficultyButton(Difficulty difficulty)
		{
		}

		public void ChapterWheelDisable()
		{
		}

		public void QuestSelectMainCanvasAllButton(bool enabe)
		{
		}

		public void OnClickBack()
		{
		}

		public void StartUiEnterAnimation()
		{
		}

		public void StartUiExitAnimation()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public override void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, [Optional] Action<PageBase> onLoaded, [Optional] object data, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true)
		{
		}

		public void ShowMap()
		{
		}

		public void ShowAreaMap()
		{
		}

		public void ShowChapterMap()
		{
		}

		public TouchGuardObject QuestSelectCreateTouchGuard(TouchGuardType type)
		{
			return null;
		}

		public void QuestSelectRemoveTouchGuard(TouchGuardType type)
		{
		}

		public void SetArrowEnable(bool enable)
		{
		}

		private IEnumerator CaptureCurrentAreamapCoroutine(bool isForciblyCaptureNow, [Optional] UnityAction onCaptureDoneCallback)
		{
			return null;
		}

		private void ExchangeAreamapToCapturedImage()
		{
		}

		public void SetEnableCapturedAreamap(bool value, bool isForciblyCaptureNow = true, [Optional] UnityAction onCaptureDoneCallback)
		{
		}
	}
}
