using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class LotteryTicketDictionary : SerializableDictionary<int, LotteryTicketElement>
	{
	}
}
