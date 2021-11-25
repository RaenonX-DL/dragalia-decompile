using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class EnemyRouteMode : IMaster<EnemyRouteMode>
	{
		[SerializeField]
		private EnemyRouteModeDictionary dict;

		public EnemyRouteModeDictionary Dict => null;

		public SerializableDictionary<int, EnemyRouteModeElement>.ValueCollection List => null;
	}
}
