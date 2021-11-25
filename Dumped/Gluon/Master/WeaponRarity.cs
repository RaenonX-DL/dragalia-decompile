using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponRarity : IMaster<WeaponRarity>
	{
		[SerializeField]
		private WeaponRarityDictionary dict;

		public WeaponRarityDictionary Dict => null;

		public SerializableDictionary<int, WeaponRarityElement>.ValueCollection List => null;
	}
}
