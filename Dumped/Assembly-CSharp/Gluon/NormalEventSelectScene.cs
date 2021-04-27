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
using Gluon.PostEffectParams;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NormalEventSelectScene : SceneBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		public Camera mainCamera;
		[SerializeField]
		public Camera uiCamera;
		[SerializeField]
		public Camera flashCamera;
		[SerializeField]
		private FlashPlayerManager _flashMgr;
		[Header]
		[SerializeField]
		public int FadeInDragonDelay;
		[Header]
		[SerializeField]
		public int CarouselChangeDragonDeley;
		[Header]
		[SerializeField]
		public int AreaMapOutDragonDelay;
		[Header]
		[SerializeField]
		public int ChapterModeInDragonDeley;
		[SerializeField]
		private AnimationCurve fullScreenBlurPowerCurve;
		[SerializeField]
		private AnimationCurve fullScreenDiffusionBlurSizeCurve;
		[HideInInspector]
		public NormalEventSelectUiCanvas uiCanvas;
		public Dictionary<string, GameObject> questSelectResourceDic;
		private FadeMode fadeMode;
		private GameObject guardCanvasPrefab;
		private GameObject guardCanvas;
		private Sequence fullScreenBlurPowerSequence;
		private Sequence fullScreenDiffusionBlurSizeSequence;
		public PostEffect camPostEffect;
		private PostFilmMode camPostEffectFilmMode;
		private bool camPostEffectIsEnableBloom;
		private QuestSelectEventTopPage _eventTopPage;
		private TouchGuardObject startTouchGuardObject;
		private bool _hardEnable;
		private List<QSChapterElement> nchlist;
		public bool isStartQuestSelect;
		public bool isStartQuestSelect2;
		public bool isCanvasBgFadingOut;
		private TouchGuardObject matchingTouchGuard;
		private Dictionary<int, GameObject> loadedCommonObjects;
		private readonly SceneNameDefine.PageName[] LoadPageList;
		[CompilerGenerated]
		private bool _isTutorialRequired_k__BackingField;
		[CompilerGenerated]
		private bool _isTutorialRequiredAfterNewChapterEffect_k__BackingField;
		[CompilerGenerated]
		private bool _isOnEnterScene_k__BackingField;
		[SerializeField]
		private RectTransform canvasBg;
		[SerializeField]
		private Image questBg;
		[SerializeField]
		private Image screenShotBlackPanel;
		[SerializeField]
		private CanvasGroup screenShotCanvasGroup;
		public AudioPlayback bgm;
		private SceneNameDefine.PageName firstPageName;
		[CompilerGenerated]
		private bool _isCloudAnimationEnded_k__BackingField;
		public Dictionary<TouchGuardType, TouchGuardObject> touchGuardObjDic;
		private StateType state;
	
		// Properties
		public bool hardEnable { get; }
		public List<QSChapterElement> qSChapterElementList { get; }
		public QuestSelectEventTopPage eventTopPage { get; set; }
		public FlashPlayerManager flashPlayerManager { get; private set; }
		public bool isTutorialRequired { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isTutorialRequiredAfterNewChapterEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isOnEnterScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Image QuestBg { get; }
		public CanvasGroup ScreenShotCanvasGroup { get; }
		public static QuestSelectInstance questSelectInstance { get; }
		public bool isCloudAnimationEnded { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum FadeMode
		{
			None = 0,
			In = 1,
			Out = 2,
			First = 3
		}
	
		public enum QuestSelectSceneType
		{
			eventQuestTop = 0,
			eventQuestSub = 1,
			eventQuestDetail = 2,
			supportSelect = 3,
			none = 4
		}
	
		private enum QuestSelectUiType
		{
			Canvas = 0,
			Num = 1
		}
	
		public enum TouchGuardType
		{
			touchGuardTutorial = 0
		}
	
		private enum StateType
		{
			Initialized = 0,
			CreatingRoom = 1,
			Matching = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public bool isExistTutorialUI;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _Start_b__5();
			internal bool _Start_b__6();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__76_0;
			public static Func<bool> __9__76_1;
			public static Action __9__83_0;
			public static UnityAction __9__124_2;
			public static Action __9__124_1;
			public static UnityAction __9__129_1;
			public static Action __9__129_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__76_0();
			internal bool _Start_b__76_1();
			internal void _OnEnterScene_b__83_0();
			internal void _TutorialAstralRaidCoroutine_b__124_1();
			internal void _TutorialAstralRaidCoroutine_b__124_2();
			internal void _TutorialReleaseDiabolosCoroutine_b__129_0();
			internal void _TutorialReleaseDiabolosCoroutine_b__129_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadCommonObjects_d__86 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadCommonObjects_d__86(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__87 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__87(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public NormalEventSelectScene __4__this;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _OnSupportPageStartAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CaptureMapImage_d__99 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CaptureMapImage_d__99(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__111 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__111(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseAgito_Coroutine_d__113 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseAgito_Coroutine_d__113(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseInstructor_Coroutine_d__115 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseInstructor_Coroutine_d__115(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseInstructor_CoroutineGuide_d__116 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseInstructor_CoroutineGuide_d__116(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_Coroutine_d__118 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_Coroutine_d__118(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_ShowDualWindow_Coroutine_d__119 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_ShowDualWindow_Coroutine_d__119(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_Coroutine_d__121 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_Coroutine_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_ShowDualWindow_Coroutine_d__122 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_ShowDualWindow_Coroutine_d__122(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass124_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
	
			// Constructors
			public __c__DisplayClass124_0();
	
			// Methods
			internal void _TutorialAstralRaidCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialAstralRaidCoroutine_d__124 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass124_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialAstralRaidCoroutine_d__124(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_10_1_Coroutine_d__126 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NormalEventSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_10_1_Coroutine_d__126(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0
		{
			// Fields
			public TutorialFlagData flagNumber;
			public UnityAction successCallback;
			public NormalEventSelectScene __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass127_0();
	
			// Methods
			internal void _PlayGuideWindowTutorialCoroutine_b__0();
			internal void _PlayGuideWindowTutorialCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _PlayGuideWindowTutorialCoroutine_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialFlagData flagNumber;
			public UnityAction successCallback;
			public NormalEventSelectScene __4__this;
			public float delay;
			public int tutorialStep;
			private __c__DisplayClass127_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayGuideWindowTutorialCoroutine_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialReleaseDiabolosCoroutine_d__129 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialReleaseDiabolosCoroutine_d__129(int __1__state);
	
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
			public NormalEventSelectScene __4__this;
			public SceneNameDefine.PageName pageName;
			public Transform parentTransform;
			public AnimationUICanvas.AnimationPattern exitPattern;
			public AnimationUICanvas.AnimationPattern enterPattern;
			public Action<PageBase> onLoaded;
			public object data;
			public bool allowSamePageReload;
			public bool delayEnterAnimation;
			public bool deactivateLastPage;
	
			// Constructors
			public __c__DisplayClass133_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass133_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public __c__DisplayClass133_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass133_1();
	
			// Methods
			internal void _ChangePage_b__0(PageBase page);
		}
	
		// Constructors
		public NormalEventSelectScene();
	
		// Methods
		public static void ResetQuestSelectInstance();
		public void SetDifficulty(QuestSelectScene.Difficulty a_difficulty);
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void ShowMultiJoinPopupOnBegin();
		private static SceneNameDefine.PageName SetFirstPageName(bool isFirst, QuestSelectInstance.QuestFirstOpenType questFirstOpenType, bool isShortCuttingQuestSelect);
		private bool IsReward();
		public void PlayBgm();
		public void SetScreenShotBlackPanelEnable(bool value);
		private bool IsEventEnable();
		private void OnEnterScene();
		public override void StartExitAnimation();
		private bool IsAreaMapExitAnimationNeeded();
		[IteratorStateMachine]
		private IEnumerator LoadCommonObjects();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void OnCompleteScreenShotFadeOut();
		private void AfterQuestEnterCloud();
		public void SetAllButtonsEnabled(bool enable);
		private void OnSupportPageActive();
		private void OnSupportPageStartAnimation(bool isFromQuestPrepare);
		private void OnSupportPageExitAnimation();
		private void OnPageEnterAnimationEnded();
		public void OnSupportPageBackButtonPressed();
		private void Update();
		[IteratorStateMachine]
		public IEnumerator CaptureMapImage();
		public void BackToMyPage();
		public void SetGuardCanvasForScreenSpaceCamera(bool value, bool isOverHeader = false, float canvasAlpha = 1f);
		private void SetupTutorialState();
		public string GetCaptionText();
		public CaptionCanvas.IconType GetCaptionIconType();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		public void StartTutorial();
		private void Tutorial_1_1();
		private void TutorialBaseLock();
		private void Tutorial_ReleaseTruthDragonBattle();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseTruthDragonBattle_Coroutine();
		private void Tutorial_ReleaseAgito();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseAgito_Coroutine();
		private void Tutorial_ReleaseInstructor();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseInstructor_Coroutine();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseInstructor_CoroutineGuide();
		public void Tutorial_7_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_7_1_Coroutine();
		[IteratorStateMachine]
		private IEnumerator Tutorial_7_1_ShowDualWindow_Coroutine();
		private void Tutorial_9_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_9_1_Coroutine();
		[IteratorStateMachine]
		private IEnumerator Tutorial_9_1_ShowDualWindow_Coroutine();
		public void TutorialAstralRaid();
		[IteratorStateMachine]
		private IEnumerator TutorialAstralRaidCoroutine();
		private void Tutorial_10_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_10_1_Coroutine();
		[IteratorStateMachine]
		private IEnumerator PlayGuideWindowTutorialCoroutine(int tutorialStep, TutorialFlagData flagNumber, float delay = 1f, UnityAction successCallback = null);
		private void TutorialReleaseDiabolos();
		[IteratorStateMachine]
		private IEnumerator TutorialReleaseDiabolosCoroutine();
		public void SetQuestSelectUiData(QuestSelectSceneType type, UnityAction backButtonAction = null);
		public void StartUiExitAnimation();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, Action<PageBase> onLoaded = null, object data = null, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		public TouchGuardObject QuestSelectCreateTouchGuard(TouchGuardType type);
		public void QuestSelectRemoveTouchGuard(TouchGuardType type);
		private void SetScrollPosition(QuestSelectInstance.QuestEventData targetEvent);
		private void QuestListReload();
		[CompilerGenerated]
		private void _Start_b__76_2(GameObject prefab);
		[CompilerGenerated]
		private bool _Start_b__76_3();
		[CompilerGenerated]
		private bool _Start_b__76_4();
		[CompilerGenerated]
		private void _Tutorial_1_1_b__108_0();
		[CompilerGenerated]
		private void _TutorialBaseLock_b__109_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseTruthDragonBattle_b__110_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseAgito_b__112_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseAgito_Coroutine_b__113_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseInstructor_b__114_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseInstructor_Coroutine_b__115_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseInstructor_CoroutineGuide_b__116_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseInstructor_CoroutineGuide_b__116_1();
		[CompilerGenerated]
		private void _Tutorial_7_1_b__117_0();
		[CompilerGenerated]
		private void _Tutorial_7_1_Coroutine_b__118_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_b__120_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_Coroutine_b__121_0();
		[CompilerGenerated]
		private void _TutorialAstralRaid_b__123_0();
		[CompilerGenerated]
		private void _Tutorial_10_1_b__125_0();
		[CompilerGenerated]
		private void _TutorialReleaseDiabolos_b__128_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage);
	}
}
