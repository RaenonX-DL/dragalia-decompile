using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventRewardGroupDictionary : SerializableDictionary<int, RaidEventReward>
	{
	}
}
