using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionMemoryEventData : IMaster<MissionMemoryEventData>
	{
		[SerializeField]
		private MissionMemoryEventDataDictionary dict;

		public MissionMemoryEventDataDictionary Dict => null;

		public SerializableDictionary<int, MissionMemoryEventDataElement>.ValueCollection List => null;
	}
}
