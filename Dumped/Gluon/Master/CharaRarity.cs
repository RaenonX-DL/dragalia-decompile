using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaRarity : IMaster<CharaRarity>
	{
		[SerializeField]
		private CharaRarityDictionary dict;

		public CharaRarityDictionary Dict => null;

		public SerializableDictionary<int, CharaRarityElement>.ValueCollection List => null;
	}
}
