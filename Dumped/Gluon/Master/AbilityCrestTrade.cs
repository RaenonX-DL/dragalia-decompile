using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityCrestTrade : IMaster<AbilityCrestTrade>
	{
		[SerializeField]
		private AbilityCrestTradeDictionary dict;

		public AbilityCrestTradeDictionary Dict => null;

		public SerializableDictionary<int, AbilityCrestTradeElement>.ValueCollection List => null;
	}
}
