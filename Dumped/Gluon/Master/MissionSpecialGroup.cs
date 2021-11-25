using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionSpecialGroup : IMaster<MissionSpecialGroup>
	{
		[SerializeField]
		private MissionSpecialGroupDictionary dict;

		public MissionSpecialGroupDictionary Dict => null;

		public SerializableDictionary<int, MissionSpecialGroupElement>.ValueCollection List => null;
	}
}
