using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cute.Cri;
using Cute.Http;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestScene : SceneBase, ICustomMessage
	{
		private enum StateType
		{
			Initialized,
			CreatingRoom,
			Matching
		}

		private static bool isShowEventInfo;

		private static bool isGoingEventQuestScene;

		private EventStatusInfoCtrl _statusInfo;

		[SerializeField]
		private Camera _uiCamera;

		[SerializeField]
		private Camera _flashCamera;

		private readonly int WaitPrevSceneExitFrameNum;

		private EffectObject treasureTimeEffect;

		[SerializeField]
		private Canvas commonUICanvas;

		private UnityAction backButtonSoundAction;

		public EventQuestDetailCanvas questDetailCanvas;

		private SceneNameDefine.PageName firstPageName;

		private bool isAutoGoingEventQuestListPage;

		private bool isCheckStoryReward;

		private int lastQuestStoryIdOnAwake;

		private int lastEventLocationIdOnAwake;

		private const string charaFormalJoined = "playerPref_CharaFormalJoined";

		private const string charaQuit = "playerPref_CharaQuit";

		private const string eventQuestDetailCanvasPath = "Prefabs/OutGame/EventQuest/EventQuestDetailCanvas";

		private bool isFirstStoryRead;

		private bool shownNextPreviewPopup;

		private Task totalDamageRewardRequestTask;

		private StateType state;

		public static EventQuestScene instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public EventStatusInfoCtrl statusInfo => null;

		public Camera flashCamera => null;

		public Camera uiCamera => null;

		public EventQuestModel eventQuestModel
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

		public Button backButton
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

		public EventQuestCharacterShaderSettings charaShaderSettings
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

		public bool isRecievedTotalDamageReward
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

		public bool isEventEnable => default(bool);

		public static void ClearStaticData()
		{
		}

		private void Awake()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public TabCategory GetDefaultMissionType()
		{
			return default(TabCategory);
		}

		private IEnumerator StartExitAnimationCoroutine()
		{
			return null;
		}

		public void ForceMoveBackButton(bool isIn)
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExitAndInit()
		{
			return null;
		}

		private void LoadEventStatus()
		{
		}

		private void UpdateExchangeInformation()
		{
		}

		public static void GotoEventQuestScene([Optional] Action continueChangingToEventScene)
		{
		}

		public static void RemoveTouchGuardHandler()
		{
		}

		public static void GoToEventQuestSceneErrorHandler(ErrorType errorType, int errorCode)
		{
		}

		private static void RequestRaidEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestRandomEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestBuildEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestClb01EventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestExRushEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestExHunterEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestCombatEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestBattleRoyalEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestEarnEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestCollectEventData(Action continueChangingToEventScene)
		{
		}

		private static void OnGotEventData(Action continueChangingToEventScene)
		{
		}

		public static void RequestEntry()
		{
		}

		public static void RequestRaidEventEntry()
		{
		}

		public static void RequestRandomEventEntry()
		{
		}

		public static void RequestBuildEventEntry()
		{
		}

		public static void RequestClb01EventEntry()
		{
		}

		public static void RequestExRushEventEntry()
		{
		}

		public static void RequestExHunterEventEntry()
		{
		}

		public static void RequestCollectEventEntry()
		{
		}

		public static void RequestCombatEventEntry()
		{
		}

		public static void RequestBattleRoyalEventEntry()
		{
		}

		public static void RequestEarnEventEntry()
		{
		}

		private static bool GotoPrologue()
		{
			return default(bool);
		}

		private static bool IsEntryRequestNeeded()
		{
			return default(bool);
		}

		private static bool ShouldGotoPrologue()
		{
			return default(bool);
		}

		public static bool IsGotoPrologue()
		{
			return default(bool);
		}

		public static bool IsGotoEpilogue()
		{
			return default(bool);
		}

		public bool ShowBeginningPopup(Action onClosePU)
		{
			return default(bool);
		}

		private bool ShowEventInfoPopup(Action onClosePU)
		{
			return default(bool);
		}

		public void ShowNextEventPreview(Action onDone)
		{
		}

		public bool ShowAnnouncementPopup(Action onClosePU)
		{
			return default(bool);
		}

		private bool CheckChara()
		{
			return default(bool);
		}

		public void CheckStroyReward(Action onClose, bool isFirstTime = false)
		{
		}

		public void ShowEventStoryRewardPopup(UnityAction onDone)
		{
		}

		public void SetEventStatusInfo()
		{
		}

		public EventRewardConfirmPopup ShowReceiveRewardPopup(bool isAllReward, GiftType giftType = GiftType.NONE, int itemId = 0)
		{
			return null;
		}

		private Task RequestTotalDamageHistoryData()
		{
			return null;
		}

		public IEnumerator ShowTotalDamageReceiveRewardPopup()
		{
			return null;
		}

		public IEnumerator ShowTreasureTimeEffect(bool toShow)
		{
			return null;
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void SetCharacterShader()
		{
		}

		public void BindBackButtonCallback(UnityAction callback, bool showExitAnimationWhenClick)
		{
		}

		public static void CheckForBeforeTransition(int EventId, UnityAction completeCallback, [Optional] UnityAction cancelledCallback)
		{
		}

		private static void DownLoadStoryData(int storyId, UnityAction completeCallback, UnityAction cancelledCallback)
		{
		}

		public static void RequestEventData(int eventId, Action successCallback, Action<ErrorType, int> onError, bool forceRequest = true)
		{
		}

		public static AudioPlayback PlayBgm(int eventId)
		{
			return default(AudioPlayback);
		}

		public override void OnPresentReceived()
		{
		}

		private void Update()
		{
		}

		public override void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1, AnimationUICanvas.AnimationPattern enterPattern = AnimationUICanvas.AnimationPattern.Pattern_1, [Optional] Action<PageBase> onLoaded, [Optional] object data, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true)
		{
		}

		private void ChangePageToQuestSelectSupport(Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage)
		{
		}

		private void ChangePageToQuestDetailList(Transform parentTransform, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, object data, bool allowSamePageReload, bool delayEnterAnimation, bool deactivateLastPage)
		{
		}

		private void OnQuestDetailListPageActive(EventQuestDetailListPage questDetailListPage, Clb01EventLocationElement location)
		{
		}

		private void OnCombatQuestDetailListPageActive(EventQuestDetailListPage questDetailListPage, CombatEventLocationElement location)
		{
		}

		private void OnSupportPageActive()
		{
		}

		private void OnSupportPageStartAnimation(bool isFromQuestPrepare)
		{
		}

		private void OnSupportPageExitAnimation()
		{
		}

		private void OnSupportPageEnterAnimationEnded()
		{
		}

		public void OnSupportPageBackButtonPressed()
		{
		}

		public void HideScreenshotBackImage()
		{
		}

		public bool IsAutoTransitionToQuestSelect()
		{
			return default(bool);
		}

		public void SetAutoTransitionDoneToQuestSelect()
		{
		}

		public bool IsCheckStoryReward()
		{
			return default(bool);
		}

		public void SetCheckStoryReward()
		{
		}

		public Clb01EventLocationElement GetAutoTransitionLocation()
		{
			return null;
		}

		private static Clb01EventLocationElement GetLocationFromStoryId(int eventId, int storyId)
		{
			return null;
		}

		private static Clb01EventLocationElement GetLocationFromReleaseQuestStoryId(int eventId, int storyId)
		{
			return null;
		}

		private static Clb01EventLocationElement GetLocation(int eventId, int locationId)
		{
			return null;
		}

		public CombatEventLocationElement GetAutoTransitionCombatLocation()
		{
			return null;
		}

		private void CheckBefreEventEndReward()
		{
		}
	}
}
