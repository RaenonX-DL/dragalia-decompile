using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPageUICanvas : AnimationUICanvas
	{
		private enum MainBannerType
		{
			QuestEvent = 1,
			QuestEventGroup,
			Event
		}

		public CanvasGroup canvasGroup;

		public RawImage fadeoutImage;

		public MyPageScene scene;

		public Badge missionBadge;

		public Image pickupMissionBadge;

		public Badge shopBadge;

		public GameObject shopNewIcon;

		public Button infoButton;

		public Badge guildBadge;

		[SerializeField]
		private GameObject inviteBadge;

		public Button missionButton;

		public Button shopButton;

		public Button guildButton;

		public Button bannerButton;

		public Image bannerLockImage;

		public GameObject campaignButtonParent;

		public Button campaignButton;

		public Button uiHideButton;

		[SerializeField]
		public Button drillButton;

		public GameObject subBannerNode;

		public MyPageSubBannerController subBannerController;

		public GameObject startDash;

		public Image startDashTextImage;

		public Text startDashTimeText;

		public GameObject specialShopBalloon;

		public Text specialShopTimeText;

		public Image mainBannerImage;

		public Text mainBannerText;

		public bool isMainBannerEnabled;

		public Badge mainBannerBadge;

		public CanvasGroup mainBannerCanvasGroup;

		public bool isTutorialCheckComplete;

		private const int emptyEventId = 20101;

		private const int voidEventId = 30000;

		private int mainBannerEventId;

		private MainBannerType mainBannerType;

		[SerializeField]
		private GameObject guideTopObj;

		[SerializeField]
		private GameObject mainStoryGuideObj;

		[SerializeField]
		private GameObject missionGuideObj;

		[SerializeField]
		private Button guideToggleButton;

		[SerializeField]
		private Animator missionGuideAnimator;

		private const string missionGuideToggleKey = "MypPageMissionGuideToggleState";

		[SerializeField]
		private Text mainStoryGuideTitle;

		[SerializeField]
		private Text mainStoryGuideText;

		[SerializeField]
		private Text mainStoryMissionTopTitle;

		[SerializeField]
		private MypageMainStoryMissionCell mainStoryMissionTitleCell;

		[SerializeField]
		private MypageMainStoryMissionCell[] mainStoryMissionCells;

		[SerializeField]
		private GameObject mainStoryMissionUIObj;

		[SerializeField]
		private Text dailyMissionGuideText;

		private bool isEventBannerTransitionProcessing;

		[SerializeField]
		private GameObject hideFinishButton;

		[SerializeField]
		private UiAnimationHide uiAnimationHide;

		[SerializeField]
		private MyPageMissionDrillGuide missionDrillGuide;

		[SerializeField]
		private Transform missionGuidePositionAnchor;

		protected override void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator CheckSubBannerEnabled()
		{
			return null;
		}

		private void SetMainBannerText(EventDataElement eventData)
		{
		}

		private void SetMainBannerImage(int bannerImageId, string bannerImageName, [Optional] Action<Material> onCompleted)
		{
		}

		private bool GetEventDataWithinPeriod(int eventDataId, out EventDataElement eventData)
		{
			return default(bool);
		}

		private void SetMainBanner()
		{
		}

		public void Reload()
		{
		}

		public void UpdateMissionBadgeMark()
		{
		}

		public void ShowStartDash()
		{
		}

		public void ShowShopBadge(bool visible)
		{
		}

		public static bool IsGuildBadgeVisible()
		{
			return default(bool);
		}

		public void ShowGuildBadge()
		{
		}

		public void OnQuestButtonPressed(bool state)
		{
		}

		public void OnEventButtonPressed(bool state)
		{
		}

		public void OnEventBannerButtonPressed(bool state)
		{
		}

		public void OnGuildButtonPressed()
		{
		}

		public void OnNoticeButtonPressed(bool state)
		{
		}

		public InformationPopup CreateInformationPopup(bool state)
		{
			return null;
		}

		public void OnMissionButtonPressed(bool state)
		{
		}

		public void OnPvPButtonPressed()
		{
		}

		public void OnCampaignButtonPressed()
		{
		}

		public void OnShopButtonPressed()
		{
		}

		public void OnMainStoryMissionButtonPressed()
		{
		}

		public void SetSceneeAllButton(bool enable)
		{
		}

		private void SetEnableColorForBanner(bool enable)
		{
		}

		private IEnumerator TutorialCheckCoroutine(bool enable)
		{
			return null;
		}

		public void CheckShopNewBadge()
		{
		}

		private void UpdateTutorialGuide()
		{
		}

		private void UpdateMissionGuideText()
		{
		}

		private void UpdateMissionGuideToggle()
		{
		}

		private void SetMissionGuideToggle(bool isOpen, bool isSave = true)
		{
		}

		public void OnChangeMissionGuideToggle()
		{
		}

		public void OnMissionGuideButtonPressed()
		{
		}

		public void UpdateDrillMissionGuide()
		{
		}

		private void ShowSpecialShop()
		{
		}

		public void OnUiHideButtonPressed()
		{
		}

		public void OnMissionDrillButtonPressed()
		{
		}

		public void OnFinishUiHideButtonPressed()
		{
		}
	}
}
