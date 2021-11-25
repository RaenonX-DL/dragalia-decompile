using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CombatEventLocation : IMaster<CombatEventLocation>
	{
		[SerializeField]
		private CombatEventLocationDictionary dict;

		public CombatEventLocationDictionary Dict => null;

		public SerializableDictionary<int, CombatEventLocationElement>.ValueCollection List => null;
	}
}
