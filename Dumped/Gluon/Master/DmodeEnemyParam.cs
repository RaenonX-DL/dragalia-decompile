using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeEnemyParam : IMaster<DmodeEnemyParam>
	{
		[SerializeField]
		private DmodeEnemyParamDictionary dict;

		public DmodeEnemyParamDictionary Dict => null;

		public SerializableDictionary<int, DmodeEnemyParamElement>.ValueCollection List => null;
	}
}
