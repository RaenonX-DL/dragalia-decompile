using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class QuestStoryDictionary : SerializableDictionary<int, QuestStoryElement>
	{
	}
}
