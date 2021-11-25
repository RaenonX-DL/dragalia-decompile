using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortField : IMaster<FortField>
	{
		[SerializeField]
		private FortFieldDictionary dict;

		public FortFieldDictionary Dict => null;

		public SerializableDictionary<int, FortFieldElement>.ValueCollection List => null;
	}
}
