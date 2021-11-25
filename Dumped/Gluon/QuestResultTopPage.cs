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
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultTopPage : MonoBehaviour
	{
		public struct FlPlaneSortingInfo
		{
			public string targetNamePhrase;

			public int sortingOffset;

			public FlPlaneSortingInfo(string name, int offset)
			{
			}
		}

		private enum EnumStete
		{
			InitWait,
			Prepare,
			GoQuest,
			Exit
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
		public Text uiQuestChapterText;

		public Text uiQuestTitleText;

		public Text uiQuestTitleEventText;

		public Image uiQuestLevelImage;

		[SerializeField]
		[Header("Mission")]
		public Text[] uiMissionText;

		public Image[] uiMissionOnImage;

		public Image[] uiMissionOffImage;

		public Transform[] uiMissionBase;

		[SerializeField]
		[Header("Exp")]
		public Text uiExpText;

		public Text uiCharaExpText;

		[SerializeField]
		[Header("ExpBars")]
		public QRExpBar playerExpBar;

		public Text playerNewLevel;

		public Text playerNewLevelValue;

		public QRExpBar[] charaExpBarList;

		public CommonIcon[] charaIconList;

		public Transform[] charaListSortDecoTrans;

		private CommonIconListSortDeco[] charaListSortDeco;

		[SerializeField]
		[Header("Face")]
		public GameObject[] uiCharaFaceImage;

		[SerializeField]
		[Header("SaveClearParty")]
		public Button uiCheckMarkButton;

		public Image uiCheckMarkImage;

		[SerializeField]
		[Header("TreasureLine")]
		public Text uiManaText;

		public Text uiManaRateText;

		public Text uiRupiText;

		public Text uiRupiRateText;

		public Text uiDropRateText;

		[SerializeField]
		[Header("Button")]
		public Button uiFullCanvasButton;

		[SerializeField]
		[Header("Treasure")]
		public GameObject treasureTitleLine;

		public GameObject treasureListParent;

		[SerializeField]
		[Header("Reborn")]
		public GameObject rebornSection;

		public GameObject rebornListParent;

		public GameObject rebornHeartGO;

		[SerializeField]
		[Header("Animation")]
		public Button tapToNextButton;

		public Transform[] titlePartTrans;

		public Transform[] missionPartTrans;

		public Transform[] playerExpPartTrans;

		public Transform[] characterPartTrans;

		public Transform[] treasurePartTrans;

		public Transform[] buttonPartTrans;

		public Transform battleRoyalTopTrans;

		public Transform battleRoyalCenterTrans;

		[SerializeField]
		private Transform[] bestTotalDamageTransList;

		[SerializeField]
		[Header("ScrollRect")]
		public ScrollRect treasureScrollRect;

		[SerializeField]
		[Header("ClearTime")]
		public GameObject newClearTimeIcon;

		public Text clearTimeText;

		private const int clearTimeMax = 5999;

		[SerializeField]
		[Header("Multi")]
		private Transform multiRebattlePageNode;

		private const string multiRebattlePagePath = "Prefabs/OutGame/QuestResult/QRMultiRebattlePage";

		private QuestResultMultiRebattlePage multiRebattlePage;

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
		private float popupDelayTime;

		[SerializeField]
		private float dropItemAppearTime;

		[SerializeField]
		private float battleRoyalFlashWaitTime;

		[SerializeField]
		private Sprite[] difficultyAtlasImage;

		[SerializeField]
		private GameObject clearPartyObj;

		[SerializeField]
		private QuestResultLvUpEffect levupEffect;

		[SerializeField]
		[Header("RankingParent")]
		private Transform rankingParent;

		[SerializeField]
		[Header("TotalDamageEvent")]
		private QuestResultRankingCell rankingCell;

		private QuestResultRankingPage questResultRankingPage;

		[SerializeField]
		private GameObject tresureNothingLine;

		public bool bPlayerExpBarFinished;

		private int iconListSectionCount;

		private int useCharaCount;

		private List<QRTreasureIcon> iconAnimationList;

		private Coroutine waitForTimerCoroutine;

		private bool clearPartyFlag;

		private bool bSkipButtonClicked;

		private bool bWaitTimerEnd;

		private bool isDialogClosed;

		private bool rareStopFlag;

		private bool isEventFlag;

		private bool raidFriendshipEffectFlag;

		private bool randomEventMedalEffectFlag;

		private bool buildEventEffectFlag;

		private bool earnEventEffectFlag;

		private bool isOnTopPageDone;

		private bool isOnPressNext;

		private bool isTopPageOut;

		private bool treasureEnd;

		private const string seRising = "SE_OUT_COMMON_0010";

		private const string seMissionGet = "SE_OUT_COMMON_0021";

		private const string sePlayerRankUp = "SE_OUT_COMMON_0022";

		private const string seCharaLevelUp = "SE_OUT_COMMON_0024";

		private const string seRupee = "SE_OUT_COMMON_0025";

		private const string seItemSwitch = "SE_OUT_COMMON_0026";

		private const string seCharaSlideIn = "SE_OUT_COMMON_0033";

		private const string seCharaSlideOut = "SE_OUT_COMMON_0034";

		private const string seClear = "SE_OUT_COMMON_0054";

		private const float time = 0.5f;

		private const int initialValue = 99999999;

		private DateTime rebattleStartTime;

		private GameObject eventCharaPrefab;

		private GameObject randomEventResultPrefab;

		private GameObject buildEventResultPrefab;

		public const float waitTime = 71f / (678f * (float)Math.PI);

		private const float HeaderAnimationOutTime = 19f / 30f;

		private FlashPlayer flashGaugeBurst;

		private FlashPlayer[] flashCharaExplvup;

		private FlashPlayer[] flashMission;

		private FlashPlayer headerChara;

		private FlRoot battleRoyalRankFlash;

		private ButtonSound buttonSound;

		private float slideOutDistance;

		private Vector3[] titleSlideVector;

		public float missionFlashDelay;

		private QuestSkipTicketConfirmPopup questSkipTicketConfirmPopup;

		private QuestResultRetryPopup questResultRetryPopup;

		private QuestResultRetryConfirmPopup questResultRetryConfirmPopup;

		private EventQuestConditionPopup conditionPopup;

		private QuestSkipTicketClearFlashPopup clearFlashPopup;

		public PointerEventHandler retryButton;

		public PointerEventHandler nextButton;

		private float tresureBaseHegiht;

		private const float outAnimRatio = 1f;

		private float headerCharacterOutTime;

		[SerializeField]
		[Header("AnimationFrame")]
		public AnimationData[] titleAnimationData;

		public AnimationData[] missionAnimationData;

		public AnimationData[] rebornAnimationData;

		public AnimationData[] playerAnimationData;

		public AnimationData[] characterAnimationData;

		public AnimationData[] tresureAnimationData;

		public AnimationData[] buttonAnimationData;

		public AnimationData battleRoyalAnimationData;

		public AnimationData battleRoyalCenterAnimationData;

		[SerializeField]
		private AnimationData bestTotalDamageTopAnimationData;

		public UIAnimationPublisher buttonAnimationPublisher;

		private Vector2 defaultheaderCharaPosition;

		private UnityEvent backKeyEvent;

		private int[] maxLevel;

		private Vector3[] defaultTitlePos;

		private Vector3[] defaultMissionPos;

		private Vector3[] defaultExpPos;

		private Vector3[] defaultCharaPos;

		private Vector3[] defaultTreasurePos;

		private Vector3[] defaultbuttonPos;

		private Vector3 defaultRebornPos;

		private Vector3 defaultBattleRoyalTopPos;

		private Vector3 defaultBattleRoyalCenterPos;

		private Vector3[] defaultBestTotalDamagePosList;

		private QREventCharaResult eventChara;

		private QRRandomEventReward randomEventResult;

		private QRBuildEventResult buildEventResult;

		private QuestResultEarnEventBonus questResultEarnEventBonus;

		private QuestResultRanking ranking;

		private QuestResultRankingEffect rankingEffect;

		private const float difficultTextHeight = 30f;

		private const float titleTextHeight = 50f;

		private readonly Vector3 buttonSlideVector;

		private const int nextButtonIndex = 1;

		private const int retryButtonIndex = 0;

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

		public bool isTopPageSkip
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool canRetry
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

		private void OnDestroy()
		{
		}

		public (bool, bool) CheckStageFlags()
		{
			return default((bool, bool));
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

		private bool ShouldRaiseRaidBoostGetPU()
		{
			return default(bool);
		}

		public void OnPressNext()
		{
		}

		private void RequestSaveClearParty()
		{
		}

		private void RequestSaveClearPartySingle()
		{
		}

		private void ApiOnSuccess(QuestSetQuestClearPartyResponse res)
		{
		}

		private void RequestSaveClearPartyMulti()
		{
		}

		private void ApiOnSuccess(QuestSetQuestClearPartyMultiResponse res)
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

		private void OnSkipTicketContinues()
		{
		}

		private Sequence SetRebornHeart()
		{
			return null;
		}

		private void OnRebattlePageDone()
		{
		}

		public void CreateFirstClearCharaDragonPopup(QuestResultModel.FirstClearModel.FirstClearItemInfo info, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateFirstClearItemPopup([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateBonusItemPopup([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateBattleRoyalCycleRewardPopup([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		private IEnumerator CreateTimeAttackRankingTierRewardPopup([Optional] Action onCloseCallback)
		{
			return null;
		}

		public void CreateCarryBonusPopup([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		public void CreateEventCharaResultPopup()
		{
		}

		public void InitByData()
		{
		}

		private bool CanRetry()
		{
			return default(bool);
		}

		private void CreateDropItem()
		{
		}

		private void Start()
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		private void SetButtonSoundAction(PointerEventHandler eventHandler)
		{
		}

		private void SetUpTreasurePanel()
		{
		}

		private void AddTreasureIconOneByOne(QuestResultModel.TopPageModel.RewardItemInfo item, float animationDelay, float animationDelayStep, Transform parentTransform, int row)
		{
		}

		public void HeaderFlashVisible()
		{
		}

		public void HeaderFlashInvisible()
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

		private bool IsClearPartyCheckEnable(int selectQuestId)
		{
			return default(bool);
		}

		private IEnumerator DoQuestResultAnimation()
		{
			return null;
		}

		private IEnumerator IconStartAnimation(List<QRTreasureIcon> list)
		{
			return null;
		}

		private bool IsNextQuestExtraBattle(int curQuestId, out QuestEventMenuElement eventMenuElement)
		{
			return default(bool);
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

		private void CheckRandomEventReward(QuestResultModel.TopPageModel model)
		{
		}

		private void CreateBuildEventReward(QuestResultModel.TopPageModel model)
		{
		}

		private void CreateEarnEventReward(QuestResultModel.TopPageModel model)
		{
		}

		private void CreateDuplicateConfirmPopup(string title, string text)
		{
		}

		private Sequence DoPartEnterAnimationMission()
		{
			return null;
		}

		private void FlashMissionPlay(int index)
		{
		}

		private void SetFlashMissionCallback(int index, Action callback, FlMotionActionTypes type = FlMotionActionTypes.End)
		{
		}

		private void DisableMission(int no)
		{
		}

		private void SetClearMission(int index, QuestResultModel.TopPageModel.MissionClearInfo info)
		{
		}

		private void OnFinishMissionFlash(int no)
		{
		}

		private void DoCharaLevelUpAnimation(int index, int level)
		{
		}

		public void OnPlayerLevelUpDone()
		{
		}

		public void OnPlayerLevelup(int level)
		{
		}

		private void LevupAnimation(int level)
		{
		}

		private Sequence DoPageOutAnimation(bool includingTitleAndButton, bool isMovingToEventPage)
		{
			return null;
		}

		private void InitQuestResultTop()
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

		public void OnRetryButton()
		{
		}

		private void OnRandomRetry()
		{
		}

		public void CreateRetryConfirmPopup()
		{
		}

		public void OnRetryConfirmPopupOk()
		{
		}

		public void OnRetryConfirmPopupCancel()
		{
		}

		public void CreateSkipTicketPopup()
		{
		}

		public void OnSkipConfirmPopupOk()
		{
		}

		public void SkipTicektApi(int playCount)
		{
		}

		private void onSkipSuccess()
		{
		}

		private void OnSkipTicket()
		{
		}

		private void onSkipError()
		{
		}

		private void CloseEventQuestConditionPopup()
		{
		}

		public void OnSkipConfirmPopupCancel()
		{
		}

		public static IEnumerator GoToIngame()
		{
			return null;
		}

		private static void CheckDisconnectType()
		{
		}

		public static void PopupMatchingError([Optional] Action exitSceneAction)
		{
		}

		public void SetNextAndRetryActive(bool enable)
		{
		}

		public void SetNextAndRetryActive(bool enableNext, bool enableRetry)
		{
		}

		public void ResetRetryButton()
		{
		}

		public void ResetRestryButtonNotFlag()
		{
		}

		public void SetNextButtonCallback(UnityAction callback)
		{
		}

		public void SetRetryButtonCallback(UnityAction callback)
		{
		}

		public void OnBeforeLeaving()
		{
		}

		private static void Disconnect()
		{
		}

		private IEnumerator UpdateReBattleCountDown()
		{
			return null;
		}

		private bool IsNomalMultiQuest()
		{
			return default(bool);
		}
	}
}
