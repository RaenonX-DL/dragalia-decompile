using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AreaQuestSkillDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _AreaId;

		[SerializeField]
		private int _Difficulty;

		[SerializeField]
		private QuestSkillEnum _QuestSkillName1;

		[SerializeField]
		private string _GimmickLabel1;

		public int Id => default(int);

		public string AreaId => null;

		public int Difficulty => default(int);

		public QuestSkillEnum QuestSkillName1 => default(QuestSkillEnum);

		public string GimmickLabel1 => null;
	}
}
