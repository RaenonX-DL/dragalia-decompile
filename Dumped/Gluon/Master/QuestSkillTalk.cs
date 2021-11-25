using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestSkillTalk : IMaster<QuestSkillTalk>
	{
		[SerializeField]
		private QuestSkillTalkDictionary dict;

		public QuestSkillTalkDictionary Dict => null;

		public SerializableDictionary<int, QuestSkillTalkElement>.ValueCollection List => null;
	}
}
