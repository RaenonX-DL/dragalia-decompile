using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalEventItem : IMaster<BattleRoyalEventItem>
	{
		[SerializeField]
		private BattleRoyalEventItemDictionary dict;

		public BattleRoyalEventItemDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalEventItemElement>.ValueCollection List => null;
	}
}
