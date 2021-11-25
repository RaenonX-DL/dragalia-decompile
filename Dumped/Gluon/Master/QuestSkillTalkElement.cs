using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestSkillTalkElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private QuestSkillEnum _QuestSkillName;

		[SerializeField]
		private int _QuestSkillLevel;

		[SerializeField]
		private int _TalkId;

		[SerializeField]
		private QuestSkillTalkTrigger _Trigger;

		[SerializeField]
		private int _IntValue01;

		[SerializeField]
		private int _IsPlayPlural;

		public int Id => default(int);

		public QuestSkillEnum QuestSkillName => default(QuestSkillEnum);

		public int QuestSkillLevel => default(int);

		public int TalkId => default(int);

		public QuestSkillTalkTrigger Trigger => default(QuestSkillTalkTrigger);

		public int IntValue01 => default(int);

		public int IsPlayPlural => default(int);
	}
}
