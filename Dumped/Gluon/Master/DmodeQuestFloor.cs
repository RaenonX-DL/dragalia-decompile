using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeQuestFloor : IMaster<DmodeQuestFloor>
	{
		[SerializeField]
		private DmodeQuestFloorDictionary dict;

		public DmodeQuestFloorDictionary Dict => null;

		public SerializableDictionary<int, DmodeQuestFloorElement>.ValueCollection List => null;
	}
}
