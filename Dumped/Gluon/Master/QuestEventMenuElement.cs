using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestEventMenuElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _QuestSubType;

		[SerializeField]
		private int _IsHideQuestList;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _IsEpilogue;

		[SerializeField]
		private int _BandColorId;

		[SerializeField]
		private QuestType _EntryQuestType;

		[SerializeField]
		private int _EntryQuestId;

		[SerializeField]
		private QuestReleaseCompareType _ReleaseCompareType;

		[SerializeField]
		private QuestType _ReleaseQuestType1;

		[SerializeField]
		private int _ReleaseQuestId1;

		[SerializeField]
		private QuestType _ReleaseQuestType2;

		[SerializeField]
		private int _ReleaseQuestId2;

		[SerializeField]
		private QuestType _ReleaseQuestType3;

		[SerializeField]
		private int _ReleaseQuestId3;

		[SerializeField]
		private QuestType _ReleaseQuestType4;

		[SerializeField]
		private int _ReleaseQuestId4;

		[SerializeField]
		private QuestType _ReleaseQuestType5;

		[SerializeField]
		private int _ReleaseQuestId5;

		[SerializeField]
		private QuestType _ReleaseQuestType6;

		[SerializeField]
		private int _ReleaseQuestId6;

		[SerializeField]
		private QuestType _ReleaseQuestType7;

		[SerializeField]
		private int _ReleaseQuestId7;

		[SerializeField]
		private QuestType _ReleaseQuestType8;

		[SerializeField]
		private int _ReleaseQuestId8;

		[SerializeField]
		private QuestType _ReleaseQuestType9;

		[SerializeField]
		private int _ReleaseQuestId9;

		[SerializeField]
		private QuestType _ReleaseQuestType10;

		[SerializeField]
		private int _ReleaseQuestId10;

		[SerializeField]
		private QuestType _ReleaseQuestType;

		[SerializeField]
		private int _ReleaseQuestId;

		[SerializeField]
		private string _ReleaseConditionText;

		[SerializeField]
		private int _IsAppearQuest;

		[SerializeField]
		private int _AppearParentQuestId1;

		[SerializeField]
		private int _AppearParentQuestId2;

		public int Id => default(int);

		public int GroupId => default(int);

		public int QuestSubType => default(int);

		public int IsHideQuestList => default(int);

		public int SortId => default(int);

		public int IsEpilogue => default(int);

		public int BandColorId => default(int);

		public QuestType EntryQuestType => default(QuestType);

		public int EntryQuestId => default(int);

		public QuestReleaseCompareType ReleaseCompareType => default(QuestReleaseCompareType);

		public QuestType ReleaseQuestType1 => default(QuestType);

		public int ReleaseQuestId1 => default(int);

		public QuestType ReleaseQuestType2 => default(QuestType);

		public int ReleaseQuestId2 => default(int);

		public QuestType ReleaseQuestType3 => default(QuestType);

		public int ReleaseQuestId3 => default(int);

		public QuestType ReleaseQuestType4 => default(QuestType);

		public int ReleaseQuestId4 => default(int);

		public QuestType ReleaseQuestType5 => default(QuestType);

		public int ReleaseQuestId5 => default(int);

		public QuestType ReleaseQuestType6 => default(QuestType);

		public int ReleaseQuestId6 => default(int);

		public QuestType ReleaseQuestType7 => default(QuestType);

		public int ReleaseQuestId7 => default(int);

		public QuestType ReleaseQuestType8 => default(QuestType);

		public int ReleaseQuestId8 => default(int);

		public QuestType ReleaseQuestType9 => default(QuestType);

		public int ReleaseQuestId9 => default(int);

		public QuestType ReleaseQuestType10 => default(QuestType);

		public int ReleaseQuestId10 => default(int);

		public QuestType ReleaseQuestType => default(QuestType);

		public int ReleaseQuestId => default(int);

		public string ReleaseConditionText => null;

		public int IsAppearQuest => default(int);

		public int AppearParentQuestId1 => default(int);

		public int AppearParentQuestId2 => default(int);
	}
}
