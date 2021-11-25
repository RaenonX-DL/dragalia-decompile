using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestTreasureData : IMaster<QuestTreasureData>
	{
		[SerializeField]
		private QuestTreasureDataDictionary dict;

		public QuestTreasureDataDictionary Dict => null;

		public SerializableDictionary<int, QuestTreasureDataElement>.ValueCollection List => null;
	}
}
