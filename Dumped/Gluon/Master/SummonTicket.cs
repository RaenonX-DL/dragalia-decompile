using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SummonTicket : IMaster<SummonTicket>
	{
		[SerializeField]
		private SummonTicketDictionary dict;

		public SummonTicketDictionary Dict => null;

		public SerializableDictionary<int, SummonTicketElement>.ValueCollection List => null;
	}
}
