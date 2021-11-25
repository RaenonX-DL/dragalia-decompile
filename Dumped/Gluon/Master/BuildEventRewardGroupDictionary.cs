using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventRewardGroupDictionary : SerializableDictionary<int, BuildEventReward>
	{
	}
}
