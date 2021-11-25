using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AreaGimmickData : IMaster<AreaGimmickData>
	{
		[SerializeField]
		private AreaGimmickDataDictionary dict;

		public AreaGimmickDataDictionary Dict => null;

		public SerializableDictionary<int, AreaGimmickDataElement>.ValueCollection List => null;
	}
}
