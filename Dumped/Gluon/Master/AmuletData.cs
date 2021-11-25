using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AmuletData : IMaster<AmuletData>
	{
		[SerializeField]
		private AmuletDataDictionary dict;

		public AmuletDataDictionary Dict => null;

		public SerializableDictionary<int, AmuletDataElement>.ValueCollection List => null;
	}
}
