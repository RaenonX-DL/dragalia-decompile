using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyData : IMaster<EnemyData>
	{
		[SerializeField]
		private EnemyDataDictionary dict;

		public EnemyDataDictionary Dict => null;

		public SerializableDictionary<int, EnemyDataElement>.ValueCollection List => null;
	}
}
