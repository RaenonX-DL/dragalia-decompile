using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyList : IMaster<EnemyList>
	{
		[SerializeField]
		private EnemyListDictionary dict;

		public EnemyListDictionary Dict => null;

		public SerializableDictionary<int, EnemyListElement>.ValueCollection List => null;
	}
}
