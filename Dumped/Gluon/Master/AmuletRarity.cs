using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AmuletRarity : IMaster<AmuletRarity>
	{
		[SerializeField]
		private AmuletRarityDictionary dict;

		public AmuletRarityDictionary Dict => null;

		public SerializableDictionary<int, AmuletRarityElement>.ValueCollection List => null;
	}
}
