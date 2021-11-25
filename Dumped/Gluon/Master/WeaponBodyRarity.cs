using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponBodyRarity : IMaster<WeaponBodyRarity>
	{
		[SerializeField]
		private WeaponBodyRarityDictionary dict;

		public WeaponBodyRarityDictionary Dict => null;

		public SerializableDictionary<int, WeaponBodyRarityElement>.ValueCollection List => null;
	}
}
