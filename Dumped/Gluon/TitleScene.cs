using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class TitleScene : MonoBehaviour
	{
		public enum TitleType
		{
			Normal,
			FEH2018,
			FirstAnniversary,
			Hunter,
			Hero,
			SecondAnniversary,
			Eight,
			ThirdAnniversary
		}

		public enum StoryProgress
		{
			Step0,
			Step1,
			Step2,
			Step3,
			Step4,
			Step5,
			Step6,
			Step7,
			Step8
		}

		public Camera flashCamera;

		public Canvas splashCanvas;

		public CanvasGroup whiteCanvasGroup;

		public CanvasGroup nintendoCanvasGroup;

		public CanvasGroup cygamesCanvasGroup;

		public TitleCanvas titleCanvas;

		private bool isTitleButtonPressed;

		private UnityEvent backKeyEvent;

		private bool isEulaRequestDone;

		private bool isSocialSigninDone;

		private bool isProceedReserved;

		private bool isLogoFinished;

		private bool isFirstBootNALinkChecked;

		private long deletedSize;

		private bool isNeedLogoFlash;

		public static bool isTitleLanguageSettingDone;

		public static bool isSPFXInitialized;

		public const string questProgressForTitleKey = "QuestProgressForTitleKey";

		public const string firstAnniversaryForTitleKey = "FirstAnniversaryForTitleKey";

		public TitleType titleType
		{
			[CompilerGenerated]
			get
			{
				return default(TitleType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool ShouldHideTooLongTopAndBottom
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

		public static TitleScene instance
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

		public bool isHavingUnreadComments
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

		public void Awake()
		{
		}

		public IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void OnSuggestionBoxButtonPressed()
		{
		}

		public void OnMenuButtonPressed()
		{
		}

		private IEnumerator ShowMenuPopup()
		{
			return null;
		}

		private IEnumerator InitTitle()
		{
			return null;
		}

		private IEnumerator PlayBGMCoroutine()
		{
			return null;
		}

		private void CheckInquireStatus()
		{
		}

		private void UpdateViewerID()
		{
		}

		private void GetEulaWebViewList(Action next)
		{
		}

		private void NALinkMenu()
		{
		}

		private void RequestTrackingAuthorization(Action next)
		{
		}

		private void AfterAgreement()
		{
		}

		private void AdjustInit()
		{
		}

		private void CheckEulaVersion()
		{
		}

		private void CreateAgreementPopup()
		{
		}

		private void InitBackKeyEvent()
		{
		}

		private void SocialAccountLogin()
		{
		}

		private bool CheckCollabo04TitleNeeded()
		{
			return default(bool);
		}

		private bool Check2ndAnniversaryTitleNeeded()
		{
			return default(bool);
		}

		private bool Check3rdAnniversaryTitleNeeded()
		{
			return default(bool);
		}

		private bool CheckEightTitleNeeded()
		{
			return default(bool);
		}

		private void CheckSpecialTitleNeeded()
		{
		}

		private StoryProgress GetStoryProgress()
		{
			return default(StoryProgress);
		}

		private string GetFlashPrefabPath(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathNormal(string lang)
		{
			return null;
		}

		private string GetLogoPrefabPath(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathColloabo01(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathSecondAnniversary(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathThirdAnniversary(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathColloabo03(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathColloabo04(string lang)
		{
			return null;
		}

		private string GetFlashPrefabPathEight(string lang)
		{
			return null;
		}

		private void InitTitleFlash()
		{
		}

		private void InitTitleFlashNormal()
		{
		}

		private IEnumerator InitLogoCoroutine(GameObject logoPosObj, FlMotion rootMotion)
		{
			return null;
		}

		private void InitTitleFlashForColloabo04()
		{
		}

		private void InitTitleFlashForAnniversary()
		{
		}

		private void InitTitleFlashForColloabo03()
		{
		}

		public void CreateAndroidBackKeyAppExitPopup()
		{
		}

		public void OnTouchGuardPressed()
		{
		}

		public void OnTitleButtonPressed()
		{
		}

		public void GoToFullDownload()
		{
		}

		private IEnumerator GoToFullDownloadCoroutine()
		{
			return null;
		}

		private IEnumerator OnTitleButtonPressedCoroutine()
		{
			return null;
		}

		private void OnDeleteSizeCalculated(long size)
		{
		}

		private void CheckDownload()
		{
		}

		public void OnCancelTitleButtonPressed()
		{
		}

		private IEnumerator GoToNextSceneCoroutine()
		{
			return null;
		}

		private bool CheckIllegalUser()
		{
			return default(bool);
		}
	}
}
