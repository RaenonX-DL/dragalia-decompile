using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DungeonAreaPlannerData : IMaster<DungeonAreaPlannerData>
	{
		[SerializeField]
		private DungeonAreaPlannerDataDictionary dict;

		public DungeonAreaPlannerDataDictionary Dict => null;

		public SerializableDictionary<int, DungeonAreaPlannerDataElement>.ValueCollection List => null;
	}
}
