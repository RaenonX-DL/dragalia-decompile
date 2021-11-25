using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbilityData : IMaster<AbilityData>
	{
		[SerializeField]
		private AbilityDataDictionary dict;

		public AbilityDataDictionary Dict => null;

		public SerializableDictionary<int, AbilityDataElement>.ValueCollection List => null;
	}
}
