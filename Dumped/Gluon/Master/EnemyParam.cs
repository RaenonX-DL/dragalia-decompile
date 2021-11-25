using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyParam : IMaster<EnemyParam>
	{
		[SerializeField]
		private EnemyParamDictionary dict;

		public EnemyParamDictionary Dict => null;

		public SerializableDictionary<int, EnemyParamElement>.ValueCollection List => null;
	}
}
