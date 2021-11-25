using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionCompleteType : IMaster<MissionCompleteType>
	{
		[SerializeField]
		private MissionCompleteTypeDictionary dict;

		public MissionCompleteTypeDictionary Dict => null;

		public SerializableDictionary<int, MissionCompleteTypeElement>.ValueCollection List => null;
	}
}
