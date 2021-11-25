using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyActionSet : IMaster<EnemyActionSet>
	{
		[SerializeField]
		private EnemyActionSetDictionary dict;

		public EnemyActionSetDictionary Dict => null;

		public SerializableDictionary<int, EnemyActionSetElement>.ValueCollection List => null;
	}
}
