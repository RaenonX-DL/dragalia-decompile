using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestSkillHolyLight : IMaster<QuestSkillHolyLight>
	{
		[SerializeField]
		private QuestSkillHolyLightDictionary dict;

		public QuestSkillHolyLightDictionary Dict => null;

		public SerializableDictionary<string, QuestSkillHolyLightElement>.ValueCollection List => null;
	}
}
