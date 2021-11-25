using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestStoryGroup : IMaster<QuestStoryGroup>
	{
		[SerializeField]
		private QuestStoryGroupDictionary dict;

		public QuestStoryGroupDictionary Dict => null;

		public SerializableDictionary<int, QuestStoryGroupElement>.ValueCollection List => null;
	}
}
