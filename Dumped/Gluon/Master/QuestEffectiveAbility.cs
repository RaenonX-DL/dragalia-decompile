using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestEffectiveAbility : IMaster<QuestEffectiveAbility>
	{
		[SerializeField]
		private QuestEffectiveAbilityDictionary dict;

		public QuestEffectiveAbilityDictionary Dict => null;

		public SerializableDictionary<int, QuestEffectiveAbilityElement>.ValueCollection List => null;
	}
}
