using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeDungeonArea : IMaster<DmodeDungeonArea>
	{
		[SerializeField]
		private DmodeDungeonAreaDictionary dict;

		public DmodeDungeonAreaDictionary Dict => null;

		public SerializableDictionary<int, DmodeDungeonAreaElement>.ValueCollection List => null;
	}
}
