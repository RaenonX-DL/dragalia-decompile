using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyHitDifficulty : IMaster<EnemyHitDifficulty>
	{
		[SerializeField]
		private EnemyHitDifficultyDictionary dict;

		public EnemyHitDifficultyDictionary Dict => null;

		public SerializableDictionary<string, EnemyHitDifficultyElement>.ValueCollection List => null;
	}
}
