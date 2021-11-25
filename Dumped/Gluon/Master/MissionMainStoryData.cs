using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionMainStoryData : IMaster<MissionMainStoryData>
	{
		[SerializeField]
		private MissionMainStoryDataDictionary dict;

		public MissionMainStoryDataDictionary Dict => null;

		public SerializableDictionary<int, MissionMainStoryDataElement>.ValueCollection List => null;
	}
}
