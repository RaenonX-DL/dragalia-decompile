using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionMainStoryGroup : IMaster<MissionMainStoryGroup>
	{
		[SerializeField]
		private MissionMainStoryGroupDictionary dict;

		public MissionMainStoryGroupDictionary Dict => null;

		public SerializableDictionary<int, MissionMainStoryGroupElement>.ValueCollection List => null;
	}
}
