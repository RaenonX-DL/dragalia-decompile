using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalUnit : IMaster<BattleRoyalUnit>
	{
		[SerializeField]
		private BattleRoyalUnitDictionary dict;

		public BattleRoyalUnitDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalUnitElement>.ValueCollection List => null;
	}
}
