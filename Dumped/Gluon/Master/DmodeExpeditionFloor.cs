using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeExpeditionFloor : IMaster<DmodeExpeditionFloor>
	{
		[SerializeField]
		private DmodeExpeditionFloorDictionary dict;

		public DmodeExpeditionFloorDictionary Dict => null;

		public SerializableDictionary<int, DmodeExpeditionFloorElement>.ValueCollection List => null;
	}
}
