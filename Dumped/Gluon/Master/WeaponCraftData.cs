using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponCraftData : IMaster<WeaponCraftData>
	{
		[SerializeField]
		private WeaponCraftDataDictionary dict;

		public WeaponCraftDataDictionary Dict => null;

		public SerializableDictionary<int, WeaponCraftDataElement>.ValueCollection List => null;
	}
}
