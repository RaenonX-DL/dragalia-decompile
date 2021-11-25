using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using Cute.Http;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallResultTopPage : MonoBehaviour
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
		[Header("Title")]
		public Text uiQuestTitleEventText;

		[SerializeField]
		[Header("Exp")]
		public Text uiExpText;

		public Text uiCharaExpText;

		[SerializeField]
		[Header("ExpBars")]
		public QRExpBar playerExpBar;

		public QRExpBar[] charaExpBarList;

		public CommonIcon[] charaIconList;

		public Transform[] charaListSortDecoTrans;

		[SerializeField]
		[Header("Face")]
		public GameObject[] uiCharaFaceImage;

		[SerializeField]
		[Header("SaveClearParty")]
		public Image uiCheckMarkImage;

		[SerializeField]
		[Header("TreasureLine")]
		public Text uiManaText;

		public Text uiRupiText;

		[SerializeField]
		[Header("Button")]
		public Button uiFullCanvasButton;

		[SerializeField]
		[Header("Treasure")]
		public GameObject treasureTitleLine;

		public GameObject treasureListParent;

		[SerializeField]
		[Header("Animation")]
		public Transform[] titlePartTrans;

		public Transform[] playerExpPartTrans;

		public Transform[] characterPartTrans;

		public Transform[] treasurePartTrans;

		public Transform[] buttonPartTrans;

		[SerializeField]
		[Header("ScrollRect")]
		public ScrollRect treasureScrollRect;

		[SerializeField]
		public CanvasGroup descriptionNodeCanvasGroup;

		[SerializeField]
		public Text descriptionText;

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

		[SerializeField]
		public float descriptionNodeCanvasGroupFadeInTime;

		[SerializeField]
		public float descriptionNodeCanvasGroupFadeOutTime;

		[SerializeField]
		private Vector3 iconScale;

		[SerializeField]
		private float animationWaitTime;

		[SerializeField]
		private float popupDelayTime;

		[SerializeField]
		private float dropItemAppearTime;

		[SerializeField]
		private GameObject clearPartyObj;

		[SerializeField]
		private GameObject tresureNothingLine;

		[SerializeField]
		[Header("Button")]
		public PointerEventHandler retryButton;

		public PointerEventHandler nextButton;

		public UIAnimationPublisher buttonAnimationPublisher;

		[SerializeField]
		[Header("AnimationFrame")]
		public AnimationData[] titleAnimationData;

		public AnimationData[] playerAnimationData;

		public AnimationData[] characterAnimationData;

		public AnimationData[] tresureAnimationData;

		public AnimationData[] buttonAnimationData;

		public bool bPlayerExpBarFinished;

		private float preservedDotweenTimeScale;

		private CommonIconListSortDeco[] charaListSortDeco;

		private int iconListSectionCount;

		private List<QRTreasureIcon> iconAnimationList;

		private Coroutine waitForTimerCoroutine;

		private bool clearPartyFlag;

		private bool bSkipButtonClicked;

		private bool bWaitTimerEnd;

		private bool isDialogClosed;

		private bool rareStopFlag;

		private bool isOnTopPageDone;

		private bool isOnPressNext;

		private bool isTopPageOut;

		private bool treasureEnd;

		private ButtonSound buttonSound;

		private float slideOutDistance;

		private Vector3[] titleSlideVector;

		private float tresureBaseHegiht;

		private int[] maxLevel;

		private Vector3[] defaultTitlePos;

		private Vector3[] defaultMissionPos;

		private Vector3[] defaultExpPos;

		private Vector3[] defaultCharaPos;

		private Vector3[] defaultTreasurePos;

		private Vector3[] defaultbuttonPos;

		private Sequence bottomButtonAnimSeq;

		private FlRoot headerFlash;

		private FlRoot nextItemFlash;

		private FlRoot getItemFlash;

		private FlRoot effectFlash;

		private const float outAnimRatio = 0.6f;

		private const float headerCharacterOutTime = 0.18f;

		private const float waitTime = 71f / (678f * (float)Math.PI);

		private const float time = 0.5f;

		private const string seRising = "SE_OUT_COMMON_0010";

		private const string seRupee = "SE_OUT_COMMON_0025";

		private const string seCharaSlideIn = "SE_OUT_COMMON_0033";

		private const string seCharaSlideOut = "SE_OUT_COMMON_0034";

		private const float difficultTextHeight = 30f;

		private const float titleTextHeight = 50f;

		private const int nextButtonIndex = 1;

		private const int retryButtonIndex = 0;

		private readonly Vector3 buttonSlideVector;

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

		private void Start()
		{
		}

		public void InitByData()
		{
		}

		private IEnumerator DoQuestResultAnimation()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void OnPressClearParty()
		{
		}

		public void SlideNextAndRetryButtons(bool isOut, bool withNextButton, bool withRetryButton)
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

		public void OnPressSkip()
		{
		}

		public void OnPressNext()
		{
		}

		private void RequestSaveClearParty()
		{
		}

		private void ApiOnSuccess(WallSetWallClearPartyResponse res)
		{
		}

		private void ApiOnError(ErrorType errorType, int resultCode)
		{
		}

		public void MoveOut(Transform trans, float distance, Action onComplete)
		{
		}

		private void OnQuestResultDone()
		{
		}

		public void CreateFirstClearCharaDragonPopup(QuestResultModel.FirstClearModel.FirstClearItemInfo info, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateFirstClearItemPopup(List<QuestResultModel.FirstClearModel.FirstClearItemInfo> info, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateBonusItemPopup([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		private void CreateDropItem()
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		private void SetButtonSoundAction(PointerEventHandler eventHandler)
		{
		}

		private void AddTreasureIcon(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform)
		{
		}

		private void AddTreasureIconOneByOne(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform)
		{
		}

		public bool SkipChecker()
		{
			return default(bool);
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

		private IEnumerator IconStartAnimation(List<QRTreasureIcon> list)
		{
			return null;
		}

		private void OnExpPlayerBarFinish(AudioPlayback apb)
		{
		}

		private IEnumerator OnExpPlayerBarFinishCorutine(AudioPlayback apb)
		{
			return null;
		}

		private void NextRarePopupFlagOff()
		{
		}

		private void CreateDuplicateConfirmPopup(string title, string text)
		{
		}

		private Sequence DoPageOutAnimation(bool includingTitleAndButton, bool isMovingToEventPage, [Optional] Action action)
		{
			return null;
		}

		private void SetMotionPlayIn()
		{
		}

		private void SetMotionPlayOut(Action action)
		{
		}

		public void SetMotionPlaySkip()
		{
		}

		public void NextButtonSlideIn()
		{
		}

		private void Visible(Transform trans, float alpha)
		{
		}

		private FlashPlayer SetupFlash(string path, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true, [Optional] Canvas targetCanvas, int canvasSortingOrder = 0, bool isAddPlaneCountToCanvasOrder = false)
		{
			return null;
		}

		private FlashPlayer SetupFlashEachLayer(string path, FlPlaneSortingInfo[] flPlaneSortingInfos, GameObject parentObj, int sortingOrder, Vector3 localPos, bool isAutoDestroy = true)
		{
			return null;
		}

		public void CameraDepth(int depth)
		{
		}

		private int Digit(int num)
		{
			return default(int);
		}

		private int MaxValue(int digit)
		{
			return default(int);
		}

		public void OnNextBattleButton()
		{
		}

		public void OnNextBattleConfirmPopupOk()
		{
		}

		private void GoToIngame()
		{
		}

		public void SetNextButtonCallback(UnityAction callback)
		{
		}

		public void OnBeforeLeaving()
		{
		}

		private void CheckPartyPower(UnityAction onSucceed)
		{
		}
	}
}
