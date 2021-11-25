using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyParamPattern : IMaster<EnemyParamPattern>
	{
		[SerializeField]
		private EnemyParamPatternDictionary dict;

		public EnemyParamPatternDictionary Dict => null;

		public SerializableDictionary<int, EnemyParamPatternElement>.ValueCollection List => null;
	}
}
