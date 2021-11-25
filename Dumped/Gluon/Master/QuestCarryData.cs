using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestCarryData : IMaster<QuestCarryData>
	{
		[SerializeField]
		private QuestCarryDataDictionary dict;

		public QuestCarryDataDictionary Dict => null;

		public SerializableDictionary<int, QuestCarryDataElement>.ValueCollection List => null;
	}
}
