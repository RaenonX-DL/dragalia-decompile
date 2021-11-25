using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SummonGroup : IMaster<SummonGroup>
	{
		[SerializeField]
		private SummonGroupDictionary dict;

		public SummonGroupDictionary Dict => null;

		public SerializableDictionary<int, SummonGroupElement>.ValueCollection List => null;
	}
}
