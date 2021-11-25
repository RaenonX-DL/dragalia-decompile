using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalDungeonItemSet : IMaster<BattleRoyalDungeonItemSet>
	{
		[SerializeField]
		private BattleRoyalDungeonItemSetDictionary dict;

		public BattleRoyalDungeonItemSetDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalDungeonItemSetElement>.ValueCollection List => null;
	}
}
