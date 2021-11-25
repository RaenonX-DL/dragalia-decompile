using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyBoundaryAction : IMaster<EnemyBoundaryAction>
	{
		[SerializeField]
		private EnemyBoundaryActionDictionary dict;

		public EnemyBoundaryActionDictionary Dict => null;

		public SerializableDictionary<int, EnemyBoundaryActionElement>.ValueCollection List => null;
	}
}
