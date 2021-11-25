using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickDurablePillar : IMaster<GimmickDurablePillar>
	{
		[SerializeField]
		private GimmickDurablePillarDictionary dict;

		public GimmickDurablePillarDictionary Dict => null;

		public SerializableDictionary<string, GimmickDurablePillarElement>.ValueCollection List => null;
	}
}
