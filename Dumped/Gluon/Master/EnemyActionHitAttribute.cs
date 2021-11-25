using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyActionHitAttribute : IMaster<EnemyActionHitAttribute>
	{
		[SerializeField]
		private EnemyActionHitAttributeDictionary dict;

		public EnemyActionHitAttributeDictionary Dict => null;

		public SerializableDictionary<string, EnemyActionHitAttributeElement>.ValueCollection List => null;
	}
}
