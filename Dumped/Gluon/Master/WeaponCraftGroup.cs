using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponCraftGroup : IMaster<WeaponCraftGroup>
	{
		[SerializeField]
		private WeaponCraftGroupDictionary dict;

		public WeaponCraftGroupDictionary Dict => null;

		public SerializableDictionary<int, WeaponCraftGroupElement>.ValueCollection List => null;
	}
}
