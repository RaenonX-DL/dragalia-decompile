using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionPeriodData : IMaster<MissionPeriodData>
	{
		[SerializeField]
		private MissionPeriodDataDictionary dict;

		public MissionPeriodDataDictionary Dict => null;

		public SerializableDictionary<int, MissionPeriodDataElement>.ValueCollection List => null;
	}
}
