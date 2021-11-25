using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionDailyData : IMaster<MissionDailyData>
	{
		[SerializeField]
		private MissionDailyDataDictionary dict;

		public MissionDailyDataDictionary Dict => null;

		public SerializableDictionary<int, MissionDailyDataElement>.ValueCollection List => null;
	}
}
