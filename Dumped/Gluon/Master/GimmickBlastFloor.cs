using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickBlastFloor : IMaster<GimmickBlastFloor>
	{
		[SerializeField]
		private GimmickBlastFloorDictionary dict;

		public GimmickBlastFloorDictionary Dict => null;

		public SerializableDictionary<string, GimmickBlastFloorElement>.ValueCollection List => null;
	}
}
