using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GameFlowSwitching : IMaster<GameFlowSwitching>
	{
		[SerializeField]
		private GameFlowSwitchingDictionary dict;

		public GameFlowSwitchingDictionary Dict => null;

		public SerializableDictionary<int, GameFlowSwitchingElement>.ValueCollection List => null;
	}
}
