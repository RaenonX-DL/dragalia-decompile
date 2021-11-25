using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionBeginnerData : IMaster<MissionBeginnerData>
	{
		[SerializeField]
		private MissionBeginnerDataDictionary dict;

		public MissionBeginnerDataDictionary Dict => null;

		public SerializableDictionary<int, MissionBeginnerDataElement>.ValueCollection List => null;
	}
}
