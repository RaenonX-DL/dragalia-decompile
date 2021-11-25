using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class StackBuffData : IMaster<StackBuffData>
	{
		[SerializeField]
		private StackBuffDataDictionary dict;

		public StackBuffDataDictionary Dict => null;

		public SerializableDictionary<int, StackBuffDataElement>.ValueCollection List => null;
	}
}
