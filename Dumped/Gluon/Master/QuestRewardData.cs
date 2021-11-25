using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestRewardData : IMaster<QuestRewardData>
	{
		[SerializeField]
		private QuestRewardDataDictionary dict;

		public QuestRewardDataDictionary Dict => null;

		public SerializableDictionary<int, QuestRewardDataElement>.ValueCollection List => null;
	}
}
