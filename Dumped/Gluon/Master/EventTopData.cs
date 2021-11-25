using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventTopData : IMaster<EventTopData>
	{
		[SerializeField]
		private EventTopDataDictionary dict;

		public EventTopDataDictionary Dict => null;

		public SerializableDictionary<int, EventTopDataElement>.ValueCollection List => null;
	}
}
