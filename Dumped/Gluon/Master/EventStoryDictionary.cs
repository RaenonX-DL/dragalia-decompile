using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EventStoryDictionary : SerializableDictionary<int, EventStoryElement>
	{
	}
}
