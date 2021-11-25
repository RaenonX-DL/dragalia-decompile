using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestWallDetail : IMaster<QuestWallDetail>
	{
		[SerializeField]
		private QuestWallDetailDictionary dict;

		public QuestWallDetailDictionary Dict => null;

		public SerializableDictionary<int, QuestWallDetailElement>.ValueCollection List => null;
	}
}
