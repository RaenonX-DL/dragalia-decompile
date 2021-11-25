using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CombatEventItem : IMaster<CombatEventItem>
	{
		[SerializeField]
		private CombatEventItemDictionary dict;

		public CombatEventItemDictionary Dict => null;

		public SerializableDictionary<int, CombatEventItemElement>.ValueCollection List => null;
	}
}
