using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class StampData : IMaster<StampData>
	{
		[SerializeField]
		private StampDataDictionary dict;

		public StampDataDictionary Dict => null;

		public SerializableDictionary<int, StampDataElement>.ValueCollection List => null;
	}
}
