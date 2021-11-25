using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickBombObj : IMaster<GimmickBombObj>
	{
		[SerializeField]
		private GimmickBombObjDictionary dict;

		public GimmickBombObjDictionary Dict => null;

		public SerializableDictionary<string, GimmickBombObjElement>.ValueCollection List => null;
	}
}
