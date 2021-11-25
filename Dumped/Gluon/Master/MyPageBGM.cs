using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MyPageBGM : IMaster<MyPageBGM>
	{
		[SerializeField]
		private MyPageBGMDictionary dict;

		public MyPageBGMDictionary Dict => null;

		public SerializableDictionary<int, MyPageBGMElement>.ValueCollection List => null;
	}
}
