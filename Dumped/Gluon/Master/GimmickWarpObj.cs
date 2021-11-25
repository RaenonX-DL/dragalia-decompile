using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickWarpObj : IMaster<GimmickWarpObj>
	{
		[SerializeField]
		private GimmickWarpObjDictionary dict;

		public GimmickWarpObjDictionary Dict => null;

		public SerializableDictionary<string, GimmickWarpObjElement>.ValueCollection List => null;
	}
}
