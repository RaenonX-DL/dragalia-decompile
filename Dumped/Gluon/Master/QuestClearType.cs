using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestClearType : IMaster<QuestClearType>
	{
		[SerializeField]
		private QuestClearTypeDictionary dict;

		public QuestClearTypeDictionary Dict => null;

		public SerializableDictionary<int, QuestClearTypeElement>.ValueCollection List => null;
	}
}
