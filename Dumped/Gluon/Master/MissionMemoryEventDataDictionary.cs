using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MissionMemoryEventDataDictionary : SerializableDictionary<int, MissionMemoryEventDataElement>
	{
	}
}
