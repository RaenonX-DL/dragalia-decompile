using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ShopBanner : IMaster<ShopBanner>
	{
		[SerializeField]
		private ShopBannerDictionary dict;

		public ShopBannerDictionary Dict => null;

		public SerializableDictionary<int, ShopBannerElement>.ValueCollection List => null;
	}
}
