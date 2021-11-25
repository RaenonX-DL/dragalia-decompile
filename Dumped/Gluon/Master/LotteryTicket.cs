using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LotteryTicket : IMaster<LotteryTicket>
	{
		[SerializeField]
		private LotteryTicketDictionary dict;

		public LotteryTicketDictionary Dict => null;

		public SerializableDictionary<int, LotteryTicketElement>.ValueCollection List => null;
	}
}
