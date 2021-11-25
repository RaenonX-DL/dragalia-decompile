using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TreasureTradeGroup : IMaster<TreasureTradeGroup>
	{
		[SerializeField]
		private TreasureTradeGroupDictionary dict;

		public TreasureTradeGroupDictionary Dict => null;

		public SerializableDictionary<int, TreasureTradeGroupElement>.ValueCollection List => null;
	}
}
