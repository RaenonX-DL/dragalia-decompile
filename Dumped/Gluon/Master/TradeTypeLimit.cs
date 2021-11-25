using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TradeTypeLimit : IMaster<TradeTypeLimit>
	{
		[SerializeField]
		private TradeTypeLimitDictionary dict;

		public TradeTypeLimitDictionary Dict => null;

		public SerializableDictionary<int, TradeTypeLimitElement>.ValueCollection List => null;
	}
}
