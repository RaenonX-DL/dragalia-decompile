using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestData : IMaster<QuestData>
	{
		[SerializeField]
		private QuestDataDictionary dict;

		public QuestDataDictionary Dict => null;

		public SerializableDictionary<int, QuestDataElement>.ValueCollection List => null;
	}
}
