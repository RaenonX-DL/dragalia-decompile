using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestWall : IMaster<QuestWall>
	{
		[SerializeField]
		private QuestWallDictionary dict;

		public QuestWallDictionary Dict => null;

		public SerializableDictionary<int, QuestWallElement>.ValueCollection List => null;
	}
}
