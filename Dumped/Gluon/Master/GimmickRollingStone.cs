using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickRollingStone : IMaster<GimmickRollingStone>
	{
		[SerializeField]
		private GimmickRollingStoneDictionary dict;

		public GimmickRollingStoneDictionary Dict => null;

		public SerializableDictionary<string, GimmickRollingStoneElement>.ValueCollection List => null;
	}
}
