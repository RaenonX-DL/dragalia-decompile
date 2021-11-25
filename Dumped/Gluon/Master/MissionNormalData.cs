using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionNormalData : IMaster<MissionNormalData>
	{
		[SerializeField]
		private MissionNormalDataDictionary dict;

		public MissionNormalDataDictionary Dict => null;

		public SerializableDictionary<int, MissionNormalDataElement>.ValueCollection List => null;
	}
}
