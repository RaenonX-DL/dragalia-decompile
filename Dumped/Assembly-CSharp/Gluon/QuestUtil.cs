/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Http;
using Gluon.Master;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestUtil
	{
		// Fields
		private const string mainStoryMissionPlayLockEffectStatusKey = "MainStoryMissionPlayLockEffect_{0}";
		private const string mainStoryMissionPlayUnlockEffectStatusKey = "MainStoryMissionPlayUnlockEffect_{0}";
		public const int questPlayCountResetTimeDaily = 6;
		public const int questPlayCountResetTimeWeekly = 1;
		private static readonly float enterAnimationDurationInQuestSelectShortCutting;
		private static Dictionary<int, List<QuestScheduleDataWrapper>> eventEventGroupScheduleDataDictionary;
	
		// Nested types
		public enum QuestState
		{
			None = -1,
			New = 0,
			Trying = 1,
			Cleared = 2,
			Completed = 3,
			Bonus = 4
		}
	
		public enum locationState
		{
			none = -1,
			questNew = 0,
			questclear = 1,
			questCompleate = 2
		}
	
		public enum Easeing
		{
			easeOut = 0,
			easeOutCirc = 1
		}
	
		public enum payEntityType
		{
			none = 0,
			all = 1,
			hostOnly = 2,
			allPlusMultiItem = 3
		}
	
		[Flags]
		public enum QuestEntryFailReason
		{
			None = 0,
			NotOpen = 1,
			BattlePoint = 2,
			PlayCount = 4,
			Item = 8,
			EntryCondition = 16
		}
	
		public enum playType
		{
			defaultPlay = 1,
			multiPlay = 2,
			battlePlay = 3
		}
	
		public enum LastQuestType
		{
			Last = 0,
			LastMainQuest = 1,
			LastEventQuest = 2
		}
	
		public enum CellBandColorType
		{
			QuestBlueBand = 101,
			QuestYellowBand = 102,
			QuestRedBand = 103,
			QuestLightRedBand = 104,
			QuestPurpleBand = 105,
			StoryBlueBand = 201,
			StoryPurpleBand = 202
		}
	
		public enum MainStoryMissionStatus
		{
			None = 0,
			PlayLockEffect = 1,
			NowLocking = 2,
			PlayUnLockEffect = 3,
			LockEnd = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0
		{
			// Fields
			public DayOfWeek dayOfWeek;
	
			// Constructors
			public __c__DisplayClass88_0();
	
			// Methods
			internal bool _IsEnable_b__0(QuestScheduleDataWrapper e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public FlashPlayer flashPlayer;
			public Vector3 localPos;
			public float localScale;
			public int sortingOrder;
			public Action<int> action;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _SetFlashAsync_b__0(int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass123_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass123_0();
	
			// Methods
			internal void _CreateDuplicateConfirmPopup_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QSChapterElement> __9__164_0;
			public static Comparison<QuestMainMenuElement> __9__164_1;
			public static Action __9__200_0;
			public static UnityAction __9__202_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetQSChapterElementList_b__164_0(QSChapterElement a, QSChapterElement b);
			internal int _GetQSChapterElementList_b__164_1(QuestMainMenuElement a, QuestMainMenuElement b);
			internal void _ReEnterQuestSupportScene_b__200_0();
			internal void _GotoLastQuest_b__202_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass181_0
		{
			// Fields
			public Image image;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass181_0();
	
			// Methods
			internal void _SetQuestThumbnail_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass182_0
		{
			// Fields
			public Image image;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass182_0();
	
			// Methods
			internal void _SetMainStoryCellBg_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass200_0
		{
			// Fields
			public Action gotoQuest;
	
			// Constructors
			public __c__DisplayClass200_0();
	
			// Methods
			internal void _ReEnterQuestSupportScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass201_0
		{
			// Fields
			public bool isMainQuest;
			public bool isAddSceneClearInstantly;
			public UnityAction postLoadSceneCallback;
	
			// Constructors
			public __c__DisplayClass201_0();
	
			// Methods
			internal void _GotoQuestScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass201_1
		{
			// Fields
			public Action gotoQuest;
	
			// Constructors
			public __c__DisplayClass201_1();
	
			// Methods
			internal void _GotoQuestScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass203_0
		{
			// Fields
			public GameObject bannerParent;
			public QuestEventBanner.TargetEventType eventType;
			public QuestEventBanner.TargetEventPeriod eventPeriod;
	
			// Constructors
			public __c__DisplayClass203_0();
	
			// Methods
			internal void _SetupQuestEventBanner_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass212_0
		{
			// Fields
			public GameObject gameObject;
			public int questId;
			public bool isMultiStamina;
			public int playCount;
			public Action<bool> onEnough;
			public Action onLack;
			public Action onStaminaRecoveryCancelled;
	
			// Constructors
			public __c__DisplayClass212_0();
	
			// Methods
			internal void _CheckRequiredStamina_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass212_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass212_1();
	
			// Methods
			internal void _CheckRequiredStamina_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass223_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass223_0();
	
			// Methods
			internal void _OnSkipDisabledButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass225_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass225_0();
	
			// Methods
			internal void _CheckRequiredSkipConditions_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass225_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass225_1();
	
			// Methods
			internal void _CheckRequiredSkipConditions_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass237_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass237_0();
	
			// Methods
			internal void _IsQuestPeriod_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass238_0
		{
			// Fields
			public QuestDataElement questDataElement;
	
			// Constructors
			public __c__DisplayClass238_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass238_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass238_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass238_1();
	
			// Methods
			internal void _IsQuestPeriodToQuestTopOrLoginBonus_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass242_0
		{
			// Fields
			public bool succeeded;
	
			// Constructors
			public __c__DisplayClass242_0();
	
			// Methods
			internal void _GetRaidLikeEventDataIfNeeded_b__0();
			internal bool _GetRaidLikeEventDataIfNeeded_b__1();
		}
	
		[CompilerGenerated]
		private struct _GetRaidLikeEventDataIfNeeded_d__242 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action action;
			private List<int> __7__wrap1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass243_0
		{
			// Fields
			public QuestReleasePopup releasePopup;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass243_0();
	
			// Methods
			internal void _ShowQuestEndPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass258_0
		{
			// Fields
			public CommonPopup popup;
			public Action okButtonCallback;
	
			// Constructors
			public __c__DisplayClass258_0();
	
			// Methods
			internal void _PersonalInformationPopup_b__0();
		}
	
		// Constructors
		public QuestUtil();
		static QuestUtil();
	
		// Methods
		public static QuestEventMenuElement GetQuestEventMenuElement(int questId);
		public static QuestMainMenuElement GetQuestMainMenuElement(int questId, QuestSelectScene.Difficulty difficulty);
		public static QuestMainGroupElement GetQuestMainGroupElement(int questGroupId);
		public static QuestEventGroupElement GetQuestEventGroupElement(int questGroupId);
		public static QuestEventElement GetQuestEventElement(int questEventId);
		public static QuestEventElement GetQuestEventElementByQuestGroupId(int questGroupId);
		public static QuestEventElement GetQuestEventElement(QuestEventGroupElement qege);
		public static List<QuestEventGroupElement> GetQuestEventGroupElements(int questEventId, bool checkEnable = false);
		public static List<QuestEventGroupElement> GetQuestEventGroupElements(int questEventId, ICollection<QuestEventGroupElement> givenQegeList);
		public static QuestMainGroupElement GetQuestMainGroupElementFromQuestId(int questId);
		public static QuestEventGroupElement GetQuestEventGroupElementFromQuestId(int questId);
		public static bool GetQuestGroupElementsFromQuestId(int questId, out QuestMainGroupElement qmge, out QuestEventGroupElement qege);
		public static bool GetQuestGroupElements(QuestDataElement qde, out QuestMainGroupElement qmge, out QuestEventGroupElement qege);
		public static void GetQuestMainLocationElementsAll(int questGroupId, List<QuestMainLocationElement> qmleList);
		public static void GetQuestMainMenuElementsAllByLocationId(int questLocationId, List<QuestMainMenuElement> qmmeList, QuestSelectScene.Difficulty difficulty);
		public static bool IsMainRouteLocation(QuestMainLocationElement qmle);
		public static void GetQuestMainMenuElementsAll(int questGroupId, List<QuestMainMenuElement> qmmeList, bool onlyHardCollect = false, bool onlyVeryHardCollect = false);
		public static void GetQuestEventMenuElementsAll(int questGroupId, List<QuestEventMenuElement> qemeList);
		public static QuestDataElement GetQuestDataElement(int questId);
		public static QuestStoryElement GetQuestStoryElement(int questId);
		public static bool IsQuestMainMenuElementReleaseAnother(QuestMainMenuElement target, QuestMainMenuElement candidate, QuestSelectScene.Difficulty difficulty);
		public static bool IsQuestEventMenuElementReleaseAnother(QuestEventMenuElement target, QuestEventMenuElement candidate);
		public static void GetQuestEntryTypeParams(int questId, out QuestEntryType entryType, out int entryValue1, out int entryValue2, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.MAX);
		public static bool IsQuestReleased(QuestMainMenuElement mainMenuElement, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.MAX);
		public static bool IsQuestReleased(QuestEventMenuElement eventMenuElement);
		public static bool IsQuestReleased(int questDataId);
		public static QuestState GetQuestMainState(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static QuestGroupType GetQuestGroupType(int questId);
		public static QuestState GetQuestMainState(QuestSelectScene.Difficulty difficulty, bool isForceInit, int groupId = 0, int locationId = 0, int questId = 0);
		public static QuestState CheckQuestMainMenuElementListWholeState(List<QuestMainMenuElement> qmmeList, QuestSelectScene.Difficulty difficulty, out bool isCleared, out bool isCompleted, bool isGroup = false, bool isLocation = false);
		public static QuestState GetQuestEventState(QuestEventMenuElement qeme);
		public static QuestState GetQuestEventState(List<QuestEventMenuElement> cellData);
		private static bool IsEnablePeriod(QuestEventMenuElement questEventMenuElement);
		public static QuestState GetQuestStateByIdAndType(int questId, QuestType type, out bool isFound);
		public static bool IsQuestCleared(int questId);
		public static QuestSelectScene.Difficulty GetQuestVariationType(int questId);
		public static bool IsQuestEventAppeared(int questId);
		public static int GetPlayCount(QuestDataElement dataElement);
		public static int GetPlayCount(QuestDataElement dataElement, out int maxPlayCount);
		public static int GetPlayCount(int questId, QuestResetIntervalType limitType);
		public static bool IsBattlePowerEnough(QuestDataElement questDataElement);
		public static bool IsLimitedElementalTypeEnough(ElementalType limitedElementalType);
		public static bool IsLimitedElementalTypeEnough(ElementalType limitedElementalType, int partyIndex, bool isClearParty = false);
		public static bool IsJoinConditionsPassed(int questDataId, bool isHost = true);
		public static bool IsJoinConditionsPassedForMatching(int questDataId, bool isHost = true);
		public static QuestEntryFailReason GetJoinConditionsFailReasonForMatching(int questDataId, StringBuilder failedDescription = null, bool isHost = true);
		public static QuestEntryFailReason GetJoinConditionsFailReason(int questDataId, StringBuilder failedDescription = null, bool isHost = true);
		public static bool IsMainQuestAllMissionClear(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static bool IsEventQuestAllMissionClear(int questId);
		public static bool IsEntryConditionPassed(QuestDataElement dataElement, ref string failedDescription, bool fetchFailedDescription);
		public static int GetEventCharaId(int eventId);
		public static int GetEventCharaMaxPointValue(int charaId);
		public static int GetEventCharaDataManagerPoint(int charaId);
		public static int GetEventCharaQuestResultPoint(int charaId, bool beforePoint = false);
		public static int GetCollectEventItemCount(CollectEventItemType itemType);
		public static int GetClb01EventItemCount(int eventId, Clb01EventItemType itemType);
		public static CharaFriendshipList GetNewCharaFriendship(CharaFriendshipList charaFriendship);
		public static QuestType GetQuestTypeByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static int GetQuestIdByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static int GetReleaseQuestIdByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static bool CheckMainStoryReleaseCondition(ref int a_questID, ref QuestType a_questType, QuestSelectScene.Difficulty difficulty, QuestMainMenuElement a_qmme);
		public static bool IsMainQuest(int questId);
		public static int GetMainQuestChapterNumber(int groupId);
		public static string GetQuestChapterName(int questId);
		public static bool CheckPlayCount(int questId);
		public static bool CheckPlayCount(QuestDataElement dataElement);
		public static bool IsExist(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static bool IsEnable(QuestEventElement qee);
		public static bool IsEnable(EventDataElement ede);
		public static bool IsEnable(int questGroupId, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.Normal, bool isCloseTime = false);
		public static bool IsQuestEventEnable(QuestEventElement qee);
		public static bool IsQuestEventGroupEnable(QuestEventGroupElement qege);
		public static bool IsEnable(QuestEventMenuElement qeme);
		public static bool IsEnable(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static bool IsEnable(QuestDataElement dataElement);
		public static bool IsEnableNotIsLockView(QuestDataElement dataElement);
		private static QuestGroupIntervalType GetIntervalType(QuestDataElement dataElement);
		public static string GetEventNextStartTimeStr(QuestDataElement dataElement);
		private static DateTime GetNearestDayOfWeekDateTime(DateTime date, DayOfWeek wantDayOfWeek);
		public static bool IsEnableForMatching(QuestDataElement dataElement, bool isHost);
		public static bool CheckLocalTime(string startTimeStr, string endTimeStr);
		public static bool CheckLocalTimeSetEndTime(string startTimeStr, double days);
		public static bool GetQuestMainGroupDurationTime(QuestMainGroupElement groupElement, out string startTime, out string endTime);
		public static bool GetQuestGroupDurationTime(QuestEventGroupElement groupElement, out string startTime, out string endTime, bool isCloseTime = false);
		public static bool GetQuestGroupDurationTime(int groupId, out string startTime, out string endTime);
		public static bool IsEnablePeriod(QuestMainGroupElement qmge, QuestGroupIntervalType intervalType);
		public static bool IsEnablePeriod(QuestEventGroupElement qege, QuestGroupIntervalType intervalType, bool isCloseTime = false);
		public static QuestScheduleDataWrapper GetEventSchedule(QuestEventGroupElement eventGroup, DateTime spanTime, DateTime currentTime);
		public static QuestScheduleDataWrapper GetEventSchedule(int questId, DateTime spanTime, DateTime currentTime);
		public static List<QuestScheduleDataWrapper> GetEventScheduleList(int questId, DateTime spanTime, DateTime currentTime);
		public static void ClearCache();
		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventGroupElement eventGroup);
		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventGroupElement eventGroup, DateTime spanTime, DateTime currentTime);
		public static IEnumerable<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventMenuElement questEventMenu);
		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestDataElement questData);
		public static void GetViewStartDate2AndViewEndDate2String(QuestDataElement questData, out string viewStartDate, out string viewEndDate);
		public static bool IsEventEndButNotClosed(QuestEventGroupElement groupElement);
		public static DateTime GetCheckSpanTime();
		public static bool IsEnableIntervalType(QuestGroupIntervalType intervalType, DayOfWeek dayOfWeek);
		public static EventDataElement GetEventDataElement(int eventId);
		public static bool IsEnablePeriod(EventDataElement ede);
		public static bool IsWaitForClosingPeriod(EventDataElement ede);
		public static GameObject LoadPartPrefab(string partPrefabPath, GameObject parentObj);
		public static void SetupFlash(FlashPlayer flashPlayer, string path, GameObject parentObj, int sortingOrder, Vector3 localPos, float localScale = 1f, bool isAutoDestroy = true);
		public static void SetFlashAsync(FlashPlayer flashPlayer, string path, GameObject parentObj, int sortingOrder, Vector3 localPos, float localScale = 1f, Action<int> action = null, int flashIndex = 0);
		public static Sprite GetLandmarkIconImage(QuestMainLocationElement qmle);
		public static QuestTreasureDataElement GetQuestTreasureDataElement(int questLocationId, QuestSelectScene.Difficulty difficulty);
		public static CommonPopup CheckRewardListDuplicate(DataManager.GameData<AtgenBuildEventRewardEntityList> rewardList);
		public static CommonPopup CreateDuplicateConfirmPopup(string title, string text);
		public static locationState GetLocationState(int locationId, QuestSelectScene.Difficulty difficulty);
		public static float EaseOut(float t, float b, float c, float d);
		public static float EaseOutCirc(float t, float b, float c, float d);
		public static float GetEaseValue(Easeing ease, float time, float fromValue, float diff, float totalTime);
		public static T GetSceneComponent<T>(string sceneName);
		public static bool IsMatching();
		public static bool IsInQuestPlayTransition(bool isMatchingOK = true);
		public static bool IsInQuestPartyBaseScene(bool isMatchingOK = true);
		public static QuestPrepareData[] GetCommonPartyPowerCalculateData(MatchingService.Room room);
		public static QuestPrepareData[] GetCommonPartyPowerCalculateRaidData(MatchingService.Room matching);
		public static int[] GetCharacterIndex(int index, int maxPlayerCount);
		public static int GetUidGrpForGuerrilla();
		public static string GetNextQuestSceneName(int questId);
		public static string GetNextSceneNameFromIngameForMultiGuest(int questId);
		public static string GetNextQuestSceneName(QuestMainGroupElement groupElement);
		public static string GetNextQuestSceneName(QuestEventGroupElement groupElement);
		public static bool IsEventMenuTabQuest(QuestEventElement qee);
		public static bool IsEventMenuTabQuestFromQuestId(int questId);
		public static bool IsEventMenuTabQuest(int questGroupId);
		public static bool IsEventMenuTabQuest(QuestEventGroupElement qege);
		public static bool IsVoidBattle(QuestEventElement qee);
		public static bool IsBattleRoyal(QuestEventElement qee);
		public static bool IsVoidBattle(QuestEventGroupElement qee);
		public static bool IsBattleRoyal(QuestEventGroupElement qee);
		public static bool IsAstralRaid(QuestEventElement qee);
		public static bool IsAstralRaid(QuestEventGroupElement qee);
		public static bool IsAstralRaid(int questId);
		public static bool IsSimpleEvent(QuestEventElement qee);
		public static bool IsSimpleEvent(int eventId);
		public static bool IsSimpleEvent(QuestEventGroupElement qege);
		public static bool IsRedThemeEvent(int questId);
		public static bool IsRedThemaNormalEvent(QuestEventElement qee);
		public static bool IsRedThemaNormalEvent(QuestEventGroupElement qee);
		public static bool IsBlueThemeEvent(int questId);
		public static bool IsBlueThemeEvent(EventKindType eventKindType);
		public static bool IsBlueThemeEvent(QuestEventElement qee);
		public static bool IsBlueThemeEvent(QuestEventGroupElement qee);
		public static bool IsExRush(QuestEventElement qee);
		public static void SetQuestConditionIcon(Image image, QuestDataElement questDataElement);
		public static bool IsQuestPlayFlowOnPartyScene();
		public static List<QSChapterElement> GetQSChapterElementList(ref bool hardEnable);
		public static bool IsMatchingBPEnough(QuestDataElement questDataElement);
		public static bool IsQuestEntityEnough(QuestDataElement questDataElement, bool isHost = true);
		public static long GetQuestItem(QuestDataElement questDataElement, bool isHost = true);
		public static bool IsSingleStaminaEnough(int questId, int playCount, out bool isStaminaMaxEnough);
		public static int GetQuestSingleStamina(int questId);
		private static bool IsStaminaZero(QuestDataElement questData);
		public static bool IsMultiStaminaEnough(int questId, int playCount, out bool isStaminaMaxEnough);
		public static int GetQuestMultiStamina(int questId);
		public static int GetDefaultQuestMultiStamina(int questId);
		public static bool IsCampaignQuest(CampaignType type, int groupId);
		public static int GetQuestSkipTicketNum();
		public static int GetQuestSkipTicketMax();
		public static int GetQuestSkipTicketUse(int questId);
		public static List<QuestMainMenuElement> GetMainMenuGroup(int locationId);
		public static void SetQuestThumbnail(int questId, Image image, bool isUnknown);
		public static void SetQuestThumbnail(QuestDataElement questData, Image image, bool isUnknown, Action onComplete = null);
		public static void SetQuestThumbnail(string imageMaterialStr, Image image, Action onComplete = null);
		public static void SetMainStoryCellBg(string name, Image image, Action onComplete = null);
		public static bool IsSingleMatchingModeEnabled(int questId);
		public static bool IsManyMultiBattleFlag(int questId);
		public static bool IsMissionCleared(QuestList ql, int index);
		public static bool IsMissionCompleted(QuestList ql);
		public static bool IsMissionAlreadyCleared(QuestList ql);
		public static string GetQuestNameOrStoryName(QuestType questType, int questId);
		public static QRTreasureIcon.TreasureIconType GetTreasureIconType(int placeValue, QuestResultModel.TopPageModel.RewardItemInfo.PorchRarity porchRarity);
		public static bool IsFirstMainQuestClear();
		public static bool IsNewLandMark(int groupId, int lastLocationId, QuestSelectScene.Difficulty type);
		public static QuestMainGroupElement GetLatestQuestMainGroup();
		public static QuestMainGroupElement GetQuestMainGroupElementFromChapterId(int chapterNum);
		public static bool EnableEventQuestCellArrow(QuestCell cell, QuestEventMenuElement prev, QuestEventMenuElement target);
		public static void EnableQuestCellArrow(QuestCell cell, QuestType questType, bool isArrowEnable);
		public static bool isEventQuestActive(int eventQuestGroupId);
		public static List<int> GetEventIdFormCharaId(int charaId);
		public static int GetClosestEventIdFromCharaId(int charaId, out bool isOutOfPeriod);
		public static string GetQuestBgResourcePath(int questId);
		public static void ReEnterQuestSupportScene(float enterAnimationDutation, bool isNotSupport);
		public static void GotoQuestScene(UnityAction postLoadSceneCallback = null, bool isAddSceneClearInstantly = true);
		public static void GotoLastQuest(LastQuestType type, UnityAction postLoadSceneCallback = null, bool isAddSceneClearInstantly = true);
		public static void SetupQuestEventBanner(GameObject bannerParent, QuestEventBanner.TargetEventType eventType, QuestEventBanner.TargetEventPeriod eventPeriod);
		public static bool IsEventQuestTurorialDone();
		public static int GetAreaPathIndex(int chapter, bool isAreaMap);
		public static bool IsRankingPeriodByQuestId(int questId);
		public static bool IsRankingPeriod(QuestEventGroupElement qege);
		public static bool IsRankingPeriod(QuestEventElement qee);
		public static void GetRankingInfo(int questId, out int clearTimeNum, out int rankingNum);
		public static string GetPayEntityName(QuestDataElement qde);
		public static bool CheckRequiredStamina(GameObject gameObject, int questId, bool isMultiStamina, Action<bool> onEnough, Action onLack = null, Action onStaminaRecoveryCancelled = null, bool isJustCheckStaminaMaxCapacity = false, bool isRecoveredStamina = false);
		public static bool CheckRequiredStamina(GameObject gameObject, int questId, bool isMultiStamina, int playCount, Action<bool> onEnough, Action onLack = null, Action onStaminaRecoveryCancelled = null, bool isJustCheckStaminaMaxCapacity = false, bool isRecoveredStamina = false);
		public static bool IsInsertQuestStory(int id);
		public static bool IsParameterOverrideQuest(int id);
		public static bool IsSupportEnableQuest(int id);
		public static bool IsSupportEnableQuest(QuestConstraintType constraintType);
		public static bool IsMultiplayEnableQuest(QuestConstraintType constraintType);
		public static bool IsMultiplayEnableEvent(int eventId);
		public static Color GetNecessaryColor();
		public static Color GetNecessaryOutlineColor();
		public static Color GetRecommendedColor();
		public static bool IsSkipDisabledQuest(int questId);
		public static void OnSkipDisabledButton(int questId);
		public static bool IsLackOfTicket(int questId);
		public static bool CheckRequiredSkipConditions(int questId);
		public static bool IsMultiPlayHost();
		public static CellBandColorType GetCellBandColorType(int questId, int variationType);
		public static bool IsUltimateDragonBattle(QuestEventElement qee);
		public static bool IsUltimateDragonBattle(QuestEventGroupElement qege);
		public static bool IsQuestEventType(QuestEventGroupElement qege, QuestEventType type);
		public static bool IsUltimateDragonBattle(QuestDataElement qde);
		public static Localize.TextId GetUltimateDragonBattleDifficultyText(QuestDataElement qde);
		public static bool IsDragonBattle(QuestEventElement qee);
		public static Localize.TextId GetMainQuestDifficulity(QuestDataElement element);
		public static int GetUltimateDragonBattlePrologueId(QuestEventGroupElement groupElement);
		public static bool IsUltimateDragonBattlePrologueDone(QuestEventGroupElement groupElement);
		public static bool IsQuestPeriod(int questId);
		public static bool IsQuestPeriodToQuestTopOrLoginBonus(int questId);
		public static bool IsAllEventInterval();
		public static bool IsRaidLikeEventNowOpen();
		public static List<int> GetRaidEventNowOpen();
		public static async void GetRaidLikeEventDataIfNeeded(Action action);
		public static void ShowQuestEndPopup(Action callback = null);
		public static bool CheckDateChanged();
		public static bool CheckDateChangeStartQuest();
		public static bool IsFirstAndNewLandmerk();
		public static bool IsTresureRelease(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public static bool IsExtraBattleQuest(int questId);
		public static bool IsExtraBattleQuest(QuestEventMenuElement qeme);
		public static bool IsRaidBattleQuest(int questId);
		public static bool IsQuestResetted(QuestResetIntervalType resetType, int lastResetTime);
		public static bool IsDropUpTarget(GiftType giftType);
		public static bool IsPeriodQuestEvent(QuestEventType eventType);
		public static bool IsRankingPreriodQuestEvent(QuestEventElement eventElement);
		public static QuestDataElement GetRankingPreriodQuestEventForQuestData(QuestEventGroupElement groupElement);
		public static bool IsRankingPeriodQuestData(QuestDataElement qde, bool isView = false);
		public static bool IsPersonalInformationPopup();
		public static void PersonalInformationPopup(Localize.TextId title, Localize.TextId difficulty, Action okButtonCallback);
		public static void LoadQuestSelectSceneAsync(bool isMainStoryQuest, Action onLoadedCallback = null, bool needRequestEventQuest = true, bool isAddSceneClearInstantly = true, SceneModelBase model = null);
		public static bool IsVeryHardReleased();
		public static bool IsQuestPrologueIdDone(QuestEventGroupElement groupElement);
		public static MainStoryMissionStatus GetMainStoryMissionStatus(int questId, int entryConditionId);
		public static void SaveMainStoryMissionLockEffectStatus(int questId, int entryConditionId);
		public static void SaveMainStoryMissionUnlockEffectStatus(int questId, int entryConditionId);
		public static bool IsPlayStoryMissionLockEffect(int questId, int entryConditionId);
		public static bool IsPlayStoryMissionUnlockEffect(int questId, int entryConditionId);
		public static bool IsMainQuestNewCondition(int groupId);
		public static List<string> GetQuestNameOrStoryNameList(QuestEventMenuElement eventMenuElement, ref bool isReleased);
		public static string GetTriggetString(QuestDataElement questData);
		private static string GetNotClearQuestNameOrStoryName(QuestType questType, int questId);
		private static string GetSectionName(QuestType questType, int id);
		public static bool IsQuestCarryQuestData(int questId);
		public static HashSet<int> GetQuestIdAll();
		public static HashSet<int> GetClearedMainQuestIdAll();
		public static HashSet<int> GetNotClearedMainQuestIdAll();
		public static void GetQuestIdAllList(out HashSet<int> mainQuestIdList, out HashSet<int> notMainQuestIdList);
		public static void GetStoryIdAllList(out HashSet<int> mainStoryIdList, out HashSet<int> notMainStoryIdList);
		public static void GetSingleStoryIdList(out HashSet<int> allStoryIdList, out HashSet<int> clearedMainStoryIdList, out HashSet<int> notClearedMainStoryIdList);
		public static bool IsEventMenuElementQuestReleased(QuestEventMenuElement eventMenuElement);
		public static bool IsLimitedElementalQuest(int questId, out ElementalType element);
		public static bool IsSoloMultiQuestGroup(int eventGroupId);
	}
}
