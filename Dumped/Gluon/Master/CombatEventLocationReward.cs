using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CombatEventLocationReward : IMaster<CombatEventLocationReward>
	{
		[SerializeField]
		private CombatEventLocationRewardDictionary dict;

		public CombatEventLocationRewardDictionary Dict => null;

		public SerializableDictionary<int, CombatEventLocationRewardElement>.ValueCollection List => null;
	}
}
