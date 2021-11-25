using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class QuestRewardDataDictionary : SerializableDictionary<int, QuestRewardDataElement>
	{
	}
}
