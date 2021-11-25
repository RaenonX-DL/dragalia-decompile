using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class NowLoadingCanvas : MonoBehaviour
	{
		public enum ResourceReleaseMode
		{
			None,
			Delayed
		}

		private enum FadeOutProcessFlag
		{
			Delay = 1,
			Nhaam = 2,
			Tips = 4
		}

		public Camera nhaamCamera;

		public Camera dummyFlashCamera;

		public Camera charaTipsCamera;

		public GameObject touchGuard;

		public CanvasGroup blackLayer;

		public GameObject gaugeRoot;

		public AnimationUIBase gaugeRootAnimation;

		public Gauge gauge;

		public Text progressNumText;

		public GameObject iconRoot;

		public CanvasGroup iconRootCanvasGroup;

		private Tips tips;

		public Image nowLoadingImage;

		public RawImage rawImage;

		public RawImage charaTipsImage;

		public CanvasGroup charaTipsCanvasGroup;

		public Text nowLoadingText;

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

		private List<Text> changeColorTexts;

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

		public static NowLoadingCanvas instance => null;

		public static bool IsInstanceEmpty => default(bool);

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void Release()
		{
		}

		public void ShowNextLoadingInWhiteBg(bool isWhite)
		{
		}

		private IEnumerator PlayFlashIn()
		{
			return null;
		}

		public void FadeOut(bool showGauge = true, bool showIcon = true, bool showTips = true, bool slideHeader = true, bool slideFooter = true, [Optional] Camera targetCamera, [Optional] Action onCompletedAction, float duration = 0.8f, bool forceReleaseAssetsOnDestroy = false)
		{
		}

		private IEnumerator FadeOutCoroutine(bool showGauge, bool showIcon, bool showTips, bool slideHeader, bool slideFooter, float delay, float duration, Action onCompletedAction)
		{
			return null;
		}

		private IEnumerator ShowTipsCoroutine()
		{
			return null;
		}

		private IEnumerator CharaTipsDelay()
		{
			return null;
		}

		private IEnumerator TipsAnimationDelay()
		{
			return null;
		}

		private void OnPageChanged(int pageIndex)
		{
		}

		private void OnBeforePageChange(bool isToLeft)
		{
		}

		private void ReloadTipsTextObject(LoadingTipsElement tipsData)
		{
		}

		public void FadeIn(bool slideHeader = true, bool slideFooter = true, [Optional] Camera targetCamera, [Optional] Action onCompletedAction, float duration = 0.8f, ResourceReleaseMode resourceReleaseMode = ResourceReleaseMode.Delayed)
		{
		}

		private IEnumerator FadeInCoroutine(bool slideHeader, bool slideFooter, float delay, float duration, Action onCompletedAction, ResourceReleaseMode resourceReleaseMode)
		{
			return null;
		}

		private void DestoryTips()
		{
		}

		public void ShowDownloadGauge(UnityAction onValueChangeCompletedAction)
		{
		}

		private void Update()
		{
		}

		public static bool IsLoadingAndInstaceExists()
		{
			return default(bool);
		}

		public bool IsLoading()
		{
			return default(bool);
		}

		public bool IsBeforeEndLoading()
		{
			return default(bool);
		}

		public static bool IsFadingOutAndInstaceExists()
		{
			return default(bool);
		}

		public bool IsFadingOut()
		{
			return default(bool);
		}

		public void SetDownloadOperation(DownloadOperation downloadOperation)
		{
		}

		public void StartDownloadOperation()
		{
		}

		public static bool IsDownloadingAndInstaceExists()
		{
			return default(bool);
		}

		public bool IsDownloading()
		{
			return default(bool);
		}

		public void ChangeTipsButtonPressed(bool isToLeft)
		{
		}

		private IEnumerator ChangeTips(bool isToLeft)
		{
			return null;
		}
	}
}
