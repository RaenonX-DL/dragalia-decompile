using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestCarryTarget : IMaster<QuestCarryTarget>
	{
		[SerializeField]
		private QuestCarryTargetDictionary dict;

		public QuestCarryTargetDictionary Dict => null;

		public SerializableDictionary<int, QuestCarryTargetElement>.ValueCollection List => null;
	}
}
