using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AuraData : IMaster<AuraData>
	{
		[SerializeField]
		private AuraDataDictionary dict;

		public AuraDataDictionary Dict => null;

		public SerializableDictionary<int, AuraDataElement>.ValueCollection List => null;
	}
}
