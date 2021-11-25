using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestStory : IMaster<QuestStory>
	{
		[SerializeField]
		private QuestStoryDictionary dict;

		public QuestStoryDictionary Dict => null;

		public SerializableDictionary<int, QuestStoryElement>.ValueCollection List => null;
	}
}
