using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TreasureTrade : IMaster<TreasureTrade>
	{
		[SerializeField]
		private TreasureTradeDictionary dict;

		public TreasureTradeDictionary Dict => null;

		public SerializableDictionary<int, TreasureTradeElement>.ValueCollection List => null;
	}
}
