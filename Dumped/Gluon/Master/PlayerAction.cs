using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PlayerAction : IMaster<PlayerAction>
	{
		[SerializeField]
		private PlayerActionDictionary dict;

		public PlayerActionDictionary Dict => null;

		public SerializableDictionary<int, PlayerActionElement>.ValueCollection List => null;
	}
}
