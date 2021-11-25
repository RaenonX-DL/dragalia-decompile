using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventDetailBannerPage : QuestEventBannerPage
	{
		[SerializeField]
		private RectTransform maskRectTransform;

		private bool isShown;

		public static Action<RenderTexture> onFinishMapInstance;

		[SerializeField]
		public RawImage render3dImageBlack;

		[SerializeField]
		private Image outerFrame;

		private Vector2 descripImageDefaultPos;

		private Sequence animationSeq;

		[SerializeField]
		private RectTransform dummyRectEventQuestTop;

		[SerializeField]
		private RectTransform dummyRectEventQuestTopFrame;

		[SerializeField]
		private RectTransform dummyRectEventQuestMiddle;

		[SerializeField]
		private RectTransform dummyRectEventQuestMiddleFrame;

		[SerializeField]
		private Transform campaignTrans;

		private CampaignButtons campaign;

		private string campaginPath;

		public bool isPrepare;

		private FlashPlayerManager fpMgr;

		private FlashPlayer questTransitionEffect;

		public float mapMove;

		public float mapMoveTime;

		public bool isMapAnim;

		public float fadeout;

		public float goQuestPrepareFlashSec;

		[SerializeField]
		[Header("Void")]
		private GameObject voidRoot;

		[SerializeField]
		private GameObject bonusRoot;

		[SerializeField]
		private Text bonusText;

		[SerializeField]
		private Text notBonusText;

		[SerializeField]
		private Image bonusImage;

		[SerializeField]
		private Animator bonusAnimator;

		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;

		[SerializeField]
		private GameObject detailCheckIcon;

		[SerializeField]
		private Button detailButton;

		[SerializeField]
		[Header("Wall")]
		private GameObject questWallNode;

		[SerializeField]
		private GameObject astralRoot;

		[SerializeField]
		private Image astralItemIconImage;

		[SerializeField]
		private Text astralItemNumText;

		[SerializeField]
		[Header("Simple")]
		private QuestEventSimpleBanner simpleBanner;

		[SerializeField]
		[Header("Agito")]
		private QuestAgitoBanner questAgitoBanner;

		[SerializeField]
		[Header("TimeAttack")]
		private QuestEventTimeAttackBanner questEventTimeAttackBanner;

		[SerializeField]
		[Header("Ultimate Dragon")]
		protected Button ultimateDragonInfoButton;

		[SerializeField]
		private ButtonWithSelectedImage ultimateDragonInfoButtonnWithSelectedImage;

		private QuestEventGroupElement groupElement;

		private bool isBonusTime;

		[SerializeField]
		private float animationFrame;

		private static readonly int bonusAnimationHash;

		private QuestWallBanner questWallBanner;

		[SerializeField]
		private UIAnimationPublisher bannerObjectAnimation;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetContent(QuestEventGroupElement groupElement)
		{
		}

		private static void SetActiveScale(GameObject obj, bool isActive)
		{
		}

		public void StartEnterAnimation(float duration = 0.2f, [Optional] Action onCompleteAction)
		{
		}

		public void StartExitAnimation(float duration = 0.2f, bool inActiveOnComplete = false)
		{
		}

		public Tweener SetScreenTransVisible(bool visible, float time = 2f)
		{
			return null;
		}

		public void MapFadeOutAnimation(Action showQuestPrepare3dImage)
		{
		}

		public void OnQuestDetail()
		{
		}

		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage)
		{
			return null;
		}

		private void FrameDefault()
		{
		}

		public void OnTimeAttackRankingButtonForQuestId()
		{
		}

		public new void OnHowToButtonTouched()
		{
		}

		public void OnUltimateDragonInfoButton()
		{
		}

		public void AfterTutorialSetInstructorButton()
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}
