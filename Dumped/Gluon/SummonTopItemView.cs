using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonTopItemView : MonoBehaviour
	{
		public enum SummonTopItemTabType
		{
			None = -1,
			Normal = 0,
			StarLegend = 2,
			Platinum = 3,
			CharaSsr = 4,
			DragonSsr = 5,
			CampaginSsr = 6,
			CharaSsrUpdate = 7,
			DragonSsrUpdate = 8,
			Exclude = 9
		}

		public enum TenTicketBallonType
		{
			defaultBalloon,
			tenTicketBallon,
			tenFreeBalloon,
			tenFreeBeginnerBallon,
			manyFreeMultipleBallon
		}

		public struct SummonTopItemTabOrderData
		{
			public int summonId;

			public SummonTopItemTabType summonType;

			public SummonTopItemTabOrderData(int id, SummonTopItemTabType type)
			{
			}
		}

		[SerializeField]
		[Header("SummonPoint")]
		public CanvasGroup commonSummonPageCanvasGroup;

		[SerializeField]
		[Header("SummonButtons")]
		public SummonButton dailyButton;

		public SummonButton singleButton;

		public SummonButton multiButton;

		public SummonButton storyButton;

		private List<SummonButton> buttons;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject dailySummonLine;

		public GameObject singleSummonLine;

		public GameObject multiSummonLine;

		public GameObject starLegendInfoLine;

		public GameObject ownedTicketLine;

		public GameObject ownedStoneLine;

		public GameObject owneddragonStoneLine;

		public GameObject singleUseTicketLine;

		public GameObject multiUseTicketLine;

		public GameObject singleUseStoneLine;

		public GameObject multiUseStoneLine;

		public Image whiteFade;

		public GameObject ownTicketBalloon;

		public GameObject oneFreeSummonBalloon;

		public GameObject[] tenSummonBalloon;

		[SerializeField]
		[Header("Banner")]
		public SummonPageViewBase bannerPageView;

		[SerializeField]
		private GameObject bannerTouchGuard;

		[SerializeField]
		[Header("MovingForTabs")]
		public GameObject movieFrameLine;

		public GameObject otherButtonsMovingTabLine;

		public GameObject ownedMovingTabLine;

		[SerializeField]
		[Header("CSSummon")]
		public GameObject switchSummonButton;

		public Text switchSummonText;

		[SerializeField]
		[Header("MovingObject")]
		public Transform singleStonePriceObject;

		public Transform multiStonePriceObject;

		[SerializeField]
		[Header("DailyMask")]
		public GameObject dailyDrawnMask;

		[SerializeField]
		[Header("Texts")]
		public Text ownedPaidStoneCount;

		public Text ownedFreeStoneCount;

		[SerializeField]
		[Header("CommonPriceText")]
		public Text dailyPrice;

		public Text singlePrice;

		public Text multiPrice;

		[SerializeField]
		[Header("OwnedPriceText")]
		public Text ownedSingleTicketCount;

		public Text ownedMultiTicketCount;

		public Text starLegendPrice;

		public Text starLegendInfoText;

		[SerializeField]
		[Header("Exchange Summons")]
		public GameObject exchangeSummonNode;

		[SerializeField]
		public Text exchangeSummonItemCount;

		[SerializeField]
		[Header("PageView")]
		public PageViewBase pageView;

		public GridLayoutGroup pageViewGridLayout;

		public GameObject pageViewTouchGuard;

		[SerializeField]
		[Header("SingleImageView")]
		public GameObject pageViewFrameNode;

		public GameObject singleImageViewFrameNode;

		public GameObject startDashButtonAttachNode;

		public GameObject startDashCommentAttachNode;

		[SerializeField]
		[Header("SwitchTabPublisher")]
		public UIAnimationPublisher switchTabPublisher;

		public UIAnimationPublisher toStagePublisher;

		[SerializeField]
		[Header("DragonSSrOnly")]
		private GameObject dragonSsrButtonsNode;

		[SerializeField]
		[Header("manyFreeMultiplSummon")]
		private Text manyFreeMultipleBalloonText;

		[SerializeField]
		private float fadeTimeFactor;

		[HideInInspector]
		public SummonScene scene;

		private SummonTopData topData;

		private float autoRefreshTime;

		private const float movieRefreshTime = 8f;

		private const float topRefreshTime = 3f;

		private const float amuletRefreshTime = 6f;

		private Coroutine autoRefreshCoroutine;

		private float edgeToEdgeMovingHeightAlphaValue;

		private StartDashImageSetting startDashImageSetting;

		private StartDashImageSetting dragonSsrImageSetting;

		private PlatinumImageSetting platinumImageSetting;

		private CampaignImageSetting campaignImageSetting;

		private SummonSsrUpdateImageSetting summonCharaSsrUpdateImageSetting;

		private SummonSsrUpdateImageSetting summonDragonSsrUpdateImageSetting;

		private ExcludeImageSetting excludeImageSetting;

		private Image specificDragonSsrTopBannerImage;

		private Image specificCharaSsrTopBannerImage;

		private Image campaignTopBannerImage;

		private Vector3 initialOthersButtonLinePos;

		private AnimationUITalkWindow specialSummonTalkWindow;

		private bool onChangingSummon;

		private const int csSummonId = 9999999;

		private SummonTopItemData _data;

		private List<SummonTopItemTabOrderData> bannerDataList;

		private int bannerTabIndex;

		private List<SummonTopItemData> SummonTopItemDataList;

		private SummonTopItemTabType currentTabType;

		public SummonTopItemData data => null;

		private void SwitchToSummonTopItemData(SummonTopItemData itemData, bool includeBanner = false)
		{
		}

		private void Awake()
		{
		}

		private string GetTitleImagePath(int index)
		{
			return null;
		}

		public void DisableButtonsForTutorial(bool enableMultiButton)
		{
		}

		private GameObject CopyNodeFromNodeAndAddToTransform(GameObject from, Transform to)
		{
			return null;
		}

		private GameObject MoveNode(GameObject from, Transform to)
		{
			return null;
		}

		public void RefreshPriceAndButton()
		{
		}

		public void SetSummonExchangeUI()
		{
		}

		private void SummonDataUpdate()
		{
		}

		private void SetTenBallon(TenTicketBallonType ballonType)
		{
		}

		private IEnumerator RefreshByData(bool includeBanner = false)
		{
			return null;
		}

		private void ShowBannerInCurrentPage()
		{
		}

		private IEnumerator SummonPointCheck()
		{
			return null;
		}

		private void LoadSpecialSummonResources()
		{
		}

		private void LoadSpecialDragonSummonResources()
		{
		}

		private void LoadSummonCharaSsrResources()
		{
		}

		private void LoadSummonDragonSsrResources()
		{
		}

		private void LoadCampaginSummonResource()
		{
		}

		private void LoadExcludeSummonResource()
		{
		}

		private void LoadPlatinumResource()
		{
		}

		private IEnumerator SetupTabPageView()
		{
			return null;
		}

		private IEnumerator SetupPageView()
		{
			return null;
		}

		private List<SummonTopItemTabOrderData> GetListOfShowingTopTabOrderData()
		{
			return null;
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void OnBeforeStartExitAnimation()
		{
		}

		private SummonTopItemTabOrderData ChooseValidOrDefaultTab(SummonTopItemTabOrderData tabData)
		{
			return default(SummonTopItemTabOrderData);
		}

		public void SetPlayVoiceState(bool value)
		{
		}

		public void OnSwitchTab(int tabIndex, bool calledFromUI)
		{
		}

		public void SetTopData(SummonTopData topData)
		{
		}

		public void OnButtonPressed(SummonTopItemData.ButtonType buttonType, int summonId)
		{
		}

		public void OnOddsButtonPressed()
		{
		}

		public void OnSummonDetailButtonPressed()
		{
		}

		public void OnSwitchSummonPressed()
		{
		}

		public void SwitchToSummonWithAnimation(int summonId)
		{
		}

		private void LateUpdate()
		{
		}

		public void OnUnitStoryPressed()
		{
		}

		private void SetPageContent(GameObject page, int index)
		{
		}

		private void StartStabilizationAnimation(int index)
		{
		}

		private void StartAutoRefreshCoroutine()
		{
		}

		private IEnumerator AutoRefreshCoroutine()
		{
			return null;
		}

		private void TerminateAutoRefreshCoroutine()
		{
		}

		public void OnBeforeSceneLeaving()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void StartToStageAnimation(Action onDone)
		{
		}

		public void FadeOut()
		{
		}

		private List<SummonTopItemTabOrderData> SortSummonTopItemTabOrderData(List<SummonTopItemTabOrderData> orderedList)
		{
			return null;
		}

		public void OnCelingSummon()
		{
		}

		public void ExchangePopup(Action onClose)
		{
		}
	}
}
