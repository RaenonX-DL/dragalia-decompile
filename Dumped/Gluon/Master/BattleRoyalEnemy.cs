using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalEnemy : IMaster<BattleRoyalEnemy>
	{
		[SerializeField]
		private BattleRoyalEnemyDictionary dict;

		public BattleRoyalEnemyDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalEnemyElement>.ValueCollection List => null;
	}
}
