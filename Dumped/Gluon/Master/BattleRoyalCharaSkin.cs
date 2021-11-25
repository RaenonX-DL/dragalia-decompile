using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BattleRoyalCharaSkin : IMaster<BattleRoyalCharaSkin>
	{
		[SerializeField]
		private BattleRoyalCharaSkinDictionary dict;

		public BattleRoyalCharaSkinDictionary Dict => null;

		public SerializableDictionary<int, BattleRoyalCharaSkinElement>.ValueCollection List => null;
	}
}
