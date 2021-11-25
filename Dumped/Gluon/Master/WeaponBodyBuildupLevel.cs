using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponBodyBuildupLevel : IMaster<WeaponBodyBuildupLevel>
	{
		[SerializeField]
		private WeaponBodyBuildupLevelDictionary dict;

		public WeaponBodyBuildupLevelDictionary Dict => null;

		public SerializableDictionary<int, WeaponBodyBuildupLevelElement>.ValueCollection List => null;
	}
}
