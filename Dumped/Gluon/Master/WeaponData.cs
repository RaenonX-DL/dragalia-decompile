using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponData : IMaster<WeaponData>
	{
		[SerializeField]
		private WeaponDataDictionary dict;

		public WeaponDataDictionary Dict => null;

		public SerializableDictionary<int, WeaponDataElement>.ValueCollection List => null;
	}
}
