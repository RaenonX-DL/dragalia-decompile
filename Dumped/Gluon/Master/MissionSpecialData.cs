using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionSpecialData : IMaster<MissionSpecialData>
	{
		[SerializeField]
		private MissionSpecialDataDictionary dict;

		public MissionSpecialDataDictionary Dict => null;

		public SerializableDictionary<int, MissionSpecialDataElement>.ValueCollection List => null;
	}
}
