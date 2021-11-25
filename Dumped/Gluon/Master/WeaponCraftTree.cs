using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponCraftTree : IMaster<WeaponCraftTree>
	{
		[SerializeField]
		private WeaponCraftTreeDictionary dict;

		public WeaponCraftTreeDictionary Dict => null;

		public SerializableDictionary<int, WeaponCraftTreeElement>.ValueCollection List => null;
	}
}
