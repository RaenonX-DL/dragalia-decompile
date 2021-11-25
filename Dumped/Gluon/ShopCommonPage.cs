using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonPage : ShopTradePanelBase
	{
		public class TalkTypeInfo
		{
			public ShopTradeModel.PanelType panelType;

			public int tabIndex;

			public bool hasSummon;

			public bool isCharaTouched;

			public TalkTypeInfo()
			{
			}

			public TalkTypeInfo(ShopTradeModel.PanelType panelType, int tabIndex = -1, bool hasSummon = false, bool isCharaTouched = false)
			{
			}
		}

		public enum TopPartPattern
		{
			None,
			TopPage,
			Masked,
			OutOfScreen
		}

		[SerializeField]
		[Header("Banner")]
		public PageViewBase pageView;

		public GameObject pageViewNode;

		public CanvasGroup pageViewCanvasGroup;

		[SerializeField]
		[Header("holdingText")]
		public Text holdingGoldText;

		public Text holdingManaText;

		public Text holdingMoonText;

		[SerializeField]
		[Header("Mask")]
		public RectTransform maskMovingPart;

		public GameObject topHidePart;

		public CanvasGroup bgCanvasGroup;

		[SerializeField]
		[Header("Talk")]
		private Text characterNameText;

		[SerializeField]
		private Text talkText;

		[SerializeField]
		public ShopTradeCharaTalkSelector charaTalkSelector;

		[SerializeField]
		private GameObject balloon;

		[SerializeField]
		private OutGameBgChara bgChara;

		[SerializeField]
		private KeepStableToTransform keepStable;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher topToPageWithMaskPublisher;

		public UIAnimationPublisher pageToUpwardWithMaskPublisher;

		public UIAnimationPublisher enterTopPublisher;

		public UIAnimationPublisher maskTopPartPublisher;

		public UIAnimationPublisher maskBottomPartPublisher;

		public UIAnimationPublisher topCharaInnerMovePublisher;

		public UIAnimationPublisher hideTopCharaPublisher;

		private const float maskMovingY = 1024f;

		public static string charaVoiceGroupName;

		private Coroutine talkCoroutine;

		private bool isBalloonOn;

		private const float autoMoveTime = 8f;

		private float moveTimer;

		private bool autoMove;

		private GameObject preLoadedPage;

		private bool initTalkDone;

		public static ShopCommonPage Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetTopHidePartVisibility(bool v)
		{
		}

		private void HideBGCharaAndShowPage()
		{
		}

		private void GenerateTopBanners(ShopTradeModel.PanelType curPanel, ShopTradeModel.PanelType nextPanel)
		{
		}

		private void Update()
		{
		}

		public void RaiseTalk(TopPartPattern nextPattern, TopPartPattern currentPattern, TalkTypeInfo info)
		{
		}

		private void ShowBalloon(OutGameTopCharaTalkSelector.TalkData talkData)
		{
		}

		private void HideBalloon()
		{
		}

		private IEnumerator StartTalkCoroutine(TalkTypeInfo info, float preWaitTime, float postWaitTime, bool soundOnly)
		{
			return null;
		}

		private void PlayTalk(OutGameTopCharaTalkSelector.TalkData talkData)
		{
		}

		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false)
		{
		}

		public void OnCharaPressed()
		{
		}

		public void OnStonePurchaseButtonPressed()
		{
		}

		private void RefreshHoldings()
		{
		}

		public override void RefreshCurrentPage()
		{
		}

		private TopPartPattern GetTopPartPattern(ShopTradeModel.PanelType panelType)
		{
			return default(TopPartPattern);
		}

		private void FadeBG(bool isFadeIn, float durationInFrame = 6f)
		{
		}

		public void StartExitAnimation()
		{
		}

		private void SwitchTopBanner(ShopTradeModel.PanelType currentPanel, ShopTradeModel.PanelType nextPanel)
		{
		}

		public void OnSwitchPanel(ShopTradeModel.PanelType currentPanel, ShopTradeModel.PanelType nextPanel, bool allowFromNone = false)
		{
		}
	}
}
