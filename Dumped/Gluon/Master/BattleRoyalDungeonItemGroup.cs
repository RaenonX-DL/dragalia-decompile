using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalDungeonItemGroup : IMaster<BattleRoyalDungeonItemGroup>
	{
		[SerializeField]
		private BattleRoyalDungeonItemGroupDictionary dict;

		public BattleRoyalDungeonItemGroupDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalDungeonItemGroupElement>.ValueCollection List => null;
	}
}
