using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventTradeGroup : IMaster<EventTradeGroup>
	{
		[SerializeField]
		private EventTradeGroupDictionary dict;

		public EventTradeGroupDictionary Dict => null;

		public SerializableDictionary<int, EventTradeGroupElement>.ValueCollection List => null;
	}
}
