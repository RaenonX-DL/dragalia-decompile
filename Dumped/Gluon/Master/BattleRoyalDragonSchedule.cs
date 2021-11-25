using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalDragonSchedule : IMaster<BattleRoyalDragonSchedule>
	{
		[SerializeField]
		private BattleRoyalDragonScheduleDictionary dict;

		public BattleRoyalDragonScheduleDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalDragonScheduleElement>.ValueCollection List => null;
	}
}
