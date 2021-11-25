using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestMainLocation : IMaster<QuestMainLocation>
	{
		[SerializeField]
		private QuestMainLocationDictionary dict;

		public QuestMainLocationDictionary Dict => null;

		public SerializableDictionary<int, QuestMainLocationElement>.ValueCollection List => null;
	}
}
