using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CommonAction : IMaster<CommonAction>
	{
		[SerializeField]
		private CommonActionDictionary dict;

		public CommonActionDictionary Dict => null;

		public SerializableDictionary<int, CommonActionElement>.ValueCollection List => null;
	}
}
