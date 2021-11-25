using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class UnionAbility : IMaster<UnionAbility>
	{
		[SerializeField]
		private UnionAbilityDictionary dict;

		public UnionAbilityDictionary Dict => null;

		public SerializableDictionary<int, UnionAbilityElement>.ValueCollection List => null;
	}
}
