using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestMultipleSkip : IMaster<QuestMultipleSkip>
	{
		[SerializeField]
		private QuestMultipleSkipDictionary dict;

		public QuestMultipleSkipDictionary Dict => null;

		public SerializableDictionary<int, QuestMultipleSkipElement>.ValueCollection List => null;
	}
}
