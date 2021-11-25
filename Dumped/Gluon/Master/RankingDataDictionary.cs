using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class RankingDataDictionary : SerializableDictionary<int, RankingDataElement>
	{
	}
}
