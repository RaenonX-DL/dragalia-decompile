using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickThunderbolt : IMaster<GimmickThunderbolt>
	{
		[SerializeField]
		private GimmickThunderboltDictionary dict;

		public GimmickThunderboltDictionary Dict => null;

		public SerializableDictionary<string, GimmickThunderboltElement>.ValueCollection List => null;
	}
}
