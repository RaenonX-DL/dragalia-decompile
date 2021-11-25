using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EmblemData : IMaster<EmblemData>
	{
		[SerializeField]
		private EmblemDataDictionary dict;

		public EmblemDataDictionary Dict => null;

		public SerializableDictionary<int, EmblemDataElement>.ValueCollection List => null;
	}
}
