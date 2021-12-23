using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeQuestResultTopPage : MonoBehaviour
	{
		public struct FlPlaneSortingInfo
		{
			public string targetNamePhrase;

			public int sortingOffset;

			public FlPlaneSortingInfo(string name, int offset)
			{
			}
		}

		[Serializable]
		public struct AnimationData
		{
			public float duration;

			public Ease easing;

			public float delay;

			public float returnX;

			public float returnFrame;

			public Ease returnEasing;
		}

		[SerializeField]
		[Header("ClearTime")]
		private GameObject clearTimePanel;

		[SerializeField]
		private Text clearTimeText;

		[SerializeField]
		private VerticalLayoutGroup clearTimeTitleLayoutGroup;

		[SerializeField]
		private LocalizeTextLayoutAdjuster clearTimeTitleTextLayoutAdjuster;

		[SerializeField]
		[Header("ExpBars")]
		private Text uiExpText;

		[SerializeField]
		private QRExpBar playerExpBar;

		[SerializeField]
		private Text playerNewLevel;

		[SerializeField]
		private Text playerNewLevelValue;

		[SerializeField]
		[Header("DmodeInfo")]
		private Transform floorValuePanelTransform;

		[SerializeField]
		private GameObject floorValueOriginalImage;

		[SerializeField]
		private GameObject floorUnitPanel;

		[SerializeField]
		private GameObject scoreInfoPanel;

		[SerializeField]
		private Transform scoreValuePanelTransform;

		[SerializeField]
		private GameObject scoreValueOriginalImage;

		[SerializeField]
		private GameObject scoreCommaOriginalImageObject;

		[SerializeField]
		private GameObject newIconRoot;

		[SerializeField]
		[Header("Button")]
		private Button uiFullCanvasButton;

		[SerializeField]
		[Header("Treasure")]
		private GameObject treasureTitleLine;

		[SerializeField]
		private GameObject treasureListParent;

		[SerializeField]
		private Text receivedOverLimitAnnounceText;

		[SerializeField]
		private GameObject tresureNothingLine;

		[SerializeField]
		[Header("Other")]
		private Transform flexiblePanel;

		[SerializeField]
		[Header("Animation")]
		private Button tapToNextButton;

		[SerializeField]
		private Transform resultTextPanelPartTrans;

		[SerializeField]
		private Transform[] playerExpPartTrans;

		[SerializeField]
		private Transform dmodeInfoPartTrans;

		[SerializeField]
		private Transform[] treasurePartTrans;

		[SerializeField]
		private Transform[] buttonPartTrans;

		[SerializeField]
		[Header("ScrollRect")]
		private ScrollRect treasureScrollRect;

		[SerializeField]
		[Header("å\u0090\u0084é\u0083\u00a8ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³é\u0080\u009fåº¦èª¿æ\u0095\u00b4å\u0080¤")]
		private float animationWaitSpeedModulus;

		[SerializeField]
		private float animationSlideInSpeedModulus;

		[SerializeField]
		private float animationDelay;

		[SerializeField]
		private float iconAnimationDelayTime;

		[SerializeField]
		private float viewRowScrollDuration;

		private float preservedDotweenTimeScale;

		[SerializeField]
		private Vector3 iconScale;

		[SerializeField]
		private float animationWaitTime;

		[SerializeField]
		private float dropItemAppearTime;

		[SerializeField]
		private QuestResultLvUpEffect levupEffect;

		[SerializeField]
		[Header("Dmode NumberImages")]
		private Sprite[] numberImageList;

		private int iconListSectionCount;

		private List<QRTreasureIcon> iconAnimationList;

		private Coroutine waitForTimerCoroutine;

		private bool bWaitTimerEnd;

		private bool rareStopFlag;

		private bool isOnTopPageDone;

		private bool isOnPressNext;

		private bool isTopPageOut;

		private bool treasureEnd;

		private const string seRising = "SE_OUT_COMMON_0010";

		private const string sePlayerRankUp = "SE_OUT_COMMON_0022";

		private const string seRupee = "SE_OUT_COMMON_0025";

		private const string seItemSwitch = "SE_OUT_COMMON_0026";

		private const string seCharaSlideIn = "SE_OUT_COMMON_0033";

		private const string seCharaSlideOut = "SE_OUT_COMMON_0034";

		private const string seClear = "SE_OUT_COMMON_0054";

		private static readonly int clearTimeMax;

		private const float waitTime = 71f / (678f * (float)Math.PI);

		private const float HeaderAnimationOutTime = 19f / 30f;

		private FlashPlayer flashGaugeBurst;

		private FlashPlayer headerChara;

		private ButtonSound buttonSound;

		private float slideOutDistance;

		[SerializeField]
		private PointerEventHandler nextButton;

		private float tresureBaseHegiht;

		private const float outAnimRatio = 1f;

		private float headerCharacterOutTime;

		[SerializeField]
		[Header("AnimationFrame")]
		private AnimationData resultTextPanelAnimationData;

		[SerializeField]
		private AnimationData[] playerAnimationData;

		[SerializeField]
		private AnimationData[] tresureAnimationData;

		[SerializeField]
		private AnimationData[] buttonAnimationData;

		[SerializeField]
		private AnimationData dmodeInfoAnimationData;

		[SerializeField]
		private UIAnimationPublisher buttonAnimationPublisher;

		private static readonly Vector2 defaultheaderCharaPosition;

		private UnityEvent backKeyEvent;

		private Vector3 defaultResultTextPanelPos;

		private Vector3[] defaultExpPos;

		private Vector3 defaultDmodeInfoPos;

		private Vector3[] defaultTreasurePos;

		private Vector3[] defaultbuttonPos;

		private Vector3 defaultFlexiblePanelPos;

		private readonly Vector3 buttonSlideVector;

		private static readonly int flashNewEffectLoopMotionIndex;

		private static readonly string flashNewIconPlayMotionKey;

		private Sequence bottomButtonAnimSeq;

		public QuestResultScene sceneObj
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

		public bool bPlayerExpBarFinished
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

		public bool bSkipButtonClicked
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void InitByData()
		{
		}

		private IEnumerator PlayQuestResultAnimation()
		{
			return null;
		}

		private IEnumerator IconStartAnimation(List<QRTreasureIcon> list)
		{
			return null;
		}

		public void OnPlayerLevelup(int level)
		{
		}

		public void OnPlayerLevelUpDone()
		{
		}

		private IEnumerator OnExpPlayerBarFinishCorutine(AudioPlayback apb)
		{
			return null;
		}

		private void LevelupAnimation(int level)
		{
		}

		public void SkipAnimation()
		{
		}

		private Sequence DoPageOutAnimation(bool includingTitleAndButton, bool isMovingToEventPage)
		{
			return null;
		}

		public void SetFlashCameraDepth(int depth)
		{
		}

		private FlashPlayer SetupFlashEachLayer(string path, FlPlaneSortingInfo[] flPlaneSortingInfos, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true)
		{
			return null;
		}

		private FlashPlayer SetupFlash(string path, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true, [Optional] Canvas targetCanvas, int canvasSortingOrder = 0, bool isAddPlaneCountToCanvasOrder = false)
		{
			return null;
		}

		private void SetUpTreasureIcon(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform, int row)
		{
		}

		private void CreateDropItem()
		{
		}

		public void ScrollToItem(Transform target)
		{
		}

		public void ScrollToItem(Transform baseTrans, Transform targetTrans, float waitDuration, float scrollDuration)
		{
		}

		public void ScrollToItem(Vector3 baseAnchoredPosition, Vector3 targetAnchoredPosition, float waitDuration, float scrollDuration)
		{
		}

		private IEnumerator WaitForTimerCoroutine(float waitTime)
		{
			return null;
		}

		private void StartWaitTimerForSkip(float waitTime)
		{
		}

		private void StopWaitTimerForSkip()
		{
		}

		private Sequence ButtonSlideIn(Transform buttonTrans, AnimationData buttonAnimationData, Vector3 defaultButtonPos)
		{
			return null;
		}

		private void ButtonSlideOut(Transform buttonTrans, Vector3 defaultButtonPos, float delay)
		{
		}

		private void InitButton(Transform buttonTrans, Vector3 defaultButtonPos)
		{
		}

		public void SetNextButtonCallback(UnityAction callback)
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		private void SetButtonSoundAction(PointerEventHandler eventHandler)
		{
		}

		public void OnPressSkipAnimationPanel()
		{
		}

		public void SetActiveHeaderFlashChara(bool isActive)
		{
		}

		private void ChangeUIAlpha(Transform trans, float alpha)
		{
		}

		private void SetUpNumberImagePanel(int value, Transform parentPanel, GameObject originalImage, [Optional] GameObject commaOriginalObject)
		{
		}

		public void OnPressNext()
		{
		}

		private void OnQuestResultDone()
		{
		}

		public void OnBeforeLeaving()
		{
		}
	}
}
