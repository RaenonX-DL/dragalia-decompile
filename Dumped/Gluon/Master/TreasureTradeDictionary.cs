using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class TreasureTradeDictionary : SerializableDictionary<int, TreasureTradeElement>
	{
	}
}
