using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventRewardDictionary : SerializableDictionary<int, RaidEventRewardElement>
	{
	}
}
