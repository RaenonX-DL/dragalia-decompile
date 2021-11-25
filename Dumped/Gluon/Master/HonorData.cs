using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class HonorData : IMaster<HonorData>
	{
		[SerializeField]
		private HonorDataDictionary dict;

		public HonorDataDictionary Dict => null;

		public SerializableDictionary<int, HonorDataElement>.ValueCollection List => null;
	}
}
