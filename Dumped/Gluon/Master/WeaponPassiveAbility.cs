using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponPassiveAbility : IMaster<WeaponPassiveAbility>
	{
		[SerializeField]
		private WeaponPassiveAbilityDictionary dict;

		public WeaponPassiveAbilityDictionary Dict => null;

		public SerializableDictionary<int, WeaponPassiveAbilityElement>.ValueCollection List => null;
	}
}
