using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RankingTierReward : IMaster<RankingTierReward>
	{
		[SerializeField]
		private RankingTierRewardDictionary dict;

		public RankingTierRewardDictionary Dict => null;

		public SerializableDictionary<int, RankingTierRewardElement>.ValueCollection List => null;
	}
}
