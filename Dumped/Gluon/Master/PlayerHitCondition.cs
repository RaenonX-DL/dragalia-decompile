using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PlayerHitCondition : IMaster<PlayerHitCondition>
	{
		[SerializeField]
		private PlayerHitConditionDictionary dict;

		public PlayerHitConditionDictionary Dict => null;

		public SerializableDictionary<int, PlayerHitConditionElement>.ValueCollection List => null;
	}
}
