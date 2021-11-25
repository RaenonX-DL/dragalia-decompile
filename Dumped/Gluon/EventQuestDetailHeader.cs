using System;
using System.Collections;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestDetailHeader : MonoBehaviour
	{
		[SerializeField]
		protected Image descripImage;

		[SerializeField]
		private RectTransform maskRectTransform;

		private bool isShown;

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
		private ButtonWithSelectedImage howToButtonRight;

		[SerializeField]
		private ButtonWithSelectedImage howtoButtonLeft;

		private AnimationUIBase detailButtonAnimation;

		public bool isPrepare;

		private FlashPlayerManager fpMgr;

		private FlashPlayer questTransitionEffect;

		public float mapMove;

		public float mapMoveTime;

		public bool isMapAnim;

		public float fadeout;

		private bool isAnimating;

		private TouchGuardObject goQuestPrepareTouchGuard;

		private const float animationFrame = 4f / 15f;

		private const string howToPlayCheckedKeyTemplate = "{0}_Loc_{1}_HowToPlayChecked";

		private string howToPlayImageTemplate;

		private const int howToPlayImageCountDefault = 3;

		private const int howToPlayImageCountArena = 1;

		private int howToPlayImageCount;

		private const string commonTopBannerPathTemplate = "EventQuestMenuDetail{0:D2}";

		[SerializeField]
		private GameObject needItemInfoObject;

		[SerializeField]
		private Text needItemNum;

		[SerializeField]
		private Image needItemImage;

		[SerializeField]
		private GameObject payItemInfoObject;

		[SerializeField]
		private Text payItemNum;

		[SerializeField]
		private Image payItemImage;

		private ButtonWithSelectedImage detailButtonWithSelectedImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetContent(int eventId, Clb01EventLocationElement location, Action onCompleted)
		{
		}

		public void SetContent(int eventId, CombatEventLocationElement location, Action onCompleted)
		{
		}

		public void SetContentCommon(int eventId, int topBannerImageId, Action onCompleted)
		{
		}

		protected void SetContentCommon(int eventId, string topBannerImagePath, Action onCompleted)
		{
		}

		public void StartEnterAnimation(float duration = 0.2f)
		{
		}

		public void OnQuestDetail()
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

		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage)
		{
			return null;
		}

		private void FrameDefault()
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}

		private void SetNeedItemInfo(int eventId, CombatEventLocationElement location)
		{
		}
	}
}
