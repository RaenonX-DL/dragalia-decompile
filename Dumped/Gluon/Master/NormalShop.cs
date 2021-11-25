using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class NormalShop : IMaster<NormalShop>
	{
		[SerializeField]
		private NormalShopDictionary dict;

		public NormalShopDictionary Dict => null;

		public SerializableDictionary<int, NormalShopElement>.ValueCollection List => null;
	}
}
