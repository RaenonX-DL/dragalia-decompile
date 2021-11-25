using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MyPageBanner : IMaster<MyPageBanner>
	{
		[SerializeField]
		private MyPageBannerDictionary dict;

		public MyPageBannerDictionary Dict => null;

		public SerializableDictionary<int, MyPageBannerElement>.ValueCollection List => null;
	}
}
