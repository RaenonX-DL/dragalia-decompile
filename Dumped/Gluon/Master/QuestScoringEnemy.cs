using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestScoringEnemy : IMaster<QuestScoringEnemy>
	{
		[SerializeField]
		private QuestScoringEnemyDictionary dict;

		public QuestScoringEnemyDictionary Dict => null;

		public SerializableDictionary<int, QuestScoringEnemyElement>.ValueCollection List => null;
	}
}
