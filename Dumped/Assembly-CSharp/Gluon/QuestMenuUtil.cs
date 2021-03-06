﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class QuestMenuUtil
	{
		// Fields
		public const string prefsEpigolueReleasePopup = "_QuestMenu_EpilogueReleasePopup_{0}";
	
		// Nested types
		public static class AdvancedDragonTrialsEpilogue
		{
			// Fields
			public const int eventGroupId = 21000;
			public static readonly int[] requiredQuestList;
			public static readonly int[] requiredQuestEventGroupList;
			public const int storyId = 2100001;
			public const int eventMenuGroupId = 2100001;
			public const int questEventMenuEpilogueId = 2100001;
			public const string prefsEpigolueReleasePopup = "_QuestMenu_AdvancedDragonTrialsEpilogueReleasePopup";
	
			// Constructors
			static AdvancedDragonTrialsEpilogue();
	
			// Methods
			public static bool MatchingQuestEventGroup(int eventGroupId);
			public static bool IsEpilogueReleased();
			public static bool IsEpilogueRead();
			public static bool IsEpilogueReleasePopupNoticed();
			public static void OnNoticeEpilogueReleasePopup();
			public static QuestEventMenuElement GetQuestEventMenuElem();
			public static bool IsAnyOneClearMiddleAdvancedDragon();
		}
	
		public static class AgitoTrialsEpilogue
		{
			// Fields
			public const int eventGroupId = 21900;
			public const int prologueQuestMenuWindGroupId = 21901;
			public const int prologueQuestMenuWind = 2190101;
			public static readonly int[] requiredQuestEventGroupList;
			public const int storyId = 2190001;
			public const int eventMenuGroupId = 2190001;
			public const int questEventMenuEpilogueId = 2190001;
			public const string prefsEpigolueReleasePopup = "_QuestMenu_AgitoTrialsEpilogueReleasePopup";
	
			// Nested types
			public enum AgitoLevel
			{
				Normal = 1,
				Hard = 2,
				Veryhard = 3,
				Extreme = 4
			}
	
			// Constructors
			static AgitoTrialsEpilogue();
	
			// Methods
			public static bool MatchingQuestEvent(int eventGroupId);
			public static bool MatchingQuestEventGroup(int eventGroupId);
			public static bool IsEpilogueReleased();
			public static bool IsEpilogueRead();
			public static bool IsEpilogueReleasePopupNoticed();
			public static void OnNoticeEpilogueReleasePopup();
			public static QuestEventMenuElement GetQuestEventMenuElem();
			public static bool IsReleaseAgito();
			public static bool IsAgitoTutorialStart();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public QuestDataElement qde;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal bool _IsQuestLockByDate_b__0(QuestScheduleDataWrapper e);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<EventDataElement, int> __9__22_0;
			public static Func<EventDataElement, int> __9__24_0;
			public static Func<EventDataElement, int> __9__25_0;
			public static Func<RankingTierRewardElement, int> __9__27_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetRecommendedMemoryEvents_b__22_0(EventDataElement x);
			internal int _GetOtherMemoryEvents_b__24_0(EventDataElement x);
			internal int _GetAllMemoryEvents_b__25_0(EventDataElement x);
			internal int _GetBestRankingTierReward_b__27_0(RankingTierRewardElement p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public CommonPopup popup;
			public Action okButtonCallback;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _PersonalInformationPopup_b__0();
		}
	
		// Methods
		public static bool IsEpilogueEvent(QuestEventElement qee);
		public static QuestEventGroupElement GetEpilogueQuestEventGroupElement(QuestEventElement qee);
		public static QuestStoryElement GetQuestStoryElem(QuestEventGroupElement qege);
		public static QuestEventMenuElement GetQuestEventMenuElem(QuestStoryElement qse);
		public static QuestEventMenuElement GetQuestEventMenuElem(QuestEventElement qee);
		public static bool IsEpilogueReleased(QuestEventMenuElement qeme);
		public static bool IsEpilogueReleasePopupNoticed(int eventId);
		public static void OnNoticeEpilogueReleasePopup(int eventId);
		public static QuestUtil.QuestState GetEventQuestMenuState(List<QuestEventMenuElement> menuDataList);
		private static DateTime GetNoneScheduledNextScheduleEventStartTime(QuestDataElement qde, bool useSecondSet = false);
		private static DateTime GetNoneScheduledNextScheduleEventEndTime(QuestDataElement qde, bool useSecondSet = false);
		private static string GetNoneScheduledRemainDateString(QuestDataElement questDataElement, bool useSecondSet = false);
		public static bool IsQuestLockByDate(QuestDataElement qde, out string onCellText, out string onDescriptionPUText, out string remainText);
		public static bool IsQuestLockByDate(QuestStoryElement qde, out string onCellText, out string onDescriptionPUText);
		public static bool IsMemoryEvent(QuestEventGroupElement qege);
		public static QuestEventElement GetMemoryEventQEE();
		public static bool IsMemoryEvent(QuestEventElement qee);
		public static int GetActiveMemoryEventId();
		public static List<int> GetRecommendedMemoryEvents(List<EventKindType> eventTypeList);
		public static List<int> GetRecommendedMemoryEvents(EventKindType eventType);
		public static List<int> GetOtherMemoryEvents(List<EventKindType> eventTypeList, int activeId, List<int> recommendedList);
		public static List<int> GetOtherMemoryEvents(EventKindType eventType, int activeId, List<int> recommendedList);
		public static List<int> GetAllMemoryEvents();
		public static RankingGroupDataElement GetNowRankingGroupData();
		public static RankingTierRewardElement GetBestRankingTierReward(RankingGroupDataElement rankingGroupData);
		public static bool IsNowTimeAttackPersonalInformationPopup(int eventId);
		public static void PersonalInformationPopup(int eventId, Action okButtonCallback);
	}
}
