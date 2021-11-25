using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MyPageCenterBanner : IMaster<MyPageCenterBanner>
	{
		[SerializeField]
		private MyPageCenterBannerDictionary dict;

		public MyPageCenterBannerDictionary Dict => null;

		public SerializableDictionary<int, MyPageCenterBannerElement>.ValueCollection List => null;
	}
}
