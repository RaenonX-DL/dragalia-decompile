using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BoxSummonData : IMaster<BoxSummonData>
	{
		[SerializeField]
		private BoxSummonDataDictionary dict;

		public BoxSummonDataDictionary Dict => null;

		public SerializableDictionary<int, BoxSummonDataElement>.ValueCollection List => null;
	}
}
