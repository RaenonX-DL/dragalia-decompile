using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestMainGroup : IMaster<QuestMainGroup>
	{
		[SerializeField]
		private QuestMainGroupDictionary dict;

		public QuestMainGroupDictionary Dict => null;

		public SerializableDictionary<int, QuestMainGroupElement>.ValueCollection List => null;
	}
}
