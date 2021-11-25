using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ExchangeTicket : IMaster<ExchangeTicket>
	{
		[SerializeField]
		private ExchangeTicketDictionary dict;

		public ExchangeTicketDictionary Dict => null;

		public SerializableDictionary<int, ExchangeTicketElement>.ValueCollection List => null;
	}
}
