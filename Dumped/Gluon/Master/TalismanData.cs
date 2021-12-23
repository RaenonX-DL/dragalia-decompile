using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TalismanData : IMaster<TalismanData>
	{
		[SerializeField]
		private TalismanDataDictionary dict;

		public TalismanDataDictionary Dict => null;

		public SerializableDictionary<int, TalismanDataElement>.ValueCollection List => null;
	}
}
