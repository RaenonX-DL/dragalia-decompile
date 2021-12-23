using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeDungeonItemData : IMaster<DmodeDungeonItemData>
	{
		[SerializeField]
		private DmodeDungeonItemDataDictionary dict;

		public DmodeDungeonItemDataDictionary Dict => null;

		public SerializableDictionary<int, DmodeDungeonItemDataElement>.ValueCollection List => null;
	}
}
