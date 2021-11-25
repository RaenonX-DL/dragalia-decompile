using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EventDataDictionary : SerializableDictionary<int, EventDataElement>
	{
	}
}
