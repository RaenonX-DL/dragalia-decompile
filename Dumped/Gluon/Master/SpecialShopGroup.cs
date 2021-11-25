using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SpecialShopGroup : IMaster<SpecialShopGroup>
	{
		[SerializeField]
		private SpecialShopGroupDictionary dict;

		public SpecialShopGroupDictionary Dict => null;

		public SerializableDictionary<int, SpecialShopGroupElement>.ValueCollection List => null;
	}
}
