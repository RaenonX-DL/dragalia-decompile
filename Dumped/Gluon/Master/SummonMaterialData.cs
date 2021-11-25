using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SummonMaterialData : IMaster<SummonMaterialData>
	{
		[SerializeField]
		private SummonMaterialDataDictionary dict;

		public SummonMaterialDataDictionary Dict => null;

		public SerializableDictionary<int, SummonMaterialDataElement>.ValueCollection List => null;
	}
}
