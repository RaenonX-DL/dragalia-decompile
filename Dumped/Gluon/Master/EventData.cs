using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventData : IMaster<EventData>
	{
		[SerializeField]
		private EventDataDictionary dict;

		public EventDataDictionary Dict => null;

		public SerializableDictionary<int, EventDataElement>.ValueCollection List => null;
	}
}
