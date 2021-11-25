using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PlayerActionHitAttribute : IMaster<PlayerActionHitAttribute>
	{
		[SerializeField]
		private PlayerActionHitAttributeDictionary dict;

		public PlayerActionHitAttributeDictionary Dict => null;

		public SerializableDictionary<string, PlayerActionHitAttributeElement>.ValueCollection List => null;
	}
}
