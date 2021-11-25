using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponLimitBreak : IMaster<WeaponLimitBreak>
	{
		[SerializeField]
		private WeaponLimitBreakDictionary dict;

		public WeaponLimitBreakDictionary Dict => null;

		public SerializableDictionary<int, WeaponLimitBreakElement>.ValueCollection List => null;
	}
}
