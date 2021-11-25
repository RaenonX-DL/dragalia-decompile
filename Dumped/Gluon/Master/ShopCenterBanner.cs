using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ShopCenterBanner : IMaster<ShopCenterBanner>
	{
		[SerializeField]
		private ShopCenterBannerDictionary dict;

		public ShopCenterBannerDictionary Dict => null;

		public SerializableDictionary<int, ShopCenterBannerElement>.ValueCollection List => null;
	}
}
