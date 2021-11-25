using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MyPageLimitedArea : IMaster<MyPageLimitedArea>
	{
		[SerializeField]
		private MyPageLimitedAreaDictionary dict;

		public MyPageLimitedAreaDictionary Dict => null;

		public SerializableDictionary<int, MyPageLimitedAreaElement>.ValueCollection List => null;
	}
}
