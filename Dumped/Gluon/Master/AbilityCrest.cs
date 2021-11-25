using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrest : IMaster<AbilityCrest>
	{
		[SerializeField]
		private AbilityCrestDictionary dict;

		public AbilityCrestDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestElement>.ValueCollection List => null;
	}
}
