using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventStatusInfoCtrl : AnimationUIObject
	{
		[SerializeField]
		[Header("BG")]
		private Image bg2DImage;

		[SerializeField]
		private Image bgPlane;

		[SerializeField]
		[Header("Chara")]
		private Image charaBg;

		[SerializeField]
		public OutGameBgChara bgCharacter;

		[SerializeField]
		private RectTransform etoeCharaMoveNode;

		[SerializeField]
		private Transform charaOffsetNode;

		[SerializeField]
		private float charaMoveOffsetIPhoneX;

		[SerializeField]
		[Header("Talk")]
		private Button charaTalkButton;

		[SerializeField]
		[Header("TalkWindowModule")]
		public EventTalkWindowModule talkWindowModule;

		[SerializeField]
		[Header("Masks")]
		private RectMask2D questTopMask;

		[SerializeField]
		private RectMask2D questListMask;

		[SerializeField]
		private GameObject goSeperatorTop;

		[SerializeField]
		private GameObject goSeperatorQuestList;

		[SerializeField]
		private Transform topKeepStableOffset;

		[SerializeField]
		[Header("StatusInfo")]
		private Transform statusInfoParent;

		[SerializeField]
		[Header("Campaign")]
		private CampaignButtons campaign;

		[SerializeField]
		[Header("ForRandom")]
		private EventMapImage mapImage;

		[SerializeField]
		private GameObject treasureImagesParent;

		[SerializeField]
		private Image[] treasureImages;

		[SerializeField]
		[Header("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0081\u00a8ã\u0081®é\u0096\u0093ã\u0081§ã\u0081®æ\u009e\u00a0èª¿æ\u0095\u00b4")]
		private float startHeightSeperatorQuestList;

		[SerializeField]
		public float endHightSeperatorRaidQuestList;

		[SerializeField]
		private float startHeadSeparatorYOffset;

		[SerializeField]
		[Header("æ\u00a8ª")]
		private float questListMaskMinWidth;

		[SerializeField]
		public float questListMaskMaxWidth;

		[SerializeField]
		[Header("MaskMoving")]
		private float maskMovingDuration;

		[SerializeField]
		[Header("Frame")]
		private RectTransform bgTopTransform;

		[SerializeField]
		private RectTransform frameTopTransform;

		[SerializeField]
		private RectTransform bgMiddleTransform;

		[SerializeField]
		private RectTransform frameMiddleTransform;

		[SerializeField]
		private GameObject edgeToEdgeFrameObj;

		[SerializeField]
		[Header("Publishers")]
		private UIAnimationPublisher charaPublisher;

		[SerializeField]
		[Header("Old Publishers")]
		private AnimationUIGroup animationGroup;

		[SerializeField]
		private AnimationUIMove charaMove;

		[SerializeField]
		[Header("ToQuestListBallonExitDelay")]
		private bool isUseBalloonExitDelay;

		[SerializeField]
		private float balloonExitDelay;

		private int curTalkIndex;

		public bool isTreasureTime;

		private const float image2DHeightIPhoneX = 642f;

		public static Action<RenderTexture> onFinishMapInstance;

		private const float topKeepStableHighPosOffset = -76f;

		private string selectedTopCharaId;

		private CanvasGroup bgCanvasGroup;

		private const string bgMaterialReadyFlagName = "__matReady";

		private Coroutine talkCoroutine;

		private EventInfoCtrlBase infoCtrl;

		private bool isNeedHeaderMargin;

		private bool isMapAnim;

		private FlashPlayer questTransitionEffect;

		private FlashPlayerManager fpMgr;

		private float fadeout;

		public int eventPoint
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isOnMaskAnimation
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

		public RectTransform syncTopMask
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

		public bool isInited
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

		public EventInfoCtrlBase GetEventInfoCtrlBase()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateCampains()
		{
		}

		public static Vector2 LoadCharaterImage(int eventId, OutGameBgChara bgCharacter, Image charaBg, out Vector2 charaEventListPageMoveOffset, [Optional] EventStatusInfoCtrl infoCtrl, bool deactiveParts = false, [Optional] EventQuestTalkDataModel.TalkSet usingTalkSet)
		{
			return default(Vector2);
		}

		private void Load2DIBgImage()
		{
		}

		public void SetEventInfo()
		{
		}

		public void OnMiniCharaTouched(int posIndex)
		{
		}

		public void ShowTreasureTimeImageInHeader(EventQuestModel.TreasureTimeType treasureType, bool forceInactive = false)
		{
		}

		public void OnCharaTouched()
		{
		}

		public void StartTalk(string voiceData, [Optional] EventTopPageBase page)
		{
		}

		public void StopTalk(bool forceFadeOut = false)
		{
		}

		private IEnumerator Talk(string voiceData, [Optional] EventTopPageBase page)
		{
			return null;
		}

		private string GetVoiceGroupName(string soundName)
		{
			return null;
		}

		public string GetVoiceData(bool isFromCharaTouch)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void ResetTopImageAndTalk()
		{
		}

		private IEnumerator FadeBackground(bool isFadeIn)
		{
			return null;
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void SetAlphaWithObjects(float value)
		{
		}

		public void StartAnimationFromQuestPrepare(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName previousPageName, bool isFadeOut = false, float delay = 0f)
		{
		}

		public void StartAnimation(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName previousPageName, bool isFadeOut = false, float delay = 0f)
		{
		}

		private IEnumerator ExcuteAnimation(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName prevPageName, bool isFadeOut, float delay)
		{
			return null;
		}

		public void ResetCharaTalkButton(bool defaultValue = true)
		{
		}

		public void ResetEventTopMask()
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public void StartQuestPrepareMoveAnimation()
		{
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

		public Tweener SetScreenTransVisible(bool visible)
		{
			return null;
		}

		public bool IsOldIphone()
		{
			return default(bool);
		}
	}
}
