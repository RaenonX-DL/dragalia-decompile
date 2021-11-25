using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventPassive : IMaster<EventPassive>
	{
		[SerializeField]
		private EventPassiveDictionary dict;

		public EventPassiveDictionary Dict => null;

		public SerializableDictionary<int, EventPassiveElement>.ValueCollection List => null;
	}
}
