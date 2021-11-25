using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageBannerDictionary : SerializableDictionary<int, MyPageBannerElement>
	{
	}
}
