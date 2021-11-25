using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalEventCycle : IMaster<BattleRoyalEventCycle>
	{
		[SerializeField]
		private BattleRoyalEventCycleDictionary dict;

		public BattleRoyalEventCycleDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalEventCycleElement>.ValueCollection List => null;
	}
}
