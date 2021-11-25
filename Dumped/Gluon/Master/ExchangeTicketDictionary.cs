using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class ExchangeTicketDictionary : SerializableDictionary<int, ExchangeTicketElement>
	{
	}
}
