using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SpecialShop : IMaster<SpecialShop>
	{
		[SerializeField]
		private SpecialShopDictionary dict;

		public SpecialShopDictionary Dict => null;

		public SerializableDictionary<int, SpecialShopElement>.ValueCollection List => null;
	}
}
