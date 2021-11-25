using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventRewardDictionary : SerializableDictionary<int, BuildEventRewardElement>
	{
	}
}
