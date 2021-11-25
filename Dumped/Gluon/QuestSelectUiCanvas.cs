using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectUiCanvas : AnimationUICanvas
	{
		[Serializable]
		public struct FlashPosScaleInfo
		{
			public Vector3 localPos;

			public float localScale;

			public int sortingOrder;
		}

		[SerializeField]
		private Canvas _uiCanvas;

		private UnityAction backButtonSoundAction;

		private BackButton _backButton;

		private UnityAction _unityAction;

		private bool _isOpen;

		[SerializeField]
		private Button[] uiDifficultyButtons;

		[SerializeField]
		private Image[] uiDifficultyNormalArrow;

		[SerializeField]
		private GameObject uiDiffcultyAndAchievementRoot;

		[SerializeField]
		private GameObject _uiFlashTrans;

		[SerializeField]
		private GameObject uiCampaignParent;

		[SerializeField]
		private PointerEventHandler uiCampaignButton;

		[SerializeField]
		private PointerEventHandler uiDragonSphereButton;

		[SerializeField]
		private GameObject uiToChapterButton;

		[SerializeField]
		private GameObject uiScrollChapter;

		[SerializeField]
		private Text uiScrollChapterNumberText;

		[SerializeField]
		private GameObject uiBannerParent;

		[SerializeField]
		private GameObject leftAreaChangeButton;

		[SerializeField]
		private GameObject rightAreaChangeButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private FlashPosScaleInfo dragonFlashInfo;

		[SerializeField]
		private GameObject uiStoryButton;

		[SerializeField]
		private GameObject uiStorySkipButton;

		[SerializeField]
		private GameObject uiLastedChapterButton;

		[SerializeField]
		private CanvasGroup mapCanvasGroup;

		[SerializeField]
		private CanvasGroup titleCanvasGroup;

		[SerializeField]
		private GameObject notOpenchapterLockObj;

		[SerializeField]
		private Text notOpenchapterLockText;

		[SerializeField]
		private CanvasGroup notOpenchapterLockObjCanvasGroup;

		public UnityAction onClickRightArrow;

		public UnityAction onClickLeftArrow;

		public UnityAction onToChapter;

		public UnityAction onBanner;

		private SimpleAnimationButton animButton;

		private QuestSelectScene.QuestSelectSceneType nowType;

		[SerializeField]
		private int _locationId;

		[SerializeField]
		private QuestMapImage _questMapImage;

		[SerializeField]
		private QuestMenuListTitle questListTitle;

		private static bool _isOpenOnCreated;

		[SerializeField]
		private QuestSelectScene.Difficulty _difficulty;

		public QuestSelectScene questSelectScene;

		private AnimationUIPart[] animationUIParts;

		private UnityAction onOpenCallback;

		private UnityAction onCloseCallback;

		public FlashPlayer[] flashPlayerDragonlr;

		private bool isDragonAnimation;

		[SerializeField]
		private PointerEventHandler chapterMovePointerEventHander;

		private Vector2 vec;

		public Canvas uiCanvas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BackButton backButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityAction unityAction => null;

		public bool isOpen
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public GameObject uiFlashTrans => null;

		public int locationId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public QuestMapImage questMapImage => null;

		public static bool isOpenOnCreated
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public QuestSelectScene.Difficulty difficulty
		{
			get
			{
				return default(QuestSelectScene.Difficulty);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void CheckReleaseFunction()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetBackButtonCallback(QuestSelectScene.QuestSelectSceneType type, UnityAction unityAction, bool isAnimStop = true)
		{
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}

		private void StartEnterAnimationAfterExitingCompleted(bool isImageToText, QuestSelectScene.QuestSelectSceneType type, bool isAfterAnimStop = false)
		{
		}

		private IEnumerator WaitForExitingAndStartEnteringCoroutine(bool isImageToText, QuestSelectScene.QuestSelectSceneType type, bool isAfterAnimStop)
		{
			return null;
		}

		public void AnimationFlagStop()
		{
		}

		public void DeleteBackButtonCallback()
		{
		}

		public void SetDifficultButtonCallBack([Optional] UnityAction unityAction)
		{
		}

		public void SetChangeStatus(QuestSelectScene.QuestSelectSceneType type)
		{
		}

		public void SetButtonAllOff()
		{
		}

		public void SetUIAll(bool enable)
		{
		}

		public void SetButtonActive()
		{
		}

		public void OnEnableDifficultyButtonFromTutorial()
		{
		}

		public void ChangeDifficultyButton(QuestSelectScene.Difficulty difficulty)
		{
		}

		public void SetNormalDifficultyArrowss()
		{
		}

		public void SetAllButtonsEnabled(bool isEnabled)
		{
		}

		public void OnClickRightArrow()
		{
		}

		public void OnClickLeftArrow()
		{
		}

		public void SetArrowEnable(bool enable)
		{
		}

		public void OnToChapter()
		{
		}

		public void OnBanner()
		{
		}

		public void OnCampaignButtonPressed()
		{
		}

		public void OnSphereButton()
		{
		}

		public void SetToChapterNumber(int index)
		{
		}

		public void OnSwipeChangeChapter(float pointEventData)
		{
		}

		public void MapOpen(int locationId)
		{
		}

		private IEnumerator WaitBgAndOpen()
		{
			return null;
		}

		private void Appear()
		{
		}

		private void Open()
		{
		}

		public void OnHide()
		{
		}

		protected void Hide()
		{
		}

		private void InitializeParts(bool isInitializeLandmarkPosAndBg = true)
		{
		}

		public void MapClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false)
		{
		}

		private void Close()
		{
		}

		private IEnumerator WaitCloseCompleted(bool isDestroyOnCompleted, bool isCloseTouchGuard)
		{
			return null;
		}

		public void SetOpenCallback([Optional] UnityAction onOpen)
		{
		}

		public void SetCloseCallback([Optional] UnityAction onClose)
		{
		}

		public void MapNotClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false)
		{
		}

		public void CreateDragon()
		{
		}

		public void SetActiveDragon(bool enable)
		{
		}

		private IEnumerator SetActiveDragonCorutine(bool enable)
		{
			return null;
		}

		public void PlayDragonFlash(string str, int delayCount = 0, [Optional] Action action)
		{
		}

		private IEnumerator DelayMethod(Action callback, int delayCount)
		{
			return null;
		}

		private void OnDragonAnimationEnd()
		{
		}

		public bool IsDragonAnimation()
		{
			return default(bool);
		}

		public void OnStorySkipButtonPressed()
		{
		}

		public void OnAdvStoryButtonPressed()
		{
		}

		private int GetMaxChapter()
		{
			return default(int);
		}

		public void SetButtonStateTutorial_2_2_Tutorial_ToBackButton(UnityAction callback)
		{
		}

		public void OnLastedChapterButton()
		{
		}
	}
}
