using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using Cute.Cri;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class DownloadScene : MonoBehaviour
	{
		public Canvas mainCanvas;

		public GameObject movieParent;

		public EventSystem eventSystem;

		public Text downloadPercentText;

		public Gauge gauge;

		public GameObject gaugeBar;

		public GameObject gaugeBarCompleted;

		public RectTransform dotsRectTransform;

		public Image[] dots;

		public Text downloadingText;

		public Text bottomText;

		public GameObject nharmNode;

		public CanvasGroup frontBlackCG;

		public GameObject topBlack;

		public Text debugText;

		public Image progressDot;

		public static bool isFromTitle;

		public static bool isFullDownload;

		public static bool exceptVoiceOnFullDownload;

		public const string UseAssetBundlePrefs = "UseAssetBundle";

		public const string UseLocalAssetBundlePrefs = "UseLocalAssetBundle";

		private FlashPlayer flashPlayer;

		private long downloadSizeFromTitle;

		private float percent;

		private float lastPercent;

		private bool isTweeningOn;

		private bool show100Percent;

		private MoviePlayerHandle movie;

		private static bool hashErrorSend;

		private const string movieName = "GL_30s_DBEN";

		private const int NAMissionID = 10005002;

		public static DownloadOperation assetDownloadOperation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void LoadNharm()
		{
		}

		private IEnumerator DoDownload()
		{
			return null;
		}

		private void PlayMovie()
		{
		}

		private DownloadOperation GetAfterPrologueDownloadOperation()
		{
			return null;
		}

		private DownloadOperation GetAfterPrologueDownloadOperationWithoutVoice()
		{
			return null;
		}

		private DownloadOperation GetAfterPrologueDownloadOperationMinimum()
		{
			return null;
		}

		private IEnumerator DoNormalDownload()
		{
			return null;
		}

		private IEnumerator DoAfterPrologueDownload()
		{
			return null;
		}

		private void ResetGameInfoAfterMasterReload()
		{
		}

		private void StartNormalDownload()
		{
		}

		private IEnumerator DotAnimation()
		{
			return null;
		}

		private void Update()
		{
		}

		private void StartGaugeTween()
		{
		}

		private IEnumerator OnDownloadCompleted()
		{
			return null;
		}

		private void AfterDownloadCompleted()
		{
		}

		private void GotoNextScene()
		{
		}

		private void GotoNextSceneImpl()
		{
		}

		private void CreateInitialOptionPopup()
		{
		}

		private void CheckBackgroundDownload(Action<bool> action)
		{
		}

		private void GoToPrologue(bool doBackgroundDownload)
		{
		}

		private void GotoTutorialSummonPrologue(bool doBackgroundDownload)
		{
		}

		private void GoToMyPage(bool isPrologue)
		{
		}

		private void InitWebViewManager()
		{
		}

		private void PreLoadInformationPage()
		{
		}

		private IEnumerator GoToMyPageCoroutine(bool isPrologue)
		{
			return null;
		}

		public static void GoNextSceneAfterDateCheckOrDownload(bool maySessionRenewed = false)
		{
		}

		private IEnumerator LoadOutGameResidentAssetsCoroutine()
		{
			return null;
		}

		private void CreateDownloadErrorPopup(DownloadErrorType type, string errorMsg, UnityAction onDownloadFailed, [Optional] UnityAction onBeforeLoadTitleScene)
		{
		}

		private void WriteLocalDataForTitle()
		{
		}
	}
}
