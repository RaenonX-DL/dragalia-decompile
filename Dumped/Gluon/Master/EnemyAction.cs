using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyAction : IMaster<EnemyAction>
	{
		[SerializeField]
		private EnemyActionDictionary dict;

		public EnemyActionDictionary Dict => null;

		public SerializableDictionary<int, EnemyActionElement>.ValueCollection List => null;
	}
}
