using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionDrillGroup : IMaster<MissionDrillGroup>
	{
		[SerializeField]
		private MissionDrillGroupDictionary dict;

		public MissionDrillGroupDictionary Dict => null;

		public SerializableDictionary<int, MissionDrillGroupElement>.ValueCollection List => null;
	}
}
