/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NowLoadingCanvas : MonoBehaviour
	{
		// Fields
		public Camera nhaamCamera;
		public Camera dummyFlashCamera;
		public Camera charaTipsCamera;
		public GameObject touchGuard;
		public CanvasGroup blackLayer;
		public GameObject gaugeRoot;
		public AnimationUIBase gaugeRootAnimation;
		public Gauge gauge;
		public UnityEngine.UI.Text progressNumText;
		public GameObject iconRoot;
		public CanvasGroup iconRootCanvasGroup;
		private Tips tips;
		public Image nowLoadingImage;
		public RawImage rawImage;
		public RawImage charaTipsImage;
		public CanvasGroup charaTipsCanvasGroup;
		public UnityEngine.UI.Text nowLoadingText;
		public PageViewBase pageView;
		public Transform textAttachParent;
		public Transform tipsTitleParent;
		public Transform edgeToEdgeFrame;
		[HideInInspector]
		public TargetTipsType tipsType;
		[HideInInspector]
		public int tipsTargetId;
		private DownloadOperation downloadOperation;
		private UnityAction onDownloadCompletedAction;
		private Coroutine changeTipsCoroutine;
		private Tips[] tipsObjs;
		private int progress;
		private Vector3 gaugeRootInitialPos;
		private bool isNowLoading;
		private bool isBeforeEndLoading;
		private bool isFadingOut;
		private bool isHeaderSlidedOut;
		private bool isFooterSlidedOut;
		public const float fadeInDelay = 0f;
		public const float fadeInDuration = 0.8f;
		public const float fadeOutDelay = 0.1f;
		public const float fadeOutDuration = 0.8f;
		public const float playFlashInDelay = 0.2f;
		public const float slideDuration = 0.6f;
		public const float loadingFadeAlpha = 1f;
		public const float loadingFadeTransparentAlpha = 0.5f;
		private Action onFadeOutCompletedAction;
		private Action onFadeInCompletedAction;
		private FlashPlayer flashPlayer;
		private GameObject flashObject;
		private bool showNextLoadingInWhiteBg;
		public static Color aquaColorForWhiteBg;
		private RenderTexture renderTexture;
		private bool forceReleaseAssetsOnDestroy;
		private Dictionary<string, Material> materialDict;
		private Dictionary<string, Sprite> spriteDict;
		private List<UnityEngine.UI.Text> changeColorTexts;
		private TipsObject tipsTextObject;
		private readonly string TipsTextPrefabResourcePath;
		private readonly string WorldTipsTextPrefabResourcePath;
		private LoadingTipsElement[] tipsDatas;
		private int tipsDataIndex;
		public Transform tipsArrowParentTransform;
		public UIAnimationPublisher animationPublisher;
		public UIAnimationPublisher charaAnimationPublisher;
		public Transform charaTextTipsTransform;
		public GameObject charaTipsPagerParentTransform;
		private int fadeOutProcessFlag;
		private readonly int FadeOutWaitTipsFlag;
		private float fadeOutDelayEndTime;
		private static NowLoadingCanvas _instance;
	
		// Properties
		public static NowLoadingCanvas instance { get; }
		public static bool IsInstanceEmpty { get; }
	
		// Nested types
		public enum ResourceReleaseMode
		{
			None = 0,
			Delayed = 1
		}
	
		private enum FadeOutProcessFlag
		{
			Delay = 1,
			Nhaam = 2,
			Tips = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public FlMotion rootMotion;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _PlayFlashIn_b__0(object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_1
		{
			// Fields
			public ResourceRequest req;
	
			// Constructors
			public __c__DisplayClass77_1();
	
			// Methods
			internal bool _PlayFlashIn_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_2
		{
			// Fields
			public ResourceRequest req;
	
			// Constructors
			public __c__DisplayClass77_2();
	
			// Methods
			internal bool _PlayFlashIn_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _PlayFlashIn_d__77 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
			private __c__DisplayClass77_1 __8__1;
			private __c__DisplayClass77_0 __8__2;
			private float _startTime_5__2;
			private Color _color_5__3;
			private string _prefabPath_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayFlashIn_d__77(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public NowLoadingCanvas __4__this;
			public bool slideHeader;
			public bool slideFooter;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _FadeOutCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _FadeOutCoroutine_d__79 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
			public bool slideHeader;
			public bool slideFooter;
			public bool showGauge;
			public bool showIcon;
			public bool showTips;
			public float delay;
			private __c__DisplayClass79_0 __8__1;
			public float duration;
			private int _processCheckCounter_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FadeOutCoroutine_d__79(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public bool isTipsRootLoading;
			public GameObject tipsRootObj;
			public bool isTipsArrowLoading;
			public GameObject tipsArrowObj;
			public NowLoadingCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _ShowTipsCoroutine_b__0(GameObject root);
			internal void _ShowTipsCoroutine_b__1(GameObject arrow);
			internal bool _ShowTipsCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_1
		{
			// Fields
			public List<KeyValuePair<int, GameObject>> pageValues;
			public __c__DisplayClass80_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass80_1();
	
			// Methods
			internal void _ShowTipsCoroutine_b__4(GameObject page, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_2
		{
			// Fields
			public List<KeyValuePair<int, GameObject>> pageValues;
			public __c__DisplayClass80_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass80_2();
	
			// Methods
			internal void _ShowTipsCoroutine_b__5(GameObject page, int index);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<GameObject, int> __9__80_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowTipsCoroutine_b__80_3(GameObject page, int index);
		}
	
		[CompilerGenerated]
		private sealed class _ShowTipsCoroutine_d__80 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
			private __c__DisplayClass80_0 __8__1;
			private Coroutine _processCheck_5__2;
			private Tips.TipsLayoutType _tipsLayoutType_5__3;
			private GameObject _tipsObj_5__4;
			private List<KeyValuePair<int, GameObject>> __7__wrap4;
			private KeyValuePair<int, GameObject> _page_5__6;
			private Tips _pageTips_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowTipsCoroutine_d__80(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CharaTipsDelay_d__81 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CharaTipsDelay_d__81(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TipsAnimationDelay_d__82 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TipsAnimationDelay_d__82(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public NowLoadingCanvas __4__this;
			public LoadingTipsElement tipsData;
			public UnityAction __9__2;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _ReloadTipsTextObject_b__0();
			internal void _ReloadTipsTextObject_b__2();
			internal void _ReloadTipsTextObject_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _FadeInCoroutine_d__87 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public NowLoadingCanvas __4__this;
			public bool slideHeader;
			public bool slideFooter;
			public float duration;
			public ResourceReleaseMode resourceReleaseMode;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FadeInCoroutine_d__87(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeTips_d__101 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NowLoadingCanvas __4__this;
			public bool isToLeft;
			private LoadingTipsElement _tipsData_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeTips_d__101(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public NowLoadingCanvas();
		static NowLoadingCanvas();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public static void Release();
		public void ShowNextLoadingInWhiteBg(bool isWhite);
		[IteratorStateMachine]
		private IEnumerator PlayFlashIn();
		public void FadeOut(bool showGauge = true, bool showIcon = true, bool showTips = true, bool slideHeader = true, bool slideFooter = true, Camera targetCamera = null, Action onCompletedAction = null, float duration = 0.8f, bool forceReleaseAssetsOnDestroy = false);
		[IteratorStateMachine]
		private IEnumerator FadeOutCoroutine(bool showGauge, bool showIcon, bool showTips, bool slideHeader, bool slideFooter, float delay, float duration, Action onCompletedAction);
		[IteratorStateMachine]
		private IEnumerator ShowTipsCoroutine();
		[IteratorStateMachine]
		private IEnumerator CharaTipsDelay();
		[IteratorStateMachine]
		private IEnumerator TipsAnimationDelay();
		private void OnPageChanged(int pageIndex);
		private void OnBeforePageChange(bool isToLeft);
		private void ReloadTipsTextObject(LoadingTipsElement tipsData);
		public void FadeIn(bool slideHeader = true, bool slideFooter = true, Camera targetCamera = null, Action onCompletedAction = null, float duration = 0.8f, ResourceReleaseMode resourceReleaseMode = ResourceReleaseMode.Delayed);
		[IteratorStateMachine]
		private IEnumerator FadeInCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Action onCompletedAction, ResourceReleaseMode resourceReleaseMode);
		private void DestoryTips();
		public void ShowDownloadGauge(UnityAction onValueChangeCompletedAction);
		private void Update();
		public static bool IsLoadingAndInstaceExists();
		public bool IsLoading();
		public bool IsBeforeEndLoading();
		public static bool IsFadingOutAndInstaceExists();
		public bool IsFadingOut();
		public void SetDownloadOperation(DownloadOperation downloadOperation);
		public void StartDownloadOperation();
		public static bool IsDownloadingAndInstaceExists();
		public bool IsDownloading();
		public void ChangeTipsButtonPressed(bool isToLeft);
		[IteratorStateMachine]
		private IEnumerator ChangeTips(bool isToLeft);
		[CompilerGenerated]
		private bool _CharaTipsDelay_b__81_0();
		[CompilerGenerated]
		private bool _TipsAnimationDelay_b__82_0();
		[CompilerGenerated]
		private void _FadeInCoroutine_b__87_1();
		[CompilerGenerated]
		private void _FadeInCoroutine_b__87_2();
		[CompilerGenerated]
		private bool _FadeInCoroutine_b__87_0();
		[CompilerGenerated]
		private bool _ChangeTips_b__101_0();
		[CompilerGenerated]
		private bool _ChangeTips_b__101_1();
		[CompilerGenerated]
		private bool _ChangeTips_b__101_2();
	}
}
