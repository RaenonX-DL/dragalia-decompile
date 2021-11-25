using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortAreaMap : IMaster<FortAreaMap>
	{
		[SerializeField]
		private FortAreaMapDictionary dict;

		public FortAreaMapDictionary Dict => null;

		public SerializableDictionary<int, FortAreaMapElement>.ValueCollection List => null;
	}
}
