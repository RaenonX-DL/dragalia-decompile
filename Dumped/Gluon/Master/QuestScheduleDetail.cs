using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestScheduleDetail : IMaster<QuestScheduleDetail>
	{
		[SerializeField]
		private QuestScheduleDetailDictionary dict;

		public QuestScheduleDetailDictionary Dict => null;

		public SerializableDictionary<int, QuestScheduleDetailElement>.ValueCollection List => null;
	}
}
