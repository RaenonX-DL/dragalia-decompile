using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickNeedleFloor : IMaster<GimmickNeedleFloor>
	{
		[SerializeField]
		private GimmickNeedleFloorDictionary dict;

		public GimmickNeedleFloorDictionary Dict => null;

		public SerializableDictionary<string, GimmickNeedleFloorElement>.ValueCollection List => null;
	}
}
