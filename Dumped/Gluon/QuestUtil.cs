using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestUtil
	{
		public enum QuestState
		{
			None = -1,
			New,
			Trying,
			Cleared,
			Completed,
			Bonus
		}

		public enum locationState
		{
			none = -1,
			questNew,
			questclear,
			questCompleate
		}

		public enum Easeing
		{
			easeOut,
			easeOutCirc
		}

		public enum payEntityType
		{
			none,
			all,
			hostOnly,
			allPlusMultiItem
		}

		[Flags]
		public enum QuestEntryFailReason
		{
			None = 0x0,
			NotOpen = 0x1,
			BattlePoint = 0x2,
			PlayCount = 0x4,
			Item = 0x8,
			EntryCondition = 0x10
		}

		public enum playType
		{
			defaultPlay = 1,
			multiPlay,
			battlePlay
		}

		public enum LastQuestType
		{
			Last,
			LastMainQuest,
			LastEventQuest
		}

		public enum CellBandColorType
		{
			QuestBlueBand = 101,
			QuestYellowBand = 102,
			QuestRedBand = 103,
			QuestPurpleBand = 105,
			QuestLightRedBand = 104,
			StoryBlueBand = 201,
			StoryPurpleBand = 202
		}

		public enum MainStoryMissionStatus
		{
			None,
			PlayLockEffect,
			NowLocking,
			PlayUnLockEffect,
			LockEnd
		}

		public enum QuestBonusReceiveType
		{
			AutoReceive,
			SelectReceive,
			StackReceive,
			StackSelectReceive,
			Max
		}

		private const string mainStoryMissionPlayLockEffectStatusKey = "MainStoryMissionPlayLockEffect_{0}";

		private const string mainStoryMissionPlayUnlockEffectStatusKey = "MainStoryMissionPlayUnlockEffect_{0}";

		public const int questPlayCountResetTimeDaily = 6;

		public const int questPlayCountResetTimeWeekly = 1;

		private static readonly float enterAnimationDurationInQuestSelectShortCutting;

		public const int voidBaseGroupId = 30000;

		private static Dictionary<int, List<QuestScheduleDataWrapper>> eventEventGroupScheduleDataDictionary;

		public static QuestEventMenuElement GetQuestEventMenuElement(int questId)
		{
			return null;
		}

		public static QuestMainMenuElement GetQuestMainMenuElement(int questId, QuestSelectScene.Difficulty difficulty)
		{
			return null;
		}

		public static QuestMainGroupElement GetQuestMainGroupElement(int questGroupId)
		{
			return null;
		}

		public static QuestEventGroupElement GetQuestEventGroupElement(int questGroupId)
		{
			return null;
		}

		public static QuestEventElement GetQuestEventElement(int questEventId)
		{
			return null;
		}

		public static QuestEventElement GetQuestEventElementFromQuestId(int questId)
		{
			return null;
		}

		public static QuestEventElement GetQuestEventElementByQuestGroupId(int questGroupId)
		{
			return null;
		}

		public static QuestEventElement GetQuestEventElement(QuestEventGroupElement qege)
		{
			return null;
		}

		public static List<QuestEventGroupElement> GetQuestEventGroupElements(int questEventId, bool checkEnable = false)
		{
			return null;
		}

		public static List<QuestEventGroupElement> GetQuestEventGroupElements(int questEventId, ICollection<QuestEventGroupElement> givenQegeList)
		{
			return null;
		}

		public static QuestMainGroupElement GetQuestMainGroupElementFromQuestId(int questId)
		{
			return null;
		}

		public static QuestEventGroupElement GetQuestEventGroupElementFromQuestId(int questId)
		{
			return null;
		}

		public static bool GetQuestGroupElementsFromQuestId(int questId, out QuestMainGroupElement qmge, out QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool GetQuestGroupElements(QuestDataElement qde, out QuestMainGroupElement qmge, out QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static void GetQuestMainLocationElementsAll(int questGroupId, List<QuestMainLocationElement> qmleList)
		{
		}

		public static void GetQuestMainMenuElementsAllByLocationId(int questLocationId, List<QuestMainMenuElement> qmmeList, QuestSelectScene.Difficulty difficulty)
		{
		}

		public static bool IsMainRouteLocation(QuestMainLocationElement qmle)
		{
			return default(bool);
		}

		public static void GetQuestMainMenuElementsAll(int questGroupId, List<QuestMainMenuElement> qmmeList, bool onlyHardCollect = false, bool onlyVeryHardCollect = false)
		{
		}

		public static void GetQuestEventMenuElementsAll(int questGroupId, List<QuestEventMenuElement> qemeList)
		{
		}

		public static QuestDataElement GetQuestDataElement(int questId)
		{
			return null;
		}

		public static QuestStoryElement GetQuestStoryElement(int questId)
		{
			return null;
		}

		public static bool IsQuestMainMenuElementReleaseAnother(QuestMainMenuElement target, QuestMainMenuElement candidate, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public static bool IsQuestEventMenuElementReleaseAnother(QuestEventMenuElement target, QuestEventMenuElement candidate)
		{
			return default(bool);
		}

		public static void GetQuestEntryTypeParams(int questId, out QuestEntryType entryType, out int entryValue1, out int entryValue2, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.MAX)
		{
		}

		public static bool IsQuestReleased(QuestMainMenuElement mainMenuElement, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.MAX)
		{
			return default(bool);
		}

		public static bool IsQuestReleased(QuestEventMenuElement eventMenuElement)
		{
			return default(bool);
		}

		public static bool IsQuestReleased(int questDataId)
		{
			return default(bool);
		}

		public static QuestState GetQuestMainState(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(QuestState);
		}

		public static QuestGroupType GetQuestGroupType(int questId)
		{
			return default(QuestGroupType);
		}

		public static QuestState GetQuestMainState(QuestSelectScene.Difficulty difficulty, bool isForceInit, int groupId = 0, int locationId = 0, int questId = 0)
		{
			return default(QuestState);
		}

		public static QuestState CheckQuestMainMenuElementListWholeState(List<QuestMainMenuElement> qmmeList, QuestSelectScene.Difficulty difficulty, out bool isCleared, out bool isCompleted, bool isGroup = false, bool isLocation = false)
		{
			return default(QuestState);
		}

		public static QuestState GetQuestEventState(QuestEventMenuElement qeme)
		{
			return default(QuestState);
		}

		public static QuestState GetQuestEventState(List<QuestEventMenuElement> cellData)
		{
			return default(QuestState);
		}

		private static bool IsEnablePeriod(QuestEventMenuElement questEventMenuElement)
		{
			return default(bool);
		}

		public static QuestState GetQuestStateByIdAndType(int questId, QuestType type, out bool isFound)
		{
			return default(QuestState);
		}

		public static bool IsQuestCleared(int questId)
		{
			return default(bool);
		}

		public static QuestSelectScene.Difficulty GetQuestVariationType(int questId)
		{
			return default(QuestSelectScene.Difficulty);
		}

		public static bool IsQuestEventAppeared(int questId)
		{
			return default(bool);
		}

		public static int GetPlayCount(QuestDataElement dataElement)
		{
			return default(int);
		}

		public static int GetPlayCount(QuestDataElement dataElement, out int maxPlayCount)
		{
			return default(int);
		}

		public static int GetPlayCount(int questId, QuestResetIntervalType limitType)
		{
			return default(int);
		}

		public static bool IsBattlePowerEnough(QuestDataElement questDataElement)
		{
			return default(bool);
		}

		public static bool IsLimitedElementalTypeEnough(ElementalType limitedElementalType)
		{
			return default(bool);
		}

		public static bool IsLimitedElementalTypeEnough(ElementalType limitedElementalType, int partyIndex, bool isClearParty = false)
		{
			return default(bool);
		}

		public static bool IsLimitedWeaponTypeEnough(List<WeaponType> limitedWeaponTypeList)
		{
			return default(bool);
		}

		public static bool IsLimitedWeaponTypeEnough(List<WeaponType> limitedWeaponTypeList, int partyIndex, bool isClearParty = false)
		{
			return default(bool);
		}

		public static bool IsJoinConditionsPassed(int questDataId, bool isHost = true)
		{
			return default(bool);
		}

		public static bool IsJoinConditionsPassedForMatching(int questDataId, bool isHost = true)
		{
			return default(bool);
		}

		public static QuestEntryFailReason GetJoinConditionsFailReasonForMatching(int questDataId, [Optional] StringBuilder failedDescription, bool isHost = true)
		{
			return default(QuestEntryFailReason);
		}

		public static QuestEntryFailReason GetJoinConditionsFailReason(int questDataId, [Optional] StringBuilder failedDescription, bool isHost = true)
		{
			return default(QuestEntryFailReason);
		}

		public static bool IsMainQuestAllMissionClear(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public static bool IsEventQuestAllMissionClear(int questId)
		{
			return default(bool);
		}

		public static bool IsEntryConditionPassed(QuestDataElement dataElement, ref string failedDescription, bool fetchFailedDescription)
		{
			return default(bool);
		}

		public static int GetEventCharaId(int eventId)
		{
			return default(int);
		}

		public static int GetEventCharaMaxPointValue(int charaId)
		{
			return default(int);
		}

		public static int GetEventCharaDataManagerPoint(int charaId)
		{
			return default(int);
		}

		public static int GetEventCharaQuestResultPoint(int charaId, bool beforePoint = false)
		{
			return default(int);
		}

		public static int GetCollectEventItemCount(CollectEventItemType itemType)
		{
			return default(int);
		}

		public static int GetClb01EventItemCount(int eventId, Clb01EventItemType itemType)
		{
			return default(int);
		}

		public static CharaFriendshipList GetNewCharaFriendship(CharaFriendshipList charaFriendship)
		{
			return null;
		}

		public static QuestType GetQuestTypeByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(QuestType);
		}

		public static int GetQuestIdByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(int);
		}

		public static int GetReleaseQuestIdByDifficulty(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(int);
		}

		public static bool CheckMainStoryReleaseCondition(ref int a_questID, ref QuestType a_questType, QuestSelectScene.Difficulty difficulty, QuestMainMenuElement a_qmme)
		{
			return default(bool);
		}

		public static bool IsMainQuest(int questId)
		{
			return default(bool);
		}

		public static int GetMainQuestChapterNumber(int groupId)
		{
			return default(int);
		}

		public static string GetQuestChapterName(int questId)
		{
			return null;
		}

		public static bool CheckPlayCount(int questId)
		{
			return default(bool);
		}

		public static bool CheckPlayCount(QuestDataElement dataElement)
		{
			return default(bool);
		}

		public static bool IsExist(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public static bool IsEnable(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsEnable(EventDataElement ede)
		{
			return default(bool);
		}

		public static bool IsEnable(int questGroupId, QuestSelectScene.Difficulty difficulty = QuestSelectScene.Difficulty.Normal, bool isCloseTime = false)
		{
			return default(bool);
		}

		public static bool IsQuestEventEnable(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsQuestEventGroupEnable(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsEnable(QuestEventMenuElement qeme)
		{
			return default(bool);
		}

		public static bool IsEnable(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public static bool IsEnable(QuestDataElement dataElement)
		{
			return default(bool);
		}

		public static bool IsEnableNotIsLockView(QuestDataElement dataElement)
		{
			return default(bool);
		}

		private static QuestGroupIntervalType GetIntervalType(QuestDataElement dataElement)
		{
			return default(QuestGroupIntervalType);
		}

		public static string GetEventNextStartTimeStr(QuestDataElement dataElement)
		{
			return null;
		}

		private static DateTime GetNearestDayOfWeekDateTime(DateTime date, DayOfWeek wantDayOfWeek)
		{
			return default(DateTime);
		}

		public static bool IsEnableForMatching(QuestDataElement dataElement, bool isHost)
		{
			return default(bool);
		}

		public static bool CheckLocalTime(string startTimeStr, string endTimeStr)
		{
			return default(bool);
		}

		public static bool CheckLocalTimeSetEndTime(string startTimeStr, double days)
		{
			return default(bool);
		}

		public static bool GetQuestMainGroupDurationTime(QuestMainGroupElement groupElement, out string startTime, out string endTime)
		{
			return default(bool);
		}

		public static bool GetQuestGroupDurationTime(QuestEventGroupElement groupElement, out string startTime, out string endTime, bool isCloseTime = false)
		{
			return default(bool);
		}

		public static bool GetQuestGroupDurationTime(int groupId, out string startTime, out string endTime)
		{
			return default(bool);
		}

		public static bool IsEnablePeriod(QuestMainGroupElement qmge, QuestGroupIntervalType intervalType)
		{
			return default(bool);
		}

		public static bool IsEnablePeriod(QuestEventGroupElement qege, QuestGroupIntervalType intervalType, bool isCloseTime = false)
		{
			return default(bool);
		}

		public static QuestScheduleDataWrapper GetEventSchedule(QuestEventGroupElement eventGroup, DateTime spanTime, DateTime currentTime)
		{
			return null;
		}

		public static QuestScheduleDataWrapper GetEventSchedule(int questId, DateTime spanTime, DateTime currentTime)
		{
			return null;
		}

		public static List<QuestScheduleDataWrapper> GetEventScheduleList(int questId, DateTime spanTime, DateTime currentTime)
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventGroupElement eventGroup)
		{
			return null;
		}

		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventGroupElement eventGroup, DateTime spanTime, DateTime currentTime)
		{
			return null;
		}

		public static IEnumerable<QuestScheduleDataWrapper> GetEventScheduleList(QuestEventMenuElement questEventMenu)
		{
			return null;
		}

		public static List<QuestScheduleDataWrapper> GetEventScheduleList(QuestDataElement questData)
		{
			return null;
		}

		public static void GetViewStartDate2AndViewEndDate2String(QuestDataElement questData, out string viewStartDate, out string viewEndDate)
		{
		}

		public static bool IsEventEndButNotClosed(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static DateTime GetCheckSpanTime()
		{
			return default(DateTime);
		}

		public static bool IsEnableIntervalType(QuestGroupIntervalType intervalType, DayOfWeek dayOfWeek)
		{
			return default(bool);
		}

		public static EventDataElement GetEventDataElement(int eventId)
		{
			return null;
		}

		public static bool IsEnablePeriod(EventDataElement ede)
		{
			return default(bool);
		}

		public static bool IsWaitForClosingPeriod(EventDataElement ede)
		{
			return default(bool);
		}

		public static GameObject LoadPartPrefab(string partPrefabPath, GameObject parentObj)
		{
			return null;
		}

		public static void SetupFlash(FlashPlayer flashPlayer, string path, GameObject parentObj, int sortingOrder, Vector3 localPos, float localScale = 1f, bool isAutoDestroy = true)
		{
		}

		public static void SetFlashAsync(FlashPlayer flashPlayer, string path, GameObject parentObj, int sortingOrder, Vector3 localPos, float localScale = 1f, [Optional] Action<int> action, int flashIndex = 0)
		{
		}

		public static Sprite GetLandmarkIconImage(QuestMainLocationElement qmle)
		{
			return null;
		}

		public static QuestTreasureDataElement GetQuestTreasureDataElement(int questLocationId, QuestSelectScene.Difficulty difficulty)
		{
			return null;
		}

		public static CommonPopup CheckRewardListDuplicate(DataManager.GameData<AtgenBuildEventRewardEntityList> rewardList)
		{
			return null;
		}

		public static CommonPopup CreateDuplicateConfirmPopup(string title, string text)
		{
			return null;
		}

		public static locationState GetLocationState(int locationId, QuestSelectScene.Difficulty difficulty)
		{
			return default(locationState);
		}

		public static float EaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		public static float EaseOutCirc(float t, float b, float c, float d)
		{
			return default(float);
		}

		public static float GetEaseValue(Easeing ease, float time, float fromValue, float diff, float totalTime)
		{
			return default(float);
		}

		public static T GetSceneComponent<T>(string sceneName)
		{
			return (T)null;
		}

		public static bool IsInQuestPlayTransition(bool isMatchingOK = true)
		{
			return default(bool);
		}

		public static bool IsInQuestPartyBaseScene(bool isMatchingOK = true)
		{
			return default(bool);
		}

		public static QuestPrepareData[] GetCommonPartyPowerCalculateData(MatchingService.Room room)
		{
			return null;
		}

		public static QuestPrepareData[] GetCommonPartyPowerCalculateRaidData(MatchingService.Room matching)
		{
			return null;
		}

		public static int[] GetCharacterIndex(int index, int maxPlayerCount)
		{
			return null;
		}

		public static int GetUidGrpForGuerrilla()
		{
			return default(int);
		}

		public static string GetNextQuestSceneName(int questId)
		{
			return null;
		}

		public static string GetNextSceneNameFromIngameForMultiGuest(int questId)
		{
			return null;
		}

		public static string GetNextQuestSceneName(QuestMainGroupElement groupElement)
		{
			return null;
		}

		public static string GetNextQuestSceneName(QuestEventGroupElement groupElement, int questId)
		{
			return null;
		}

		public static bool IsEventMenuTabQuest(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsEventMenuTabQuestFromQuestId(int questId)
		{
			return default(bool);
		}

		public static bool IsEventMenuTabQuest(int questGroupId)
		{
			return default(bool);
		}

		public static bool IsEventMenuTabQuest(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsVoidBattle(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsBattleRoyal(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsVoidBattle(QuestEventGroupElement qee)
		{
			return default(bool);
		}

		public static bool IsBattleRoyal(QuestEventGroupElement qee)
		{
			return default(bool);
		}

		public static bool IsAstralRaid(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsAstralRaid(QuestEventGroupElement qee)
		{
			return default(bool);
		}

		public static bool IsAstralRaid(int questId)
		{
			return default(bool);
		}

		public static bool IsSubdueQuest(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsSubdueQuest(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsSimpleEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsSimpleEvent(int eventId)
		{
			return default(bool);
		}

		public static bool IsSimpleEvent(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsRedThemeEvent(int questId)
		{
			return default(bool);
		}

		public static bool IsRedThemaNormalEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsRedThemaNormalEvent(QuestEventGroupElement qee)
		{
			return default(bool);
		}

		public static bool IsBlueThemeEvent(int questId)
		{
			return default(bool);
		}

		public static bool IsBlueThemeEvent(EventKindType eventKindType)
		{
			return default(bool);
		}

		public static bool IsBlueThemeEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsBlueThemeEvent(QuestEventGroupElement qee)
		{
			return default(bool);
		}

		public static bool IsExRush(QuestEventElement qee)
		{
			return default(bool);
		}

		public static void SetQuestConditionIcon(Image image, QuestDataElement questDataElement)
		{
		}

		public static bool IsQuestPlayFlowOnPartyScene()
		{
			return default(bool);
		}

		public static List<QSChapterElement> GetQSChapterElementList(ref bool hardEnable)
		{
			return null;
		}

		public static bool IsMatchingBPEnough(QuestDataElement questDataElement)
		{
			return default(bool);
		}

		public static bool IsQuestEntityEnough(QuestDataElement questDataElement, bool isHost = true)
		{
			return default(bool);
		}

		public static long GetQuestItem(QuestDataElement questDataElement, bool isHost = true)
		{
			return default(long);
		}

		public static bool IsSingleStaminaEnough(int questId, int playCount, out bool isStaminaMaxEnough)
		{
			return default(bool);
		}

		public static int GetQuestSingleStamina(int questId)
		{
			return default(int);
		}

		public static int CalculateSingleQuestStaminaSumCount(List<int> questIdList)
		{
			return default(int);
		}

		private static bool IsStaminaZero(QuestDataElement questData)
		{
			return default(bool);
		}

		public static bool IsMultiStaminaEnough(int questId, int playCount, out bool isStaminaMaxEnough)
		{
			return default(bool);
		}

		public static int GetQuestMultiStamina(int questId)
		{
			return default(int);
		}

		public static int GetDefaultQuestMultiStamina(int questId)
		{
			return default(int);
		}

		public static bool IsCampaignQuest(CampaignType type, int groupId)
		{
			return default(bool);
		}

		public static int GetQuestSkipTicketNum()
		{
			return default(int);
		}

		public static int GetQuestSkipTicketMax()
		{
			return default(int);
		}

		public static int GetQuestSkipTicketUse(int questId)
		{
			return default(int);
		}

		public static List<QuestMainMenuElement> GetMainMenuGroup(int locationId)
		{
			return null;
		}

		public static void SetQuestThumbnail(int questId, Image image, bool isUnknown)
		{
		}

		public static void SetQuestThumbnail(QuestDataElement questData, Image image, bool isUnknown, [Optional] Action onComplete)
		{
		}

		public static void SetQuestThumbnail(string imageMaterialStr, Image image, [Optional] Action onComplete)
		{
		}

		public static void SetMainStoryCellBg(string name, Image image, [Optional] Action onComplete)
		{
		}

		public static bool IsSingleMatchingModeEnabled(int questId)
		{
			return default(bool);
		}

		public static bool IsManyMultiBattleFlag(int questId)
		{
			return default(bool);
		}

		public static bool IsMissionCleared(QuestList ql, int index)
		{
			return default(bool);
		}

		public static bool IsMissionCompleted(QuestList ql)
		{
			return default(bool);
		}

		public static bool IsMissionAlreadyCleared(QuestList ql)
		{
			return default(bool);
		}

		public static string GetQuestNameOrStoryName(QuestType questType, int questId)
		{
			return null;
		}

		public static QRTreasureIcon.TreasureIconType GetTreasureIconType(int placeValue, QuestResultModel.TopPageModel.RewardItemInfo.PorchRarity porchRarity)
		{
			return default(QRTreasureIcon.TreasureIconType);
		}

		public static bool IsFirstMainQuestClear()
		{
			return default(bool);
		}

		public static bool IsNewLandMark(int groupId, int lastLocationId, QuestSelectScene.Difficulty type)
		{
			return default(bool);
		}

		public static QuestMainGroupElement GetLatestQuestMainGroup()
		{
			return null;
		}

		public static QuestMainGroupElement GetQuestMainGroupElementFromChapterId(int chapterNum)
		{
			return null;
		}

		public static bool EnableEventQuestCellArrow(QuestCell cell, QuestEventMenuElement prev, QuestEventMenuElement target)
		{
			return default(bool);
		}

		public static void EnableQuestCellArrow(QuestCell cell, QuestType questType, bool isArrowEnable)
		{
		}

		public static bool isEventQuestActive(int eventQuestGroupId)
		{
			return default(bool);
		}

		public static List<int> GetEventIdFormCharaId(int charaId)
		{
			return null;
		}

		public static int GetClosestEventIdFromCharaId(int charaId, out bool isOutOfPeriod)
		{
			return default(int);
		}

		public static string GetQuestBgResourcePath(int questId)
		{
			return null;
		}

		public static void ReEnterQuestSupportScene(float enterAnimationDutation, bool isNotSupport)
		{
		}

		public static void GotoQuestScene([Optional] UnityAction postLoadSceneCallback, bool isAddSceneClearInstantly = true)
		{
		}

		public static void GotoLastQuest(LastQuestType type, [Optional] UnityAction postLoadSceneCallback, bool isAddSceneClearInstantly = true)
		{
		}

		public static void SetupQuestEventBanner(GameObject bannerParent, QuestEventBanner.TargetEventType eventType, QuestEventBanner.TargetEventPeriod eventPeriod)
		{
		}

		public static bool IsEventQuestTurorialDone()
		{
			return default(bool);
		}

		public static int GetAreaPathIndex(int chapter, bool isAreaMap)
		{
			return default(int);
		}

		public static bool IsRankingPeriodByQuestId(int questId)
		{
			return default(bool);
		}

		public static bool IsRankingPeriod(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsRankingPeriod(QuestEventElement qee)
		{
			return default(bool);
		}

		public static void GetRankingInfo(int questId, out int clearTimeNum, out int rankingNum)
		{
		}

		public static string GetPayEntityName(QuestDataElement qde)
		{
			return null;
		}

		public static bool CheckRequiredStamina(GameObject gameObject, int questId, bool isMultiStamina, Action<bool> onEnough, [Optional] Action onLack, [Optional] Action onStaminaRecoveryCancelled, bool isJustCheckStaminaMaxCapacity = false, bool isRecoveredStamina = false)
		{
			return default(bool);
		}

		public static bool CheckRequiredStamina(GameObject gameObject, int questId, bool isMultiStamina, int playCount, Action<bool> onEnough, [Optional] Action onLack, [Optional] Action onStaminaRecoveryCancelled, bool isJustCheckStaminaMaxCapacity = false, bool isRecoveredStamina = false)
		{
			return default(bool);
		}

		public static void CheckStamina(GameObject destroyWatchAttach, List<int> questIdList, Action onEnough)
		{
		}

		public static bool IsInsertQuestStory(int id)
		{
			return default(bool);
		}

		public static bool IsParameterOverrideQuest(int id)
		{
			return default(bool);
		}

		public static bool IsSupportEnableQuest(int id)
		{
			return default(bool);
		}

		public static bool IsSupportEnableQuest(QuestConstraintType constraintType)
		{
			return default(bool);
		}

		public static bool IsMultiplayEnableQuest(QuestConstraintType constraintType)
		{
			return default(bool);
		}

		public static bool IsMultiplayEnableEvent(int eventId)
		{
			return default(bool);
		}

		public static Color GetNecessaryColor()
		{
			return default(Color);
		}

		public static Color GetNecessaryOutlineColor()
		{
			return default(Color);
		}

		public static Color GetRecommendedColor()
		{
			return default(Color);
		}

		public static bool IsSkipDisabledQuest(int questId)
		{
			return default(bool);
		}

		public static void OnSkipDisabledButton(int questId)
		{
		}

		public static bool IsLackOfTicket(List<int> questIdList)
		{
			return default(bool);
		}

		public static bool CheckRequiredSkipConditions(List<int> questIdList)
		{
			return default(bool);
		}

		public static bool IsMultiPlayHost()
		{
			return default(bool);
		}

		public static CellBandColorType GetCellBandColorType(int questId, int variationType)
		{
			return default(CellBandColorType);
		}

		public static bool IsUltimateDragonBattle(QuestEventElement qee)
		{
			return default(bool);
		}

		public static bool IsUltimateDragonBattle(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static bool IsQuestEventType(QuestEventGroupElement qege, QuestEventType type)
		{
			return default(bool);
		}

		public static bool IsUltimateDragonBattle(QuestDataElement qde)
		{
			return default(bool);
		}

		public static Localize.TextId GetUltimateDragonBattleDifficultyText(QuestDataElement qde)
		{
			return default(Localize.TextId);
		}

		public static bool IsDragonBattle(QuestEventElement qee)
		{
			return default(bool);
		}

		public static Localize.TextId GetMainQuestDifficulity(QuestDataElement element)
		{
			return default(Localize.TextId);
		}

		public static int GetUltimateDragonBattlePrologueId(QuestEventGroupElement groupElement)
		{
			return default(int);
		}

		public static bool IsUltimateDragonBattlePrologueDone(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static bool IsQuestPeriod(int questId)
		{
			return default(bool);
		}

		public static bool IsQuestPeriodToQuestTopOrLoginBonus(int questId)
		{
			return default(bool);
		}

		public static bool IsAllEventInterval()
		{
			return default(bool);
		}

		public static bool IsScheduleEventOpened(int eventGroupElementId)
		{
			return default(bool);
		}

		public static bool IsRaidLikeEventNowOpen()
		{
			return default(bool);
		}

		public static List<int> GetRaidEventNowOpen()
		{
			return null;
		}

		public static void GetRaidLikeEventDataIfNeeded(Action action)
		{
		}

		public static void ShowQuestEndPopup([Optional] Action callback)
		{
		}

		public static bool CheckDateChanged()
		{
			return default(bool);
		}

		public static bool CheckDateChangeStartQuest()
		{
			return default(bool);
		}

		public static bool IsFirstAndNewLandmerk()
		{
			return default(bool);
		}

		public static bool IsTresureRelease(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public static bool IsExtraBattleQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsExtraBattleQuest(QuestEventMenuElement qeme)
		{
			return default(bool);
		}

		public static bool IsRaidBattleQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsQuestBonusSelectableStack(QuestEventElement questEvent)
		{
			return default(bool);
		}

		public static int GetQuestBonusActiveStackCount(int questEventId)
		{
			return default(int);
		}

		private static int GetQuestBonusStackCount(QuestEventElement questEvent, int stackCount, int stackTime)
		{
			return default(int);
		}

		public static bool IsQuestResetted(QuestResetIntervalType resetType, int lastResetTime)
		{
			return default(bool);
		}

		public static bool IsDropUpTarget(GiftType giftType)
		{
			return default(bool);
		}

		public static bool IsPeriodQuestEvent(QuestEventType eventType)
		{
			return default(bool);
		}

		public static bool IsRankingPreriodQuestEvent(QuestEventElement eventElement)
		{
			return default(bool);
		}

		public static QuestDataElement GetRankingPreriodQuestEventForQuestData(QuestEventGroupElement groupElement)
		{
			return null;
		}

		public static bool IsRankingPeriodQuestData(QuestDataElement qde, bool isView = false)
		{
			return default(bool);
		}

		public static bool IsPersonalInformationPopup()
		{
			return default(bool);
		}

		public static void PersonalInformationPopup(Localize.TextId title, Localize.TextId difficulty, Action okButtonCallback)
		{
		}

		public static void LoadQuestSelectSceneAsync(bool isMainStoryQuest, [Optional] Action onLoadedCallback, bool needRequestEventQuest = true, bool isAddSceneClearInstantly = true, [Optional] SceneModelBase model)
		{
		}

		public static bool IsVeryHardReleased()
		{
			return default(bool);
		}

		public static bool IsQuestPrologueIdDone(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static MainStoryMissionStatus GetMainStoryMissionStatus(int questId, int entryConditionId)
		{
			return default(MainStoryMissionStatus);
		}

		public static void SaveMainStoryMissionLockEffectStatus(int questId, int entryConditionId)
		{
		}

		public static void SaveMainStoryMissionUnlockEffectStatus(int questId, int entryConditionId)
		{
		}

		public static bool IsPlayStoryMissionLockEffect(int questId, int entryConditionId)
		{
			return default(bool);
		}

		public static bool IsPlayStoryMissionUnlockEffect(int questId, int entryConditionId)
		{
			return default(bool);
		}

		public static bool IsMainQuestNewCondition(int groupId)
		{
			return default(bool);
		}

		public static List<string> GetQuestNameOrStoryNameList(QuestEventMenuElement eventMenuElement, ref bool isReleased)
		{
			return null;
		}

		public static string GetDiff(QuestDataElement questData)
		{
			return null;
		}

		public static string GetTriggetString(QuestDataElement questData)
		{
			return null;
		}

		private static string GetNotClearQuestNameOrStoryName(QuestType questType, int questId)
		{
			return null;
		}

		private static string GetSectionName(QuestType questType, int id)
		{
			return null;
		}

		public static bool IsQuestCarryQuestData(int questId)
		{
			return default(bool);
		}

		public static HashSet<int> GetQuestIdAll()
		{
			return null;
		}

		public static HashSet<int> GetClearedMainQuestIdAll()
		{
			return null;
		}

		public static HashSet<int> GetNotClearedMainQuestIdAll()
		{
			return null;
		}

		public static void GetQuestIdAllList(out HashSet<int> mainQuestIdList, out HashSet<int> notMainQuestIdList)
		{
		}

		public static void GetStoryIdAllList(out HashSet<int> mainStoryIdList, out HashSet<int> notMainStoryIdList)
		{
		}

		public static void GetSingleStoryIdList(out HashSet<int> allStoryIdList, out HashSet<int> clearedMainStoryIdList, out HashSet<int> notClearedMainStoryIdList)
		{
		}

		public static bool IsEventMenuElementQuestReleased(QuestEventMenuElement eventMenuElement)
		{
			return default(bool);
		}

		public static bool IsLimitedElementalQuest(int questId, out ElementalType limitedElementalType1, out ElementalType limitedElementalType2)
		{
			return default(bool);
		}

		public static bool IsLimitedWeaponTypeQuest(int questId, out List<WeaponType> limitedWeaponTypeList)
		{
			return default(bool);
		}

		public static bool IsSoloMultiQuestGroup(int eventGroupId)
		{
			return default(bool);
		}

		public static bool IsTimeAttackSoloQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsHighLevelQuestRelease(QuestEventMenuElement currentMenue, out QuestEventMenuElement releaseQuest)
		{
			return default(bool);
		}

		public static bool NeedCloseViewBeingHeldEvent(int eventId)
		{
			return default(bool);
		}

		public static bool NeedCloseViewBeingHeldEvent(EventDataElement eventData)
		{
			return default(bool);
		}
	}
}
