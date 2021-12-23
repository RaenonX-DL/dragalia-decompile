using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeAreaGimmickData : IMaster<DmodeAreaGimmickData>
	{
		[SerializeField]
		private DmodeAreaGimmickDataDictionary dict;

		public DmodeAreaGimmickDataDictionary Dict => null;

		public SerializableDictionary<int, DmodeAreaGimmickDataElement>.ValueCollection List => null;
	}
}
