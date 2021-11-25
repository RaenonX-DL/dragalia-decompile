using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventTextData : IMaster<EventTextData>
	{
		[SerializeField]
		private EventTextDataDictionary dict;

		public EventTextDataDictionary Dict => null;

		public SerializableDictionary<int, EventTextDataElement>.ValueCollection List => null;
	}
}
