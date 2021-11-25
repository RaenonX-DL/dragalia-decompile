using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class ShopBannerDictionary : SerializableDictionary<int, ShopBannerElement>
	{
	}
}
