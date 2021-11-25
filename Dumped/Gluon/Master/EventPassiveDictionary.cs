using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EventPassiveDictionary : SerializableDictionary<int, EventPassiveElement>
	{
	}
}
