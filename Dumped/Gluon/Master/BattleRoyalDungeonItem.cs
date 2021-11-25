using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalDungeonItem : IMaster<BattleRoyalDungeonItem>
	{
		[SerializeField]
		private BattleRoyalDungeonItemDictionary dict;

		public BattleRoyalDungeonItemDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalDungeonItemElement>.ValueCollection List => null;
	}
}
