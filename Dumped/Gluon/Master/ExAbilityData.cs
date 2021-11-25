using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ExAbilityData : IMaster<ExAbilityData>
	{
		[SerializeField]
		private ExAbilityDataDictionary dict;

		public ExAbilityDataDictionary Dict => null;

		public SerializableDictionary<int, ExAbilityDataElement>.ValueCollection List => null;
	}
}
