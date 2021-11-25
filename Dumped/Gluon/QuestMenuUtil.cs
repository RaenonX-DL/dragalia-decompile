using System;
using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public static class QuestMenuUtil
	{
		public static class AdvancedDragonTrialsEpilogue
		{
			public const int eventGroupId = 21000;

			public static readonly int[] requiredQuestList;

			public static readonly int[] requiredQuestEventGroupList;

			public const int storyId = 2100001;

			public const int eventMenuGroupId = 2100001;

			public const int questEventMenuEpilogueId = 2100001;

			public const string prefsEpigolueReleasePopup = "_QuestMenu_AdvancedDragonTrialsEpilogueReleasePopup";

			public static bool MatchingQuestEventGroup(int eventGroupId)
			{
				return default(bool);
			}

			public static bool IsEpilogueReleased()
			{
				return default(bool);
			}

			public static bool IsEpilogueRead()
			{
				return default(bool);
			}

			public static bool IsEpilogueReleasePopupNoticed()
			{
				return default(bool);
			}

			public static void OnNoticeEpilogueReleasePopup()
			{
			}

			public static QuestEventMenuElement GetQuestEventMenuElem()
			{
				return null;
			}

			public static bool IsAnyOneClearMiddleAdvancedDragon()
			{
				return default(bool);
			}
		}

		public static class AgitoTrialsEpilogue
		{
			public enum AgitoLevel
			{
				Normal = 1,
				Hard,
				Veryhard,
				Extreme
			}

			public const int eventGroupId = 21900;

			public const int prologueQuestMenuWindGroupId = 21901;

			public const int prologueQuestMenuWind = 2190101;

			public static readonly int[] requiredQuestEventGroupList;

			public const int storyId = 2190001;

			public const int eventMenuGroupId = 2190001;

			public const int questEventMenuEpilogueId = 2190001;

			public const string prefsEpigolueReleasePopup = "_QuestMenu_AgitoTrialsEpilogueReleasePopup";

			public static bool MatchingQuestEvent(int eventGroupId)
			{
				return default(bool);
			}

			public static bool MatchingQuestEventGroup(int eventGroupId)
			{
				return default(bool);
			}

			public static bool IsEpilogueReleased()
			{
				return default(bool);
			}

			public static bool IsEpilogueRead()
			{
				return default(bool);
			}

			public static bool IsEpilogueReleasePopupNoticed()
			{
				return default(bool);
			}

			public static void OnNoticeEpilogueReleasePopup()
			{
			}

			public static QuestEventMenuElement GetQuestEventMenuElem()
			{
				return null;
			}

			public static bool IsReleaseAgito()
			{
				return default(bool);
			}

			public static bool IsAgitoTutorialStart()
			{
				return default(bool);
			}
		}

		public const string prefsEpigolueReleasePopup = "_QuestMenu_EpilogueReleasePopup_{0}";

		public static bool IsEpilogueEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static QuestEventGroupElement GetEpilogueQuestEventGroupElement(QuestEventElement qee)
		{
			return null;
		}

		public static QuestStoryElement GetQuestStoryElem(QuestEventGroupElement qege)
		{
			return null;
		}

		public static QuestEventMenuElement GetQuestEventMenuElem(QuestStoryElement qse)
		{
			return null;
		}

		public static QuestEventMenuElement GetQuestEventMenuElem(QuestEventElement qee)
		{
			return null;
		}

		public static bool IsEpilogueReleased(QuestEventMenuElement qeme)
		{
			return default(bool);
		}

		public static bool IsEpilogueReleasePopupNoticed(int eventId)
		{
			return default(bool);
		}

		public static void OnNoticeEpilogueReleasePopup(int eventId)
		{
		}

		public static QuestUtil.QuestState GetEventQuestMenuState(List<QuestEventMenuElement> menuDataList)
		{
			return default(QuestUtil.QuestState);
		}

		private static DateTime GetNoneScheduledNextScheduleEventStartTime(QuestDataElement qde, bool useSecondSet = false)
		{
			return default(DateTime);
		}

		private static DateTime GetNoneScheduledNextScheduleEventEndTime(QuestDataElement qde, bool useSecondSet = false)
		{
			return default(DateTime);
		}

		private static string GetNoneScheduledRemainDateString(QuestDataElement questDataElement, bool useSecondSet = false)
		{
			return null;
		}

		public static bool IsQuestLockByDate(QuestDataElement qde, out string onCellText, out string onDescriptionPUText, out string remainText)
		{
			return default(bool);
		}

		public static bool IsQuestLockByDate(QuestStoryElement qde, out string onCellText, out string onDescriptionPUText)
		{
			return default(bool);
		}

		public static bool IsMemoryEvent(QuestEventGroupElement qege)
		{
			return default(bool);
		}

		public static QuestEventElement GetMemoryEventQEE()
		{
			return null;
		}

		public static bool IsMemoryEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static int GetActiveMemoryEventId()
		{
			return default(int);
		}

		public static List<int> GetRecommendedMemoryEvents(List<EventKindType> eventTypeList)
		{
			return null;
		}

		public static List<int> GetRecommendedMemoryEvents(EventKindType eventType)
		{
			return null;
		}

		public static List<int> GetOtherMemoryEvents(List<EventKindType> eventTypeList, int activeId, List<int> recommendedList)
		{
			return null;
		}

		public static List<int> GetOtherMemoryEvents(EventKindType eventType, int activeId, List<int> recommendedList)
		{
			return null;
		}

		public static List<int> GetAllMemoryEvents()
		{
			return null;
		}

		public static RankingGroupDataElement GetNowRankingGroupData()
		{
			return null;
		}

		public static RankingTierRewardElement GetBestRankingTierReward(RankingGroupDataElement rankingGroupData)
		{
			return null;
		}

		public static bool IsNowTimeAttackPersonalInformationPopup(int eventId)
		{
			return default(bool);
		}

		public static void PersonalInformationPopup(int eventId, Action okButtonCallback)
		{
		}
	}
}
