using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MyPageLimitedAreaGroup : IMaster<MyPageLimitedAreaGroup>
	{
		[SerializeField]
		private MyPageLimitedAreaGroupDictionary dict;

		public MyPageLimitedAreaGroupDictionary Dict => null;

		public SerializableDictionary<int, MyPageLimitedAreaGroupElement>.ValueCollection List => null;
	}
}
