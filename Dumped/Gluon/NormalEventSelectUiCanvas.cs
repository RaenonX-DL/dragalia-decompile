using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class NormalEventSelectUiCanvas : AnimationUICanvas
	{
		[SerializeField]
		private Canvas _uiCanvas;

		private UnityAction backButtonSoundAction;

		[SerializeField]
		private Button backButton;

		private UnityAction _unityAction;

		private bool _isOpen;

		public Button multiJoinButton;

		public Button treasureTradeButton;

		[SerializeField]
		private Button dailySkipButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private ButtonWithSelectedImage dailySkipButtonSelectedImage;

		private NormalEventSelectScene.QuestSelectSceneType nowType;

		public QuestEventDetailBannerPage eventDetailBanner;

		[SerializeField]
		private UIAnimationPublisher topButtomAnimation;

		[SerializeField]
		private UIAnimationPublisher subButtomAnimation;

		[SerializeField]
		private float topButtomAnimationEnterDelay;

		public UnityAction<QuestSelectInstance.QuestEventData> actionScrollCell;

		[SerializeField]
		private Button[] balloonButtons;

		[SerializeField]
		private GameObject newSlideButtonObj;

		private QuestAutoTransitionUtil.GuestEnterRoomFromType multiJoinTypeOnBegin;

		private SceneBase parentScene;

		public Canvas uiCanvas => null;

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

		protected override void Awake()
		{
		}

		public void Initialize(SceneBase parentScene)
		{
		}

		public void SetSlideButton()
		{
		}

		public void SetBackButtonCallback(NormalEventSelectScene.QuestSelectSceneType type, UnityAction unityAction, bool isAnimStop = true)
		{
		}

		public void StartExitAnimation()
		{
		}

		public void DeleteBackButtonCallback()
		{
		}

		private void PlayTopEnterAnimation()
		{
		}

		public void PlayEventTopExitAnimation()
		{
		}

		private void ShowEventTopButton(bool bShow)
		{
		}

		public void SetChangeStatus(NormalEventSelectScene.QuestSelectSceneType type)
		{
		}

		public void SetQuestSelectUiData(NormalEventSelectScene.QuestSelectSceneType type, [Optional] UnityAction backButtonAction)
		{
		}

		private IEnumerator DelayAction(UnityAction action, float delaySeconds)
		{
			return null;
		}

		public void SetButtonActive()
		{
		}

		public void SetAllButtonsEnabled(bool isEnabled)
		{
		}

		public void OnMultiJoinButtonPressed()
		{
		}

		public void OnTreasureTradePressed()
		{
		}

		public void OnDailyPressed()
		{
		}

		public void OnBalloonJumpNewQuestButtonPressed()
		{
		}

		private QuestSelectInstance.QuestEventData FindNewIconRemainEvent()
		{
			return null;
		}

		private bool IsNewIconRemainEvent(QuestSelectInstance.QuestEventData eventData)
		{
			return default(bool);
		}

		public void ShowRoomListPopup(QuestAutoTransitionUtil.GuestEnterRoomFromType enterRoomFromType)
		{
		}

		public void ShowIdInputPopup(bool searchPrevRoom)
		{
		}

		private void ShowGpsSearchPopup()
		{
		}

		private void ShowMatchingRoomListPopup()
		{
		}

		private void SetParentUiQuestPrepareMode()
		{
		}

		private void GoPrepareScene(int questId, QuestAutoTransitionUtil.GuestEnterRoomFromType enterFromType)
		{
		}

		public void ReserveMultiJoinPopup(QuestAutoTransitionUtil.GuestEnterRoomFromType joinTypeOnBegin)
		{
		}

		public void ShowMultiJoinPopupOnBegin()
		{
		}
	}
}
