using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestPrepareCanvas : PartyUICanvasBase
	{
		[HideInInspector]
		public QuestPrepareScene questPrepareScene;

		public PartyPageViewBase pageView;

		public UnityAction partyEditCallBack;

		public UnityAction questStartCallBack;

		[SerializeField]
		private GameObject questDifficultyIconRoot;

		[SerializeField]
		private GameObject questElementIconRoot0;

		[SerializeField]
		private GameObject questElementIconRoot;

		public static readonly float lackOfPowerWarningThresholdRatio;

		private const string clearSEName = "SE_OUT_COMMON_0054";

		public RawImage render3dImage;

		public Transform pageViewContentParent;

		public GameObject questInfoBase;

		public Text questInfoText;

		public Button clearPartyButton;

		public Button supportChangeButton;

		public Button partyEditButton;

		[SerializeField]
		private Image partyEditNormalImage;

		[SerializeField]
		private Image partyEditSelectedImage;

		public Image supportSkillIcon;

		public Text clearPartyText;

		public Text questName;

		public float runAnimationDistance;

		public QuestPrepareUIStatus[] partyStatus;

		public Image leadImage;

		public GameObject statusBase;

		[SerializeField]
		private Button questStartButton;

		[SerializeField]
		private GameObject partyCheckRoot;

		[SerializeField]
		private RectTransform partyCheckButtonRect;

		[SerializeField]
		private RectTransform partyCheckButtonRightPos;

		[SerializeField]
		private GameObject questSkipRoot;

		[SerializeField]
		private Button questSkipButton;

		[SerializeField]
		private Image questSkipDisabledImage;

		[SerializeField]
		private Image questSkipNotSatisfyConditionsImage;

		[SerializeField]
		private Text questSkipTicketNumText;

		[SerializeField]
		private Text questSkipButtonTitleText;

		[SerializeField]
		private Text questSkipTicketUseText;

		[SerializeField]
		private Button normalPartyButton;

		[SerializeField]
		private GameObject dragonOnlyIcon;

		[SerializeField]
		private GameObject dragonOnlyBallon1Unit;

		[SerializeField]
		private GameObject dragonOnlyBallon4Unit;

		[SerializeField]
		private GameObject soloQuestBalloon;

		public QuestPrepareRepeatButton repeatButton;

		private SceneUICanvas sceneUiCanvas;

		private GameObject questDifficultyIconObj;

		private GameObject questElementIconObj0;

		private GameObject questElementIconObj;

		private QuestSkipTicketConfirmPopup skipConfirmPopup;

		protected EventQuestConditionPopup conditionPopup;

		private bool isPartyEditPressed;

		private bool isPartyEditOpened;

		public RectTransform edgeToEdgeFrame;

		[SerializeField]
		[Header("DummyRect")]
		public RectTransform partyBaseMoveTo;

		public RectTransform learderImageMoveTo;

		public RectTransform statusMoveTo;

		public RectTransform switchButtonMoveTo;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher enterExitPublisherPublisher;

		public UIAnimationPublisher goCharacterPublisher1;

		public UIAnimationPublisher goCharacterPublisher2;

		public UIAnimationPublisher goEquipPublisher1;

		public UIAnimationPublisher goEquipPublisher2;

		[SerializeField]
		[Header("simple202004ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088ç\u0094\u00a8Flash")]
		public GameObject[] questReadyPawEventObjects;

		public FlashPlayerManager flashPlayerManager;

		private FlashPlayer questReadyPawMainEventFlash;

		public Transform questReadyPawMainEventFlashParent;

		public float questReadyPawMainOffsetY;

		private FlashPlayer questReadyPawLowerEventFlash;

		public Transform questReadyPawLowerEventFlashParent;

		public float questReadyPawLowerOffsetY;

		[SerializeField]
		[Header("CharacterTransparentButton")]
		public PointerEventHandler[] characterTransparentButtonsEventHandler;

		private bool isGoPartyCharacter;

		private bool isScreenCaptureEnd;

		[HideInInspector]
		public int questId;

		public Text partyNameText;

		public GameObject partyNameBaseObject;

		public GameObject partyChangeButtonObject;

		public GameObject charaModelBase => null;

		public QuestPreparePageView pageCtrl
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

		private void Start()
		{
		}

		public void SetupAndStartEnterAnimation()
		{
		}

		private void SetElementIcon()
		{
		}

		public void ReflechSkipTicketStatus(int questId)
		{
		}

		public void ReflechSkipTicketStatusWall(int wallId)
		{
		}

		private IEnumerator ActivateStatusDelay()
		{
			return null;
		}

		public void RefreshSupportInfo()
		{
		}

		public void ShowSupportInfo(bool hasSupporter)
		{
		}

		public void OnSupportSkillIconPressed()
		{
		}

		public void SetPageContent(GameObject page, int index)
		{
		}

		private void SavePartySwichIndex()
		{
		}

		public void CharaModelPressed(int tag)
		{
		}

		public void CharaModelLongPressed(int tag)
		{
		}

		public void ShowClearParty(bool isAutoSelect = false)
		{
		}

		public void ShowNormalParty(bool isAutoSelect = false)
		{
		}

		public void OnExAbilityButtonPressed()
		{
		}

		public void PartyEditPressed()
		{
		}

		public void QuestStartPressed()
		{
		}

		private void OnJoinConditionsFailed(StringBuilder failedDescription)
		{
		}

		private void OnTemporaryCharaInParty()
		{
		}

		private void CheckAfterCheckStamina()
		{
		}

		private bool IsLackOfPartyPower()
		{
			return default(bool);
		}

		private bool IsNotSuperiorElement()
		{
			return default(bool);
		}

		private ElementalType GetSuperiorElementalType()
		{
			return default(ElementalType);
		}

		private ElementalType GetCurrentElementalType()
		{
			return default(ElementalType);
		}

		private bool IsMakeNotMatchElementPopup()
		{
			return default(bool);
		}

		public void ShowQuestOrderPartyCautionPopup(string cautionText, [Optional] UnityAction closeCallBack)
		{
		}

		private void MakeLackOfPowerPopup(UnityAction questStartCallBack)
		{
		}

		private void MakeNotMatchElementPopup(bool isLackOfPower, UnityAction questStartCallBack)
		{
		}

		private void CheckOverrideQuest(UnityAction onSucceed)
		{
		}

		private void CloseEventQuestConditionPopup()
		{
		}

		public void ResetQuestButtonImage()
		{
		}

		private void ResetQuestSkipButtonImage()
		{
		}

		public void SetupPowerParam()
		{
		}

		protected override void ReloadExAbilityIcon()
		{
		}

		protected override void RefreshUnionBonus()
		{
		}

		public void OnPartyButtonUp()
		{
		}

		private void PartyCharacterButtonUpDelay(float delay)
		{
		}

		private IEnumerator PartyCharacterButtonUpDelayRoutine(float delay)
		{
			return null;
		}

		public void OnPartyButtonDown()
		{
		}

		public void OnSkipButton()
		{
		}

		public void OnSkipDisabledButton()
		{
		}

		private bool IsLackOfTicket()
		{
			return default(bool);
		}

		public void OnSkipNotSatisfyConditions()
		{
		}

		public void OnSkipConfirmPopupOk()
		{
		}

		public void OnSkipTicket()
		{
		}

		public void OnSkipConfirmPopupCancel()
		{
		}

		public void QuestStartApi(int playCount)
		{
		}

		private void onSkipSuccess()
		{
		}

		private void LoadResultScene()
		{
		}

		private IEnumerator LoadSceneCoroutine()
		{
			return null;
		}

		private IEnumerator WaitExitAnim()
		{
			return null;
		}

		private void onSkipError(ErrorType errorType, int resultCode)
		{
		}

		private void SetClearPartyEnable(bool enable)
		{
		}

		public void OnClearPartyButtonTouched()
		{
		}

		public void OnNormalPartyButtonTouched()
		{
		}

		private void OnCharactersExchangeByJumping()
		{
		}

		public void OnCharaPartyButtonTouched()
		{
		}

		public void GoPartyCharacterScene()
		{
		}

		public void StartGoCharacterSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void StartGoEquipSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished)
		{
			return null;
		}

		public void AdjustInnerAnimationOffset()
		{
		}

		public void OnBgAnimationFinished()
		{
		}

		private FlashPlayer InitializeFlash(string path, float offsetY, Transform parent)
		{
			return null;
		}

		private void OnQuestReadyPawFlashEnded(TouchGuardObject touchGuard)
		{
		}

		private void SetQuestReadyPawEventObjectEnable(bool enable)
		{
		}

		private void SetDragonOnlyIcon(QuestDataElement questData)
		{
		}

		private void SetDisabledImage(bool isActive)
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		private void UpdatePartyName()
		{
		}

		public void OnPartyChackButtonPressed()
		{
		}

		private void UpdateCanvasAction()
		{
		}

		private void ReloadPartyView(bool noReloadModel = false)
		{
		}

		public void OnPartyNameEditButtonPressed()
		{
		}

		protected override void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode)
		{
		}

		private void SetUIStatusForQuestOrderParty()
		{
		}

		private void SetUIStatusForQuestBatchRun()
		{
		}
	}
}
