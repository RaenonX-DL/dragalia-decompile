using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DungeonItemData : IMaster<DungeonItemData>
	{
		[SerializeField]
		private DungeonItemDataDictionary dict;

		public DungeonItemDataDictionary Dict => null;

		public SerializableDictionary<int, DungeonItemDataElement>.ValueCollection List => null;
	}
}
