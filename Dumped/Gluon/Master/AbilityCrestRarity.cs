using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrestRarity : IMaster<AbilityCrestRarity>
	{
		[SerializeField]
		private AbilityCrestRarityDictionary dict;

		public AbilityCrestRarityDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestRarityElement>.ValueCollection List => null;
	}
}
