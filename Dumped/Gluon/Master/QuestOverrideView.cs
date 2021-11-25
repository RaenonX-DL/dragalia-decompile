using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestOverrideView : IMaster<QuestOverrideView>
	{
		[SerializeField]
		private QuestOverrideViewDictionary dict;

		public QuestOverrideViewDictionary Dict => null;

		public SerializableDictionary<int, QuestOverrideViewElement>.ValueCollection List => null;
	}
}
