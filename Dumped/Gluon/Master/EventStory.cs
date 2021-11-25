using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EventStory : IMaster<EventStory>
	{
		[SerializeField]
		private EventStoryDictionary dict;

		public EventStoryDictionary Dict => null;

		public SerializableDictionary<int, EventStoryElement>.ValueCollection List => null;
	}
}
