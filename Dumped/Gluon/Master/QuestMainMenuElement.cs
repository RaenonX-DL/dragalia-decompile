using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestMainMenuElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _LocationId;

		[SerializeField]
		private int _LocationNumber;

		[SerializeField]
		private int _BandColorId1;

		[SerializeField]
		private QuestType _EntryQuestType1;

		[SerializeField]
		private int _EntryQuestId1;

		[SerializeField]
		private QuestType _ReleaseQuestType1;

		[SerializeField]
		private int _ReleaseQuestId1;

		[SerializeField]
		private int _BandColorId2;

		[SerializeField]
		private QuestType _EntryQuestType2;

		[SerializeField]
		private int _EntryQuestId2;

		[SerializeField]
		private QuestType _ReleaseQuestType2;

		[SerializeField]
		private int _ReleaseQuestId2;

		[SerializeField]
		private int _BandColorId3;

		[SerializeField]
		private QuestType _EntryQuestType3;

		[SerializeField]
		private int _EntryQuestId3;

		[SerializeField]
		private QuestType _ReleaseQuestType3;

		[SerializeField]
		private int _ReleaseQuestId3;

		public int Id => default(int);

		public int GroupId => default(int);

		public int LocationId => default(int);

		public int LocationNumber => default(int);

		public int BandColorId1 => default(int);

		public QuestType EntryQuestType1 => default(QuestType);

		public int EntryQuestId1 => default(int);

		public QuestType ReleaseQuestType1 => default(QuestType);

		public int ReleaseQuestId1 => default(int);

		public int BandColorId2 => default(int);

		public QuestType EntryQuestType2 => default(QuestType);

		public int EntryQuestId2 => default(int);

		public QuestType ReleaseQuestType2 => default(QuestType);

		public int ReleaseQuestId2 => default(int);

		public int BandColorId3 => default(int);

		public QuestType EntryQuestType3 => default(QuestType);

		public int EntryQuestId3 => default(int);

		public QuestType ReleaseQuestType3 => default(QuestType);

		public int ReleaseQuestId3 => default(int);
	}
}
