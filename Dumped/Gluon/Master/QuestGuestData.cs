using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestGuestData : IMaster<QuestGuestData>
	{
		[SerializeField]
		private QuestGuestDataDictionary dict;

		public QuestGuestDataDictionary Dict => null;

		public SerializableDictionary<int, QuestGuestDataElement>.ValueCollection List => null;
	}
}
