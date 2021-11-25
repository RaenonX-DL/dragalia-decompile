using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalCharaSkinPickup : IMaster<BattleRoyalCharaSkinPickup>
	{
		[SerializeField]
		private BattleRoyalCharaSkinPickupDictionary dict;

		public BattleRoyalCharaSkinPickupDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalCharaSkinPickupElement>.ValueCollection List => null;
	}
}
