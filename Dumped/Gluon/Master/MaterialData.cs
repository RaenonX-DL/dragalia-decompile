using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MaterialData : IMaster<MaterialData>
	{
		[SerializeField]
		private MaterialDataDictionary dict;

		public MaterialDataDictionary Dict => null;

		public SerializableDictionary<int, MaterialDataElement>.ValueCollection List => null;
	}
}
