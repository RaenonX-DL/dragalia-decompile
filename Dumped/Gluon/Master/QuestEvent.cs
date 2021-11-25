using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestEvent : IMaster<QuestEvent>
	{
		[SerializeField]
		private QuestEventDictionary dict;

		public QuestEventDictionary Dict => null;

		public SerializableDictionary<int, QuestEventElement>.ValueCollection List => null;
	}
}
