using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class PriceChangeDataDictionary : SerializableDictionary<int, PriceChangeDataElement>
	{
	}
}
