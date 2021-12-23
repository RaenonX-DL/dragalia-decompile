using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeAbilityCrest : IMaster<DmodeAbilityCrest>
	{
		[SerializeField]
		private DmodeAbilityCrestDictionary dict;

		public DmodeAbilityCrestDictionary Dict => null;

		public SerializableDictionary<int, DmodeAbilityCrestElement>.ValueCollection List => null;
	}
}
