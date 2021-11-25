using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class QuestSelectInstance
	{
		public enum QuestOpenType
		{
			DEFAULT,
			SHORTCUT
		}

		public enum QuestFirstOpenType
		{
			Chapter,
			Area,
			Detail,
			EventTop,
			EventSub,
			EventDetail,
			EventSupport,
			MemoryEvent
		}

		public enum QSGroupMode
		{
			Main,
			Event
		}

		private class MainQuestSelectInfo
		{
			public QuestSelectScene.Difficulty difficulty;

			public int chapterNumber;

			public QuestMainGroupElement questMainGroup;

			public QuestMainMenuElement questMainMenuElement;

			public int mainQuestID;

			public QuestUtil.QuestState prevQuestState;
		}

		private class EventQuestSelectInfo
		{
			public int eventQuestId;

			public QuestEventMenuElement questEventMenuElement;

			public int questEventGroup;
		}

		public class QuestEventData
		{
			public QuestEventElement eventElement;

			public List<QuestEventGroupElement> eventsData;

			public EventDataElement eventDataElement => null;

			public QuestEventData(QuestEventElement eventElement)
			{
			}
		}

		private QuestOpenType questOpenType;

		private QuestFirstOpenType _questFirstOpenType;

		private QuestFirstOpenType _questLastMainFirstOpenType;

		private QuestFirstOpenType _questLastEventFirstOpenType;

		private QSGroupMode _questGroupMode;

		private bool enable;

		private MainQuestSelectInfo mainQuestSelectInfo;

		private EventQuestSelectInfo eventQuestSelectInfo;

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

		private bool _returnToChapter;

		public QuestCellData curQuestCellData;

		public bool isSkipRoot;

		public bool isNextPrepare;

		public QuestFirstOpenType questFirstOpenType
		{
			get
			{
				return default(QuestFirstOpenType);
			}
			set
			{
			}
		}

		public QuestFirstOpenType questLastMainFirstOpenType
		{
			get
			{
				return default(QuestFirstOpenType);
			}
			private set
			{
			}
		}

		public QuestFirstOpenType questLastEventFirstOpenType
		{
			get
			{
				return default(QuestFirstOpenType);
			}
			private set
			{
			}
		}

		public QSGroupMode nowQSGroupMode
		{
			get
			{
				return default(QSGroupMode);
			}
			set
			{
			}
		}

		public QuestUtil.QuestState PrevMainQuestState
		{
			get
			{
				return default(QuestUtil.QuestState);
			}
			set
			{
			}
		}

		public int EventQuestId => default(int);

		public int QuestEventGroup => default(int);

		public int ClbEventLocationId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool fromMyPageEventButton
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

		public float DelayStartAnimation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public List<QSChapterElement> chapterList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsHardEnable => default(bool);

		public bool IsVeryHardEnable => default(bool);

		public int newChapter
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public long supportlistLastUpdateUnixTime
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public ElementalType supportElementFilterLastType
		{
			get
			{
				return default(ElementalType);
			}
			set
			{
			}
		}

		public int lastQuestId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int lastQuestStoryId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool returnToChapter
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		public void LastQuestInfoClear()
		{
		}

		public void SetQuestMainGroupId(int groupId)
		{
		}

		public void SetSelectEventTop()
		{
		}

		public void SetMainQuestInfo(QuestSelectScene.Difficulty difficulty, int mainQuestId, QuestMainMenuElement qmmElement, QuestMainGroupElement questGroup, QuestOpenType openType = QuestOpenType.DEFAULT)
		{
		}

		public void SetEventQuestInfo(int questId, int groupId, QuestEventMenuElement qemElement, QuestOpenType openType = QuestOpenType.DEFAULT, QuestFirstOpenType type = QuestFirstOpenType.EventTop)
		{
		}

		public bool IsShortCuttingQuestSelect()
		{
			return default(bool);
		}

		public void ResetQuestOpenType()
		{
		}

		public void SetChapterInfo(int groupId, QuestSelectScene.Difficulty a_difficulty)
		{
		}

		public void SetAreaInfo(int groupId, QuestSelectScene.Difficulty a_difficulty)
		{
		}

		public void SetSelectLandMarkQuestInfo(int locationId)
		{
		}

		public void SetDifficultyInfo(QuestSelectScene.Difficulty diff)
		{
		}

		public void GetCurChapterInfo(out int groupId, out QuestSelectScene.Difficulty a_difficulty)
		{
		}

		public bool CheckLastQuestIdValid()
		{
			return default(bool);
		}

		public void LoadQuestInfoCheck()
		{
		}

		public void LoadQuestInfo(bool noChangeChapter = false)
		{
		}

		public void NewChapterCheck()
		{
		}

		public int NewReleaseChack()
		{
			return default(int);
		}

		private bool IsQuestEntry(QuestMainMenuElement qmm)
		{
			return default(bool);
		}

		private bool DataCheck(int groupId)
		{
			return default(bool);
		}

		private void Reset()
		{
		}

		public void SetChapterList(List<QSChapterElement> a_chapterList)
		{
		}

		public bool IsEnable()
		{
			return default(bool);
		}

		public QuestSelectScene.Difficulty GetDifficulty()
		{
			return default(QuestSelectScene.Difficulty);
		}

		public void SetDifficulty(QuestSelectScene.Difficulty dif)
		{
		}

		public int GetChapterNumber()
		{
			return default(int);
		}

		public int GetCurrentMaxChapter(QuestSelectScene.Difficulty difficulty)
		{
			return default(int);
		}

		public void SetChapterNumber(int number)
		{
		}

		public QuestMainGroupElement GetQuestMainGroupElement()
		{
			return null;
		}

		public QuestMainMenuElement GetQuestMainMenuElement()
		{
			return null;
		}

		public QuestEventMenuElement GetQuestEventMenuElement()
		{
			return null;
		}

		public void SetQuestEventMenuElement(QuestEventMenuElement value)
		{
		}

		public int GetMainQuestID()
		{
			return default(int);
		}

		public List<QSChapterElement> GetChapterList()
		{
			return null;
		}

		public QSChapterElement GetChapterData(int index)
		{
			return null;
		}

		public int GetGuestCharacterId(int questId)
		{
			return default(int);
		}

		public void ClearAllEventLists()
		{
		}

		public QuestEventData FindEventDataFromEventGroupElement(QuestEventGroupElement groupElement)
		{
			return null;
		}

		public QuestEventData FindEventDataFromId(int questEventDataId)
		{
			return null;
		}

		private void AddQuestEventGroupElementToEventData(QuestEventGroupElement groupElement, QuestEventElement baseEventElement, List<QuestEventData> eventsData)
		{
		}

		private void SortEventsData(ref List<QuestEventData> eventsData)
		{
		}

		private void FindRecommendEvent(List<QuestEventData> eventsData)
		{
		}

		public static void RefreshEventData(QuestEventData eventData)
		{
		}

		public void LoadEventData()
		{
		}

		public bool IsEnable(QuestMainMenuElement qmme, QuestSelectScene.Difficulty dif)
		{
			return default(bool);
		}

		public bool IsExist(QuestMainMenuElement qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public bool IsAppear(QuestMainMenuElement a_qmme, QuestSelectScene.Difficulty difficulty)
		{
			return default(bool);
		}

		public bool IsMainQuestFirstOpenType(QuestFirstOpenType type)
		{
			return default(bool);
		}

		public bool IsEventQuestFirstOpenType(QuestFirstOpenType type)
		{
			return default(bool);
		}

		public int GetLastMainQuestClearState()
		{
			return default(int);
		}

		public bool IsLastMainQuestIdFirstClear(int questId)
		{
			return default(bool);
		}
	}
}
