using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyAbility : IMaster<EnemyAbility>
	{
		[SerializeField]
		private EnemyAbilityDictionary dict;

		public EnemyAbilityDictionary Dict => null;

		public SerializableDictionary<int, EnemyAbilityElement>.ValueCollection List => null;
	}
}
