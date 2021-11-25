using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonRarity : IMaster<DragonRarity>
	{
		[SerializeField]
		private DragonRarityDictionary dict;

		public DragonRarityDictionary Dict => null;

		public SerializableDictionary<int, DragonRarityElement>.ValueCollection List => null;
	}
}
