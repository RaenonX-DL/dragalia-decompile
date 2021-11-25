using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyLevelHit : IMaster<EnemyLevelHit>
	{
		[SerializeField]
		private EnemyLevelHitDictionary dict;

		public EnemyLevelHitDictionary Dict => null;

		public SerializableDictionary<int, EnemyLevelHitElement>.ValueCollection List => null;
	}
}
