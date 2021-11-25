using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestFailedType : IMaster<QuestFailedType>
	{
		[SerializeField]
		private QuestFailedTypeDictionary dict;

		public QuestFailedTypeDictionary Dict => null;

		public SerializableDictionary<int, QuestFailedTypeElement>.ValueCollection List => null;
	}
}
