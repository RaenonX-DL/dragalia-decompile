using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AreaQuestSkillData : IMaster<AreaQuestSkillData>
	{
		[SerializeField]
		private AreaQuestSkillDataDictionary dict;

		public AreaQuestSkillDataDictionary Dict => null;

		public SerializableDictionary<int, AreaQuestSkillDataElement>.ValueCollection List => null;
	}
}
