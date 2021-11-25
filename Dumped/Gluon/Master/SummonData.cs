using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SummonData : IMaster<SummonData>
	{
		[SerializeField]
		private SummonDataDictionary dict;

		public SummonDataDictionary Dict => null;

		public SerializableDictionary<int, SummonDataElement>.ValueCollection List => null;
	}
}
