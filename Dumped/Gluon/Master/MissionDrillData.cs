using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionDrillData : IMaster<MissionDrillData>
	{
		[SerializeField]
		private MissionDrillDataDictionary dict;

		public MissionDrillDataDictionary Dict => null;

		public SerializableDictionary<int, MissionDrillDataElement>.ValueCollection List => null;
	}
}
