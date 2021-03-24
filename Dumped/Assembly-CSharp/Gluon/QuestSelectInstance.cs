/*
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
	public class QuestSelectInstance
	{
		// Fields
		private QuestOpenType questOpenType;
		private QuestFirstOpenType _questFirstOpenType;
		private QuestFirstOpenType _questLastMainFirstOpenType;
		private QuestFirstOpenType _questLastEventFirstOpenType;
		private QSGroupMode _questGroupMode;
		private bool enable;
		private MainQuestSelectInfo mainQuestSelectInfo;
		private EventQuestSelectInfo eventQuestSelectInfo;
		[CompilerGenerated]
		private int _ClbEventLocationId_k__BackingField;
		[CompilerGenerated]
		private bool _fromMyPageEventButton_k__BackingField;
		private float delayStartAnimation;
		private List<QSChapterElement> _chapterList;
		private int _newChapter;
		private long _supportlistLastUpdateUnixTime;
		private ElementalType _supportElementFilterLastType;
		public List<QuestEventData> normalEventsData;
		public List<QuestEventData> specialEventsData;
		public List<QuestEventData> rankingEventsData;
		public List<QuestEventData> challengeEventsData;
		public List<QuestEventData> highLevelEventsData;
		public const int recommendEventMaxCount = 6;
		public List<QuestEventData> recommendEventsData;
		public bool isFirst;
		[CompilerGenerated]
		private int _lastQuestId_k__BackingField;
		[CompilerGenerated]
		private int _lastQuestStoryId_k__BackingField;
		private bool _returnToChapter;
		public QuestCellData curQuestCellData;
		public bool isSkipRoot;
		public bool isNextPrepare;
	
		// Properties
		public QuestFirstOpenType questFirstOpenType { get; set; }
		public QuestFirstOpenType questLastMainFirstOpenType { get; private set; }
		public QuestFirstOpenType questLastEventFirstOpenType { get; private set; }
		public QSGroupMode nowQSGroupMode { get; set; }
		public QuestUtil.QuestState PrevMainQuestState { get; set; }
		public int EventQuestId { get; }
		public int QuestEventGroup { get; }
		public int ClbEventLocationId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool fromMyPageEventButton { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float DelayStartAnimation { get; set; }
		public List<QSChapterElement> chapterList { get; set; }
		public bool IsHardEnable { get; }
		public bool IsVeryHardEnable { get; }
		public int newChapter { get; set; }
		public long supportlistLastUpdateUnixTime { get; set; }
		public ElementalType supportElementFilterLastType { get; set; }
		public int lastQuestId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int lastQuestStoryId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool returnToChapter { get; set; }
	
		// Nested types
		public enum QuestOpenType
		{
			DEFAULT = 0,
			SHORTCUT = 1
		}
	
		public enum QuestFirstOpenType
		{
			Chapter = 0,
			Area = 1,
			Detail = 2,
			EventTop = 3,
			EventSub = 4,
			EventDetail = 5,
			EventSupport = 6,
			MemoryEvent = 7
		}
	
		public enum QSGroupMode
		{
			Main = 0,
			Event = 1
		}
	
		private class MainQuestSelectInfo
		{
			// Fields
			public QuestSelectScene.Difficulty difficulty;
			public int chapterNumber;
			public QuestMainGroupElement questMainGroup;
			public QuestMainMenuElement questMainMenuElement;
			public int mainQuestID;
			public QuestUtil.QuestState prevQuestState;
	
			// Constructors
			public MainQuestSelectInfo();
		}
	
		private class EventQuestSelectInfo
		{
			// Fields
			public int eventQuestId;
			public QuestEventMenuElement questEventMenuElement;
			public int questEventGroup;
	
			// Constructors
			public EventQuestSelectInfo();
		}
	
		public class QuestEventData
		{
			// Fields
			public QuestEventElement eventElement;
			public List<QuestEventGroupElement> eventsData;
	
			// Properties
			public EventDataElement eventDataElement { get; }
	
			// Constructors
			public QuestEventData(QuestEventElement eventElement);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass125_0
		{
			// Fields
			public QuestEventGroupElement groupElement;
			public Predicate<QuestEventGroupElement> __9__0;
			public Predicate<QuestEventGroupElement> __9__1;
			public Predicate<QuestEventGroupElement> __9__2;
			public Predicate<QuestEventGroupElement> __9__3;
	
			// Constructors
			public __c__DisplayClass125_0();
	
			// Methods
			internal bool _FindEventDataFromEventGroupElement_b__0(QuestEventGroupElement a);
			internal bool _FindEventDataFromEventGroupElement_b__1(QuestEventGroupElement a);
			internal bool _FindEventDataFromEventGroupElement_b__2(QuestEventGroupElement a);
			internal bool _FindEventDataFromEventGroupElement_b__3(QuestEventGroupElement a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0
		{
			// Fields
			public int questEventDataId;
	
			// Constructors
			public __c__DisplayClass126_0();
	
			// Methods
			internal bool _FindEventDataFromId_b__0(QuestEventData a);
			internal bool _FindEventDataFromId_b__1(QuestEventData a);
			internal bool _FindEventDataFromId_b__2(QuestEventData a);
			internal bool _FindEventDataFromId_b__3(QuestEventData a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0
		{
			// Fields
			public QuestEventElement baseEventElement;
	
			// Constructors
			public __c__DisplayClass127_0();
	
			// Methods
			internal bool _AddQuestEventGroupElementToEventData_b__0(QuestEventData a);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<QuestEventData, bool> __9__128_0;
			public static Func<QuestEventData, bool> __9__128_1;
			public static Func<QuestEventData, long> __9__128_2;
			public static Func<QuestEventData, int> __9__128_3;
			public static Func<QuestEventData, int> __9__128_4;
			public static Comparison<QuestEventGroupElement> __9__128_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SortEventsData_b__128_0(QuestEventData x);
			internal bool _SortEventsData_b__128_1(QuestEventData x);
			internal long _SortEventsData_b__128_2(QuestEventData x);
			internal int _SortEventsData_b__128_3(QuestEventData x);
			internal int _SortEventsData_b__128_4(QuestEventData x);
			internal int _SortEventsData_b__128_5(QuestEventGroupElement a, QuestEventGroupElement b);
		}
	
		// Constructors
		public QuestSelectInstance();
	
		// Methods
		public void Clear();
		public void LastQuestInfoClear();
		public void SetQuestMainGroupId(int groupId);
		public void SetSelectEventTop();
		public void SetMainQuestInfo(QuestSelectScene.Difficulty difficulty, int mainQuestId, QuestMainMenuElement qmmElement, QuestMainGroupElement questGroup, QuestOpenType openType = QuestOpenType.DEFAULT);
		public void SetEventQuestInfo(int questId, int groupId, QuestEventMenuElement qemElement, QuestOpenType openType = QuestOpenType.DEFAULT, QuestFirstOpenType type = QuestFirstOpenType.EventTop);
		public bool IsShortCuttingQuestSelect();
		public void ResetQuestOpenType();
		public void SetChapterInfo(int groupId, QuestSelectScene.Difficulty a_difficulty);
		public void SetAreaInfo(int groupId, QuestSelectScene.Difficulty a_difficulty);
		public void SetSelectLandMarkQuestInfo(int locationId);
		public void SetDifficultyInfo(QuestSelectScene.Difficulty diff);
		public void GetCurChapterInfo(out int groupId, out QuestSelectScene.Difficulty a_difficulty);
		public bool CheckLastQuestIdValid();
		public void LoadQuestInfoCheck();
		public void LoadQuestInfo(bool noChangeChapter = false);
		public void NewChapterCheck();
		public int NewReleaseChack();
		private bool IsQuestEntry(QuestMainMenuElement qmm);
		private bool DataCheck(int groupId);
		private void Reset();
		public void SetChapterList(List<QSChapterElement> a_chapterList);
		public bool IsEnable();
		public QuestSelectScene.Difficulty GetDifficulty();
		public void SetDifficulty(QuestSelectScene.Difficulty dif);
		public int GetChapterNumber();
		public int GetCurrentMaxChapter(QuestSelectScene.Difficulty difficulty);
		public void SetChapterNumber(int number);
		public QuestMainGroupElement GetQuestMainGroupElement();
		public QuestMainMenuElement GetQuestMainMenuElement();
		public QuestEventMenuElement GetQuestEventMenuElement();
		public void SetQuestEventMenuElement(QuestEventMenuElement value);
		public int GetMainQuestID();
		public List<QSChapterElement> GetChapterList();
		public QSChapterElement GetChapterData(int index);
		public int GetGuestCharacterId(int questId);
		public void ClearAllEventLists();
		public QuestEventData FindEventDataFromEventGroupElement(QuestEventGroupElement groupElement);
		public QuestEventData FindEventDataFromId(int questEventDataId);
		private void AddQuestEventGroupElementToEventData(QuestEventGroupElement groupElement, QuestEventElement baseEventElement, List<QuestEventData> eventsData);
		private void SortEventsData(ref List<QuestEventData> eventsData);
		private void FindRecommendEvent(List<QuestEventData> eventsData);
		public static void RefreshEventData(QuestEventData eventData);
		public void LoadEventData();
		public bool IsEnable(QuestMainMenuElement qmme, QuestSelectScene.Difficulty dif);
		public bool IsExist(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty);
		public bool IsAppear(QuestMainMenuElement a_qmme, QuestSelectScene.Difficulty difficulty);
		public bool IsMainQuestFirstOpenType(QuestFirstOpenType type);
		public bool IsEventQuestFirstOpenType(QuestFirstOpenType type);
		public int GetLastMainQuestClearState();
		public bool IsLastMainQuestIdFirstClear(int questId);
	}
}
