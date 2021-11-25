using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponLevel : IMaster<WeaponLevel>
	{
		[SerializeField]
		private WeaponLevelDictionary dict;

		public WeaponLevelDictionary Dict => null;

		public SerializableDictionary<int, WeaponLevelElement>.ValueCollection List => null;
	}
}
