using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class RankingTierRewardDictionary : SerializableDictionary<int, RankingTierRewardElement>
	{
	}
}
