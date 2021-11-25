using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestScoreMissionData : IMaster<QuestScoreMissionData>
	{
		[SerializeField]
		private QuestScoreMissionDataDictionary dict;

		public QuestScoreMissionDataDictionary Dict => null;

		public SerializableDictionary<int, QuestScoreMissionDataElement>.ValueCollection List => null;
	}
}
