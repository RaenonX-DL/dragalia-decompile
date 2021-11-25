using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ShopHeaderBanner : IMaster<ShopHeaderBanner>
	{
		[SerializeField]
		private ShopHeaderBannerDictionary dict;

		public ShopHeaderBannerDictionary Dict => null;

		public SerializableDictionary<int, ShopHeaderBannerElement>.ValueCollection List => null;
	}
}
