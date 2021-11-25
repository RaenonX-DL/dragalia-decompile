using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponBodyBuildupGroup : IMaster<WeaponBodyBuildupGroup>
	{
		[SerializeField]
		private WeaponBodyBuildupGroupDictionary dict;

		public WeaponBodyBuildupGroupDictionary Dict => null;

		public SerializableDictionary<int, WeaponBodyBuildupGroupElement>.ValueCollection List => null;
	}
}
