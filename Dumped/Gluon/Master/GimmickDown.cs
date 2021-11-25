using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickDown : IMaster<GimmickDown>
	{
		[SerializeField]
		private GimmickDownDictionary dict;

		public GimmickDownDictionary Dict => null;

		public SerializableDictionary<string, GimmickDownElement>.ValueCollection List => null;
	}
}
