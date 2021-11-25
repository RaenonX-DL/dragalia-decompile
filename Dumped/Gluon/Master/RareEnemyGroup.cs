using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RareEnemyGroup : IMaster<RareEnemyGroup>
	{
		[SerializeField]
		private RareEnemyGroupDictionary dict;

		public RareEnemyGroupDictionary Dict => null;

		public SerializableDictionary<int, RareEnemyGroupElement>.ValueCollection List => null;
	}
}
