/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestModel
	{
		// Fields
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
		[CompilerGenerated]
		private bool _needCheckOverLimit_k__BackingField;
	
		// Properties
		public static int curEventId { get; set; }
		public static int eventPoint { get; set; }
		public static int boxSummonSeq { get; set; }
		public static GiftType resetItemType { get; set; }
		public static int resetItemId { get; set; }
		public static int summonItemRemain { get; set; }
		public static int summonItemTotal { get; set; }
		public static int collectRecivedRewardFromBaseId { get; set; }
		public static bool canResetBoxSummon { get; set; }
		public static int multiItemRatio { get; set; }
		public static SceneNameDefine.PageName firstPageName { get; set; }
		public Dictionary<int, List<QuestEventMenuElement>> raidEventDataDic { get; }
		public Dictionary<int, List<QuestEventMenuElement>> buildEventDataDic { get; }
		public List<QuestEventMenuElement> randomEventDataDic { get; }
		public Dictionary<int, List<QuestEventMenuElement>> collectEventDataDic { get; }
		public static QuestEventGroupElement groupElement { get; }
		public static EventDataElement eventDataElement { get; }
		public static QuestEventType questEventElementEventTypeForNonSpecialEvent { get; }
		public static EventKindType eventKindType { get; }
		public static int eventViewType { get; }
		public int curItemCount { get; }
		public bool needCheckOverLimit { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum TreasureTimeType
		{
			None = 0,
			Treasure = 1,
			Box = 2,
			LuckyArea = 3
		}
	
		public enum RaidEventSubType
		{
			Normal = 1,
			BossBattle = 2,
			RaidBattle = 3,
			ExtraRaidBattle = 4,
			HellRaidBattle = 5,
			UltimateRaidBattle = 6,
			Arena = 7,
			Challenge = 8
		}
	
		public enum BuildEventSubType
		{
			Normal = 1,
			Daily = 2,
			BossBattle = 3,
			ExtraBossBattle = 4,
			Challenge = 5,
			HellBattle = 6,
			Ordeal = 7
		}
	
		public enum RewardStatusType
		{
			None = 0,
			Received = 1,
			CanReceive = 2,
			CannotReceive = 3
		}
	
		public enum RaidCharaTalkCategory0
		{
			Top = 1,
			Result = 2,
			HintMessage = 3,
			QuestDescription = 4,
			ExBattleShowUp = 5
		}
	
		public enum RaidCharaTalkCategory1
		{
			FriendShip = 1,
			Reward = 2,
			End = 3,
			BeforeJoin = 4
		}
	
		public enum RaidResultCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End = 2,
			BeforeJoin = 3
		}
	
		public enum Clb01CharaTalkCategory0
		{
			Top = 1,
			Result = 2,
			HintMessage = 3,
			QuestDescription = 4
		}
	
		public enum Clb01CharaTalkCategory1
		{
			FriendShip = 1,
			Reward = 2,
			End = 3,
			BeforeJoin = 4
		}
	
		public enum RaidResultCharaTalkQuestDescriptionCategory1
		{
			BoxBattle = 1,
			RaidBattle = 2,
			ExtraRaidBattle = 3,
			HellRaidBattle = 4,
			UltimateRaidBattle = 5,
			Arena = 6,
			Charange = 7
		}
	
		public enum Clb01ResultCharaTalkHintMessageCategory1
		{
			BeforeJoin = 1,
			FriendShip = 2,
			End = 3,
			ReadStory = 4
		}
	
		public enum MazeCharaTalkCategory0
		{
			Top_EventValid = 1,
			Top_EventInvalid = 2,
			Result_Before = 3,
			Result_After = 4
		}
	
		public enum MazeTopCharaTalkCategory1
		{
			TreasureTime = 1,
			CanChangeSSRWeapon = 2,
			SSRWeapon = 3,
			PickUpReward = 4,
			CanChange = 5,
			Metal = 6
		}
	
		public enum MazeResultCharaTalkCategory1
		{
			HasReward = 1,
			PickUpReward = 2,
			NoNextReward = 3
		}
	
		public enum BuildCharaTalkCategory1
		{
			ChangeChara = 0,
			DailyBattle = 1,
			ExBossBattle = 2,
			ChallengeBattle = 3,
			NotBuilt_Story = 4,
			NotBuilt_TargetMaterialNum = 5,
			NotBuilt_MaterialFull = 6,
			RepeatPlaying = 7,
			Completed_GotoExchage = 8,
			Normal = 9,
			End = 10
		}
	
		public enum BuildCharaTalkCategoryHint
		{
			NoFacility = 0,
			HasFacility = 1
		}
	
		public enum BuildCharaTalkCategoryQuestDecscription
		{
			BossBattle = 1,
			ExtraBossBattle = 2,
			DailyBattle = 3,
			ChallengeBattle = 4,
			HellBattle = 5,
			Ordeal = 6
		}
	
		public enum BuildCharaTalkCategory0
		{
			Top = 1,
			Result = 2,
			Hint = 3,
			QuestDecription = 4,
			ExtraBattleShowUp = 5,
			FacilityRewardDescription = 6
		}
	
		public enum BuildCharaTalkResultCategory1
		{
			Start = 1,
			ShowResult = 2,
			GotReward = 3
		}
	
		public enum BuildCharaTalkResultTargetType
		{
			None = 0,
			GotReward = 1,
			GotAllReward = 2
		}
	
		public enum BuildEventStoryType
		{
			BuildStory_1 = 0,
			BuildStory_2 = 1,
			BuildStory_3 = 2,
			BuildStory_4 = 3,
			BuildStory_5 = 4
		}
	
		public enum BuildEventBattleType
		{
			Normal = 1,
			Daily = 2,
			Boss = 3,
			ExBoss = 4,
			Challenge = 5
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
			Normal = 0,
			AllStoryRead = 1,
			PostEvent = 2
		}
	
		public enum EventViewType
		{
			none = 0,
			eight = 20429
		}
	
		public class CollectProgressMapCell
		{
			// Fields
			public int subId;
			public int questId;
			public int sortOffset;
			public bool released;
			public bool read;
			public List<CollectEventTalkElement> talkElemList;
			public QuestStoryElement storyElem;
			public QuestEventMenuElement menuElem;
	
			// Constructors
			public CollectProgressMapCell();
	
			// Methods
			public bool CollectProgress(int questId, bool isEventEnded);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass172_0
		{
			// Fields
			public Image image;
			public Action<Material> onCompleted;
	
			// Constructors
			public __c__DisplayClass172_0();
	
			// Methods
			internal void _SetEventImageMaterialAsync_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass173_0
		{
			// Fields
			public Image image;
			public Action<Material> onCompleted;
	
			// Constructors
			public __c__DisplayClass173_0();
	
			// Methods
			internal void _SetEventCompImageMaterialAsync_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass174_0
		{
			// Fields
			public Image image;
			public Action<Material> onCompleted;
	
			// Constructors
			public __c__DisplayClass174_0();
	
			// Methods
			internal void _SetEventImageMaterialAsync_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass194_0
		{
			// Fields
			public string charaImage;
	
			// Constructors
			public __c__DisplayClass194_0();
	
			// Methods
			internal bool _GetCollectCharaTalkTopContent_b__0(CollectProgressMapCell x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CollectProgressMapCell, int> __9__194_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetCollectCharaTalkTopContent_b__194_1(CollectProgressMapCell x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass223_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass223_0();
	
			// Methods
			internal void _RequestRaidEventData_b__0(RaidEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass224_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass224_0();
	
			// Methods
			internal void _RequestRandomEventData_b__0(MazeEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass225_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass225_0();
	
			// Methods
			internal void _RequestBuildEventData_b__0(BuildEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass226_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass226_0();
	
			// Methods
			internal void _RequestCollectEventData_b__0(CollectEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass227_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass227_0();
	
			// Methods
			internal void _RequestClb01EventData_b__0(Clb01EventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass228_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass228_0();
	
			// Methods
			internal void _RequestExRushEventData_b__0(ExRushEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass229_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass229_0();
	
			// Methods
			internal void _RequestExHunterEventData_b__0(ExHunterEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass230_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass230_0();
	
			// Methods
			internal void _RequestCombatEventData_b__0(CombatEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass231_0
		{
			// Fields
			public Action<EventDataElement> onCompleted;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass231_0();
	
			// Methods
			internal void _RequestBattleRoyalEventData_b__0(BattleRoyalEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass232_0
		{
			// Fields
			public Action action;
	
			// Constructors
			public __c__DisplayClass232_0();
	
			// Methods
			internal void _PayEntityTargetTypeCheck_b__0(int value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass236_0
		{
			// Fields
			public UnityAction dataUpdateCallBack;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass236_0();
	
			// Methods
			internal void _IsQuestEntityEnoughCheck_b__0(ShopGetListResponse res);
			internal void _IsQuestEntityEnoughCheck_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass236_1
		{
			// Fields
			public CommonIconPopup purchasePopup;
			public __c__DisplayClass236_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass236_1();
	
			// Methods
			internal void _IsQuestEntityEnoughCheck_b__1();
			internal void _IsQuestEntityEnoughCheck_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass236_2
		{
			// Fields
			public CommonIconPopup purchasePopup;
	
			// Constructors
			public __c__DisplayClass236_2();
	
			// Methods
			internal void _IsQuestEntityEnoughCheck_b__4();
		}
	
		// Constructors
		public EventQuestModel();
		static EventQuestModel();
	
		// Methods
		public bool hasNextItems();
		public void ClearEventData();
		public void LoadEventData(QuestEventGroupElement groupElement, EventKindType eventType, bool checkPlayCount = false);
		public int GetEpilogueStroyId();
		private void AddEventData(Dictionary<int, List<QuestEventMenuElement>> targetDataDic, QuestEventMenuElement sourceElement);
		private void AddEventData(List<QuestEventMenuElement> targetDataList, QuestEventMenuElement sourceElement);
		public static DateTime GetNextScheduleEventStartTime(QuestEventGroupElement groupElement);
		public static bool IsMemoryEvent();
		public static DateTime GetNextEventStartTime(DateTime currentTime, QuestScheduleDataWrapper schedule);
		private static DateTime GetNextStartDateOfScheduleEvent(DateTime currentTime, DateTime startDate, DateTime endDate, List<DayOfWeek> dayOfWeeks);
		public static DateTime GetEventEndtime(QuestEventGroupElement groupElement);
		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestEventGroupElement groupElement);
		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestDataElement questDataElement);
		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, List<QuestScheduleDataWrapper> scheduleList);
		public static DateTime GetEventEndTimeParticularDay(DateTime currentDate, QuestScheduleDataWrapper schedule);
		private static DateTime GetEventEndTimeParticularDay(DateTime currentDate, DateTime startDate, DateTime endDate, List<DayOfWeek> dayOfWeeks);
		public static string GetRemainDateString(QuestEventGroupElement groupElement);
		public static bool IsResetIntervalDailyType(QuestEventGroupElement groupElement);
		public static string GetRemainTimeText(DateTime now, DateTime endDate, string[] templateTexts = null);
		public static string GetTreasureRemainTimeText(float time);
		public static TreasureTimeType GetRandomEventTreasureType(int randomEventId);
		public static float GetTreasureTimeRemainTime(int eventId, out TreasureTimeType treasureType);
		public static RewardStatusType CanReceiveRaidReward(EventRewardCellData cellData);
		public static RewardStatusType CanReceiveRaidReward(int rewardId, int eventItemId, int eventItemQuantity);
		public static RewardStatusType CanReceiveRandomReward(int rewardId, int eventItemQuantity);
		public static RewardStatusType CanReceiveBuildReward(int rewardId, int eventItemQuantity);
		public static RewardStatusType CanReceiveCombatReward(int rewardId, int eventItemQuantity);
		public static RewardStatusType CanReceiveClb01Reward(int rewardId, int eventItemQuantity);
		public static RewardStatusType CanReceiveBattleRoyalReward(int rewardId, int eventItemQuantity);
		public static int GetRandomEventCurrentMedalNumber(int eventId);
		public static int GetBuildEventCurrentMetalNumber(int eventId);
		public static int GetClb01EventCurrentMetalNumber(int eventId);
		public static void GetRandomEventReward(int eventGroupId, int currentMetalNumber, out MazeEventRewardElement prevReward, ref List<MazeEventRewardElement> nextRewards);
		public static void GetBuildEventReward(int eventGroupId, int currentMetalNumber, out BuildEventRewardElement prevReward, ref List<BuildEventRewardElement> nextRewards);
		public static void GetCycleEventReward(int eventGroupId, int currentPoint, out EventCyclePointRewardElement prevReward, ref List<EventCyclePointRewardElement> nextRewards);
		public static int GetBuildEventRewardMaxValue(int eventGroupId);
		public static int GetRandomEventNextRewardValue(int eventId);
		public static MazeEventRewardElement GetRandomEventNextRewardData(int eventId, int currentMetalNumber);
		public static int GetRandomEventNextRewardNum(int eventId, int currentMetalNumber);
		public void UpdateRaidCanReceivedIds(bool forceUpdate = false);
		public void UpdateRaidCanReceivedIds(int tabIndex);
		public void UpdateRandomCanReceivedIds(bool forceUpdate = false);
		public static int GetEventItemCount(int eventItemID, GiftType eventItemType);
		public static int GetTopItemCount(int index);
		public static int GetBattleRoyalEventItemValue(int eventItemId);
		public static int GetRaidEventItemValue(int eventItemId);
		public static int GetRaidEventItemValueByType(RaidEventItemType type);
		public static void SetRaidEventItemMaterialByType(Image image, RaidEventItemType type);
		public static int GetBuildEventItemValue(int eventItemId);
		public static int GetClb01EventItemValue(int eventItemId);
		public static int GetCollectEventItemValue(int eventItemId);
		public static int GetAstralEventItemValue(int eventItemId);
		public static int GetCombatEventItemValue(int eventItemId);
		public static bool SetEventImageMaterial(int eventId, Image image, string materialName, bool isLocalized = true, bool shouldSetAutoImage = false);
		public static void SetEventImageMaterialAsync(int eventId, Image image, string materialName, bool isLocalized = true, Action<Material> onCompleted = null);
		public static void SetEventCompImageMaterialAsync(int eventId, Image image, string materialName, Action<Material> onCompleted = null);
		public static void SetEventImageMaterialAsync(Image image, string path, Action<Material> onCompleted = null);
		public static string GetCollectHindMessage();
		public static string GetRaidHintMessage();
		public static string GetClb01HintMessage();
		public static string GetRaidQuestDescription(RaidResultCharaTalkQuestDescriptionCategory1 category1);
		public static string GetExHunterQuestDescription(RaidResultCharaTalkQuestDescriptionCategory1 category1);
		public static string GetRaidResultExtraBattleShowUpDescription();
		public static string GetExHunterResultExtraBattleShowUpDescription();
		public static RaidEventTalkElement GetRaidCharaTalkResultContent(int eventGroupId);
		public static RaidEventTalkElement GetRaidCharaTalkResultPointMaxContent(int eventGroupId);
		public static void GetRaidResultCharaTalkMinMaxIndex(RaidEventTalk eventTalk, RaidCharaTalkCategory1 category1, out int minIndex, out int maxIndex, int curPoint);
		public MazeEventTalkElement GetRandomTopCharaTalkContent(bool isTreasureTime, ref int curTalkIndex, ref string preferredTopCharaId);
		public static MazeEventTalkElement GetRandomResultCharaTalkContent(int eventGroupId, bool beforeGotAnimation, int currentMetalValue = 0, int gotMetal = 0);
		private bool IsBattleCleared(BuildEventBattleType type);
		public static bool IsBuildEventCategoryEnable(BuildCharaTalkCategory1 category);
		private static bool IsBuildEventBattleType(QuestEventMenuElement qeme, BuildEventBattleType type);
		private static BuildEventTalkElement GetBuildEventTalkElement(BuildCharaTalkCategory1 category);
		public static bool IsBattleAppeared(BuildEventBattleType type, out QuestEventMenuElement eventMenuElement);
		public static bool IsBuildCompleted();
		public static bool ExchangeItemExists(out bool isSSR);
		public CollectEventTalkElement GetCollectCharaTalkTopContent(bool isFromCharaTouch, ref int curTalkIndex, ref string preferredTopCharaId);
		public static void GetBuildCharaTalkMinMaxIndex(BuildEventTalk eventTalk, BuildCharaTalkCategory1 category1, out int minIndex, out int maxIndex, bool isResult);
		public static BuildEventTalkElement GetBuildCharaTalkResultContent(int eventGroupId, BuildCharaTalkResultCategory1 category, BuildCharaTalkResultTargetType targetType);
		public static string GetBuildHintMessage(bool isFacilityCompleted, string args);
		public static string GetBuildQuestDescription(BuildCharaTalkCategoryQuestDecscription category1);
		public static string GetBuildTalkTextFromCatogory0(BuildCharaTalkCategory0 category);
		public static bool IsMultiPlayerEventQuest(QuestCellData cellData);
		public static string GetBuildEventItemName(int eventId, BuildEventItemType itemType);
		public static string GetCombatEventItemName(int eventId, CombatEventItemType itemType);
		public static string GetCombatEventItemName(int eventId, int itemId);
		public static string GetBattleRoyalEventItemName(int eventId, BattleRoyalEventItemType itemType);
		public static string GetClb01EventItemName(int eventId, Clb01EventItemType itemType);
		public static string GetBuildEventItemName(int eventItemId);
		public static string GetEventItemName(GiftType type, int id);
		public static bool IsGotAllBuildEventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true);
		public static bool IsGotAllClb01EventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true);
		public static bool IsGotAllCombatEventReward(int eventId, int curMedal = -1, int gotMedal = -1, bool exceptGotMedal = true);
		public static bool HasEventPointRewardEvent(EventKindType eventKindType);
		private static bool IsGotAllEventPointReward(int eventId, int curMedal, int gotMedal = -1, bool exceptGotMedal = true);
		public static bool IsGotAllRandomEventReward(int eventId, int gotMedal, bool exceptGotMedal, int curMedal = -1);
		public static EventKindType GetEventKindType(int eventGroupId);
		public static CollectEventItemElement GetCollectItemTypeByEntityId(int eventId, int entityId);
		public static Clb01EventItemElement GetClb01ItemTypeByEntityId(int eventId, int entityId);
		public static int GetCollectTotalReleasedStoryCount(int eventId);
		public static bool IsPrologueCleared(int eventId);
		public static bool IsEventAutoEnterTypeByServer(EventKindType eventType, int eventId);
		public static bool IsPrologueReadOrNonAutoEnteredEvent(EventKindType eventType, int eventId);
		public static bool EnteredEvent(EventKindType eventType, int eventId);
		public static void RequestEventData(EventDataElement data, Action<EventDataElement> onComplete, Action<ErrorType, int> onError = null);
		public static void RequestRaidEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestRandomEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestBuildEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestCollectEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestClb01EventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestExRushEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestExHunterEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestCombatEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void RequestBattleRoyalEventData(EventDataElement data, Action<EventDataElement> onCompleted, Action<ErrorType, int> onError = null);
		public static void PayEntityTargetTypeCheck(int questId, Action action);
		public static List<int> GetCurrentEnabledEventIdByType(QuestEventType type);
		public static List<int> GetCurrentEnabledEventIdByTypeList(List<QuestEventType> typeList);
		public static bool IsRaidBoostEnabled(int eventId);
		public static bool IsQuestEntityEnoughCheck(int questId, UnityAction dataUpdateCallBack = null);
	}
}
