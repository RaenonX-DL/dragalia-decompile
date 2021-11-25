using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponBody : IMaster<WeaponBody>
	{
		[SerializeField]
		private WeaponBodyDictionary dict;

		public WeaponBodyDictionary Dict => null;

		public SerializableDictionary<int, WeaponBodyElement>.ValueCollection List => null;
	}
}
