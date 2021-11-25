using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SummonPointData : IMaster<SummonPointData>
	{
		[SerializeField]
		private SummonPointDataDictionary dict;

		public SummonPointDataDictionary Dict => null;

		public SerializableDictionary<int, SummonPointDataElement>.ValueCollection List => null;
	}
}
