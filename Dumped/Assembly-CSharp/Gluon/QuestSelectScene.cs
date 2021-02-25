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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectScene : SceneBase, ICustomMessage
	{
		// Fields
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
		private Dictionary<int, GameObject> loadedCommonObjects;
		private readonly SceneNameDefine.PageName[] LoadPageList;
		[CompilerGenerated]
		private QuestSelectRouteArranger _areaMapRouteArranger_k__BackingField;
		[CompilerGenerated]
		private bool _isTutorialRequired_k__BackingField;
		[CompilerGenerated]
		private bool _isTutorialRequiredAfterNewChapterEffect_k__BackingField;
		[CompilerGenerated]
		private bool _isOnEnterScene_k__BackingField;
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
		[CompilerGenerated]
		private bool _isCloudAnimationEnded_k__BackingField;
		[CompilerGenerated]
		private bool _isCheckStoryClearReward_k__BackingField;
		public Dictionary<TouchGuardType, TouchGuardObject> touchGuardObjDic;
		private StateType state;
	
		// Properties
		public bool IsTryingAreaMapCapture { get; }
		public bool hardEnable { get; }
		public List<QSChapterElement> qSChapterElementList { get; }
		public FlashPlayerManager flashPlayerManager { get; private set; }
		public FlashPlayerManager flashLandmarkManager { get; private set; }
		public QuestSelectRouteArranger areaMapRouteArranger { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int chapterNumber { get; }
		public bool isTutorialRequired { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isTutorialRequiredAfterNewChapterEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isOnEnterScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isNewChapterEffect { get; set; }
		public Image QuestBg { get; }
		public CanvasGroup ScreenShotCanvasGroup { get; }
		public static QuestSelectInstance questSelectInstance { get; }
		public static SceneNameDefine.PageName firstPageName { get; set; }
		public bool isCloudAnimationEnded { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isCheckStoryClearReward { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		public struct AreaSelectRootSettingByRenderMode
		{
			// Fields
			public float screenSpaceOverlayZ;
			public float screenSpaceCameraZ;
		}
	
		public enum QSMode
		{
			ChapterSelect = 0,
			AreaSelect = 1,
			Max = 2
		}
	
		private enum FadeMode
		{
			None = 0,
			In = 1,
			Out = 2,
			First = 3
		}
	
		public enum Difficulty
		{
			Normal = 1,
			Hard = 2,
			VeryHard = 3,
			MAX = 4
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
			chapter = 0,
			area = 1,
			questSelect = 2,
			questSelectDetail = 3,
			supportSelect = 4,
			none = 5
		}
	
		public enum TouchGuardType
		{
			touchGuardNewChapter = 0,
			touchGuardPoint = 1,
			touchGuardNewEnrollment = 2,
			touchGuardChangeChapter = 3,
			touchGuardTutorial = 4
		}
	
		private enum QuestSelectUiType
		{
			Canvas = 0,
			AreaMap = 1,
			ChapterMap = 2,
			Num = 3
		}
	
		private enum StateType
		{
			Initialized = 0,
			CreatingRoom = 1,
			Matching = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0
		{
			// Fields
			public bool isExistTutorialUI;
	
			// Constructors
			public __c__DisplayClass107_0();
	
			// Methods
			internal void _Start_b__4();
			internal bool _Start_b__5();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__107_0;
			public static Func<bool> __9__107_1;
			public static Action __9__113_0;
			public static Action __9__153_0;
			public static UnityAction __9__161_1;
			public static Action __9__161_0;
			public static UnityAction __9__166_1;
			public static Action __9__166_0;
			public static UnityAction __9__169_1;
			public static Action __9__169_0;
			public static UnityAction __9__173_2;
			public static Action __9__173_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__107_0();
			internal bool _Start_b__107_1();
			internal void _OnEnterScene_b__113_0();
			internal void _Tutorial_2_6_2_Coroutine_b__153_0();
			internal void _Tutorial_ReleaseTruthDragonBattle_Coroutine_b__161_0();
			internal void _Tutorial_ReleaseTruthDragonBattle_Coroutine_b__161_1();
			internal void _Tutorial_7_1_ShowDualWindow_Coroutine_b__166_0();
			internal void _Tutorial_7_1_ShowDualWindow_Coroutine_b__166_1();
			internal void _Tutorial_9_1_ShowDualWindow_Coroutine_b__169_0();
			internal void _Tutorial_9_1_ShowDualWindow_Coroutine_b__169_1();
			internal void _TutorialAstralRaidCoroutine_b__173_1();
			internal void _TutorialAstralRaidCoroutine_b__173_2();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__107 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__107(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadCommonObjects_d__116 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadCommonObjects_d__116(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_0
		{
			// Fields
			public QuestSelectScene __4__this;
			public bool isPlayForward;
			public bool isDisableOnComplete;
	
			// Constructors
			public __c__DisplayClass121_0();
	
			// Methods
			internal void _PlayFullScreenBlur_b__0(float time);
			internal void _PlayFullScreenBlur_b__1();
			internal void _PlayFullScreenBlur_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_1
		{
			// Fields
			public float blurSizeModulus;
			public __c__DisplayClass121_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass121_1();
	
			// Methods
			internal void _PlayFullScreenBlur_b__2(float time);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass134_0
		{
			// Fields
			public bool nextFlag;
	
			// Constructors
			public __c__DisplayClass134_0();
	
			// Methods
			internal void _CaptureMapImage_b__0();
			internal bool _CaptureMapImage_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CaptureMapImage_d__134 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CaptureMapImage_d__134(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForFullPostEffectAndCaptureAreamapCoroutine_d__135 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			public UnityAction onCaptureDoneCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForFullPostEffectAndCaptureAreamapCoroutine_d__135(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass152_0
		{
			// Fields
			public QuestSelectScene __4__this;
			public TouchGuardObject touchGuardObject;
	
			// Constructors
			public __c__DisplayClass152_0();
	
			// Methods
			internal void _Tutorial_2_6_2_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_6_2_Coroutine_d__153 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_6_2_Coroutine_d__153(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_3_1_Coroutine_d__155 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_3_1_Coroutine_d__155(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass157_0
		{
			// Fields
			public QuestSelectScene __4__this;
			public QuestSelectWheel questSelectWheel;
	
			// Constructors
			public __c__DisplayClass157_0();
	
			// Methods
			internal void _Tutorial_5_1_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_5_1_Coroutine_d__157 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			private __c__DisplayClass157_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_5_1_Coroutine_d__157(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_6_1_Coroutine_d__159 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_6_1_Coroutine_d__159(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__161 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__161(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass163_0
		{
			// Fields
			public QuestSelectScene __4__this;
			public QuestSelectWheel questSelectWheel;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass163_0();
	
			// Methods
			internal void _Tutorial_ReleaseAgito_Coroutine_b__0();
			internal void _Tutorial_ReleaseAgito_Coroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseAgito_Coroutine_d__163 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			private __c__DisplayClass163_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseAgito_Coroutine_d__163(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_Coroutine_d__165 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_Coroutine_d__165(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_ShowDualWindow_Coroutine_d__166 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_ShowDualWindow_Coroutine_d__166(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_Coroutine_d__168 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_Coroutine_d__168(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_ShowDualWindow_Coroutine_d__169 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_ShowDualWindow_Coroutine_d__169(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass171_0
		{
			// Fields
			public QuestSelectScene __4__this;
			public QuestSelectWheel questSelectWheel;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass171_0();
	
			// Methods
			internal void _Tutorial_10_1_Coroutine_b__0();
			internal void _Tutorial_10_1_Coroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_10_1_Coroutine_d__171 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			private __c__DisplayClass171_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_10_1_Coroutine_d__171(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass173_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
	
			// Constructors
			public __c__DisplayClass173_0();
	
			// Methods
			internal void _TutorialAstralRaidCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialAstralRaidCoroutine_d__173 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass173_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialAstralRaidCoroutine_d__173(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass175_0
		{
			// Fields
			public QuestSelectWheel questSelectWheel;
			public QuestSelectScene __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass175_0();
	
			// Methods
			internal void _TutorialReleaseDiabolosCoroutine_b__0();
			internal void _TutorialReleaseDiabolosCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialReleaseDiabolosCoroutine_d__175 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			private __c__DisplayClass175_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialReleaseDiabolosCoroutine_d__175(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass189_0
		{
			// Fields
			public QuestSelectScene __4__this;
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
			public __c__DisplayClass189_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass189_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public __c__DisplayClass189_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass189_1();
	
			// Methods
			internal void _ChangePage_b__0(PageBase page);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass196_0
		{
			// Fields
			public bool nextFlag;
	
			// Constructors
			public __c__DisplayClass196_0();
	
			// Methods
			internal void _CaptureCurrentAreamapCoroutine_b__0();
			internal bool _CaptureCurrentAreamapCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CaptureCurrentAreamapCoroutine_d__196 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectScene __4__this;
			public UnityAction onCaptureDoneCallback;
			public bool isForciblyCaptureNow;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CaptureCurrentAreamapCoroutine_d__196(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectScene();
		static QuestSelectScene();
	
		// Methods
		public static void ResetQuestSelectInstance();
		public Difficulty GetDifficulty();
		public void SetDifficulty(Difficulty a_difficulty);
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private static SceneNameDefine.PageName SetFirstPageName(bool isFirst, QuestType questType, QuestSelectInstance.QuestFirstOpenType questFirstOpenType, bool isShortCuttingQuestSelect);
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
		public void PlayFullScreenBlur(bool isPlayForward, bool isDisableOnComplete = false, bool isAreamapBlur = false);
		public void ResetPostEffect();
		private void OnSupportPageActive();
		private void OnSupportPageStartAnimation(bool isFromQuestPrepare);
		private void OnSupportPageExitAnimation();
		private void OnPageEnterAnimationEnded();
		public void OnSupportPageBackButtonPressed();
		public void ReflectData();
		private void Update();
		public void OnClickDifficulty();
		public void OnClickEventQuest();
		[IteratorStateMachine]
		public IEnumerator CaptureMapImage();
		[IteratorStateMachine]
		public IEnumerator WaitForFullPostEffectAndCaptureAreamapCoroutine(UnityAction onCaptureDoneCallback = null);
		public void OnClickMainQuestChapter(int a_chapterNumber, QuestSelectWheelElement a_qswheel);
		public void BackToMyPage();
		public int CheckNewChapter(out QSChapterElement element);
		public int CheckNewDifficulty();
		public void ClearNewChapter(QSChapterElement element);
		public int GetCurrentMaxChapter(Difficulty difficulty);
		public void SetGuardCanvasForScreenSpaceCamera(bool value, bool isOverHeader = false, float canvasAlpha = 1f);
		private void SetupTutorialState();
		public string GetCaptionText();
		public CaptionCanvas.IconType GetCaptionIconType();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		public void OnFooterPressed(string tabName, Footer.MenuTab tabType);
		public void OnFooterLongPressed(string tabName, Footer.MenuTab tabType);
		public void StartTutorial();
		private void Tutorial_1_1();
		private void Tutorial_2_6_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_6_2_Coroutine();
		private void Tutorial_3_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_3_1_Coroutine();
		private void Tutorial_5_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_5_1_Coroutine();
		private void Tutorial_6_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_6_1_Coroutine();
		private void Tutorial_ReleaseTruthDragonBattle();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseTruthDragonBattle_Coroutine();
		private void Tutorial_ReleaseAgito();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseAgito_Coroutine();
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
		private void Tutorial_10_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_10_1_Coroutine();
		public void TutorialAstralRaid();
		[IteratorStateMachine]
		private IEnumerator TutorialAstralRaidCoroutine();
		private void TutorialReleaseDiabolos();
		[IteratorStateMachine]
		private IEnumerator TutorialReleaseDiabolosCoroutine();
		public void SetQuestSelectUiData(QuestSelectSceneType type, UnityAction backButtonAction = null, UnityAction mainQuestButtonAction = null, UnityAction eventQuestButtonAction = null, UnityAction difficultAction = null);
		public void SetClickRightArrow(UnityAction action);
		public void SetClickLeftArrow(UnityAction action);
		public void SetClickToChapter(UnityAction action);
		public void SetChapter(int index);
		public void SetUiChangeStatus(QuestSelectSceneType type);
		public void ChangeDifficultyButton(Difficulty difficulty);
		public void ChapterWheelDisable();
		public void QuestSelectMainCanvasAllButton(bool enabe);
		public void OnClickBack();
		public void StartUiEnterAnimation();
		public void StartUiExitAnimation();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, Action<PageBase> onLoaded = null, object data = null, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true);
		public void ShowMap();
		public void ShowAreaMap();
		public void ShowChapterMap();
		public TouchGuardObject QuestSelectCreateTouchGuard(TouchGuardType type);
		public void QuestSelectRemoveTouchGuard(TouchGuardType type);
		public void SetArrowEnable(bool enable);
		[IteratorStateMachine]
		private IEnumerator CaptureCurrentAreamapCoroutine(bool isForciblyCaptureNow, UnityAction onCaptureDoneCallback = null);
		private void ExchangeAreamapToCapturedImage();
		public void SetEnableCapturedAreamap(bool value, bool isForciblyCaptureNow = true, UnityAction onCaptureDoneCallback = null);
		[CompilerGenerated]
		private void _Start_b__107_2(GameObject prefab);
		[CompilerGenerated]
		private bool _Start_b__107_3();
		[CompilerGenerated]
		private bool _WaitForFullPostEffectAndCaptureAreamapCoroutine_b__135_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_b__151_0();
		[CompilerGenerated]
		private void _Tutorial_3_1_b__154_0();
		[CompilerGenerated]
		private void _Tutorial_3_1_Coroutine_b__155_0();
		[CompilerGenerated]
		private void _Tutorial_5_1_b__156_0();
		[CompilerGenerated]
		private void _Tutorial_6_1_b__158_0();
		[CompilerGenerated]
		private void _Tutorial_6_1_Coroutine_b__159_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseTruthDragonBattle_b__160_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseAgito_b__162_0();
		[CompilerGenerated]
		private void _Tutorial_7_1_b__164_0();
		[CompilerGenerated]
		private void _Tutorial_7_1_Coroutine_b__165_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_b__167_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_Coroutine_b__168_0();
		[CompilerGenerated]
		private void _Tutorial_10_1_b__170_0();
		[CompilerGenerated]
		private void _TutorialAstralRaid_b__172_0();
		[CompilerGenerated]
		private void _TutorialReleaseDiabolos_b__174_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage);
	}
}
