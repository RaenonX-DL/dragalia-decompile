using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortEnums : IMaster<FortEnums>
	{
		[SerializeField]
		private FortEnumsDictionary dict;

		public FortEnumsDictionary Dict => null;

		public SerializableDictionary<int, FortEnumsElement>.ValueCollection List => null;
	}
}
