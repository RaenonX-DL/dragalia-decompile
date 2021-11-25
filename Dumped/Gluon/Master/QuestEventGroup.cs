using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestEventGroup : IMaster<QuestEventGroup>
	{
		[SerializeField]
		private QuestEventGroupDictionary dict;

		public QuestEventGroupDictionary Dict => null;

		public SerializableDictionary<int, QuestEventGroupElement>.ValueCollection List => null;
	}
}
