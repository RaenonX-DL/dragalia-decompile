using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortPayList : IMaster<FortPayList>
	{
		[SerializeField]
		private FortPayListDictionary dict;

		public FortPayListDictionary Dict => null;

		public SerializableDictionary<int, FortPayListElement>.ValueCollection List => null;
	}
}
