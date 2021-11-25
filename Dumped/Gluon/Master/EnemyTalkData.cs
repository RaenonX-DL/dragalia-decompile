using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyTalkData : IMaster<EnemyTalkData>
	{
		[SerializeField]
		private EnemyTalkDataDictionary dict;

		public EnemyTalkDataDictionary Dict => null;

		public SerializableDictionary<int, EnemyTalkDataElement>.ValueCollection List => null;
	}
}
