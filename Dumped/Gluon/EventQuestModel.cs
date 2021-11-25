using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestModel
	{
		public enum TreasureTimeType
		{
			None,
			Treasure,
			Box,
			LuckyArea
		}

		public enum RaidEventSubType
		{
			Normal = 1,
			BossBattle,
			RaidBattle,
			ExtraRaidBattle,
			HellRaidBattle,
			UltimateRaidBattle,
			Arena,
			Challenge
		}

		public enum BuildEventSubType
		{
			Normal = 1,
			Daily,
			BossBattle,
			ExtraBossBattle,
			Challenge,
			HellBattle,
			Ordeal
		}

		public enum EarnEventSubType
		{
			Normal = 1,
			RepelQuest,
			TrialQuest,
			RewardQuest
		}

		public enum RewardStatusType
		{
			None,
			Received,
			CanReceive,
			CannotReceive
		}

		public enum RaidCharaTalkCategory0
		{
			Top = 1,
			Result,
			HintMessage,
			QuestDescription,
			ExBattleShowUp
		}

		public enum RaidCharaTalkCategory1
		{
			FriendShip = 1,
			Reward,
			End,
			BeforeJoin
		}

		public enum RaidResultCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End,
			BeforeJoin
		}

		public enum Clb01CharaTalkCategory0
		{
			Top = 1,
			Result,
			HintMessage,
			QuestDescription
		}

		public enum Clb01CharaTalkCategory1
		{
			FriendShip = 1,
			Reward,
			End,
			BeforeJoin
		}

		public enum RaidResultCharaTalkQuestDescriptionCategory1
		{
			BoxBattle = 1,
			RaidBattle,
			ExtraRaidBattle,
			HellRaidBattle,
			UltimateRaidBattle,
			Arena,
			Charange
		}

		public enum Clb01ResultCharaTalkHintMessageCategory1
		{
			BeforeJoin = 1,
			FriendShip,
			End,
			ReadStory
		}

		public enum MazeCharaTalkCategory0
		{
			Top_EventValid = 1,
			Top_EventInvalid,
			Result_Before,
			Result_After
		}

		public enum MazeTopCharaTalkCategory1
		{
			TreasureTime = 1,
			CanChangeSSRWeapon,
			SSRWeapon,
			PickUpReward,
			CanChange,
			Metal
		}

		public enum MazeResultCharaTalkCategory1
		{
			HasReward = 1,
			PickUpReward,
			NoNextReward
		}

		public enum BuildCharaTalkCategory1
		{
			ChangeChara,
			DailyBattle,
			ExBossBattle,
			ChallengeBattle,
			NotBuilt_Story,
			NotBuilt_TargetMaterialNum,
			NotBuilt_MaterialFull,
			RepeatPlaying,
			Completed_GotoExchage,
			Normal,
			End
		}

		public enum BuildCharaTalkCategoryHint
		{
			NoFacility,
			HasFacility
		}

		public enum BuildCharaTalkCategoryQuestDecscription
		{
			BossBattle = 1,
			ExtraBossBattle,
			DailyBattle,
			ChallengeBattle,
			HellBattle,
			Ordeal
		}

		public enum BuildCharaTalkCategory0
		{
			Top = 1,
			Result,
			Hint,
			QuestDecription,
			ExtraBattleShowUp,
			FacilityRewardDescription
		}

		public enum BuildCharaTalkResultCategory1
		{
			Start = 1,
			ShowResult,
			GotReward
		}

		public enum BuildCharaTalkResultTargetType
		{
			None,
			GotReward,
			GotAllReward
		}

		public enum BuildEventStoryType
		{
			BuildStory_1,
			BuildStory_2,
			BuildStory_3,
			BuildStory_4,
			BuildStory_5
		}

		public enum BuildEventBattleType
		{
			Normal = 1,
			Daily,
			Boss,
			ExBoss,
			Challenge
		}

		public enum CollectEventCharaTalkCategory0
		{
			None = 0,
			StoryUnread = 1,
			StoryRead = 2,
			PostEventNoneRead = 3,
			PostEventStoryRead = 4,
			Hint = 8,
			ExchangePeriodWarning = 9
		}

		public enum CollectEventCharaTalkCategory1
		{
			ForceOnlyRead = 99
		}

		public enum CollectEventHintCategory1
		{
			Normal,
			AllStoryRead,
			PostEvent
		}

		public enum EventViewType
		{
			none = 0,
			eight = 20429
		}

		public class CollectProgressMapCell
		{
			public int subId;

			public int questId;

			public int sortOffset;

			public bool released;

			public bool read;

			public List<CollectEventTalkElement> talkElemList;

			public QuestStoryElement storyElem;

			public QuestEventMenuElement menuElem;

			public bool CollectProgress(int questId, bool isEventEnded)
			{
				return default(bool);
			}
		}

		private static int _curEventId;

		private static int _eventPoint;

		private static int _boxSummonSeq;

		private static GiftType _resetItemType;

		private static int _resetItemId;

		private static int _summonItemRemain;

		private static int _summonItemTotal;

		private static int _collectRecivedRewardFromChara;

		private static bool _canResetBoxSummon;

		private static int _multiItemRatio;

		private static SceneNameDefine.PageName _firstPageName;

		private Dictionary<int, List<QuestEventMenuElement>> _raidEventDataDic;

		private Dictionary<int, List<QuestEventMenuElement>> _buildEventDataDic;

		private List<QuestEventMenuElement> _randomEventDataDic;

		private Dictionary<int, List<QuestEventMenuElement>> _collectEventDataDic;

		private Dictionary<int, List<QuestEventMenuElement>> _earnEventDataDic;

		private static QuestEventGroupElement _groupElement;

		private static EventDataElement _eventDataElement;

		public const int raidRewardTabCount = 3;

		public Dictionary<int, List<int>> canReceivedIdsInRaid;

		public List<int> canReceivedIdsInRandom;

		private bool isRaidRewardDataInited;

		private bool isRandomRewardDataInited;

		private EventDataElement curEventData;

		private int maxRetryCount;

		public static QuestCellData curQuestCellData;

		public const string RaidEventBgmName = "BGM_OUT_0006_01";

		public const string RandomEventBgmName = "BGM_OUT_0006_02";

		public const string RandomEventTreaureTimeBgmName = "BGM_OUT_0010_01";

		public const string BuildEventBgmName = "BGM_OUT_0006_02";

		public static bool isExtraBattleEnable;

		private const int eventEndTimeElapsedDayLimit = 30;

		public const int BoxSummon_MaxCount_Item_ShowingUp = 10;

		public int boxSummonItemStartIndex;

		public static int curEventId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static int eventPoint
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static int boxSummonSeq
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static GiftType resetItemType
		{
			get
			{
				return default(GiftType);
			}
			set
			{
			}
		}

		public static int resetItemId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static int summonItemRemain
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static int summonItemTotal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static int collectRecivedRewardFromBaseId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static bool canResetBoxSummon
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static int multiItemRatio
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static SceneNameDefine.PageName firstPageName
		{
			get
			{
				return default(SceneNameDefine.PageName);
			}
			set
			{
			}
		}

		public Dictionary<int, List<QuestEventMenuElement>> raidEventDataDic => null;

		public Dictionary<int, List<QuestEventMenuElement>> buildEventDataDic => null;

		public List<QuestEventMenuElement> randomEventDataDic => null;

		public Dictionary<int, List<QuestEventMenuElement>> collectEventDataDic => null;

		public Dictionary<int, List<QuestEventMenuElement>> earnEventDataDic => null;

		public static QuestEventGroupElement groupElement => null;

		public static EventDataElement eventDataElement => null;

		public static QuestEventType questEventElementEventTypeForNonSpecialEvent => default(QuestEventType);

		public static EventKindType eventKindType => default(EventKindType);

		public static int eventViewType => default(int);

		public int curItemCount => default(int);

		public bool needCheckOverLimit
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

		public bool hasNextItems()
		{
			return default(bool);
		}

		public void ClearEventData()
		{
		}

		public void LoadEventData(QuestEventGroupElement groupElement, EventKindType eventType, bool checkPlayCount = false)
		{
		}

		public int GetEpilogueStroyId()
		{
			return default(int);
		}

		private void AddEventData(Dictionary<int, List<QuestEventMenuElement>> targetDataDic, QuestEventMenuElement sourceElement)
		{
		}

		private void AddEventData(List<QuestEventMenuElement> targetDataList, QuestEventMenuElement sourceElement)
		{
		}

		public static DateTime GetNextScheduleEventStartTime(QuestEventGroupElement groupElement)
		{
			return default(DateTime);
		}

		public static bool IsMemoryEvent()
		{
			return default(bool);
		}

		public static bool IsUseEventCharaAbilityList()
		{
			return default(bool);
		}

		public static DateTime GetNextEventStartTime(DateTime currentTime, QuestScheduleDataWrapper schedule)
		{
			return default(DateTime);
		}

		private static DateTime GetNextStartDateOfScheduleEvent(DateTime currentTime, DateTime startDate, DateTime endDate, List<DayOfWeek> dayOfWeeks)
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndtime(QuestEventGroupElement groupElement)
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestEventGroupElement groupElement)
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestDataElement questDataElement)
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, List<QuestScheduleDataWrapper> scheduleList)
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestScheduleDataWrapper schedule)
		{
			return default(DateTime);
		}

		private static DateTime GetEventEndTimeParticularDay(DateTime currentDate, DateTime startDate, DateTime endDate, List<DayOfWeek> dayOfWeeks)
		{
			return default(DateTime);
		}

		public static string GetRemainDateString(QuestEventGroupElement groupElement)
		{
			return null;
		}

		public static bool IsResetIntervalDailyType(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static string GetRemainTimeText(DateTime now, DateTime endDate, [Optional] string[] templateTexts)
		{
			return null;
		}

		public static string GetTreasureRemainTimeText(float time)
		{
			return null;
		}

		public static TreasureTimeType GetRandomEventTreasureType(int randomEventId)
		{
			return default(TreasureTimeType);
		}

		public static float GetTreasureTimeRemainTime(int eventId, out TreasureTimeType treasureType)
		{
			return default(float);
		}

		public static RewardStatusType CanReceiveRaidReward(EventRewardCellData cellData)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveRaidReward(int rewardId, int eventItemId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveRandomReward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveBuildReward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveCombatReward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveClb01Reward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveBattleRoyalReward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static RewardStatusType CanReceiveEarnReward(int rewardId, int eventItemQuantity)
		{
			return default(RewardStatusType);
		}

		public static bool IsReservedReceivingReward(EventDamageRewardElement reward)
		{
			return default(bool);
		}

		public static int GetRandomEventCurrentMedalNumber(int eventId)
		{
			return default(int);
		}

		public static int GetBuildEventCurrentMetalNumber(int eventId)
		{
			return default(int);
		}

		public static int GetClb01EventCurrentMetalNumber(int eventId)
		{
			return default(int);
		}

		public static void GetRandomEventReward(int eventGroupId, int currentMetalNumber, out MazeEventRewardElement prevReward, ref List<MazeEventRewardElement> nextRewards)
		{
		}

		public static void GetBuildEventReward(int eventGroupId, int currentMetalNumber, out BuildEventRewardElement prevReward, ref List<BuildEventRewardElement> nextRewards)
		{
		}

		public static void GetCycleEventReward(int eventGroupId, int currentPoint, out EventCyclePointRewardElement prevReward, ref List<EventCyclePointRewardElement> nextRewards)
		{
		}

		public static void GetTotalDamageEventReward(int eventGroupId, long currentTotalDamage, out EventDamageRewardElement prevReward, ref List<EventDamageRewardElement> nextRewards)
		{
		}

		public static int GetBuildEventRewardMaxValue(int eventGroupId)
		{
			return default(int);
		}

		public static int GetRandomEventNextRewardValue(int eventId)
		{
			return default(int);
		}

		public static MazeEventRewardElement GetRandomEventNextRewardData(int eventId, int currentMetalNumber)
		{
			return null;
		}

		public static int GetRandomEventNextRewardNum(int eventId, int currentMetalNumber)
		{
			return default(int);
		}

		public void UpdateRaidCanReceivedIds(bool forceUpdate = false)
		{
		}

		public void UpdateRaidCanReceivedIds(int tabIndex)
		{
		}

		public void UpdateRandomCanReceivedIds(bool forceUpdate = false)
		{
		}

		public static int GetEventItemCount(int eventItemID, GiftType eventItemType)
		{
			return default(int);
		}

		public static int GetTopItemCount(int index)
		{
			return default(int);
		}

		public static int GetBattleRoyalEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetEarnEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetRaidEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetRaidEventItemValueByType(RaidEventItemType type)
		{
			return default(int);
		}

		public static void SetRaidEventItemMaterialByType(Image image, RaidEventItemType type)
		{
		}

		public static int GetBuildEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetClb01EventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetCollectEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetAstralEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetCombatEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static int GetEarnEventItemValueByType(EarnEventItemType type)
		{
			return default(int);
		}

		public static bool SetEventImageMaterial(int eventId, Image image, string materialName, bool isLocalized = true, bool shouldSetAutoImage = false)
		{
			return default(bool);
		}

		public static void SetEventImageMaterialAsync(int eventId, Image image, string materialName, bool isLocalized = true, [Optional] Action<Material> onCompleted)
		{
		}

		public static void SetEventCompImageMaterialAsync(int eventId, Image image, string materialName, [Optional] Action<Material> onCompleted)
		{
		}

		public static void SetEventImageMaterialAsync(Image image, string path, [Optional] Action<Material> onCompleted)
		{
		}

		public static string GetCollectHindMessage()
		{
			return null;
		}

		public static string GetRaidHintMessage()
		{
			return null;
		}

		public static string GetClb01HintMessage()
		{
			return null;
		}

		public static string GetRaidQuestDescription(RaidResultCharaTalkQuestDescriptionCategory1 category1)
		{
			return null;
		}

		public static string GetExHunterQuestDescription(RaidResultCharaTalkQuestDescriptionCategory1 category1)
		{
			return null;
		}

		public static string GetRaidResultExtraBattleShowUpDescription()
		{
			return null;
		}

		public static string GetExHunterResultExtraBattleShowUpDescription()
		{
			return null;
		}

		public static RaidEventTalkElement GetRaidCharaTalkResultContent(int eventGroupId)
		{
			return null;
		}

		public static RaidEventTalkElement GetRaidCharaTalkResultPointMaxContent(int eventGroupId)
		{
			return null;
		}

		public static void GetRaidResultCharaTalkMinMaxIndex(RaidEventTalk eventTalk, RaidCharaTalkCategory1 category1, out int minIndex, out int maxIndex, int curPoint)
		{
		}

		public MazeEventTalkElement GetRandomTopCharaTalkContent(bool isTreasureTime, ref int curTalkIndex, ref string preferredTopCharaId)
		{
			return null;
		}

		public static MazeEventTalkElement GetRandomResultCharaTalkContent(int eventGroupId, bool beforeGotAnimation, int currentMetalValue = 0, int gotMetal = 0)
		{
			return null;
		}

		private bool IsBattleCleared(BuildEventBattleType type)
		{
			return default(bool);
		}

		public static bool IsBuildEventCategoryEnable(BuildCharaTalkCategory1 category)
		{
			return default(bool);
		}

		private static bool IsBuildEventBattleType(QuestEventMenuElement qeme, BuildEventBattleType type)
		{
			return default(bool);
		}

		private static BuildEventTalkElement GetBuildEventTalkElement(BuildCharaTalkCategory1 category)
		{
			return null;
		}

		public static bool IsBattleAppeared(BuildEventBattleType type, out QuestEventMenuElement eventMenuElement)
		{
			return default(bool);
		}

		public static bool IsBuildCompleted()
		{
			return default(bool);
		}

		public static bool ExchangeItemExists(out bool isSSR)
		{
			return default(bool);
		}

		public CollectEventTalkElement GetCollectCharaTalkTopContent(bool isFromCharaTouch, ref int curTalkIndex, ref string preferredTopCharaId)
		{
			return null;
		}

		public static void GetBuildCharaTalkMinMaxIndex(BuildEventTalk eventTalk, BuildCharaTalkCategory1 category1, out int minIndex, out int maxIndex, bool isResult)
		{
		}

		public static BuildEventTalkElement GetBuildCharaTalkResultContent(int eventGroupId, BuildCharaTalkResultCategory1 category, BuildCharaTalkResultTargetType targetType)
		{
			return null;
		}

		public static EarnEventTalkElement GetEarnCharaTalkResultContent(int eventGroupId, BuildCharaTalkResultCategory1 category, BuildCharaTalkResultTargetType targetType)
		{
			return null;
		}

		public static string GetBuildHintMessage(bool isFacilityCompleted, string args)
		{
			return null;
		}

		public static string GetBuildQuestDescription(BuildCharaTalkCategoryQuestDecscription category1)
		{
			return null;
		}

		public static string GetBuildTalkTextFromCatogory0(BuildCharaTalkCategory0 category)
		{
			return null;
		}

		public static bool IsMultiPlayerEventQuest(QuestCellData cellData)
		{
			return default(bool);
		}

		public static string GetBuildEventItemName(int eventId, BuildEventItemType itemType)
		{
			return null;
		}

		public static string GetCombatEventItemName(int eventId, CombatEventItemType itemType)
		{
			return null;
		}

		public static string GetCombatEventItemName(int eventId, int itemId)
		{
			return null;
		}

		public static string GetBattleRoyalEventItemName(int eventId, BattleRoyalEventItemType itemType)
		{
			return null;
		}

		public static string GetClb01EventItemName(int eventId, Clb01EventItemType itemType)
		{
			return null;
		}

		public static string GetBuildEventItemName(int eventItemId)
		{
			return null;
		}

		public static string GetEarnEventItemName(int eventItemId, EarnEventItemType itemType)
		{
			return null;
		}

		public static string GetEventItemName(GiftType type, int id)
		{
			return null;
		}

		public static bool IsGotAllBuildEventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true)
		{
			return default(bool);
		}

		public static bool IsGotAllClb01EventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true)
		{
			return default(bool);
		}

		public static bool IsGotAllCombatEventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true)
		{
			return default(bool);
		}

		public static bool IsGotAllEarnEventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true)
		{
			return default(bool);
		}

		public static bool HasEventPointRewardEvent(EventKindType eventKindType)
		{
			return default(bool);
		}

		private static bool IsGotAllEventPointReward(int eventId, int curMedal, int gotMedal = -1, bool exceptGotMedal = true)
		{
			return default(bool);
		}

		public static bool IsGotAllRandomEventReward(int eventId, int gotMedal, bool exceptGotMedal, int curMedal = -1)
		{
			return default(bool);
		}

		public static EventKindType GetEventKindType(int eventGroupId)
		{
			return default(EventKindType);
		}

		public static CollectEventItemElement GetCollectItemTypeByEntityId(int eventId, int entityId)
		{
			return null;
		}

		public static Clb01EventItemElement GetClb01ItemTypeByEntityId(int eventId, int entityId)
		{
			return null;
		}

		public static int GetCollectTotalReleasedStoryCount(int eventId)
		{
			return default(int);
		}

		public static bool IsPrologueCleared(int eventId)
		{
			return default(bool);
		}

		public static bool IsEventAutoEnterTypeByServer(EventKindType eventType, int eventId)
		{
			return default(bool);
		}

		public static bool IsPrologueReadOrNonAutoEnteredEvent(EventKindType eventType, int eventId)
		{
			return default(bool);
		}

		public static bool EnteredEvent(EventKindType eventType, int eventId)
		{
			return default(bool);
		}

		public static void RequestEventData(EventDataElement data, Action<EventDataElement> onComplete, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestRaidEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestRandomEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestBuildEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestCollectEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestClb01EventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestExRushEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestExHunterEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestCombatEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestBattleRoyalEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void RequestEarnEventData(EventDataElement data, Action<EventDataElement> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void PayEntityTargetTypeCheck(int questId, Action action)
		{
		}

		public static List<int> GetCurrentEnabledEventIdByType(QuestEventType type)
		{
			return null;
		}

		public static List<int> GetCurrentEnabledEventIdByTypeList(List<QuestEventType> typeList)
		{
			return null;
		}

		public static bool IsRaidBoostEnabled(int eventId)
		{
			return default(bool);
		}

		public static bool IsQuestEntityEnoughCheck(int questId, [Optional] UnityAction dataUpdateCallBack)
		{
			return default(bool);
		}

		public static bool IsTotalDamageEvent()
		{
			return default(bool);
		}

		public static bool IsTotalDamageEvent(int eventId)
		{
			return default(bool);
		}

		public static bool IsTotalDamageEventFromQuestId(int questId)
		{
			return default(bool);
		}
	}
}
