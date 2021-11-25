using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponCraftWeaponSet : IMaster<WeaponCraftWeaponSet>
	{
		[SerializeField]
		private WeaponCraftWeaponSetDictionary dict;

		public WeaponCraftWeaponSetDictionary Dict => null;

		public SerializableDictionary<int, WeaponCraftWeaponSetElement>.ValueCollection List => null;
	}
}
