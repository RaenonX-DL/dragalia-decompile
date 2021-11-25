using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PriceChangeData : IMaster<PriceChangeData>
	{
		[SerializeField]
		private PriceChangeDataDictionary dict;

		public PriceChangeDataDictionary Dict => null;

		public SerializableDictionary<int, PriceChangeDataElement>.ValueCollection List => null;
	}
}
