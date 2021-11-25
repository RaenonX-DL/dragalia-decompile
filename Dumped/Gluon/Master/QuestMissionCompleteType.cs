using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestMissionCompleteType : IMaster<QuestMissionCompleteType>
	{
		[SerializeField]
		private QuestMissionCompleteTypeDictionary dict;

		public QuestMissionCompleteTypeDictionary Dict => null;

		public SerializableDictionary<int, QuestMissionCompleteTypeElement>.ValueCollection List => null;
	}
}
