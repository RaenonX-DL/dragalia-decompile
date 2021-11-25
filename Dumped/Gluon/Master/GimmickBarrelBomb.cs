using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickBarrelBomb : IMaster<GimmickBarrelBomb>
	{
		[SerializeField]
		private GimmickBarrelBombDictionary dict;

		public GimmickBarrelBombDictionary Dict => null;

		public SerializableDictionary<string, GimmickBarrelBombElement>.ValueCollection List => null;
	}
}
