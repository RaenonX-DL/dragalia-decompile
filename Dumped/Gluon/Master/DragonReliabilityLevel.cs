using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonReliabilityLevel : IMaster<DragonReliabilityLevel>
	{
		[SerializeField]
		private DragonReliabilityLevelDictionary dict;

		public DragonReliabilityLevelDictionary Dict => null;

		public SerializableDictionary<int, DragonReliabilityLevelElement>.ValueCollection List => null;
	}
}
